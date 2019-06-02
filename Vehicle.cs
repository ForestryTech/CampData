using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampData
{
    class Vehicle
    {
        private int vehicleId;
        private string connString;

        public string Xnumber { get; set; }
        public string RadioId { get; set; }
        public enum SaveStatus
        {
            Error = 1,
            Succsess = 2
        }

        public int Id
        {
            get
            {
                return vehicleId;
            }
        }

        public Vehicle()
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
        }

        public Vehicle(int id)
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
            GetData(id);
        }

        public void GetData(int id)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * FROM vehicle WHERE id=@id", conn);
                    command.Parameters.AddWithValue("@id", id);
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        this.vehicleId = (int)reader["id"];
                        Xnumber = reader["xNumber"].ToString();
                        RadioId = reader["radioNumber"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Get Vehicle Information");

                }

            }

        }

        public SaveStatus UpdateData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE [vehicle] SET [xNumber]=@xNumber, [radioNumber]=@radioNumber" +
                        " WHERE [id]=@id", conn);

                    command.Parameters.AddWithValue("@xNumber", Xnumber);
                    command.Parameters.AddWithValue("@radioNumber", RadioId);
                    command.Parameters.AddWithValue("@id", vehicleId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Update Vehicle Information");
                    return SaveStatus.Error;
                }
                
            }
            return SaveStatus.Succsess;
        }

        public SaveStatus AddData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO [vehicle]([xNumber], [radioNumber]) " +
                        "VALUES(@xNumber, @radioNumber", conn);

                    command.Parameters.AddWithValue("@xNumber", Xnumber);
                    command.Parameters.AddWithValue("@radioNumber", RadioId);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Add Vehicle Information");
                    return SaveStatus.Error;
                }


            }
            return SaveStatus.Succsess;
        }
    }
}
