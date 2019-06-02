using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampData
{
    class Staff
    {
        private int id;
        private string connString;

        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Agency { get; set; }
        public bool Type1 { get; set; }
        
        public string FullName
        {
            get
            {
                if(LastName == null)
                {
                    return "";
                }
                else
                {
                    return LastName + ", " + FirstName.Substring(0, 1); 
                }
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }

        public enum SaveStatus
        {
            Error = 1,
            Succsess = 2
        }

        public Staff()
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
        }

        public Staff(int staffId)
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
            id = staffId;
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
                    OleDbCommand command = new OleDbCommand("SELECT * FROM staff WHERE id=@id", conn);
                    command.Parameters.AddWithValue("@id", id);
                    reader = command.ExecuteReader();
                    
                    while(reader.Read())
                    {
                        this.id = (int)reader["id"];
                        FirstName = reader["firstName"].ToString();
                        LastName = reader["lastName"].ToString();
                        Position = reader["position"].ToString();
                        Agency = reader["agency"].ToString();
                        Type1 = (bool)reader["typeOne"];
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Get Staff Information");

                }

            }
        }

        public SaveStatus AddData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("INSERT INTO [staff]([firstName], [lastName], [position], [agency], [typeOne])" +
                        "VALUES(@firstName, @lastName, @position, @agency, @typeOne)", conn);

                    command.Parameters.AddWithValue("@firstName", FirstName);
                    command.Parameters.AddWithValue("@lastName", LastName);
                    command.Parameters.AddWithValue("@position", Position);
                    command.Parameters.AddWithValue("@agency", Agency);
                    command.Parameters.AddWithValue("@typeOne", Type1);
                    

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Add Staff Information");
                    return SaveStatus.Error;
                }
                return SaveStatus.Succsess;
            }
        }

        public SaveStatus UpdateData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE [staff] SET [firstName]=@firstName, [lastName]=@lastName, [position]=@position," +
                        "[agency]=@agency, [typeOne]=@typeOne WHERE [id]=@id", conn);

                    command.Parameters.AddWithValue("@firstName", FirstName);
                    command.Parameters.AddWithValue("@lastName", LastName);
                    command.Parameters.AddWithValue("@position", Position);
                    command.Parameters.AddWithValue("@agency", Agency);
                    command.Parameters.AddWithValue("@typeOne", Type1);
                    command.Parameters.AddWithValue("@id", id);
              
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Update Staff Information");
                    return SaveStatus.Error;
         
                }
                return SaveStatus.Succsess;
            }
            
        }
    }
}
