namespace CampData
{
    partial class hookline
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
            this.pilotrockdataDataSet2 = new CampData.pilotrockdataDataSet2();
            this.inmateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmateTableAdapter = new CampData.pilotrockdataDataSet2TableAdapters.inmateTableAdapter();
            this.pilotrockdataDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inmateBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pilotrockdataDataSet2BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inmateBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // pilotrockdataDataSet2
            // 
            this.pilotrockdataDataSet2.DataSetName = "pilotrockdataDataSet2";
            this.pilotrockdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inmateBindingSource
            // 
            this.inmateBindingSource.DataMember = "inmate";
            this.inmateBindingSource.DataSource = this.pilotrockdataDataSet2;
            // 
            // inmateTableAdapter
            // 
            this.inmateTableAdapter.ClearBeforeFill = true;
            // 
            // pilotrockdataDataSet2BindingSource
            // 
            this.pilotrockdataDataSet2BindingSource.DataSource = this.pilotrockdataDataSet2;
            this.pilotrockdataDataSet2BindingSource.Position = 0;
            // 
            // inmateBindingSource1
            // 
            this.inmateBindingSource1.DataMember = "inmate";
            this.inmateBindingSource1.DataSource = this.pilotrockdataDataSet2BindingSource;
            // 
            // pilotrockdataDataSet2BindingSource1
            // 
            this.pilotrockdataDataSet2BindingSource1.DataSource = this.pilotrockdataDataSet2;
            this.pilotrockdataDataSet2BindingSource1.Position = 0;
            // 
            // inmateBindingSource2
            // 
            this.inmateBindingSource2.DataMember = "inmate";
            this.inmateBindingSource2.DataSource = this.pilotrockdataDataSet2;
            // 
            // hookline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 684);
            this.Name = "hookline";
            this.Text = "hookline";
            this.Load += new System.EventHandler(this.hookline_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pilotrockdataDataSet2BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inmateBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private pilotrockdataDataSet2 pilotrockdataDataSet2;
        private System.Windows.Forms.BindingSource inmateBindingSource;
        private pilotrockdataDataSet2TableAdapters.inmateTableAdapter inmateTableAdapter;
        private System.Windows.Forms.BindingSource pilotrockdataDataSet2BindingSource;
        private System.Windows.Forms.BindingSource inmateBindingSource1;
        private System.Windows.Forms.BindingSource pilotrockdataDataSet2BindingSource1;
        private System.Windows.Forms.BindingSource inmateBindingSource2;
    }
}