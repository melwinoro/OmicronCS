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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ui_Icon = new System.Windows.Forms.PictureBox();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Symbol", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle10;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 48);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.metroGrid1.RowHeadersVisible = false;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle12;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_GridLastName.DefaultCellStyle = dataGridViewCellStyle2;
            this.ui_GridLastName.HeaderText = "Last Name";
            this.ui_GridLastName.MinimumWidth = 92;
            this.ui_GridLastName.Name = "ui_GridLastName";
            // 
            // ui_GiridFirstName
            // 
            this.ui_GiridFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_GiridFirstName.DefaultCellStyle = dataGridViewCellStyle3;
            this.ui_GiridFirstName.HeaderText = "First Name";
            this.ui_GiridFirstName.MinimumWidth = 92;
            this.ui_GiridFirstName.Name = "ui_GiridFirstName";
            // 
            // ui_GiridMiddleName
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridMiddleName.DefaultCellStyle = dataGridViewCellStyle4;
            this.ui_GiridMiddleName.HeaderText = "Middle Name";
            this.ui_GiridMiddleName.MinimumWidth = 120;
            this.ui_GiridMiddleName.Name = "ui_GiridMiddleName";
            this.ui_GiridMiddleName.Width = 120;
            // 
            // ui_GiridBirthday
            // 
            this.ui_GiridBirthday.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridBirthday.DefaultCellStyle = dataGridViewCellStyle5;
            this.ui_GiridBirthday.HeaderText = "Birthday";
            this.ui_GiridBirthday.MinimumWidth = 92;
            this.ui_GiridBirthday.Name = "ui_GiridBirthday";
            // 
            // ui_GiridEducation
            // 
            this.ui_GiridEducation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridEducation.DefaultCellStyle = dataGridViewCellStyle6;
            this.ui_GiridEducation.HeaderText = "Education";
            this.ui_GiridEducation.MinimumWidth = 92;
            this.ui_GiridEducation.Name = "ui_GiridEducation";
            // 
            // ui_GiridIndustry
            // 
            this.ui_GiridIndustry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridIndustry.DefaultCellStyle = dataGridViewCellStyle7;
            this.ui_GiridIndustry.HeaderText = "Industry";
            this.ui_GiridIndustry.MinimumWidth = 92;
            this.ui_GiridIndustry.Name = "ui_GiridIndustry";
            // 
            // ui_GiridIncome
            // 
            this.ui_GiridIncome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridIncome.DefaultCellStyle = dataGridViewCellStyle8;
            this.ui_GiridIncome.HeaderText = "Income";
            this.ui_GiridIncome.MinimumWidth = 92;
            this.ui_GiridIncome.Name = "ui_GiridIncome";
            // 
            // ui_GiridTenure
            // 
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ui_GiridTenure.DefaultCellStyle = dataGridViewCellStyle9;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 768);
            this.Controls.Add(this.ui_TabCtrlMain);
            this.Controls.Add(this.ui_Icon);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Resizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            ((System.ComponentModel.ISupportInitialize)(this.ui_Icon)).EndInit();
            this.ui_TabCtrlMain.ResumeLayout(false);
            this.ui_TabHome.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ui_Icon;
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

