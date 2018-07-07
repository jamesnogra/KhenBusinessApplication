namespace Business_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.businessApplicationsTab = new System.Windows.Forms.TabControl();
            this.allBusinessApplicationsTab = new System.Windows.Forms.TabPage();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.allBusinessApplicationsDataGrid = new System.Windows.Forms.DataGridView();
            this.addBusinessApplicationTab = new System.Windows.Forms.TabPage();
            this.addBusinessApplicationButton = new System.Windows.Forms.Button();
            this.amountPaidText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.orNoText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.locationText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.projectTypeText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.decisionNoText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.applicationNoText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.businessNameText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nameOfApplicantText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.editBusinessApplcationTab = new System.Windows.Forms.TabPage();
            this.idEditText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.editBusinessApplicationButton = new System.Windows.Forms.Button();
            this.amountPaidEditText = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.orNoEditText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.locationEditText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.projectTypeEditText = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.decisionNoEditText = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.applicationNoEditText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.businessNameEditText = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nameOfApplicantEditText = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.createLoginUserTab = new System.Windows.Forms.TabPage();
            this.createPassword1Text = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.createPasswordText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.createUserText = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.businessApplicationsTab.SuspendLayout();
            this.allBusinessApplicationsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBusinessApplicationsDataGrid)).BeginInit();
            this.addBusinessApplicationTab.SuspendLayout();
            this.editBusinessApplcationTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.createLoginUserTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // businessApplicationsTab
            // 
            this.businessApplicationsTab.Controls.Add(this.allBusinessApplicationsTab);
            this.businessApplicationsTab.Controls.Add(this.addBusinessApplicationTab);
            this.businessApplicationsTab.Controls.Add(this.editBusinessApplcationTab);
            this.businessApplicationsTab.Controls.Add(this.loginTab);
            this.businessApplicationsTab.Controls.Add(this.createLoginUserTab);
            this.businessApplicationsTab.Location = new System.Drawing.Point(13, 13);
            this.businessApplicationsTab.Name = "businessApplicationsTab";
            this.businessApplicationsTab.SelectedIndex = 0;
            this.businessApplicationsTab.Size = new System.Drawing.Size(959, 576);
            this.businessApplicationsTab.TabIndex = 0;
            this.businessApplicationsTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.businessApplicationsTabs_Selected);
            // 
            // allBusinessApplicationsTab
            // 
            this.allBusinessApplicationsTab.Controls.Add(this.searchText);
            this.allBusinessApplicationsTab.Controls.Add(this.label18);
            this.allBusinessApplicationsTab.Controls.Add(this.allBusinessApplicationsDataGrid);
            this.allBusinessApplicationsTab.Location = new System.Drawing.Point(4, 22);
            this.allBusinessApplicationsTab.Name = "allBusinessApplicationsTab";
            this.allBusinessApplicationsTab.Padding = new System.Windows.Forms.Padding(3);
            this.allBusinessApplicationsTab.Size = new System.Drawing.Size(951, 550);
            this.allBusinessApplicationsTab.TabIndex = 0;
            this.allBusinessApplicationsTab.Text = "All Business Applications";
            this.allBusinessApplicationsTab.UseVisualStyleBackColor = true;
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchText.Location = new System.Drawing.Point(66, 16);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(296, 22);
            this.searchText.TabIndex = 2;
            this.searchText.TextChanged += new System.EventHandler(this.searchText_TextChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 19);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 16);
            this.label18.TabIndex = 1;
            this.label18.Text = "Search:";
            // 
            // allBusinessApplicationsDataGrid
            // 
            this.allBusinessApplicationsDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.allBusinessApplicationsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allBusinessApplicationsDataGrid.Location = new System.Drawing.Point(7, 50);
            this.allBusinessApplicationsDataGrid.Name = "allBusinessApplicationsDataGrid";
            this.allBusinessApplicationsDataGrid.ReadOnly = true;
            this.allBusinessApplicationsDataGrid.Size = new System.Drawing.Size(938, 494);
            this.allBusinessApplicationsDataGrid.TabIndex = 0;
            this.allBusinessApplicationsDataGrid.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.allBusinessApplicationsDataGrid_CellMouseDoubleClick);
            this.allBusinessApplicationsDataGrid.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.allBusinessApplicationsDataGrid_UserDeletingRow);
            // 
            // addBusinessApplicationTab
            // 
            this.addBusinessApplicationTab.Controls.Add(this.addBusinessApplicationButton);
            this.addBusinessApplicationTab.Controls.Add(this.amountPaidText);
            this.addBusinessApplicationTab.Controls.Add(this.label8);
            this.addBusinessApplicationTab.Controls.Add(this.orNoText);
            this.addBusinessApplicationTab.Controls.Add(this.label7);
            this.addBusinessApplicationTab.Controls.Add(this.locationText);
            this.addBusinessApplicationTab.Controls.Add(this.label6);
            this.addBusinessApplicationTab.Controls.Add(this.projectTypeText);
            this.addBusinessApplicationTab.Controls.Add(this.label5);
            this.addBusinessApplicationTab.Controls.Add(this.decisionNoText);
            this.addBusinessApplicationTab.Controls.Add(this.label4);
            this.addBusinessApplicationTab.Controls.Add(this.applicationNoText);
            this.addBusinessApplicationTab.Controls.Add(this.label3);
            this.addBusinessApplicationTab.Controls.Add(this.businessNameText);
            this.addBusinessApplicationTab.Controls.Add(this.label2);
            this.addBusinessApplicationTab.Controls.Add(this.nameOfApplicantText);
            this.addBusinessApplicationTab.Controls.Add(this.label1);
            this.addBusinessApplicationTab.Location = new System.Drawing.Point(4, 22);
            this.addBusinessApplicationTab.Name = "addBusinessApplicationTab";
            this.addBusinessApplicationTab.Padding = new System.Windows.Forms.Padding(3);
            this.addBusinessApplicationTab.Size = new System.Drawing.Size(951, 550);
            this.addBusinessApplicationTab.TabIndex = 1;
            this.addBusinessApplicationTab.Text = "Add Business Application";
            this.addBusinessApplicationTab.UseVisualStyleBackColor = true;
            // 
            // addBusinessApplicationButton
            // 
            this.addBusinessApplicationButton.BackColor = System.Drawing.Color.Black;
            this.addBusinessApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBusinessApplicationButton.ForeColor = System.Drawing.Color.White;
            this.addBusinessApplicationButton.Location = new System.Drawing.Point(365, 224);
            this.addBusinessApplicationButton.Name = "addBusinessApplicationButton";
            this.addBusinessApplicationButton.Size = new System.Drawing.Size(200, 40);
            this.addBusinessApplicationButton.TabIndex = 9;
            this.addBusinessApplicationButton.Text = "Save Business Application";
            this.addBusinessApplicationButton.UseVisualStyleBackColor = false;
            this.addBusinessApplicationButton.Click += new System.EventHandler(this.addBusinessApplicationButton_Click);
            // 
            // amountPaidText
            // 
            this.amountPaidText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidText.Location = new System.Drawing.Point(145, 198);
            this.amountPaidText.Name = "amountPaidText";
            this.amountPaidText.Size = new System.Drawing.Size(420, 22);
            this.amountPaidText.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 14;
            this.label8.Text = "Amount Paid";
            // 
            // orNoText
            // 
            this.orNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orNoText.Location = new System.Drawing.Point(145, 172);
            this.orNoText.Name = "orNoText";
            this.orNoText.Size = new System.Drawing.Size(420, 22);
            this.orNoText.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "OR No.";
            // 
            // locationText
            // 
            this.locationText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationText.Location = new System.Drawing.Point(145, 146);
            this.locationText.Name = "locationText";
            this.locationText.Size = new System.Drawing.Size(420, 22);
            this.locationText.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Location";
            // 
            // projectTypeText
            // 
            this.projectTypeText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTypeText.Location = new System.Drawing.Point(145, 120);
            this.projectTypeText.Name = "projectTypeText";
            this.projectTypeText.Size = new System.Drawing.Size(420, 22);
            this.projectTypeText.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Project Type";
            // 
            // decisionNoText
            // 
            this.decisionNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionNoText.Location = new System.Drawing.Point(145, 94);
            this.decisionNoText.Name = "decisionNoText";
            this.decisionNoText.Size = new System.Drawing.Size(420, 22);
            this.decisionNoText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Decision No.";
            // 
            // applicationNoText
            // 
            this.applicationNoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationNoText.Location = new System.Drawing.Point(145, 68);
            this.applicationNoText.Name = "applicationNoText";
            this.applicationNoText.Size = new System.Drawing.Size(420, 22);
            this.applicationNoText.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Application No.";
            // 
            // businessNameText
            // 
            this.businessNameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameText.Location = new System.Drawing.Point(145, 42);
            this.businessNameText.Name = "businessNameText";
            this.businessNameText.Size = new System.Drawing.Size(420, 22);
            this.businessNameText.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Business Name";
            // 
            // nameOfApplicantText
            // 
            this.nameOfApplicantText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfApplicantText.Location = new System.Drawing.Point(145, 16);
            this.nameOfApplicantText.Name = "nameOfApplicantText";
            this.nameOfApplicantText.Size = new System.Drawing.Size(420, 22);
            this.nameOfApplicantText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name of Applicant";
            // 
            // editBusinessApplcationTab
            // 
            this.editBusinessApplcationTab.Controls.Add(this.idEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label17);
            this.editBusinessApplcationTab.Controls.Add(this.editBusinessApplicationButton);
            this.editBusinessApplcationTab.Controls.Add(this.amountPaidEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label9);
            this.editBusinessApplcationTab.Controls.Add(this.orNoEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label10);
            this.editBusinessApplcationTab.Controls.Add(this.locationEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label11);
            this.editBusinessApplcationTab.Controls.Add(this.projectTypeEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label12);
            this.editBusinessApplcationTab.Controls.Add(this.decisionNoEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label13);
            this.editBusinessApplcationTab.Controls.Add(this.applicationNoEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label14);
            this.editBusinessApplcationTab.Controls.Add(this.businessNameEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label15);
            this.editBusinessApplcationTab.Controls.Add(this.nameOfApplicantEditText);
            this.editBusinessApplcationTab.Controls.Add(this.label16);
            this.editBusinessApplcationTab.Location = new System.Drawing.Point(4, 22);
            this.editBusinessApplcationTab.Name = "editBusinessApplcationTab";
            this.editBusinessApplcationTab.Padding = new System.Windows.Forms.Padding(3);
            this.editBusinessApplcationTab.Size = new System.Drawing.Size(951, 550);
            this.editBusinessApplcationTab.TabIndex = 2;
            this.editBusinessApplcationTab.Text = "Edit Business Application";
            this.editBusinessApplcationTab.UseVisualStyleBackColor = true;
            // 
            // idEditText
            // 
            this.idEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idEditText.Location = new System.Drawing.Point(145, 226);
            this.idEditText.Name = "idEditText";
            this.idEditText.Size = new System.Drawing.Size(420, 22);
            this.idEditText.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 230);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 16);
            this.label17.TabIndex = 34;
            this.label17.Text = "ID (Do Not Change)";
            // 
            // editBusinessApplicationButton
            // 
            this.editBusinessApplicationButton.BackColor = System.Drawing.Color.Black;
            this.editBusinessApplicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBusinessApplicationButton.ForeColor = System.Drawing.Color.White;
            this.editBusinessApplicationButton.Location = new System.Drawing.Point(365, 254);
            this.editBusinessApplicationButton.Name = "editBusinessApplicationButton";
            this.editBusinessApplicationButton.Size = new System.Drawing.Size(200, 40);
            this.editBusinessApplicationButton.TabIndex = 59;
            this.editBusinessApplicationButton.Text = "Edit Business Application";
            this.editBusinessApplicationButton.UseVisualStyleBackColor = false;
            this.editBusinessApplicationButton.Click += new System.EventHandler(this.editBusinessApplicationButton_Click);
            // 
            // amountPaidEditText
            // 
            this.amountPaidEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountPaidEditText.Location = new System.Drawing.Point(145, 198);
            this.amountPaidEditText.Name = "amountPaidEditText";
            this.amountPaidEditText.Size = new System.Drawing.Size(420, 22);
            this.amountPaidEditText.TabIndex = 58;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 202);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 31;
            this.label9.Text = "Amount Paid";
            // 
            // orNoEditText
            // 
            this.orNoEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orNoEditText.Location = new System.Drawing.Point(145, 172);
            this.orNoEditText.Name = "orNoEditText";
            this.orNoEditText.Size = new System.Drawing.Size(420, 22);
            this.orNoEditText.TabIndex = 57;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 176);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 29;
            this.label10.Text = "OR No.";
            // 
            // locationEditText
            // 
            this.locationEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationEditText.Location = new System.Drawing.Point(145, 146);
            this.locationEditText.Name = "locationEditText";
            this.locationEditText.Size = new System.Drawing.Size(420, 22);
            this.locationEditText.TabIndex = 56;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 150);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Location";
            // 
            // projectTypeEditText
            // 
            this.projectTypeEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectTypeEditText.Location = new System.Drawing.Point(145, 120);
            this.projectTypeEditText.Name = "projectTypeEditText";
            this.projectTypeEditText.Size = new System.Drawing.Size(420, 22);
            this.projectTypeEditText.TabIndex = 55;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 16);
            this.label12.TabIndex = 25;
            this.label12.Text = "Project Type";
            // 
            // decisionNoEditText
            // 
            this.decisionNoEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.decisionNoEditText.Location = new System.Drawing.Point(145, 94);
            this.decisionNoEditText.Name = "decisionNoEditText";
            this.decisionNoEditText.Size = new System.Drawing.Size(420, 22);
            this.decisionNoEditText.TabIndex = 54;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 16);
            this.label13.TabIndex = 23;
            this.label13.Text = "Decision No.";
            // 
            // applicationNoEditText
            // 
            this.applicationNoEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationNoEditText.Location = new System.Drawing.Point(145, 68);
            this.applicationNoEditText.Name = "applicationNoEditText";
            this.applicationNoEditText.Size = new System.Drawing.Size(420, 22);
            this.applicationNoEditText.TabIndex = 53;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 16);
            this.label14.TabIndex = 21;
            this.label14.Text = "Application No.";
            // 
            // businessNameEditText
            // 
            this.businessNameEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.businessNameEditText.Location = new System.Drawing.Point(145, 42);
            this.businessNameEditText.Name = "businessNameEditText";
            this.businessNameEditText.Size = new System.Drawing.Size(420, 22);
            this.businessNameEditText.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(6, 46);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 16);
            this.label15.TabIndex = 19;
            this.label15.Text = "Business Name";
            // 
            // nameOfApplicantEditText
            // 
            this.nameOfApplicantEditText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfApplicantEditText.Location = new System.Drawing.Point(145, 16);
            this.nameOfApplicantEditText.Name = "nameOfApplicantEditText";
            this.nameOfApplicantEditText.Size = new System.Drawing.Size(420, 22);
            this.nameOfApplicantEditText.TabIndex = 51;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(118, 16);
            this.label16.TabIndex = 17;
            this.label16.Text = "Name of Applicant";
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.passwordText);
            this.loginTab.Controls.Add(this.label19);
            this.loginTab.Controls.Add(this.loginButton);
            this.loginTab.Controls.Add(this.userText);
            this.loginTab.Controls.Add(this.label20);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(951, 550);
            this.loginTab.TabIndex = 3;
            this.loginTab.Text = "Login";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordText.Location = new System.Drawing.Point(146, 43);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(420, 22);
            this.passwordText.TabIndex = 101;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(7, 47);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 16);
            this.label19.TabIndex = 39;
            this.label19.Text = "Password";
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Black;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(366, 71);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(200, 40);
            this.loginButton.TabIndex = 103;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userText
            // 
            this.userText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userText.Location = new System.Drawing.Point(146, 15);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(420, 22);
            this.userText.TabIndex = 100;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(7, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 16);
            this.label20.TabIndex = 36;
            this.label20.Text = "User";
            // 
            // createLoginUserTab
            // 
            this.createLoginUserTab.Controls.Add(this.createPassword1Text);
            this.createLoginUserTab.Controls.Add(this.label23);
            this.createLoginUserTab.Controls.Add(this.createPasswordText);
            this.createLoginUserTab.Controls.Add(this.label21);
            this.createLoginUserTab.Controls.Add(this.createUserButton);
            this.createLoginUserTab.Controls.Add(this.createUserText);
            this.createLoginUserTab.Controls.Add(this.label22);
            this.createLoginUserTab.Location = new System.Drawing.Point(4, 22);
            this.createLoginUserTab.Name = "createLoginUserTab";
            this.createLoginUserTab.Padding = new System.Windows.Forms.Padding(3);
            this.createLoginUserTab.Size = new System.Drawing.Size(951, 550);
            this.createLoginUserTab.TabIndex = 4;
            this.createLoginUserTab.Text = "Create Login User";
            this.createLoginUserTab.UseVisualStyleBackColor = true;
            // 
            // createPassword1Text
            // 
            this.createPassword1Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPassword1Text.Location = new System.Drawing.Point(146, 71);
            this.createPassword1Text.Name = "createPassword1Text";
            this.createPassword1Text.Size = new System.Drawing.Size(420, 22);
            this.createPassword1Text.TabIndex = 203;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(7, 75);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(116, 16);
            this.label23.TabIndex = 46;
            this.label23.Text = "Confirm Password";
            // 
            // createPasswordText
            // 
            this.createPasswordText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createPasswordText.Location = new System.Drawing.Point(146, 43);
            this.createPasswordText.Name = "createPasswordText";
            this.createPasswordText.Size = new System.Drawing.Size(420, 22);
            this.createPasswordText.TabIndex = 202;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 47);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 16);
            this.label21.TabIndex = 44;
            this.label21.Text = "Password";
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.Black;
            this.createUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.ForeColor = System.Drawing.Color.White;
            this.createUserButton.Location = new System.Drawing.Point(366, 99);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(200, 40);
            this.createUserButton.TabIndex = 204;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // createUserText
            // 
            this.createUserText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserText.Location = new System.Drawing.Point(146, 15);
            this.createUserText.Name = "createUserText";
            this.createUserText.Size = new System.Drawing.Size(420, 22);
            this.createUserText.TabIndex = 201;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(7, 19);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 16);
            this.label22.TabIndex = 41;
            this.label22.Text = "User";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 601);
            this.Controls.Add(this.businessApplicationsTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Business Application";
            this.businessApplicationsTab.ResumeLayout(false);
            this.allBusinessApplicationsTab.ResumeLayout(false);
            this.allBusinessApplicationsTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBusinessApplicationsDataGrid)).EndInit();
            this.addBusinessApplicationTab.ResumeLayout(false);
            this.addBusinessApplicationTab.PerformLayout();
            this.editBusinessApplcationTab.ResumeLayout(false);
            this.editBusinessApplcationTab.PerformLayout();
            this.loginTab.ResumeLayout(false);
            this.loginTab.PerformLayout();
            this.createLoginUserTab.ResumeLayout(false);
            this.createLoginUserTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl businessApplicationsTab;
        private System.Windows.Forms.TabPage allBusinessApplicationsTab;
        private System.Windows.Forms.TabPage addBusinessApplicationTab;
        private System.Windows.Forms.DataGridView allBusinessApplicationsDataGrid;
        private System.Windows.Forms.Button addBusinessApplicationButton;
        private System.Windows.Forms.TextBox amountPaidText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox orNoText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox locationText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox projectTypeText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox decisionNoText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox applicationNoText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox businessNameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameOfApplicantText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage editBusinessApplcationTab;
        private System.Windows.Forms.Button editBusinessApplicationButton;
        private System.Windows.Forms.TextBox amountPaidEditText;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox orNoEditText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox locationEditText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox projectTypeEditText;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox decisionNoEditText;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox applicationNoEditText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox businessNameEditText;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox nameOfApplicantEditText;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox idEditText;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabPage createLoginUserTab;
        private System.Windows.Forms.TextBox createPassword1Text;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox createPasswordText;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.TextBox createUserText;
        private System.Windows.Forms.Label label22;
    }
}

