using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SamplePortalClient;
using SHDocVw;

namespace SamplePortalClientUI
{
    public partial class FChat : Form
    {
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SetWindowPos(IntPtr hwnd, IntPtr
        hWndInsertAfter, int x, int y, int cx, int cy, int wFlags);
        public IntPtr HWND_TOP = (IntPtr)(0);
        public IntPtr HWND_TOPMOST = (IntPtr)(-1);
        public IntPtr HWND_NOTOPMOST = (IntPtr)(-2);
        public int SWP_NOSIZE = 0x1;

        private SamplePortalClient.CApp mpApp;
        private SamplePortalClient.CCallChat mpCall;
        private SHDocVw.InternetExplorer mpBrowser;
        private String msLastURL = "about:blank";

        public FChat(CApp pApp, CCallChat pCall)
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            mpApp = pApp;
            mpCall = pCall;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                String sMessage = txtMessage.Text.Trim();
                if (sMessage.Length != 0)
                {
                    mpApp.SendChatMessage(mpCall, sMessage);
                    txtMessage.Text = "";
                    //Add the Text to the conversation textbox
                    txtConversation.Text = txtConversation.Text + "\r\n" + "You> " + sMessage;
                    txtConversation.SelectionStart = txtConversation.Text.Length;
                }

                String sURL = txtURL.Text.Trim();
                if (sURL.Length != 0)
                {
                    mpApp.SendChatURL(mpCall, sURL);
                    txtURL.Text = "";
                    LoadURL(sURL);
                }
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                mpApp.Hangup(mpCall);
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                LoadURL(msLastURL);
                SetWindowPos((IntPtr)mpBrowser.HWND, HWND_TOP, 0, 0, 0, 0, SWP_NOSIZE);
            }
            catch (Exception pError)
            {
                MessageBox.Show(pError.Message);
            }
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            //TODO
        }

        private void FChat_Load(object sender, EventArgs e)
        {
            try
            {
                mpApp.ChatEntityAdded += new ChatEntityHandler(this.CApp_ChatEntityAdded);
                mpApp.ChatEntityRemoved += new ChatEntityHandler(this.CApp_ChatEntityRemoved);
                mpApp.ChatMessage += new ChatMessageHandler(this.CApp_ChatMessage);
                mpApp.ChatURL += new ChatURLHandler(this.CApp_ChatURL);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        public void CApp_ChatEntityAdded(Object pSender, CChatEntityArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ChatEntityHandler(this.CApp_ChatEntityAdded), new object[] { pSender, pArgs });
                return;
            }

            try
            {
                //TODO: The server should send the callid associated with this event so we can 
                //determine whether or not the entity is for this chat call. For now, let's just
                //assume the entity is for this chat call.
                lstEntities.Items.Add(pArgs.EntityName);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        public void CApp_ChatEntityRemoved(Object pSender, CChatEntityArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ChatEntityHandler(this.CApp_ChatEntityRemoved), new object[] { pSender, pArgs });
                return;
            }

            try
            {
                //TODO: The server should send the callid associated with this event so we can 
                //determine whether or not the entity is for this chat call. For now, let's just
                //assume the entity is for this chat call.
                int index = lstEntities.FindStringExact(pArgs.EntityName);
                if (index != ListBox.NoMatches)
                    lstEntities.Items.RemoveAt(index);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        public void CApp_ChatMessage(Object pSender, CChatMessageArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ChatMessageHandler(this.CApp_ChatMessage), new object[] { pSender, pArgs });
                return;
            }

            //If this event is not for this chat call then ignore it.
            if (pArgs.CallId != mpCall.CallID)
                return;

            try
            {
                //Add the Text to the conversation textbox
                txtConversation.Text = txtConversation.Text + "\r\n" + ((pArgs.EntityType == ChatEntityType.ceAgent) ? "You" : pArgs.EntityName) + "> " + pArgs.Message;
                txtConversation.SelectionStart = txtConversation.Text.Length;
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        public void CApp_ChatURL(Object pSender, CChatURLArgs pArgs)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new ChatURLHandler(this.CApp_ChatURL), new object[] { pSender, pArgs });
                return;
            }

            //If this event is not for this chat call then ignore it.
            if (pArgs.CallId != mpCall.CallID)
                return;

            try
            {
                //Add the URL to the conversation textbox and invoke it on the browser
                //associated with this chat call.
                txtConversation.Text = txtConversation.Text + "\r\n" + "URL> " + pArgs.URL;
                txtConversation.SelectionStart = txtConversation.Text.Length;
                LoadURL(pArgs.URL);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        private void LoadURL(String sURL)
        {
            try
            {
                if (mpBrowser == null)
                {
                    mpBrowser = new SHDocVw.InternetExplorer();
                    mpBrowser.OnQuit += new DWebBrowserEvents2_OnQuitEventHandler(mpBrowser_OnQuit);
                }

                Object oEmpty = String.Empty;
                Object oURL = sURL;
                mpBrowser.Navigate2(ref oURL, ref oEmpty, ref oEmpty, ref oEmpty, ref oEmpty);
                
                if (!mpBrowser.Visible)
                    mpBrowser.Visible = true;
                   
                msLastURL = sURL;
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        void mpBrowser_OnQuit()
        {
            try
            {
                mpBrowser = null;
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        private void FChat_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (mpBrowser != null)
                {
                    mpBrowser.Quit();
                    mpBrowser = null;
                }
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }

        private void txtURL_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                txtURL.Text = (String)e.Data.GetData(DataFormats.StringFormat);
            }
            catch (Exception pError)
            {
                Console.WriteLine(pError.StackTrace);
            }
        }
    }
}