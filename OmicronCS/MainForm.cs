using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework;
using MetroFramework.Forms;
using MetroFramework.Controls;

using OmicronCS_Constants;
using OmicronCS_Enums;
using OmicronCS_Structures;

using OmicronCS_LoginMgmt;
 
namespace OmicronCS
{
    public partial class MainForm : MetroForm
    {

        public MainForm()
        {
            InitializeComponent();
            SetDefaultUiView();
        }

        private void SetDefaultUiView()
        {
            ui_ComboBoxViewData.SelectedIndex = (int) EComboBoxSelectedView.RecentlyAdded;
        }

        private void ui_BtnLoginSignIn_Click(object sender, System.EventArgs e)
        {
            handleBtnLoginSignInClick();
        }

        private void in_BtnLoginClear_Click(object sender, EventArgs e)
        {
            handleBtnLoginClearClick();
        }

        public void handleBtnLoginSignInClick()
        {
            string username = ui_TextBoxUsername.Text.ToString();
            string password = ui_TextBoxPassword.Text.ToString();

            LoginMgmt loginMgmt = new LoginMgmt();
            bool isLoginValid = loginMgmt.isLoginCredentialsValid(username, password);

            if (isLoginValid)
            {
                ui_PanelLogin.Dispose();
                ui_TabCtrlMain.Visible = true;
            }
            else
            {
                loginMgmt.showLoginError(this);
                loginMgmt.clearLoginTextBox(ui_TextBoxUsername, ui_TextBoxPassword);
            }
        }

        public void handleBtnLoginClearClick()
        {
            LoginMgmt loginMgmt = new LoginMgmt();
            loginMgmt.clearLoginTextBox(ui_TextBoxUsername, ui_TextBoxPassword);
        }
    }
}