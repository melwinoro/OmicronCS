namespace OmicronCS
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ui_Icon = new System.Windows.Forms.PictureBox();
            this.ui_PanelLogin = new MetroFramework.Controls.MetroPanel();
            this.ui_LabelLogin = new MetroFramework.Controls.MetroLabel();
            this.in_BtnLoginClear = new MetroFramework.Controls.MetroButton();
            this.ui_BtnLoginSignIn = new MetroFramework.Controls.MetroButton();
            this.ui_LabelLoginPassword = new MetroFramework.Controls.MetroLabel();
            this.ui_LabelLoginUsername = new MetroFramework.Controls.MetroLabel();
            this.ui_TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ui_TextBoxUsername = new System.Windows.Forms.TextBox();
            this.ui_TabCtrlMain = new MetroFramework.Controls.MetroTabControl();
            this.ui_TabHome = new MetroFramework.Controls.MetroTabPage();
            this.ui_BtnEditEntry = new MetroFramework.Controls.MetroButton();
            this.ui_BtnDeleteEntry = new MetroFramework.Controls.MetroButton();
            this.ui_BtnAddEntry = new MetroFramework.Controls.MetroButton();
            this.ui_BtnExportData = new MetroFramework.Controls.MetroButton();
            this.ui_BtnImportData = new MetroFramework.Controls.MetroButton();
            this.ui_ComboBoxViewData = new MetroFramework.Controls.MetroComboBox();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ui_GridLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridMiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridEducation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridIndustry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GiridTenure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_GridStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_TabCutOff = new MetroFramework.Controls.MetroTabPage();
            this.ui_TabView = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ui_Icon)).BeginInit();
            this.ui_PanelLogin.SuspendLayout();
            this.ui_TabCtrlMain.SuspendLayout();
            this.ui_TabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // ui_Icon
            // 
            this.ui_Icon.Image = ((System.Drawing.Image)(resources.GetObject("ui_Icon.Image")));
            this.ui_Icon.Location = new System.Drawing.Point(30, 35);
            this.ui_Icon.Name = "ui_Icon";
            this.ui_Icon.Size = new System.Drawing.Size(256, 79);
            this.ui_Icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ui_Icon.TabIndex = 0;
            this.ui_Icon.TabStop = false;
            // 
            // ui_PanelLogin
            // 
            this.ui_PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(176)))), ((int)(((byte)(214)))));
            this.ui_PanelLogin.Controls.Add(this.ui_LabelLogin);
            this.ui_PanelLogin.Controls.Add(this.in_BtnLoginClear);
            this.ui_PanelLogin.Controls.Add(this.ui_BtnLoginSignIn);
            this.ui_PanelLogin.Controls.Add(this.ui_LabelLoginPassword);
            this.ui_PanelLogin.Controls.Add(this.ui_LabelLoginUsername);
            this.ui_PanelLogin.Controls.Add(this.ui_TextBoxPassword);
            this.ui_PanelLogin.Controls.Add(this.ui_TextBoxUsername);
            this.ui_PanelLogin.HorizontalScrollbarBarColor = false;
            this.ui_PanelLogin.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_PanelLogin.HorizontalScrollbarSize = 10;
            this.ui_PanelLogin.Location = new System.Drawing.Point(0, 327);
            this.ui_PanelLogin.Name = "ui_PanelLogin";
            this.ui_PanelLogin.Size = new System.Drawing.Size(1024, 292);
            this.ui_PanelLogin.TabIndex = 1;
            this.ui_PanelLogin.UseCustomBackColor = true;
            this.ui_PanelLogin.VerticalScrollbarBarColor = false;
            this.ui_PanelLogin.VerticalScrollbarHighlightOnWheel = false;
            this.ui_PanelLogin.VerticalScrollbarSize = 10;
            // 
            // ui_LabelLogin
            // 
            this.ui_LabelLogin.AutoSize = true;
            this.ui_LabelLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ui_LabelLogin.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_LabelLogin.ForeColor = System.Drawing.Color.White;
            this.ui_LabelLogin.Location = new System.Drawing.Point(189, 104);
            this.ui_LabelLogin.Name = "ui_LabelLogin";
            this.ui_LabelLogin.Size = new System.Drawing.Size(64, 25);
            this.ui_LabelLogin.Style = MetroFramework.MetroColorStyle.White;
            this.ui_LabelLogin.TabIndex = 0;
            this.ui_LabelLogin.Text = "LOGIN";
            this.ui_LabelLogin.UseCustomBackColor = true;
            this.ui_LabelLogin.UseCustomForeColor = true;
            this.ui_LabelLogin.UseStyleColors = true;
            // 
            // in_BtnLoginClear
            // 
            this.in_BtnLoginClear.BackColor = System.Drawing.Color.White;
            this.in_BtnLoginClear.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.in_BtnLoginClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.in_BtnLoginClear.Highlight = true;
            this.in_BtnLoginClear.Location = new System.Drawing.Point(680, 240);
            this.in_BtnLoginClear.Name = "in_BtnLoginClear";
            this.in_BtnLoginClear.Size = new System.Drawing.Size(93, 29);
            this.in_BtnLoginClear.TabIndex = 4;
            this.in_BtnLoginClear.Text = "Clear";
            this.in_BtnLoginClear.Theme = MetroFramework.MetroThemeStyle.Light;
            this.in_BtnLoginClear.UseSelectable = true;
            this.in_BtnLoginClear.UseStyleColors = true;
            // 
            // ui_BtnLoginSignIn
            // 
            this.ui_BtnLoginSignIn.BackColor = System.Drawing.Color.White;
            this.ui_BtnLoginSignIn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ui_BtnLoginSignIn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnLoginSignIn.Highlight = true;
            this.ui_BtnLoginSignIn.Location = new System.Drawing.Point(578, 240);
            this.ui_BtnLoginSignIn.Name = "ui_BtnLoginSignIn";
            this.ui_BtnLoginSignIn.Size = new System.Drawing.Size(93, 29);
            this.ui_BtnLoginSignIn.TabIndex = 3;
            this.ui_BtnLoginSignIn.Text = "Sign in";
            this.ui_BtnLoginSignIn.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_BtnLoginSignIn.UseSelectable = true;
            this.ui_BtnLoginSignIn.UseStyleColors = true;
            this.ui_BtnLoginSignIn.Click += new System.EventHandler(this.ui_BtnLoginSignIn_Click);
            // 
            // ui_LabelLoginPassword
            // 
            this.ui_LabelLoginPassword.AutoSize = true;
            this.ui_LabelLoginPassword.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ui_LabelLoginPassword.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_LabelLoginPassword.ForeColor = System.Drawing.Color.White;
            this.ui_LabelLoginPassword.Location = new System.Drawing.Point(189, 197);
            this.ui_LabelLoginPassword.Name = "ui_LabelLoginPassword";
            this.ui_LabelLoginPassword.Size = new System.Drawing.Size(88, 25);
            this.ui_LabelLoginPassword.Style = MetroFramework.MetroColorStyle.White;
            this.ui_LabelLoginPassword.TabIndex = 0;
            this.ui_LabelLoginPassword.Text = "Password";
            this.ui_LabelLoginPassword.UseCustomBackColor = true;
            this.ui_LabelLoginPassword.UseCustomForeColor = true;
            this.ui_LabelLoginPassword.UseStyleColors = true;
            // 
            // ui_LabelLoginUsername
            // 
            this.ui_LabelLoginUsername.AutoSize = true;
            this.ui_LabelLoginUsername.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ui_LabelLoginUsername.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_LabelLoginUsername.ForeColor = System.Drawing.Color.White;
            this.ui_LabelLoginUsername.Location = new System.Drawing.Point(189, 150);
            this.ui_LabelLoginUsername.Name = "ui_LabelLoginUsername";
            this.ui_LabelLoginUsername.Size = new System.Drawing.Size(91, 25);
            this.ui_LabelLoginUsername.Style = MetroFramework.MetroColorStyle.White;
            this.ui_LabelLoginUsername.TabIndex = 0;
            this.ui_LabelLoginUsername.Text = "Username";
            this.ui_LabelLoginUsername.UseCustomBackColor = true;
            this.ui_LabelLoginUsername.UseCustomForeColor = true;
            this.ui_LabelLoginUsername.UseStyleColors = true;
            // 
            // ui_TextBoxPassword
            // 
            this.ui_TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_TextBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ui_TextBoxPassword.Location = new System.Drawing.Point(317, 196);
            this.ui_TextBoxPassword.Name = "ui_TextBoxPassword";
            this.ui_TextBoxPassword.Size = new System.Drawing.Size(456, 26);
            this.ui_TextBoxPassword.TabIndex = 2;
            this.ui_TextBoxPassword.Text = "omicroncs";
            // 
            // ui_TextBoxUsername
            // 
            this.ui_TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_TextBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.ui_TextBoxUsername.Location = new System.Drawing.Point(317, 149);
            this.ui_TextBoxUsername.Name = "ui_TextBoxUsername";
            this.ui_TextBoxUsername.Size = new System.Drawing.Size(456, 26);
            this.ui_TextBoxUsername.TabIndex = 1;
            this.ui_TextBoxUsername.Text = "omicroncs";
            // 
            // ui_TabCtrlMain
            // 
            this.ui_TabCtrlMain.Controls.Add(this.ui_TabHome);
            this.ui_TabCtrlMain.Controls.Add(this.ui_TabCutOff);
            this.ui_TabCtrlMain.Controls.Add(this.ui_TabView);
            this.ui_TabCtrlMain.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.ui_TabCtrlMain.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.ui_TabCtrlMain.ItemSize = new System.Drawing.Size(286, 40);
            this.ui_TabCtrlMain.Location = new System.Drawing.Point(79, 138);
            this.ui_TabCtrlMain.Name = "ui_TabCtrlMain";
            this.ui_TabCtrlMain.RightToLeftLayout = true;
            this.ui_TabCtrlMain.SelectedIndex = 0;
            this.ui_TabCtrlMain.Size = new System.Drawing.Size(867, 607);
            this.ui_TabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ui_TabCtrlMain.TabIndex = 2;
            this.ui_TabCtrlMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ui_TabCtrlMain.UseSelectable = true;
            this.ui_TabCtrlMain.UseStyleColors = true;
            this.ui_TabCtrlMain.Visible = false;
            // 
            // ui_TabHome
            // 
            this.ui_TabHome.Controls.Add(this.ui_BtnEditEntry);
            this.ui_TabHome.Controls.Add(this.ui_BtnDeleteEntry);
            this.ui_TabHome.Controls.Add(this.ui_BtnAddEntry);
            this.ui_TabHome.Controls.Add(this.ui_BtnExportData);
            this.ui_TabHome.Controls.Add(this.ui_BtnImportData);
            this.ui_TabHome.Controls.Add(this.ui_ComboBoxViewData);
            this.ui_TabHome.Controls.Add(this.metroGrid1);
            this.ui_TabHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ui_TabHome.HorizontalScrollbarBarColor = true;
            this.ui_TabHome.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_TabHome.HorizontalScrollbarSize = 10;
            this.ui_TabHome.Location = new System.Drawing.Point(4, 44);
            this.ui_TabHome.Name = "ui_TabHome";
            this.ui_TabHome.Size = new System.Drawing.Size(859, 559);
            this.ui_TabHome.TabIndex = 0;
            this.ui_TabHome.Text = "Home";
            this.ui_TabHome.VerticalScrollbarBarColor = true;
            this.ui_TabHome.VerticalScrollbarHighlightOnWheel = false;
            this.ui_TabHome.VerticalScrollbarSize = 10;
            // 
            // ui_BtnEditEntry
            // 
            this.ui_BtnEditEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ui_BtnEditEntry.DisplayFocus = true;
            this.ui_BtnEditEntry.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ui_BtnEditEntry.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnEditEntry.ForeColor = System.Drawing.Color.White;
            this.ui_BtnEditEntry.Highlight = true;
            this.ui_BtnEditEntry.Location = new System.Drawing.Point(756, 531);
            this.ui_BtnEditEntry.Name = "ui_BtnEditEntry";
            this.ui_BtnEditEntry.Size = new System.Drawing.Size(93, 29);
            this.ui_BtnEditEntry.TabIndex = 6;
            this.ui_BtnEditEntry.Text = "Edit";
            this.ui_BtnEditEntry.UseCustomBackColor = true;
            this.ui_BtnEditEntry.UseCustomForeColor = true;
            this.ui_BtnEditEntry.UseSelectable = true;
            // 
            // ui_BtnDeleteEntry
            // 
            this.ui_BtnDeleteEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ui_BtnDeleteEntry.DisplayFocus = true;
            this.ui_BtnDeleteEntry.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ui_BtnDeleteEntry.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnDeleteEntry.ForeColor = System.Drawing.Color.White;
            this.ui_BtnDeleteEntry.Highlight = true;
            this.ui_BtnDeleteEntry.Location = new System.Drawing.Point(657, 531);
            this.ui_BtnDeleteEntry.Name = "ui_BtnDeleteEntry";
            this.ui_BtnDeleteEntry.Size = new System.Drawing.Size(93, 29);
            this.ui_BtnDeleteEntry.TabIndex = 6;
            this.ui_BtnDeleteEntry.Text = "Delete";
            this.ui_BtnDeleteEntry.UseCustomBackColor = true;
            this.ui_BtnDeleteEntry.UseCustomForeColor = true;
            this.ui_BtnDeleteEntry.UseSelectable = true;
            // 
            // ui_BtnAddEntry
            // 
            this.ui_BtnAddEntry.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ui_BtnAddEntry.DisplayFocus = true;
            this.ui_BtnAddEntry.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ui_BtnAddEntry.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnAddEntry.ForeColor = System.Drawing.Color.White;
            this.ui_BtnAddEntry.Highlight = true;
            this.ui_BtnAddEntry.Location = new System.Drawing.Point(558, 531);
            this.ui_BtnAddEntry.Name = "ui_BtnAddEntry";
            this.ui_BtnAddEntry.Size = new System.Drawing.Size(93, 29);
            this.ui_BtnAddEntry.TabIndex = 5;
            this.ui_BtnAddEntry.Text = "Add";
            this.ui_BtnAddEntry.UseCustomBackColor = true;
            this.ui_BtnAddEntry.UseCustomForeColor = true;
            this.ui_BtnAddEntry.UseSelectable = true;
            // 
            // ui_BtnExportData
            // 
            this.ui_BtnExportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ui_BtnExportData.DisplayFocus = true;
            this.ui_BtnExportData.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ui_BtnExportData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnExportData.ForeColor = System.Drawing.Color.White;
            this.ui_BtnExportData.Highlight = true;
            this.ui_BtnExportData.Location = new System.Drawing.Point(107, 11);
            this.ui_BtnExportData.Name = "ui_BtnExportData";
            this.ui_BtnExportData.Size = new System.Drawing.Size(93, 29);
            this.ui_BtnExportData.TabIndex = 4;
            this.ui_BtnExportData.Text = "Export";
            this.ui_BtnExportData.UseCustomBackColor = true;
            this.ui_BtnExportData.UseCustomForeColor = true;
            this.ui_BtnExportData.UseSelectable = true;
            // 
            // ui_BtnImportData
            // 
            this.ui_BtnImportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.ui_BtnImportData.DisplayFocus = true;
            this.ui_BtnImportData.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ui_BtnImportData.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_BtnImportData.ForeColor = System.Drawing.Color.White;
            this.ui_BtnImportData.Highlight = true;
            this.ui_BtnImportData.Location = new System.Drawing.Point(9, 11);
            this.ui_BtnImportData.Name = "ui_BtnImportData";
            this.ui_BtnImportData.Size = new System.Drawing.Size(93, 29);
            this.ui_BtnImportData.TabIndex = 3;
            this.ui_BtnImportData.Text = "Import";
            this.ui_BtnImportData.UseCustomBackColor = true;
            this.ui_BtnImportData.UseCustomForeColor = true;
            this.ui_BtnImportData.UseSelectable = true;
            // 
            // ui_ComboBoxViewData
            // 
            this.ui_ComboBoxViewData.FormattingEnabled = true;
            this.ui_ComboBoxViewData.ItemHeight = 23;
            this.ui_ComboBoxViewData.Items.AddRange(new object[] {
            "Recently Added",
            "Today",
            "Yesterday",
            "Last Week",
            "Last Month",
            "Custom Date"});
            this.ui_ComboBoxViewData.Location = new System.Drawing.Point(670, 11);
            this.ui_ComboBoxViewData.Name = "ui_ComboBoxViewData";
            this.ui_ComboBoxViewData.Size = new System.Drawing.Size(177, 29);
            this.ui_ComboBoxViewData.TabIndex = 10;
            this.ui_ComboBoxViewData.UseSelectable = true;
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ui_GridLastName,
            this.ui_GiridFirstName,
            this.ui_GiridMiddleName,
            this.ui_GiridBirthday,
            this.ui_GiridEducation,
            this.ui_GiridIndustry,
            this.ui_GiridIncome,
            this.ui_GiridTenure,
            this.ui_GridStatus});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle22;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 48);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.metroGrid1.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(853, 477);
            this.metroGrid1.TabIndex = 2;
            // 
            // ui_GridLastName
            // 
            this.ui_GridLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_GridLastName.DefaultCellStyle = dataGridViewCellStyle14;
            this.ui_GridLastName.HeaderText = "Last Name";
            this.ui_GridLastName.MinimumWidth = 92;
            this.ui_GridLastName.Name = "ui_GridLastName";
            // 
            // ui_GiridFirstName
            // 
            this.ui_GiridFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_GiridFirstName.DefaultCellStyle = dataGridViewCellStyle15;
            this.ui_GiridFirstName.HeaderText = "First Name";
            this.ui_GiridFirstName.MinimumWidth = 92;
            this.ui_GiridFirstName.Name = "ui_GiridFirstName";
            // 
            // ui_GiridMiddleName
            // 
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridMiddleName.DefaultCellStyle = dataGridViewCellStyle16;
            this.ui_GiridMiddleName.HeaderText = "Middle Name";
            this.ui_GiridMiddleName.MinimumWidth = 120;
            this.ui_GiridMiddleName.Name = "ui_GiridMiddleName";
            this.ui_GiridMiddleName.Width = 120;
            // 
            // ui_GiridBirthday
            // 
            this.ui_GiridBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridBirthday.DefaultCellStyle = dataGridViewCellStyle17;
            this.ui_GiridBirthday.HeaderText = "Birthday";
            this.ui_GiridBirthday.MinimumWidth = 92;
            this.ui_GiridBirthday.Name = "ui_GiridBirthday";
            // 
            // ui_GiridEducation
            // 
            this.ui_GiridEducation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridEducation.DefaultCellStyle = dataGridViewCellStyle18;
            this.ui_GiridEducation.HeaderText = "Education";
            this.ui_GiridEducation.MinimumWidth = 92;
            this.ui_GiridEducation.Name = "ui_GiridEducation";
            // 
            // ui_GiridIndustry
            // 
            this.ui_GiridIndustry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridIndustry.DefaultCellStyle = dataGridViewCellStyle19;
            this.ui_GiridIndustry.HeaderText = "Industry";
            this.ui_GiridIndustry.MinimumWidth = 92;
            this.ui_GiridIndustry.Name = "ui_GiridIndustry";
            // 
            // ui_GiridIncome
            // 
            this.ui_GiridIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridIncome.DefaultCellStyle = dataGridViewCellStyle20;
            this.ui_GiridIncome.HeaderText = "Income";
            this.ui_GiridIncome.MinimumWidth = 92;
            this.ui_GiridIncome.Name = "ui_GiridIncome";
            // 
            // ui_GiridTenure
            // 
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridTenure.DefaultCellStyle = dataGridViewCellStyle21;
            this.ui_GiridTenure.HeaderText = "Tenure";
            this.ui_GiridTenure.MinimumWidth = 80;
            this.ui_GiridTenure.Name = "ui_GiridTenure";
            this.ui_GiridTenure.Width = 80;
            // 
            // ui_GridStatus
            // 
            this.ui_GridStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ui_GridStatus.HeaderText = "Status";
            this.ui_GridStatus.MinimumWidth = 92;
            this.ui_GridStatus.Name = "ui_GridStatus";
            // 
            // ui_TabCutOff
            // 
            this.ui_TabCutOff.HorizontalScrollbarBarColor = true;
            this.ui_TabCutOff.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_TabCutOff.HorizontalScrollbarSize = 10;
            this.ui_TabCutOff.Location = new System.Drawing.Point(4, 44);
            this.ui_TabCutOff.Name = "ui_TabCutOff";
            this.ui_TabCutOff.Size = new System.Drawing.Size(859, 559);
            this.ui_TabCutOff.TabIndex = 1;
            this.ui_TabCutOff.Text = "Cut-Off";
            this.ui_TabCutOff.VerticalScrollbarBarColor = true;
            this.ui_TabCutOff.VerticalScrollbarHighlightOnWheel = false;
            this.ui_TabCutOff.VerticalScrollbarSize = 10;
            // 
            // ui_TabView
            // 
            this.ui_TabView.HorizontalScrollbarBarColor = true;
            this.ui_TabView.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_TabView.HorizontalScrollbarSize = 10;
            this.ui_TabView.Location = new System.Drawing.Point(4, 44);
            this.ui_TabView.Name = "ui_TabView";
            this.ui_TabView.Size = new System.Drawing.Size(859, 559);
            this.ui_TabView.TabIndex = 2;
            this.ui_TabView.Text = "View";
            this.ui_TabView.VerticalScrollbarBarColor = true;
            this.ui_TabView.VerticalScrollbarHighlightOnWheel = false;
            this.ui_TabView.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AcceptButton = this.ui_BtnLoginSignIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.ui_TabCtrlMain);
            this.Controls.Add(this.ui_Icon);
            this.Controls.Add(this.ui_PanelLogin);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.ui_Icon)).EndInit();
            this.ui_PanelLogin.ResumeLayout(false);
            this.ui_PanelLogin.PerformLayout();
            this.ui_TabCtrlMain.ResumeLayout(false);
            this.ui_TabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ui_Icon;
        private MetroFramework.Controls.MetroPanel ui_PanelLogin;
        private System.Windows.Forms.TextBox ui_TextBoxPassword;
        private System.Windows.Forms.TextBox ui_TextBoxUsername;
        private MetroFramework.Controls.MetroLabel ui_LabelLoginUsername;
        private MetroFramework.Controls.MetroLabel ui_LabelLoginPassword;
        private MetroFramework.Controls.MetroButton in_BtnLoginClear;
        private MetroFramework.Controls.MetroButton ui_BtnLoginSignIn;
        private MetroFramework.Controls.MetroLabel ui_LabelLogin;
        private MetroFramework.Controls.MetroTabControl ui_TabCtrlMain;
        private MetroFramework.Controls.MetroTabPage ui_TabHome;
        private MetroFramework.Controls.MetroTabPage ui_TabCutOff;
        private MetroFramework.Controls.MetroTabPage ui_TabView;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private MetroFramework.Controls.MetroComboBox ui_ComboBoxViewData;
        private MetroFramework.Controls.MetroButton ui_BtnImportData;
        private MetroFramework.Controls.MetroButton ui_BtnExportData;
        private MetroFramework.Controls.MetroButton ui_BtnEditEntry;
        private MetroFramework.Controls.MetroButton ui_BtnDeleteEntry;
        private MetroFramework.Controls.MetroButton ui_BtnAddEntry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GridLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridMiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridEducation;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridIndustry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GiridTenure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ui_GridStatus;
    }
}

