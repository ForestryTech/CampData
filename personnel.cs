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
    public partial class Personnel : Form
    {
        public enum Agency
        {
            calfire = 1,
            cdcr = 2,
            all = 3
        }

        private string queryString;
        public Personnel(Agency agency)
        {
            //string selectedAgency;
            InitializeComponent();
            //selectedAgency = (agency == Agency.calfire) ? "CALFIRE" : "CDCR";
            this.Tag = (int)agency;
            switch(agency)
            {
                case Agency.calfire:
                    queryString = "SELECT * FROM staff WHERE agency='CALFIRE'";
                    break;
                case Agency.cdcr:
                    queryString = "SELECT * FROM staff WHERE agency='CDCR'";
                    break;
                case Agency.all:
                    queryString = "SELECT * FROM staff";
                    break;
            }
            
            setUpDataGridView();
        }
        private void setUpDataGridView()
        {
            dgvStaff.DataSource = null;
            Counts counts = new Counts();
            dgvStaff.DataSource = counts.StaffRoster(queryString);
            dgvStaff.DataMember = "staff";
        }

        private void personnel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pilotrockdataDataSet.staff' table. You can move, or remove it, as needed.
            //this.staffTableAdapter.Fill(this.pilotrockdataDataSet.staff);

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            DialogResult result;
            if (e.ColumnIndex < 0) return;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string action = e.ColumnIndex == 1 ? "Edit" : "Remove";
                //result = MessageBox.Show(dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString(), "Selected Staff to " + action);
                // Edit staff member
                if (e.ColumnIndex == 1)
                {
                    AddEditStaff editStaff = new AddEditStaff((int)dgvStaff.Rows[e.RowIndex].Cells[0].Value, AddEditStaff.FormMode.Edit);
                    editStaff.ShowDialog();
                }
                else // Remove staff member * Should really never have to remove a staff member.
                {

                }

                setUpDataGridView();
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            AddEditStaff addStaff = new AddEditStaff(0, AddEditStaff.FormMode.Add);
            addStaff.ShowDialog();
            setUpDataGridView();
        }
    }
}
