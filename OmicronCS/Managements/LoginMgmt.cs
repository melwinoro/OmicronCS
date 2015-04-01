using System.Windows.Forms;

using OmicronCS_Constants;
using MetroFramework;

namespace OmicronCS_LoginMgmt
{
    public class LoginMgmt
    {
        public bool isLoginCredentialsValid(string username, string password)
        {
            return username.Equals(Constants.Username) && password.Equals(Constants.Password);
        }

        public void showLoginError(IWin32Window iWin32Window)
        {
            MetroMessageBox.Show(iWin32Window, "Incorrect username or password.",
                                               "Login Error",
                                               MessageBoxButtons.OK,
                                               MessageBoxIcon.Error,
                                               Constants.LoginMessageBoxHeight);
        }

        public void clearLoginTextBox(TextBox textBoxUsername, TextBox textBoxPassword)
        {
            textBoxUsername.Clear();
            textBoxPassword.Clear();
            textBoxUsername.Focus();
        }
    }
}