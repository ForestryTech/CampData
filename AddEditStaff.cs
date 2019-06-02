using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampData
{
    public partial class AddEditStaff : Form
    {

        private bool formChanged;
        private Staff staff;
        private FormMode formMode;

        public enum FormMode
        {
            Add = 1,
            Edit = 2
        }
        public AddEditStaff(int id, FormMode formMode)
        {
            InitializeComponent();
            loadComboBox();
            this.formMode = formMode;
            if (formMode == FormMode.Add)
            {
                staff = new Staff();
                lblCaption.Text = "Add Staff Memeber to database";
            } else
            {
                
                staff = new Staff(id);
                staff.GetData(id);
                addData();
                lblCaption.Text = "Edit Staff Member information";
            }
            lblSaveStatus.Visible = false;
            formChanged = false;
        }

        private void loadComboBox()
        {
            cboAgency.Items.Add("CALFIRE");
            cboAgency.Items.Add("CDCR");

            cboPosition.Items.Add("Captain");
            cboPosition.Items.Add("Officer");
            cboPosition.Items.Add("DC");
            cboPosition.Items.Add("BC");
            cboPosition.Items.Add("Lieutenant");
            cboPosition.Items.Add("Sergant");
        }
        private void FormChanged(object sender, EventArgs e)
        {
            formChanged = true;
        }

        private void addData()
        {
            txtFname.Text = staff.FirstName;
            txtLname.Text = staff.LastName;
            cboAgency.Text = staff.Agency;
            cboPosition.Text = staff.Position;
            chkTypeOne.Checked = staff.Type1;
        }

        private void getData()
        {
            staff.FirstName = txtFname.Text;
            staff.LastName = txtLname.Text;
            staff.Agency = cboAgency.Text;
            staff.Position = cboPosition.Text;
            staff.Type1 = chkTypeOne.Checked;
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            //DialogResult result = DialogResult.Yes;

            if (formChanged)
            {
                DialogResult result = MessageBox.Show("Form has not been save. Closing form will lose all changes. Are you sure you want to close the Form?", "Form not saved", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }
            this.Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            getData();
            if(!formChanged)
            {
                DialogResult result = MessageBox.Show("No changers have been made.", "Nothing To Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if(formMode == FormMode.Add)
                {
                    if(staff.AddData() == Staff.SaveStatus.Succsess)
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        lblSaveStatus.Text = "Data for " + staff.LastName + ", " + staff.FirstName + " has been saved.";
                    } else
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.Red;
                        lblSaveStatus.Text = "There was an error saving data for " + staff.LastName + ", " + staff.FirstName + ".";
                    }
                }
                else
                {
                    if(staff.UpdateData() == Staff.SaveStatus.Succsess)
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        lblSaveStatus.Text = "Data for " + staff.LastName + ", " + staff.FirstName + " has been saved.";
                    } else
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.Red;
                        lblSaveStatus.Text = "There was an error saving data for " + staff.LastName + ", " + staff.FirstName + ".";
                    }
                }
                lblSaveStatus.Visible = true;
                formChanged = false;
            }

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtFname.Text = "";
            txtLname.Text = "";
            cboAgency.Text = "";
            cboPosition.Text = "";
            chkTypeOne.Checked = false;
            lblSaveStatus.Visible = false;
            formChanged = false;
        }
    }
}
