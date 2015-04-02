namespace OmicronCS
{
    partial class LogInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInForm));
            this.ui_Icon = new System.Windows.Forms.PictureBox();
            this.ui_TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ui_TextBoxUsername = new System.Windows.Forms.TextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.ui_ProgSpinLogIn = new MetroFramework.Controls.MetroProgressSpinner();
            this.ui_LabelLogin = new MetroFramework.Controls.MetroLabel();
            this.ui_LabelLoginPassword = new MetroFramework.Controls.MetroLabel();
            this.ui_LabelLoginUsername = new MetroFramework.Controls.MetroLabel();
            this.ui_BtnLogin = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ui_BgWorkerLogIn = new System.ComponentModel.BackgroundWorker();
            this.ui_BtnClear = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.ui_Icon)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_Icon
            // 
            this.ui_Icon.Image = ((System.Drawing.Image)(resources.GetObject("ui_Icon.Image")));
            this.ui_Icon.Location = new System.Drawing.Point(9, 14);
            this.ui_Icon.Name = "ui_Icon";
            this.ui_Icon.Size = new System.Drawing.Size(256, 79);
            this.ui_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ui_Icon.TabIndex = 1;
            this.ui_Icon.TabStop = false;
            // 
            // ui_TextBoxPassword
            // 
            this.ui_TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ui_TextBoxPassword.Location = new System.Drawing.Point(150, 101);
            this.ui_TextBoxPassword.Name = "ui_TextBoxPassword";
            this.ui_TextBoxPassword.Size = new System.Drawing.Size(232, 22);
            this.ui_TextBoxPassword.TabIndex = 1;
            this.ui_TextBoxPassword.Text = "omicroncs";
            // 
            // ui_TextBoxUsername
            // 
            this.ui_TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ui_TextBoxUsername.Location = new System.Drawing.Point(150, 64);
            this.ui_TextBoxUsername.Name = "ui_TextBoxUsername";
            this.ui_TextBoxUsername.Size = new System.Drawing.Size(232, 22);
            this.ui_TextBoxUsername.TabIndex = 0;
            this.ui_TextBoxUsername.Text = "omicroncs";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.metroPanel1.Controls.Add(this.ui_BtnClear);
            this.metroPanel1.Controls.Add(this.ui_ProgSpinLogIn);
            this.metroPanel1.Controls.Add(this.ui_LabelLogin);
            this.metroPanel1.Controls.Add(this.ui_LabelLoginPassword);
            this.metroPanel1.Controls.Add(this.ui_LabelLoginUsername);
            this.metroPanel1.Controls.Add(this.ui_BtnLogin);
            this.metroPanel1.Controls.Add(this.ui_TextBoxPassword);
            this.metroPanel1.Controls.Add(this.ui_TextBoxUsername);
            this.metroPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 281);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(450, 180);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // ui_ProgSpinLogIn
            // 
            this.ui_ProgSpinLogIn.Location = new System.Drawing.Point(163, 28);
            this.ui_ProgSpinLogIn.Maximum = 100;
            this.ui_ProgSpinLogIn.Name = "ui_ProgSpinLogIn";
            this.ui_ProgSpinLogIn.Size = new System.Drawing.Size(20, 20);
            this.ui_ProgSpinLogIn.Style = MetroFramework.MetroColorStyle.White;
            this.ui_ProgSpinLogIn.TabIndex = 8;
            this.ui_ProgSpinLogIn.UseCustomBackColor = true;
            this.ui_ProgSpinLogIn.UseCustomForeColor = true;
            this.ui_ProgSpinLogIn.UseSelectable = true;
            this.ui_ProgSpinLogIn.UseStyleColors = true;
            this.ui_ProgSpinLogIn.Visible = false;
            // 
            // ui_LabelLogin
            // 
            this.ui_LabelLogin.AutoSize = true;
            this.ui_LabelLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ui_LabelLogin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_LabelLogin.ForeColor = System.Drawing.Color.White;
            this.ui_LabelLogin.Location = new System.Drawing.Point(13, 24);
            this.ui_LabelLogin.Name = "ui_LabelLogin";
            this.ui_LabelLogin.Size = new System.Drawing.Size(148, 25);
            this.ui_LabelLogin.Style = MetroFramework.MetroColorStyle.White;
            this.ui_LabelLogin.TabIndex = 6;
            this.ui_LabelLogin.Text = "Login Credentials";
            this.ui_LabelLogin.UseCustomBackColor = true;
            this.ui_LabelLogin.UseCustomForeColor = true;
            this.ui_LabelLogin.UseStyleColors = true;
            // 
            // ui_LabelLoginPassword
            // 
            this.ui_LabelLoginPassword.AutoSize = true;
            this.ui_LabelLoginPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_LabelLoginPassword.ForeColor = System.Drawing.Color.White;
            this.ui_LabelLoginPassword.Location = new System.Drawing.Point(63, 101);
            this.ui_LabelLoginPassword.Name = "ui_LabelLoginPassword";
            this.ui_LabelLoginPassword.Size = new System.Drawing.Size(67, 19);
            this.ui_LabelLoginPassword.Style = MetroFramework.MetroColorStyle.White;
            this.ui_LabelLoginPassword.TabIndex = 6;
            this.ui_LabelLoginPassword.Text = "Password";
            this.ui_LabelLoginPassword.UseCustomBackColor = true;
            this.ui_LabelLoginPassword.UseCustomForeColor = true;
            this.ui_LabelLoginPassword.UseStyleColors = true;
            // 
            // ui_LabelLoginUsername
            // 
            this.ui_LabelLoginUsername.AutoSize = true;
            this.ui_LabelLoginUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_LabelLoginUsername.ForeColor = System.Drawing.Color.White;
            this.ui_LabelLoginUsername.Location = new System.Drawing.Point(63, 64);
            this.ui_LabelLoginUsername.Name = "ui_LabelLoginUsername";
            this.ui_LabelLoginUsername.Size = new System.Drawing.Size(71, 19);
            this.ui_LabelLoginUsername.Style = MetroFramework.MetroColorStyle.White;
            this.ui_LabelLoginUsername.TabIndex = 7;
            this.ui_LabelLoginUsername.Text = "Username";
            this.ui_LabelLoginUsername.UseCustomBackColor = true;
            this.ui_LabelLoginUsername.UseCustomForeColor = true;
            this.ui_LabelLoginUsername.UseStyleColors = true;
            // 
            // ui_BtnLogin
            // 
            this.ui_BtnLogin.BackColor = System.Drawing.Color.White;
            this.ui_BtnLogin.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ui_BtnLogin.Location = new System.Drawing.Point(256, 133);
            this.ui_BtnLogin.Name = "ui_BtnLogin";
            this.ui_BtnLogin.Size = new System.Drawing.Size(60, 30);
            this.ui_BtnLogin.TabIndex = 2;
            this.ui_BtnLogin.Text = "Login";
            this.ui_BtnLogin.UseCustomBackColor = true;
            this.ui_BtnLogin.UseCustomForeColor = true;
            this.ui_BtnLogin.UseSelectable = true;
            this.ui_BtnLogin.Click += new System.EventHandler(this.ui_BtnLogin_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(93, 561);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(271, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Copyright @ Omicron Credit Solutions, 2015";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel1.Location = new System.Drawing.Point(0, 281);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(450, 5);
            this.panel1.TabIndex = 7;
            // 
            // ui_BgWorkerLogIn
            // 
            this.ui_BgWorkerLogIn.WorkerReportsProgress = true;
            this.ui_BgWorkerLogIn.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ui_BgWorkerLogIn_DoWork);
            this.ui_BgWorkerLogIn.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.ui_BgWorkerLogIn_ProgressChanged);
            this.ui_BgWorkerLogIn.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ui_BgWorkerLogIn_RunWorkerCompleted);
            // 
            // ui_BtnClear
            // 
            this.ui_BtnClear.BackColor = System.Drawing.Color.White;
            this.ui_BtnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ui_BtnClear.Location = new System.Drawing.Point(322, 133);
            this.ui_BtnClear.Name = "ui_BtnClear";
            this.ui_BtnClear.Size = new System.Drawing.Size(60, 30);
            this.ui_BtnClear.TabIndex = 8;
            this.ui_BtnClear.Text = "Clear";
            this.ui_BtnClear.UseCustomBackColor = true;
            this.ui_BtnClear.UseCustomForeColor = true;
            this.ui_BtnClear.UseSelectable = true;
            this.ui_BtnClear.Click += new System.EventHandler(this.in_BtnClear_Click);
            // 
            // LogInForm
            // 
            this.AcceptButton = this.ui_BtnLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.ui_Icon);
            this.MaximizeBox = false;
            this.Name = "LogInForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.ui_Icon)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ui_Icon;
        private System.Windows.Forms.TextBox ui_TextBoxPassword;
        private System.Windows.Forms.TextBox ui_TextBoxUsername;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ui_BtnLogin;
        private MetroFramework.Controls.MetroLabel ui_LabelLoginPassword;
        private MetroFramework.Controls.MetroLabel ui_LabelLoginUsername;
        private MetroFramework.Controls.MetroLabel ui_LabelLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroProgressSpinner ui_ProgSpinLogIn;
        private System.ComponentModel.BackgroundWorker ui_BgWorkerLogIn;
        private MetroFramework.Controls.MetroButton ui_BtnClear;
    }
}