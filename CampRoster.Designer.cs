namespace CampData
{
    partial class CampRoster
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CampRoster));
            this.dgvCampRoster = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editInmate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cdcrNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradeEligibleDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.housingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.laundryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sawStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightWeightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ethnicityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eprdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paroledDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.atCampDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.jobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.crewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campJobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.specialStatusTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inmateBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.pilotrockdataDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotrockdataDataSet2 = new CampData.pilotrockdataDataSet2();
            this.inmateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.inmateTableAdapter2 = new CampData.pilotrockdataDataSet2TableAdapters.inmateTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkGrade = new System.Windows.Forms.CheckBox();
            this.chkNonGrade = new System.Windows.Forms.CheckBox();
            this.chkCrew1 = new System.Windows.Forms.CheckBox();
            this.chkCrew2 = new System.Windows.Forms.CheckBox();
            this.chkCrew3 = new System.Windows.Forms.CheckBox();
            this.chkCrew4 = new System.Windows.Forms.CheckBox();
            this.chkCALFIREInCamp = new System.Windows.Forms.CheckBox();
            this.chkCdcr = new System.Windows.Forms.CheckBox();
            this.chkAll = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampRoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCampRoster
            // 
            this.dgvCampRoster.AllowUserToAddRows = false;
            this.dgvCampRoster.AllowUserToDeleteRows = false;
            this.dgvCampRoster.AllowUserToResizeColumns = false;
            this.dgvCampRoster.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvCampRoster.AutoGenerateColumns = false;
            this.dgvCampRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCampRoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.editInmate,
            this.lastNameDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.cdcrNumberDataGridViewTextBoxColumn,
            this.gradeEligibleDataGridViewCheckBoxColumn,
            this.housingNumberDataGridViewTextBoxColumn,
            this.laundryNumberDataGridViewTextBoxColumn,
            this.sawStatusDataGridViewTextBoxColumn,
            this.flightWeightDataGridViewTextBoxColumn,
            this.ethnicityDataGridViewTextBoxColumn,
            this.eprdDataGridViewTextBoxColumn,
            this.paroledDataGridViewCheckBoxColumn,
            this.atCampDataGridViewCheckBoxColumn,
            this.jobDataGridViewTextBoxColumn,
            this.crewDataGridViewTextBoxColumn,
            this.campJobDataGridViewTextBoxColumn,
            this.specialStatusDataGridViewCheckBoxColumn,
            this.specialStatusTextDataGridViewTextBoxColumn});
            this.dgvCampRoster.DataSource = this.inmateBindingSource4;
            this.dgvCampRoster.Location = new System.Drawing.Point(0, 107);
            this.dgvCampRoster.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCampRoster.Name = "dgvCampRoster";
            this.dgvCampRoster.ReadOnly = true;
            this.dgvCampRoster.Size = new System.Drawing.Size(1461, 766);
            this.dgvCampRoster.TabIndex = 0;
            this.dgvCampRoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCampRoster_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // editInmate
            // 
            this.editInmate.HeaderText = "Edit";
            this.editInmate.Name = "editInmate";
            this.editInmate.ReadOnly = true;
            this.editInmate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.editInmate.Text = "Edit";
            this.editInmate.UseColumnTextForButtonValue = true;
            this.editInmate.Width = 50;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "lastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "firstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstNameDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.firstNameDataGridViewTextBoxColumn.Width = 50;
            // 
            // cdcrNumberDataGridViewTextBoxColumn
            // 
            this.cdcrNumberDataGridViewTextBoxColumn.DataPropertyName = "cdcrNumber";
            this.cdcrNumberDataGridViewTextBoxColumn.HeaderText = "CDCR Number";
            this.cdcrNumberDataGridViewTextBoxColumn.Name = "cdcrNumberDataGridViewTextBoxColumn";
            this.cdcrNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.cdcrNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cdcrNumberDataGridViewTextBoxColumn.Width = 60;
            // 
            // gradeEligibleDataGridViewCheckBoxColumn
            // 
            this.gradeEligibleDataGridViewCheckBoxColumn.DataPropertyName = "gradeEligible";
            this.gradeEligibleDataGridViewCheckBoxColumn.HeaderText = "Grade Eligible";
            this.gradeEligibleDataGridViewCheckBoxColumn.Name = "gradeEligibleDataGridViewCheckBoxColumn";
            this.gradeEligibleDataGridViewCheckBoxColumn.ReadOnly = true;
            this.gradeEligibleDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gradeEligibleDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.gradeEligibleDataGridViewCheckBoxColumn.Width = 50;
            // 
            // housingNumberDataGridViewTextBoxColumn
            // 
            this.housingNumberDataGridViewTextBoxColumn.DataPropertyName = "housingNumber";
            this.housingNumberDataGridViewTextBoxColumn.HeaderText = "Housing Number";
            this.housingNumberDataGridViewTextBoxColumn.Name = "housingNumberDataGridViewTextBoxColumn";
            this.housingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.housingNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.housingNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // laundryNumberDataGridViewTextBoxColumn
            // 
            this.laundryNumberDataGridViewTextBoxColumn.DataPropertyName = "laundryNumber";
            this.laundryNumberDataGridViewTextBoxColumn.HeaderText = "Laundry Number";
            this.laundryNumberDataGridViewTextBoxColumn.Name = "laundryNumberDataGridViewTextBoxColumn";
            this.laundryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.laundryNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.laundryNumberDataGridViewTextBoxColumn.Width = 50;
            // 
            // sawStatusDataGridViewTextBoxColumn
            // 
            this.sawStatusDataGridViewTextBoxColumn.DataPropertyName = "sawStatus";
            this.sawStatusDataGridViewTextBoxColumn.HeaderText = "Saw Qualified";
            this.sawStatusDataGridViewTextBoxColumn.Name = "sawStatusDataGridViewTextBoxColumn";
            this.sawStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.sawStatusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sawStatusDataGridViewTextBoxColumn.Width = 60;
            // 
            // flightWeightDataGridViewTextBoxColumn
            // 
            this.flightWeightDataGridViewTextBoxColumn.DataPropertyName = "flightWeight";
            this.flightWeightDataGridViewTextBoxColumn.HeaderText = "Flight Weight";
            this.flightWeightDataGridViewTextBoxColumn.Name = "flightWeightDataGridViewTextBoxColumn";
            this.flightWeightDataGridViewTextBoxColumn.ReadOnly = true;
            this.flightWeightDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.flightWeightDataGridViewTextBoxColumn.Width = 50;
            // 
            // ethnicityDataGridViewTextBoxColumn
            // 
            this.ethnicityDataGridViewTextBoxColumn.DataPropertyName = "ethnicity";
            this.ethnicityDataGridViewTextBoxColumn.HeaderText = "Ethnicity";
            this.ethnicityDataGridViewTextBoxColumn.Name = "ethnicityDataGridViewTextBoxColumn";
            this.ethnicityDataGridViewTextBoxColumn.ReadOnly = true;
            this.ethnicityDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ethnicityDataGridViewTextBoxColumn.Width = 60;
            // 
            // eprdDataGridViewTextBoxColumn
            // 
            this.eprdDataGridViewTextBoxColumn.DataPropertyName = "eprd";
            this.eprdDataGridViewTextBoxColumn.HeaderText = "EPRD";
            this.eprdDataGridViewTextBoxColumn.Name = "eprdDataGridViewTextBoxColumn";
            this.eprdDataGridViewTextBoxColumn.ReadOnly = true;
            this.eprdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.eprdDataGridViewTextBoxColumn.Width = 75;
            // 
            // paroledDataGridViewCheckBoxColumn
            // 
            this.paroledDataGridViewCheckBoxColumn.DataPropertyName = "paroled";
            this.paroledDataGridViewCheckBoxColumn.HeaderText = "paroled";
            this.paroledDataGridViewCheckBoxColumn.Name = "paroledDataGridViewCheckBoxColumn";
            this.paroledDataGridViewCheckBoxColumn.ReadOnly = true;
            this.paroledDataGridViewCheckBoxColumn.Visible = false;
            // 
            // atCampDataGridViewCheckBoxColumn
            // 
            this.atCampDataGridViewCheckBoxColumn.DataPropertyName = "atCamp";
            this.atCampDataGridViewCheckBoxColumn.HeaderText = "At Camp";
            this.atCampDataGridViewCheckBoxColumn.Name = "atCampDataGridViewCheckBoxColumn";
            this.atCampDataGridViewCheckBoxColumn.ReadOnly = true;
            this.atCampDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.atCampDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.atCampDataGridViewCheckBoxColumn.Width = 40;
            // 
            // jobDataGridViewTextBoxColumn
            // 
            this.jobDataGridViewTextBoxColumn.DataPropertyName = "job";
            this.jobDataGridViewTextBoxColumn.HeaderText = "Job";
            this.jobDataGridViewTextBoxColumn.Name = "jobDataGridViewTextBoxColumn";
            this.jobDataGridViewTextBoxColumn.ReadOnly = true;
            this.jobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.jobDataGridViewTextBoxColumn.Width = 60;
            // 
            // crewDataGridViewTextBoxColumn
            // 
            this.crewDataGridViewTextBoxColumn.DataPropertyName = "crew";
            this.crewDataGridViewTextBoxColumn.HeaderText = "Crew";
            this.crewDataGridViewTextBoxColumn.Name = "crewDataGridViewTextBoxColumn";
            this.crewDataGridViewTextBoxColumn.ReadOnly = true;
            this.crewDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.crewDataGridViewTextBoxColumn.Width = 50;
            // 
            // campJobDataGridViewTextBoxColumn
            // 
            this.campJobDataGridViewTextBoxColumn.DataPropertyName = "campJob";
            this.campJobDataGridViewTextBoxColumn.HeaderText = "Camp Job";
            this.campJobDataGridViewTextBoxColumn.Name = "campJobDataGridViewTextBoxColumn";
            this.campJobDataGridViewTextBoxColumn.ReadOnly = true;
            this.campJobDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.campJobDataGridViewTextBoxColumn.Width = 75;
            // 
            // specialStatusDataGridViewCheckBoxColumn
            // 
            this.specialStatusDataGridViewCheckBoxColumn.DataPropertyName = "specialStatus";
            this.specialStatusDataGridViewCheckBoxColumn.HeaderText = "Special Status";
            this.specialStatusDataGridViewCheckBoxColumn.Name = "specialStatusDataGridViewCheckBoxColumn";
            this.specialStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            this.specialStatusDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.specialStatusDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.specialStatusDataGridViewCheckBoxColumn.Width = 50;
            // 
            // specialStatusTextDataGridViewTextBoxColumn
            // 
            this.specialStatusTextDataGridViewTextBoxColumn.DataPropertyName = "specialStatusText";
            this.specialStatusTextDataGridViewTextBoxColumn.HeaderText = "Special Status Reason";
            this.specialStatusTextDataGridViewTextBoxColumn.Name = "specialStatusTextDataGridViewTextBoxColumn";
            this.specialStatusTextDataGridViewTextBoxColumn.ReadOnly = true;
            this.specialStatusTextDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // inmateBindingSource4
            // 
            this.inmateBindingSource4.DataMember = "inmate";
            this.inmateBindingSource4.DataSource = this.pilotrockdataDataSet2BindingSource;
            // 
            // pilotrockdataDataSet2BindingSource
            // 
            this.pilotrockdataDataSet2BindingSource.DataSource = this.pilotrockdataDataSet2;
            this.pilotrockdataDataSet2BindingSource.Position = 0;
            // 
            // pilotrockdataDataSet2
            // 
            this.pilotrockdataDataSet2.DataSetName = "pilotrockdataDataSet2";
            this.pilotrockdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inmateBindingSource2
            // 
            this.inmateBindingSource2.DataMember = "inmate";
            this.inmateBindingSource2.DataSource = this.pilotrockdataDataSet2;
            // 
            // inmateTableAdapter2
            // 
            this.inmateTableAdapter2.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(647, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilot Rock Conservation Camp #15 Camp Roster";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1190, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(271, 38);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Inmate To Roster";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1725, 100);
            this.panel1.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1504, 37);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 38);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close Roster";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkGrade
            // 
            this.chkGrade.AutoSize = true;
            this.chkGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrade.Location = new System.Drawing.Point(1504, 191);
            this.chkGrade.Name = "chkGrade";
            this.chkGrade.Size = new System.Drawing.Size(88, 29);
            this.chkGrade.TabIndex = 4;
            this.chkGrade.Text = "Grade";
            this.chkGrade.UseVisualStyleBackColor = true;
            this.chkGrade.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkNonGrade
            // 
            this.chkNonGrade.AutoSize = true;
            this.chkNonGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNonGrade.Location = new System.Drawing.Point(1504, 261);
            this.chkNonGrade.Name = "chkNonGrade";
            this.chkNonGrade.Size = new System.Drawing.Size(129, 29);
            this.chkNonGrade.TabIndex = 5;
            this.chkNonGrade.Text = "Non Grade";
            this.chkNonGrade.UseVisualStyleBackColor = true;
            this.chkNonGrade.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkCrew1
            // 
            this.chkCrew1.AutoSize = true;
            this.chkCrew1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrew1.Location = new System.Drawing.Point(1504, 331);
            this.chkCrew1.Name = "chkCrew1";
            this.chkCrew1.Size = new System.Drawing.Size(96, 29);
            this.chkCrew1.TabIndex = 6;
            this.chkCrew1.Text = "Crew 1";
            this.chkCrew1.UseVisualStyleBackColor = true;
            this.chkCrew1.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkCrew2
            // 
            this.chkCrew2.AutoSize = true;
            this.chkCrew2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrew2.Location = new System.Drawing.Point(1504, 401);
            this.chkCrew2.Name = "chkCrew2";
            this.chkCrew2.Size = new System.Drawing.Size(96, 29);
            this.chkCrew2.TabIndex = 7;
            this.chkCrew2.Text = "Crew 2";
            this.chkCrew2.UseVisualStyleBackColor = true;
            this.chkCrew2.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkCrew3
            // 
            this.chkCrew3.AutoSize = true;
            this.chkCrew3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrew3.Location = new System.Drawing.Point(1504, 471);
            this.chkCrew3.Name = "chkCrew3";
            this.chkCrew3.Size = new System.Drawing.Size(96, 29);
            this.chkCrew3.TabIndex = 8;
            this.chkCrew3.Text = "Crew 3";
            this.chkCrew3.UseVisualStyleBackColor = true;
            this.chkCrew3.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkCrew4
            // 
            this.chkCrew4.AutoSize = true;
            this.chkCrew4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrew4.Location = new System.Drawing.Point(1504, 541);
            this.chkCrew4.Name = "chkCrew4";
            this.chkCrew4.Size = new System.Drawing.Size(96, 29);
            this.chkCrew4.TabIndex = 9;
            this.chkCrew4.Text = "Crew 4";
            this.chkCrew4.UseVisualStyleBackColor = true;
            this.chkCrew4.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkCALFIREInCamp
            // 
            this.chkCALFIREInCamp.AutoSize = true;
            this.chkCALFIREInCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCALFIREInCamp.Location = new System.Drawing.Point(1504, 611);
            this.chkCALFIREInCamp.Name = "chkCALFIREInCamp";
            this.chkCALFIREInCamp.Size = new System.Drawing.Size(201, 29);
            this.chkCALFIREInCamp.TabIndex = 10;
            this.chkCALFIREInCamp.Text = "CAL FIRE In Camp";
            this.chkCALFIREInCamp.UseVisualStyleBackColor = true;
            this.chkCALFIREInCamp.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkCdcr
            // 
            this.chkCdcr.AutoSize = true;
            this.chkCdcr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCdcr.Location = new System.Drawing.Point(1504, 681);
            this.chkCdcr.Name = "chkCdcr";
            this.chkCdcr.Size = new System.Drawing.Size(91, 29);
            this.chkCdcr.TabIndex = 11;
            this.chkCdcr.Text = "CDCR";
            this.chkCdcr.UseVisualStyleBackColor = true;
            this.chkCdcr.CheckedChanged += new System.EventHandler(this.checkBoxHandler);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.Checked = true;
            this.chkAll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.Location = new System.Drawing.Point(1504, 121);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(56, 29);
            this.chkAll.TabIndex = 12;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = true;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // CampRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1725, 873);
            this.ControlBox = false;
            this.Controls.Add(this.chkAll);
            this.Controls.Add(this.chkCdcr);
            this.Controls.Add(this.chkCALFIREInCamp);
            this.Controls.Add(this.chkCrew4);
            this.Controls.Add(this.chkCrew3);
            this.Controls.Add(this.chkCrew2);
            this.Controls.Add(this.chkCrew1);
            this.Controls.Add(this.chkNonGrade);
            this.Controls.Add(this.chkGrade);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvCampRoster);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CampRoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Tag = "0";
            this.Text = "Camp Roster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.CampRoster_Activated);
            this.Load += new System.EventHandler(this.CampRoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCampRoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private pilotrockdataDataSet2 pilotrockdataDataSet2;
        private System.Windows.Forms.BindingSource inmateBindingSource2;
        private pilotrockdataDataSet2TableAdapters.inmateTableAdapter inmateTableAdapter2;
        private System.Windows.Forms.DataGridView dgvCampRoster;
        private System.Windows.Forms.BindingSource inmateBindingSource4;
        private System.Windows.Forms.BindingSource pilotrockdataDataSet2BindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn editInmate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cdcrNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gradeEligibleDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn housingNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn laundryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sawStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn flightWeightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ethnicityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eprdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn paroledDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn atCampDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn crewDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campJobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn specialStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialStatusTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox chkGrade;
        private System.Windows.Forms.CheckBox chkNonGrade;
        private System.Windows.Forms.CheckBox chkCrew1;
        private System.Windows.Forms.CheckBox chkCrew2;
        private System.Windows.Forms.CheckBox chkCrew3;
        private System.Windows.Forms.CheckBox chkCrew4;
        private System.Windows.Forms.CheckBox chkCALFIREInCamp;
        private System.Windows.Forms.CheckBox chkCdcr;
        private System.Windows.Forms.CheckBox chkAll;
        private System.Windows.Forms.Button btnClose;
    }
}