using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CampData
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            //InmateData listItems = new InmateData();
            inmate = new InmateData();
            InitializeComponent();
            

        }
        InmateData inmate;


        private void button1_Click(object sender, EventArgs e)
        {
            InmateData i = new InmateData();
            
            i.GetData(7);
            Console.WriteLine("EPRD: " + i.EPRD);
            Console.WriteLine("Saw Status: " + i.SawStatus);
            Console.WriteLine("Grade Eligible: " + i.GradeEligible);
            Console.WriteLine("Special Status: " + i.SawStatus);
            i = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            InmateData i = new InmateData();
            
            getCounts();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //InmateData i = new InmateData();

            inmate.GetData(92);
            inmate.CDCRNumber = "ZZ-1234";
            inmate.FirstName = "J";
            inmate.LastName = "Beckam";
            inmate.UpdateData();
            //i = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InmateData i = new InmateData();
            i.GetData(7);
            i.CDCRNumber = "ZZ-4321";
            i.FirstName = "PacMan";
            i.LastName = "Jones";
            i.WriteData();
            i = null;
        }




        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CampRoster campRoster = new CampRoster();
            campRoster.DataGridUpdated += CampRoster_DataGridUpdated;
            campRoster.Show();
            //label1.Text = c.GradeEligible.ToString();
        }

        private void CampRoster_DataGridUpdated(object sender, EventArgs e)
        {
            Console.WriteLine("Event from CampRoster recieved! Updating counts!");
            getCounts();
            this.Invalidate();
        }

        private void getCounts()
        {
            Counts counts = new Counts();
            if(counts.Crew1 < 12)
            {
                lblPlt1Count.ForeColor = System.Drawing.Color.Red;
            } else
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
