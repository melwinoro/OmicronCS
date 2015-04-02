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
using OmicronCS_LoginMgmt;

namespace OmicronCS
{
    public partial class LogInForm : MetroForm
    {

        public LogInForm()
        {
            InitializeComponent();
        }

        private void ui_BtnLogin_Click(object sender, EventArgs e)
        {
            handleBtnLoginClick();
        }

        private void in_BtnClear_Click(object sender, EventArgs e)
        {
            handleBtnClearClick();
        }

        public void handleBtnLoginClick()
        {
            delayLogin();
        }

        public void handleBtnClearClick()
        {
            LoginMgmt loginMgmt = new LoginMgmt();
            loginMgmt.clearLoginTextBox(ui_TextBoxUsername, ui_TextBoxPassword);
        }

        public void delayLogin()
        {
            ui_BtnLogin.Enabled = false;
            ui_BtnClear.Enabled = false;

            ui_ProgSpinLogIn.Visible = true;

            ui_BgWorkerLogIn.RunWorkerAsync();
        }

        public void continueLogin()
        {
            string username = ui_TextBoxUsername.Text.ToString();
            string password = ui_TextBoxPassword.Text.ToString();

            LoginMgmt loginMgmt = new LoginMgmt();
            bool isLoginValid = loginMgmt.isLoginCredentialsValid(username, password);

            if (isLoginValid)
            {
            }
            else
            {
                loginMgmt.showLoginError(this);
                loginMgmt.clearLoginTextBox(ui_TextBoxUsername, ui_TextBoxPassword);
            }
        }

        private void ui_BgWorkerLogIn_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 1; i <= ui_ProgSpinLogIn.Maximum; i++)
            {
                System.Threading.Thread.Sleep(Constants.SleepDuration);
                ui_BgWorkerLogIn.ReportProgress(i);
            }
        }

        private void ui_BgWorkerLogIn_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            ui_ProgSpinLogIn.Value = e.ProgressPercentage;
        }

        private void ui_BgWorkerLogIn_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ui_BtnLogin.Enabled = true;
            ui_BtnClear.Enabled = true;

            ui_ProgSpinLogIn.Value = ui_ProgSpinLogIn.Minimum;
            ui_ProgSpinLogIn.Visible = false;

            continueLogin();
        }
    }
}