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
    public partial class AddEditInmate : Form
    {

        private InmateData inmate;
        private bool formChanged;

        public enum FormMode
        {
            Add = 1,
            Edit = 2
        }

        private FormMode formMode;

        public delegate void AddEditInmateUpdatedEventHandler(object sender, EventArgs e);
        public event AddEditInmateUpdatedEventHandler AddEditInmateUpdated;
        


        public AddEditInmate(int id, FormMode mode)
        {
            InitializeComponent();
            inmate = new InmateData();
            inmate.CampDataUpdated += Inmate_CampDataUpdated;
            formMode = mode;
            if(mode == FormMode.Edit)
            {
                lblCaption.Text = "Edit Inmate Information";
                this.Text = "Edit Inmate Information";
                inmate.GetData(id);
                addData();
                cboParoled.SelectedItem = "No";
                
            } else
            {
                lblCaption.Text = "Add Inmate to Database";
                this.Text = "Add Inmate Information";
                cboSawStatus.SelectedItem = "None";
                cboParoled.SelectedItem = "No";
            }
            lblDataSaved.Visible = false;
            formChanged = false;

        }

        // Event Methods
        private void Inmate_CampDataUpdated(object sender, EventArgs e)
        {
            Console.WriteLine("Event from InmateData raised, raising event in AddEditInmate!");
            OnAddEditInmateUpdated();
        }

        protected virtual void OnAddEditInmateUpdated()
        {
            if (AddEditInmateUpdated != null)
            {
                AddEditInmateUpdated(this, EventArgs.Empty);
            }
        }

        // Methods that add data to form or get data from form and add to database
        private void addData()
        {
            txtLastName.Text = inmate.LastName;
            txtFirstName.Text = inmate.FirstName;
            txtCdcrNumber.Text = inmate.CDCRNumber;
            txtLaundryNumber.Text = inmate.LaundryNumber;
            txtHousingNumber.Text = inmate.HousingNumber;
            txtFlightWeight.Text = inmate.FlightWeight;
            cboGradeEligible.Text = inmate.GradeEligible;
            cboCrew.Text = inmate.Crew;
            cboCrewmemberType.Text = inmate.Job;
            cboCrewJob.Text = inmate.CampJob;
            cboSawStatus.Text = inmate.SawStatus;
            cboEthnicity.Text = inmate.Ethnicity;
            dtEprd.Value = inmate.EPRD == null ? DateTime.Now : (DateTime)inmate.EPRD;
            cboSpecialStatus.Text = inmate.SpecialStatus;
            txtSpecialStatusText.Text = inmate.SpecialStausText;
            cboAtCamp.Text = inmate.AtCamp;
            loadComboAfterAdd();
        }

        private void getData()
        {
            inmate.LastName = txtLastName.Text;
            inmate.FirstName = txtFirstName.Text;
            inmate.CDCRNumber = txtCdcrNumber.Text;
            inmate.LaundryNumber = txtLaundryNumber.Text;
            inmate.HousingNumber = txtHousingNumber.Text;
            inmate.FlightWeight = txtFlightWeight.Text;
            inmate.GradeEligible = cboGradeEligible.Text;
            inmate.Crew = cboCrew.Text;
            inmate.Job = cboCrewmemberType.Text;
            inmate.CampJob = cboCrewJob.Text;
            inmate.SawStatus = cboSawStatus.Text;
            inmate.Ethnicity = cboEthnicity.Text;
            inmate.EPRD = dtEprd.Value.Date;
            inmate.SpecialStatus = cboSpecialStatus.Text;
            inmate.SpecialStausText = txtSpecialStatusText.Text;
            inmate.AtCamp = cboAtCamp.Text;
            inmate.Paroled = cboParoled.Text;

        }
        // Combo box change Methods to load other combo boxes
        private void loadJobAndTypeComboBox()
        {
            switch (cboCrew.Text)
            {
                case "1":
                case "2":
                case "3":
                    cboCrewmemberType.Items.Add("Grade");
                    cboCrewmemberType.SelectedItem = "Grade";
                    cboCrewJob.Items.Clear();
                    cboCrewJob.Items.Add("Saw Team");
                    cboCrewJob.Items.Add("Tool Member");
                    cboCrewJob.Items.Add("Dragspoon");
                    cboCrewJob.Items.Add("Swamper");
                    break;
                case "4":
                    cboCrewmemberType.Items.Add("Camp");
                    cboCrewmemberType.Items.Add("Bug Crew");
                    break;
                case "CAL FIRE":
                case "CDCR":
                    cboCrewmemberType.Items.Add("Camp");
                    cboCrewmemberType.SelectedItem = "Camp";
                    cboCrewJob.Items.Clear();
                    cboCrewJob.Items.Add("Saw Shop");
                    cboCrewJob.Items.Add("Maintenance");
                    cboCrewJob.Items.Add("Sew Shop");
                    cboCrewJob.Items.Add("Mechanic");
                    cboCrewJob.Items.Add("Wastewater");
                    cboCrewJob.Items.Add("Welder");
                    cboCrewJob.Items.Add("Wherehouse");
                    cboCrewJob.Items.Add("Gasman");
                    cboCrewJob.Items.Add("Carpenter");
                    cboCrewJob.Items.Add("Gardener");
                    cboCrewJob.Items.Add("Utility");
                    cboCrewJob.Items.Add("Dishwasher");
                    cboCrewJob.Items.Add("Porter");
                    cboCrewJob.Items.Add("Clerk");
                    cboCrewJob.Items.Add("Cook");
                    break;
                default:
                    cboCrewmemberType.Items.Add("Grade");
                    cboCrewmemberType.Items.Add("Camp");
                    cboCrewmemberType.Items.Add("Bug Crew");
                    break;
            }
        }
        private void loadComboAfterAdd()
        {
            DialogResult result = MessageBox.Show(cboGradeEligible.Text, "Combo Grade");
            cboCrew.Items.Add("CALFIRE");
            cboCrew.Items.Add("CDCR");
            if (cboGradeEligible.Text == "Yes")
            {
                cboCrew.Items.Add("1");
                cboCrew.Items.Add("2");
                cboCrew.Items.Add("3");
                cboCrew.Items.Add("4");
            }

            loadJobAndTypeComboBox();
        }

        private void cboGradeEligible_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show(cboGradeEligible.SelectedItem.ToString(), "Selected Item");
            cboCrew.Items.Clear();
            cboCrew.Text = "";
            cboCrew.Items.Add("CDCR");
            cboCrew.Items.Add("CAL FIRE");
            if (cboGradeEligible.Text.ToString() == "Yes")
            {
                cboCrew.Items.Add("1");
                cboCrew.Items.Add("2");
                cboCrew.Items.Add("3");
                cboCrew.Items.Add("4");
            }

            setFormChanged();
        }

        private void cboCrew_SelectionChangeCommitted(object sender, EventArgs e)
        {
            setFormChanged();
            cboCrewmemberType.Items.Clear();
            cboCrewmemberType.Text = "";
            cboCrewJob.Items.Clear();
            cboCrewJob.Text = "";

            loadJobAndTypeComboBox();
 
        }

        private void cboCrewmemberType_SelectedIndexChanged(object sender, EventArgs e)
        {
            setFormChanged();
            switch (cboCrewmemberType.SelectedItem.ToString())
            {
                case "Bug Crew":
                    cboCrewJob.Items.Clear();
                    cboCrewJob.Text = "";
                    cboCrewJob.Items.Add("Saw Shop");
                    cboCrewJob.SelectedItem = "Saw Shop";
                    break;
                case "Camp":
                    cboCrewJob.Items.Clear();
                    cboCrewJob.Text = "";
                    cboCrewJob.Items.Add("Saw Shop");
                    cboCrewJob.Items.Add("Maintenance");
                    cboCrewJob.Items.Add("Sew Shop");
                    cboCrewJob.Items.Add("Mechanic");
                    cboCrewJob.Items.Add("Wastewater");
                    cboCrewJob.Items.Add("Welder");
                    cboCrewJob.Items.Add("Wherehouse");
                    cboCrewJob.Items.Add("Gasman");
                    cboCrewJob.Items.Add("Carpenter");
                    cboCrewJob.Items.Add("Gardener");
                    cboCrewJob.Items.Add("Utility");
                    cboCrewJob.Items.Add("Dishwasher");
                    cboCrewJob.Items.Add("Porter");
                    cboCrewJob.Items.Add("Clerk");
                    cboCrewJob.Items.Add("Cook");
                    break;
                case "Grade":
                    cboCrewJob.Items.Clear();
                    cboCrewJob.Items.Add("Saw Team");
                    cboCrewJob.Items.Add("Tool Member");
                    cboCrewJob.Items.Add("Dragspoon");
                    cboCrewJob.Items.Add("Swamper");
                    break;
                default:
                    break;
            }
        }

        private void cboParoled_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboParoled.SelectedItem.ToString() == "Yes")
            {
                DialogResult result = MessageBox.Show("By selecting 'Yes' you are indicating that this inmate has paroled. By saving this data, this inmate will no longer appear on the Camp Roster.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Method that will clear the form
        private void clearForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCdcrNumber.Text = "";
        }
        // Button Methods

        private void btnSave_Click(object sender, EventArgs e)
        {
            getData();
            if (!formChanged)
            {
                DialogResult result = MessageBox.Show("Nothing to Save!", "No Changes");
            }
            else
            {
                if(formMode == FormMode.Add)
                {
                    if (inmate.WriteData() == InmateData.SaveStatus.Succsess)
                    {
                        lblDataSaved.ForeColor = System.Drawing.Color.LimeGreen;
                        lblDataSaved.Text = "Data saved for inmate: " + inmate.LastName + ", " + inmate.FirstName + " - CDCR #: " + inmate.CDCRNumber;
                    }
                    else
                    {
                        lblDataSaved.ForeColor = System.Drawing.Color.Red;
                        lblDataSaved.Text = "There was an error while save data for inmate: " + inmate.LastName + ", " + inmate.FirstName + " - CDCR #: " + inmate.CDCRNumber;
                    }
                }
                else
                {
                    if(inmate.Crew != (string)cboCrew.SelectedValue)
                    {
                        Crew.RemoveFromCrew(inmate.Id, int.Parse(inmate.Crew));
                    }
                    if (inmate.UpdateData() == InmateData.SaveStatus.Succsess)
                    {
                        lblDataSaved.ForeColor = System.Drawing.Color.LimeGreen;
                        lblDataSaved.Text = "Data updated for inmate: " + inmate.LastName + ", " + inmate.FirstName + " - CDCR #: " + inmate.CDCRNumber;
                    }
                    else
                    {
                        lblDataSaved.ForeColor = System.Drawing.Color.Red;
                        lblDataSaved.Text = "There was an error while updating data for inmate: " + inmate.LastName + ", " + inmate.FirstName + " - CDCR #: " + inmate.CDCRNumber;
                    }
                }
            }
            
            lblDataSaved.Visible = true;
            //OnAddEditInmateUpdated();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Crew.RemoveFromCrew(48, 1);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //CampRoster campRoster = new CampRoster();
            
            //campRoster.Show();
            //campRoster.Refresh();
            this.Close();
        }

        // Methods that set formChanged to true
        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            setFormChanged();
        }

        private void setFormChanged()
        {
            formChanged = true;
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {
            setFormChanged();
        }

    }
}
