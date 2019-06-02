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
    public partial class FormVehicle : Form
    {
        public FormVehicle()
        {
            InitializeComponent();
        }

        private void FormVehicle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pilotrockdataDataSet2.vehicle' table. You can move, or remove it, as needed.
            //this.vehicleTableAdapter.Fill(this.pilotrockdataDataSet2.vehicle);
            setUpDataGridView();
        }

        private void setUpDataGridView()
        {
            dgvVehicleRoster.DataSource = null;
            Counts counts = new Counts();
            dgvVehicleRoster.DataSource = counts.VehicleRoster("SELECT * FROM [vehicle]");
            dgvVehicleRoster.DataMember = "vehicle";
        }
        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvVehicleRoster_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView senderGrid = (DataGridView)sender;
            DialogResult result;
            if (e.ColumnIndex < 0) return;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                string action = e.ColumnIndex == 1 ? "Edit" : "Remove";
                //result = MessageBox.Show(dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString(), "Selected Staff to " + action);
                // Edit vehicle
                if (e.ColumnIndex == 1)
                {
                    AddEditVehicle editStaff = new AddEditVehicle((int)dgvVehicleRoster.Rows[e.RowIndex].Cells[0].Value, AddEditVehicle.FormMode.Edit);
                    editStaff.ShowDialog();
                }
                else // Remove Vehicle member * Should really never have to remove a staff member.
                {

                }

                setUpDataGridView();
            }
        }

        private void BtnAddVehicle_Click(object sender, EventArgs e)
        {
            AddEditVehicle editStaff = new AddEditVehicle(0, AddEditVehicle.FormMode.Add);
            editStaff.ShowDialog();
            setUpDataGridView();
        }
    }
}
