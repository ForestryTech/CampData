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
    public partial class CampRoster : Form
    {
        enum AddRemove
        {
            Add = 1,
            Remove = 2
        }

        public delegate void DataGridUpdatedEventHandler(object sender, EventArgs e);
        public event DataGridUpdatedEventHandler DataGridUpdated;

        private string queryString;
        private List<string> grade;
        private List<string> crew;

        public CampRoster()
        {
            InitializeComponent();
        }

        private void CampRoster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pilotrockdataDataSet2.inmate' table. You can move, or remove it, as needed.

            //this.inmateTableAdapter2.Fill(this.pilotrockdataDataSet2.inmate);


            //this.inmateTableAdapter2.FillBy(this.pilotrockdataDataSet2.inmate);
            /*

            
            dgvCampRoster.DataSource = ds;
            dgvCampRoster.DataMember = "inmate";
            */
            grade = new List<string>();
            crew = new List<string>();
            queryString = "SELECT * FROM inmate WHERE paroled=false";
            /*Counts counts = new Counts();
            dgvCampRoster.DataSource = counts.CampRoster(queryString);
            dgvCampRoster.DataMember = "inmate";*/
            setUpDataGridView();

        }

        protected virtual void OnDataGridUpdated()
        {
            if(DataGridUpdated != null)
            {
                DataGridUpdated(this, EventArgs.Empty);
            }
        }

        private void setUpDataGridView()
        {
            dgvCampRoster.DataSource = null;
            Counts counts = new Counts();
            dgvCampRoster.DataSource = counts.CampRoster(queryString);
            dgvCampRoster.DataMember = "inmate";
        }





        private void dgvCampRoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            DataGridView senderGrid = (DataGridView)sender;
            //DialogResult result;
            if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                //result = MessageBox.Show(dgvCampRoster.Rows[e.RowIndex].Cells[0].Value.ToString(), "Selected Inmate");
                AddEditInmate editInmate = new AddEditInmate((int)dgvCampRoster.Rows[e.RowIndex].Cells[0].Value, AddEditInmate.FormMode.Edit);
                editInmate.AddEditInmateUpdated += AddInmate_AddEditInmateUpdated;
 
                editInmate.ShowDialog();
                setUpDataGridView();
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditInmate addInmate = new AddEditInmate(0, AddEditInmate.FormMode.Add);
            //addInmate.Show();
            //this.Close();
            
            addInmate.AddEditInmateUpdated += AddInmate_AddEditInmateUpdated;
            addInmate.ShowDialog();
        }

        private void AddInmate_AddEditInmateUpdated(object sender, EventArgs e)
        {
            //Console.WriteLine("Event from AddEditInmate recieved! Raising event in CampRoster! With Changes for Caleb!");
            OnDataGridUpdated();
        }

        private void checkBoxHandler(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if(chkAll.Checked)
            {
                chkGrade.Checked = false;
                chkNonGrade.Checked = false;
                chkCrew1.Checked = false;
                chkCrew2.Checked = false;
                chkCrew3.Checked = false;
                chkCrew4.Checked = false;
                chkCALFIREInCamp.Checked = false;
                chkCdcr.Checked = false;
                return;
            }
            switch (checkBox.Name)
            {
                case "chkGrade":
                    if (checkBox.Checked) grade.Add("gradeEligible=true");
                    if (!checkBox.Checked) grade.Remove("gradeEligible=true");
                    break;
                case "chkNonGrade":
                    if (checkBox.Checked) grade.Add("gradeEligible=false");
                    if (!checkBox.Checked) grade.Remove("gradeEligible=false");
                    break;
                case "chkCrew1":
                    if (checkBox.Checked) crew.Add("crew='1'");
                    if (!checkBox.Checked) crew.Remove("crew='1'");
                    break;
                case "chkCrew2":
                    if (checkBox.Checked) crew.Add("crew='2'");
                    if (!checkBox.Checked) crew.Remove("crew='2'");
                    break;
                case "chkCrew3":
                    if (checkBox.Checked) crew.Add("crew='3'");
                    if (!checkBox.Checked) crew.Remove("crew='3'");
                    break;
                case "chkCrew4":
                    if (checkBox.Checked) crew.Add("crew='4'");
                    if (!checkBox.Checked) crew.Remove("crew='4'");
                    break;
                case "chkCALFIREInCamp":
                    if (checkBox.Checked) crew.Add("crew='CALFIRE'");
                    if (!checkBox.Checked) crew.Remove("crew='CALFIRE'");
                    break;
                case "chkCdcr":
                    if (checkBox.Checked) crew.Add("crew='CDCR'");
                    if (!checkBox.Checked) crew.Remove("crew='CDCR'");
                    break;
            }

            queryBuilder();
            setUpDataGridView();
        }

        private void queryBuilder()
        {
            string qString = "SELECT * FROM inmate WHERE paroled=false";
            if(grade.Count != 0)
            {
                foreach(string q in grade)
                {
                    qString += " AND " + q;
                }
            }

            if(crew.Count != 0)
            {
                qString += " AND ";
                qString += crew[0];
                for(int i = 1; i < crew.Count; i++)
                {
                    qString += " OR " + crew[i];
                }
            }
            queryString = qString;
            Console.WriteLine(queryString);
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
            {
                queryString = "SELECT * FROM inmate WHERE paroled=false";
                setUpDataGridView();
                crew.Clear();
                grade.Clear();
                chkGrade.Checked = false;
                chkNonGrade.Checked = false;
                chkCrew1.Checked = false;
                chkCrew2.Checked = false;
                chkCrew3.Checked = false;
                chkCrew4.Checked = false;
                chkCALFIREInCamp.Checked = false;
                chkCdcr.Checked = false;
            }
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("CampRoster Closing! Raising an event!");
            OnDataGridUpdated();
            this.Close();
        }

        private void CampRoster_Activated(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Focus activated!");
        }
    }
}
