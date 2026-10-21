using SamplePortalClient.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamplePortalClientUI
{

    public interface ICallDataWindow
    {
        void CallActivated(int lineNumber);

        void SetWindowPosition(int left, int top);

        void MoveToTopmost(bool toTopmost);


        void OnCallDisposed(int lineNumber);

        void OnGatewayDown();

        void OnPortalDown();

        void ShowCallData();

        void UpdateTitleBar(UpdateTitle model);

        void MinimizeWindow();

        void RestoreWindow();

       // CallDataControl GetAssociatedCallDataControl(int lineNumber);
    }
}
