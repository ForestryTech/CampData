namespace CampData
{
    partial class FormVehicle
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
            this.dgvVehicleRoster = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.xNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radioNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove = new System.Windows.Forms.DataGridViewButtonColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pilotrockdataDataSet2 = new CampData.pilotrockdataDataSet2();
            this.pilotrockdataDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleTableAdapter = new CampData.pilotrockdataDataSet2TableAdapters.vehicleTableAdapter();
            this.btnAddVehicle = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRoster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicleRoster
            // 
            this.dgvVehicleRoster.AllowUserToAddRows = false;
            this.dgvVehicleRoster.AllowUserToDeleteRows = false;
            this.dgvVehicleRoster.AutoGenerateColumns = false;
            this.dgvVehicleRoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehicleRoster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.Edit,
            this.xNumberDataGridViewTextBoxColumn,
            this.radioNumberDataGridViewTextBoxColumn,
            this.Remove});
            this.dgvVehicleRoster.DataSource = this.vehicleBindingSource;
            this.dgvVehicleRoster.Location = new System.Drawing.Point(36, 48);
            this.dgvVehicleRoster.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVehicleRoster.Name = "dgvVehicleRoster";
            this.dgvVehicleRoster.ReadOnly = true;
            this.dgvVehicleRoster.Size = new System.Drawing.Size(616, 393);
            this.dgvVehicleRoster.TabIndex = 0;
            this.dgvVehicleRoster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVehicleRoster_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit Vehicle";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // xNumberDataGridViewTextBoxColumn
            // 
            this.xNumberDataGridViewTextBoxColumn.DataPropertyName = "xNumber";
            this.xNumberDataGridViewTextBoxColumn.HeaderText = "X Number";
            this.xNumberDataGridViewTextBoxColumn.Name = "xNumberDataGridViewTextBoxColumn";
            this.xNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.xNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // radioNumberDataGridViewTextBoxColumn
            // 
            this.radioNumberDataGridViewTextBoxColumn.DataPropertyName = "radioNumber";
            this.radioNumberDataGridViewTextBoxColumn.HeaderText = "Radio Number";
            this.radioNumberDataGridViewTextBoxColumn.Name = "radioNumberDataGridViewTextBoxColumn";
            this.radioNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.radioNumberDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove Vehicle";
            this.Remove.Name = "Remove";
            this.Remove.ReadOnly = true;
            this.Remove.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Remove.Text = "Remove";
            this.Remove.UseColumnTextForButtonValue = true;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "vehicle";
            this.vehicleBindingSource.DataSource = this.pilotrockdataDataSet2;
            // 
            // pilotrockdataDataSet2
            // 
            this.pilotrockdataDataSet2.DataSetName = "pilotrockdataDataSet2";
            this.pilotrockdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pilotrockdataDataSet2BindingSource
            // 
            this.pilotrockdataDataSet2BindingSource.DataSource = this.pilotrockdataDataSet2;
            this.pilotrockdataDataSet2BindingSource.Position = 0;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // btnAddVehicle
            // 
            this.btnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddVehicle.Location = new System.Drawing.Point(705, 48);
            this.btnAddVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddVehicle.Name = "btnAddVehicle";
            this.btnAddVehicle.Size = new System.Drawing.Size(145, 36);
            this.btnAddVehicle.TabIndex = 1;
            this.btnAddVehicle.Text = "Add Vehicle";
            this.btnAddVehicle.UseVisualStyleBackColor = true;
            this.btnAddVehicle.Click += new System.EventHandler(this.BtnAddVehicle_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(705, 117);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(145, 36);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FormVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 597);
            this.ControlBox = false;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddVehicle);
            this.Controls.Add(this.dgvVehicleRoster);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormVehicle";
            this.Tag = "0";
            this.Text = "Vehicle Roster";
            this.Load += new System.EventHandler(this.FormVehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicleRoster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVehicleRoster;
        private System.Windows.Forms.BindingSource pilotrockdataDataSet2BindingSource;
        private pilotrockdataDataSet2 pilotrockdataDataSet2;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private pilotrockdataDataSet2TableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.Button btnAddVehicle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn xNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn radioNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Remove;
    }
}