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
    public partial class AddEditVehicle : Form
    {
        private bool formChanged;
        FormMode formMode;
        Vehicle vehicle;
        public enum FormMode
        {
            Add = 1,
            Edit = 2
        }
        private void FormChanged(object sender, EventArgs e)
        {
            formChanged = true;
        }
        public AddEditVehicle(int vehicleId, FormMode formMode)
        {
            InitializeComponent();
            this.formMode = formMode;
            if(this.formMode == FormMode.Add)
            {
                this.Text = "Add Vehicle";
                lblTitle.Text = "Add Vehicle to Roster";
                vehicle = new Vehicle();
            } else
            {
                this.Text = "Edit Vehicle";
                lblTitle.Text = "Edit Vehicle in Roster";
                vehicle = new Vehicle(vehicleId);
                addData();
            }
            lblSaveStatus.Visible = false;

        }

        private void getData()
        {
            vehicle.RadioId = txtVehicleId.Text;
            vehicle.Xnumber = txtVehicleXNumber.Text;
        }

        private void addData()
        {
            txtVehicleId.Text = vehicle.RadioId;
            txtVehicleXNumber.Text = vehicle.Xnumber;
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
            if (!formChanged)
            {
                DialogResult result = MessageBox.Show("No changers have been made.", "Nothing To Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (formMode == FormMode.Add)
                {
                    if (vehicle.AddData() == Vehicle.SaveStatus.Succsess)
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        lblSaveStatus.Text = "Data for " + vehicle.RadioId + " has been saved.";
                    }
                    else
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.Red;
                        lblSaveStatus.Text = "There was an error saving data for " + vehicle.RadioId + ".";
                    }
                }
                else
                {
                    if (vehicle.UpdateData() == Vehicle.SaveStatus.Succsess)
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.LimeGreen;
                        lblSaveStatus.Text = "Data for " + vehicle.RadioId + " has been saved.";
                    }
                    else
                    {
                        lblSaveStatus.ForeColor = System.Drawing.Color.Red;
                        lblSaveStatus.Text = "There was an error saving data for " + vehicle.RadioId + ".";
                    }
                }
                lblSaveStatus.Visible = true;
                formChanged = false;
            }
        }
    }
}
