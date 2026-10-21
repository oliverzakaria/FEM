using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static SamplePortalClient.CServices;

namespace SamplePortalClient.UI
{
    public partial class F3Way : Form
    {
        private CApp mpApp;
        
        private String msPhoneNumber="";
        private Object mpSelectedItem=null;
        
        public F3Way(CApp pApp)
        {
            InitializeComponent();

            mpApp = pApp;
        }

        private void F3Way_Load(object sender, EventArgs e)
        {
            Update3WayUI(mpApp.CurrentState);
            Update1stPartyUI(mpApp.CurrentCall.FirstPartyCall.CurrentState); 
            Update3rdPartyUI(((CCallVoice)mpApp.CurrentCall).ThirdPartyCall.CurrentState); 

            mpApp.StateChange += new StateChangeHandler(this.CApp_StateChange);
            mpApp.CallStateChange += new CallStateChangeHandler(this.CApp_CallStateChange);
            mpApp.CallActivated += new CallActivatedHandler(this.CApp_CallActivated);
        }

        public void CApp_CallActivated(Object pSender, CCallActivatedArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new CallActivatedHandler(this.CApp_CallActivated), new Object[] { pSender, pArgs });
                return;
            }

            this.Close();
        }

        private void Update1stPartyUI(CState pNewState)
        {
            //Update 1st Party controls
            btnHangup1stParty.Enabled = pNewState.EnableHangup;
            btnHold1stParty.Enabled = pNewState.EnableHold;
            btnHold1stParty.Text = (pNewState is CStateHeld) ? "Pickup" : "Hold";
            lblStatus1stParty.BackColor = pNewState.BackColor;
            lblStatus1stParty.Text = pNewState.Description;
        }

        private void Update3rdPartyUI(CState pNewState)
        {
            //Update 3rd Party controls
            btnHangup3rdParty.Enabled = pNewState.EnableHangup;
            btnHold3rdParty.Enabled = pNewState.EnableHold;
            btnHold3rdParty.Text = (pNewState is CStateHeld) ? "Pickup" : "Hold";
            lblStatus3rdParty.BackColor = pNewState.BackColor;
            lblStatus3rdParty.Text = pNewState.Description;
        }
        
        private void Update3WayUI(CState pNewState)
        {
            //Update 3way controls
            btnConsult.Enabled = pNewState.EnableConsult;
            btnConference.Enabled = pNewState.EnableConference;
            btnTransfer.Enabled = pNewState.EnableTransfer;
        }

        public void CApp_StateChange(Object pSender, CStateChangeArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new StateChangeHandler(this.CApp_StateChange), new Object[] { pSender, pArgs });
                return;
            }

            //This is the main thread. Update the UI.
            Update3WayUI(pArgs.NewState);
        }

        public void CApp_CallStateChange(Object pSender, CCallStateChangeArgs pArgs)
        {
            //Form updates can/should only be performed by the thread that created the form (in this case, the main thread).
            //If this is not the main thread then invoke this method on the main thread and return.
            if (this.InvokeRequired)
            {
                this.Invoke(new CallStateChangeHandler(this.CApp_CallStateChange), new Object[] { pSender, pArgs });
                return;
            }
            
            //This is the main thread. Update the UI.
            if (pArgs.Call is C3WayCall1stParty)
            {
                if (pArgs.Call.CurrentState is CStateInactive)
                    this.Close();
                else
                    Update1stPartyUI(pArgs.Call.CurrentState);
            }
            else if (pArgs.Call is C3WayCall3rdParty)
            {
                Update3rdPartyUI(pArgs.Call.CurrentState);
            }
            
        }

        private void btnHangup1stParty_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.Hangup(mpApp.CurrentCall);
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnHold1stParty_Click(object sender, EventArgs e)
        {
            try
            {
                C3WayCall pCall = mpApp.CurrentCall.FirstPartyCall;
                if (pCall.CurrentState is CStateHeld)
                    mpApp.ReleaseHold();
                else if (pCall.CurrentState is CStateActive)
                    mpApp.Hold();
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnHangup3rdParty_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.HangupConsultation();
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnHold3rdParty_Click(object sender, EventArgs e)
        {
            try
            {
                C3WayCall pCall = ((CCallVoice)mpApp.CurrentCall).ThirdPartyCall;
                if (pCall.CurrentState is CStateHeld)
                    mpApp.ReleaseHoldOnConsultation();
                else if (pCall.CurrentState is CStateActive)
                    mpApp.HoldConsultation();
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //If current call is Chat, load form in dmChatXfer mode; Otherwise, load in dm3rdParty mode.
            FDial oDialForm;
            if (mpApp.CurrentCall is CCallChat)
                oDialForm = new FDial(mpApp, DialMode.dmChatXfer);
            else
                oDialForm = new FDial(mpApp, DialMode.dm3rdParty);
            
            oDialForm.Text = "Specify the 3rd Party you wish to consult/transfer";
            oDialForm.ShowDialog();

            if (oDialForm.DialogResult != DialogResult.OK)
                return;

            //Save selection for subsequent 3way command (ie, consult or transfer) from user and display it
            mpSelectedItem = oDialForm.SelectedItem;
            msPhoneNumber = oDialForm.PhoneNumber.Trim();

            txt3rdParty.Text = "";

            //If PhoneNumber specified
            if (msPhoneNumber != "")
                txt3rdParty.Text = "PhoneNumber <" + msPhoneNumber + "> ";

            if (mpSelectedItem == null)
                return;

            //If selected item is an External Route
            if (mpSelectedItem is CExternalRoute)
                //Append to field in case it already contains PhoneNumber
                txt3rdParty.Text = txt3rdParty.Text + "ExternalRoute <" + ((CExternalRoute)mpSelectedItem).Id + ">";

            //If selection is a User
            else if (mpSelectedItem is CUser)
                txt3rdParty.Text = "User <" + ((CUser)mpSelectedItem).Id + ">"; 
            
            //If selection is a Service
            else if (mpSelectedItem is CSimpleService)
                txt3rdParty.Text = "Service <" + ((CSimpleService)mpSelectedItem).ServiceName + ">"; 
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            //If no item selected and no phone specified, display error
            if (msPhoneNumber == "" && mpSelectedItem == null)
            {
                MessageBox.Show("You must select a 3rd party for the consultation/transfer.");
                return;
            }

            try
            {
                //If phone specified, consult the specified number
                if (msPhoneNumber != "")
                    if (mpSelectedItem is CExternalRoute)
                        mpApp.Consult(msPhoneNumber, (CExternalRoute)mpSelectedItem);
                    else
                        mpApp.Consult(msPhoneNumber);

                //Otherwise, consult the specified entity (user or service)
                else if (mpSelectedItem is CUser)
                    mpApp.Consult((CUser)mpSelectedItem);
                
                else if (mpSelectedItem is CSimpleService)
                    mpApp.Consult((CSimpleService)mpSelectedItem);
                
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            try
            {
                //If Consulting or Conferenced, transfer the call to the consulted party
                if (mpApp.CurrentState is CStateConsulting || mpApp.CurrentState is CStateConference)
                    mpApp.Transfer();
                
                //Otherwise, transfer the call to the specified phoneNumber or selected entity
                else
                {
                    //If no item selected and no phone specified, display error
                    if (msPhoneNumber == "" && mpSelectedItem == null)
                    {
                        MessageBox.Show("You must select a 3rd party for the consultation/transfer.");
                        return;
                    }

                    //If phone specified, transfer to the specified number
                    if (msPhoneNumber != "")
                        if (mpSelectedItem is CExternalRoute)
                            mpApp.Transfer(msPhoneNumber, (CExternalRoute)mpSelectedItem);
                        else
                            mpApp.Transfer(msPhoneNumber);
                        
                    //Otherwise, transfer to the specified entity (user or service)
                    else if (mpSelectedItem is CUser)
                        mpApp.Transfer((CUser)mpSelectedItem);

                    else if (mpSelectedItem is CSimpleService)
                        mpApp.Transfer((CSimpleService)mpSelectedItem);

                }
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnConference_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.Conference();
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }


    }
}