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
    public partial class campSnapShot : Form
    {
        Counts counts;

        public campSnapShot(MainMenu mainMenu)
        {
            mainmenu = mainMenu;
            InitializeComponent();
            counts = new Counts();
            getCounts();
            mainmenu.CampRosterUpdated += Mainmenu_CampRosterUpdated;
            loadComboBoxes();
        }

        private void Mainmenu_CampRosterUpdated(object sender, EventArgs e)
        {
            getCounts();
            Console.WriteLine("campSnapShot Event recieved! Updating Form");
        }

        MainMenu mainmenu;

        
        public void getCounts()
        {
            //Counts counts = new Counts();
            if (counts.Crew1 < 12)
            {
                lblPlt1Count.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPlt1Count.ForeColor = new System.Drawing.Color();
            }

            lblPlt1Count.Text = counts.Crew1.ToString();

            if (counts.Crew2 < 12)
            {
                lblPlt2Count.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPlt2Count.ForeColor = new System.Drawing.Color();
            }

            lblPlt2Count.Text = counts.Crew2.ToString();

            if (counts.Crew3 < 12)
            {
                lblPlt3Count.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPlt3Count.ForeColor = new System.Drawing.Color();
            }

            lblPlt3Count.Text = counts.Crew3.ToString();

            if (counts.Crew4 < 12)
            {
                lblPlt4Count.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                lblPlt4Count.ForeColor = new System.Drawing.Color();
            }

            lblPlt4Count.Text = counts.Crew4.ToString();

            lblPlt5Count.Text = counts.BugCrew.ToString();
            lblCalFireGradeInCampGrade.Text = counts.CALFIREGradeInCamp.ToString();
            lblCalFireInCampNonGrade.Text = counts.CALFIRENonGradeInCamp.ToString();
            lblTotalCalFireInCamp.Text = counts.CALFIREInCamp.ToString();
            lblCdcrInCamp.Text = counts.CDCRInCamp.ToString();
            lblSpecialStatusGrade.Text = counts.SpecialStatusGrade.ToString();
            lblSpecialStatusNonGrade.Text = counts.SpecialStatusNonGrade.ToString();
            lblTotalSpecialStatus.Text = (counts.SpecialStatusGrade + counts.SpecialStatusNonGrade).ToString();
            lblCampTotal.Text = counts.TotalAtCamp.ToString();
            lblGradeEligibleCount.Text = counts.GradeEligible.ToString();
            lblNonGradeCount.Text = counts.NonGrade.ToString();
        }

        private void loadComboBoxes()
        {
            string captain = "cboC";
            string vehicle = "cboV";
            ComboBox comboBox;
            string comboName;
            for (int i = 1; i <= 5; i++)
            {
                comboName = captain + i.ToString();

                comboBox = (ComboBox)this.grpWorkLocations.Controls[comboName];
                loadCaptainCombo(comboBox);


                comboName = vehicle + i.ToString();
                comboBox = (ComboBox)this.grpWorkLocations.Controls[comboName];
                loadVehicleCombo(comboBox);
            }
        }

        private void loadCaptainCombo(ComboBox cbo)
        {
            cbo.DataSource = counts.FillStaffCombo("CALFIRE");
            cbo.DisplayMember = "FullName";
            cbo.ValueMember = "Id";
            cbo.FormattingEnabled = true;
            cbo.SelectedValue = 0; 
        }

        private void loadVehicleCombo(ComboBox cbo)
        {
            cbo.DataSource = counts.FillVehicleCombo();
            cbo.DisplayMember = "RadioId";
            cbo.ValueMember = "Id";
            cbo.SelectedValue = 0;
        }

    }
}
