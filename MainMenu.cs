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
    public partial class MainMenu : Form
    {

        protected campSnapShot snapShot;
        protected CampRoster roster;
        public MainMenu()
        {
            InitializeComponent();
            snapShot = new campSnapShot(this);
            snapShot.MdiParent = this;
            snapShot.Dock = DockStyle.Fill;
            snapShot.Show();
            snapShot.Text = "Camp count as of: " + DateTime.Now.ToShortDateString();
        }
        public delegate void CampRosterUpdatedEventHandler(object sender, EventArgs e);
        public event CampRosterUpdatedEventHandler CampRosterUpdated;

        protected virtual void OnCampRosterUpdated()
        {
            if(CampRosterUpdated != null)
            {
                CampRosterUpdated(this, EventArgs.Empty);
            }
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CampRosterMenu_Click(object sender, EventArgs e)
        {
            roster = (CampRoster)isFormOpen(0, "CampRoster");
            if(roster != null)
            {
                roster.BringToFront();
                roster.WindowState = FormWindowState.Maximized;
            }
            else
            {
                roster = new CampRoster();
                roster.MdiParent = this;
                //campRosterToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
                roster.DataGridUpdated += Roster_DataGridUpdated;
                roster.Dock = DockStyle.Fill;
                roster.Show(); 
            }
        }

        private void Roster_DataGridUpdated(object sender, EventArgs e)
        {
            //snapShot.getCounts();
            OnCampRosterUpdated();
        }
        private void CampSnapShotMenu_Click(object sender, EventArgs e)
        {
            
            snapShot.BringToFront();
        }

        private void OpenCampPersonnel(object sender, EventArgs e)
        {
            ToolStripMenuItem agencyPersonnel = (ToolStripMenuItem)sender;
            int crew = int.Parse(agencyPersonnel.Tag.ToString());
            //Console.WriteLine("Open Forms: " + Application.OpenForms.Count);
            Form form = isFormOpen(crew, "Personnel");
            if (form != null)
            {
                //DialogResult dialogResult = MessageBox.Show("Hookline for crew " + crew.ToString() + " is already Open!", "Open Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                form.BringToFront();
            }
            else
            {
                Personnel campPersonnel = new Personnel((Personnel.Agency)crew);
                campPersonnel.MdiParent = this;
                campPersonnel.Dock = DockStyle.Fill;
                campPersonnel.Show();
            }
        }

        private void OpenVehiclesForm(object sender, EventArgs e)
        {
            Form form = isFormOpen(0, "FormVehicle");
            if(form != null)
            {
                form.BringToFront();
            }
            else
            {
                FormVehicle formVehicle = new FormVehicle();
                formVehicle.MdiParent = this;
                formVehicle.Dock = DockStyle.Fill;
                formVehicle.Show(); 
            }
        }

        private Form isFormOpen(int crew, string formName)
        {
            foreach(Form form in Application.OpenForms)
            {
                //Console.WriteLine(form.Name);
                if (formName == form.Name && crew == int.Parse(form.Tag.ToString()))
                {
                    //Console.WriteLine(formName + " for crew " + crew.ToString() + " is open.");
                    return form;
                }
            }
            return null;
        }

        private void OpenHookline(object sender, EventArgs e)
        {
            ToolStripMenuItem hookLine = (ToolStripMenuItem)sender;
            int crew = int.Parse(hookLine.Tag.ToString());
            //Console.WriteLine("Open Forms: " + Application.OpenForms.Count);
            Form form = isFormOpen(crew, "crewForm");
            if (form != null)
            {
                //DialogResult dialogResult = MessageBox.Show("Hookline for crew " + crew.ToString() + " is already Open!", "Open Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                form.BringToFront();
            }
            else
            {
                crewForm crewform = new crewForm((crewForm.CrewNumber)crew);
                crewform.MdiParent = this;
                crewform.Dock = DockStyle.Fill;
                crewform.Text = "PLT " + crew.ToString();
                crewform.Show();
            }
        }

        private void OpenSeatingChart(object sender, EventArgs e)
        {
           
            ToolStripMenuItem seating = (ToolStripMenuItem)sender;
            int crew = int.Parse(seating.Tag.ToString());
            Form form = isFormOpen(crew, "FormSeatingChart");
            if (form != null)
            {
                //DialogResult dialogResult = MessageBox.Show("Seating Chart for " + crew.ToString() + " is already Open!", "Open Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                form.BringToFront();
            }
            else
            {
                FormSeatingChart formSeatingChart = new FormSeatingChart(crew);
                formSeatingChart.MdiParent = this;
                formSeatingChart.Dock = DockStyle.Fill;
                formSeatingChart.Show();
            }
        }


        private void BugCrewRoster_Click(object sender, EventArgs e)
        {

        }
        private void PersonnelMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuTag = (ToolStripMenuItem)sender;
            int crew = int.Parse(menuTag.Tag.ToString());
            OpenForm(crew, "Personnel");
        }
        private void VehicleMenu_Click(object sender, EventArgs e)
        {
            OpenForm(0, "FormVehicle");
        }
        private void HooklineMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuTag = (ToolStripMenuItem)sender;
            int crew = int.Parse(menuTag.Tag.ToString());
            OpenForm(crew, "crewForm");
        }
        private void SeatingChartMenu_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuTag = (ToolStripMenuItem)sender;
            int crew = int.Parse(menuTag.Tag.ToString());
            OpenForm(crew, "FormSeatingChart");
        }
        private void OpenForm(int id, string formName)
        {
            Form formToOpen = null;
            Form form = isFormOpen(id, formName);
            if(form != null)
            {
                form.BringToFront();
            }
            else
            {
                switch(formName)
                {
                    case "crewForm":
                        formToOpen = new crewForm((crewForm.CrewNumber)id);
                        formToOpen.Text = "PLT " + id.ToString();
                        break;
                    case "FormSeatingChart":
                        formToOpen = new FormSeatingChart(id);
                        formToOpen.Text = "PLT " + id.ToString();
                        break;
                    case "FormVehicle":
                        formToOpen = new FormVehicle();
                        break;
                    case "Personnel":
                        formToOpen = new Personnel((Personnel.Agency)id);
                        break;
                    case "CampRoster":

                        break;
                }
                if (formToOpen != null)
                {
                    formToOpen.MdiParent = this;
                    formToOpen.Dock = DockStyle.Fill;
                    formToOpen.Show();
                }
            }
        }
    }
}
