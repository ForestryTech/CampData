using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace CampData
{
    class Counts
    {
        private string connString;
        private DialogResult result;



        public Counts()
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
        }

        public int GradeEligible
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE gradeEligible=true AND atCamp=true", "Grade Eligible");
            }
        }
        
        public int Crew1
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE crew='1' AND atCamp=true", "Crew 1 count");
            }
        }

        public int Crew2
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE crew='2' AND atCamp=true", "Crew 2 count");
            }
        }

        public int Crew3
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE crew='3' AND atCamp=true", "Crew 3 count");
            }
        }

        public int Crew4
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE crew='4' AND atCamp=true", "Crew 4 count");
            }
        }

        public int TotalAtCamp
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE atCamp=true", "Total Camp Count");
            }
        }

        public int BugCrew
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE job='Bug Crew' AND atCamp=true", "Bug Crew Count");
            }
        }

        public int CALFIREInCamp
        {
            get
            {
                return CALFIREGradeInCamp + CALFIRENonGradeInCamp;
            }
        }

        public int CALFIREGradeInCamp
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE job='Camp' AND gradeEligible=true AND atCamp=true", "CAL FIRE Grade Eligible In Camp");
            }
        }

        public int CALFIRENonGradeInCamp
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE crew='CALFIRE' AND gradeEligible=false AND atCamp=true", "CAL FIRE Non Grade In Camp");
            }
        }

        public int NonGrade
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE gradeEligible=false AND atCamp=true", "Non Grade Count");
            }
        }
        public int CDCRInCamp
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE crew='CDCR' AND gradeEligible=false AND atCamp=true", "CDCR In Camp");
            }
        }

        public int SpecialStatusNonGrade
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE specialStatus=true AND gradeEligible=false AND atCamp=true", "Special Status Non Grade");
            }
        }

        public int SpecialStatusGrade
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE specialStatus=true AND gradeEligible=true AND atCamp=true", "Special Status Grade");
            }
        }

        public int NotAtCamp
        {
            get
            {
                return getData("SELECT COUNT(*) FROM inmate WHERE atCamp=false", "Not At Camp Count");
            }
        }

        private int getData(string sql, string countType)
        {
            int count;

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand(sql, conn);
                    count = (int)command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    result = MessageBox.Show(ex.ToString(), countType);
                    count = 0;
                }

            }
            return count;
        }

        public DataSet CampRoster(string sql)
        {
            //string sql = "SELECT * FROM inmate WHERE paroled=false";
            DataSet ds = new DataSet();
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, con);
                    
                    con.Open();
                    dataAdapter.Fill(ds, "inmate");
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Camp Roster Data", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    //throw;
                } 
            }
            
            return ds;
        }

        public DataSet StaffRoster(string sql)
        {
            DataSet ds = new DataSet();
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, con);

                    con.Open();
                    dataAdapter.Fill(ds, "staff");
                } catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.ToString(), "Staff Roster Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return ds;
        }

        public DataSet VehicleRoster(string sql)
        {
            DataSet ds = new DataSet();
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, con);

                    con.Open();
                    dataAdapter.Fill(ds, "vehicle");
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.ToString(), "Staff Roster Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return ds;
        }

        public DataSet Roster(string sql, string table)
        {
            DataSet ds = new DataSet();
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sql, con);

                    con.Open();
                    dataAdapter.Fill(ds, table);
                }
                catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.ToString(), table + " Roster Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return ds;
        }

        public List<InmateData> FillCrewCombo(string crew)
        {
            List<InmateData> inmate = new List<InmateData>();
            inmate.Add(new InmateData());
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    con.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("Select id FROM inmate WHERE crew=@crew", con);
                    command.Parameters.AddWithValue("@crew", crew);
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        inmate.Add(new InmateData((int)reader["id"]));
                    }
                } catch (Exception ex)
                {
                    DialogResult result = MessageBox.Show(ex.ToString(), "Error in FillCrewCombo");
                }
            }
            return inmate;
        }

        public List<Staff> FillStaffCombo(string agency)
        {
            List<Staff> staff = new List<Staff>();
            staff.Add(new Staff());
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    con.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT id FROM staff WHERE agency=@agency", con);
                    command.Parameters.AddWithValue("@agency", agency);
                    reader = command.ExecuteReader();
                    while(reader.Read())
                    {
                        staff.Add(new Staff((int)reader["id"]));
                    }
                } catch(Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show(ex.ToString(), "Error in Fill Staff Combo");
                }
            }
            return staff;
        }

        public List<Vehicle> FillVehicleCombo()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(new Vehicle());
            using (OleDbConnection con = new OleDbConnection(connString))
            {
                try
                {
                    con.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT id FROM vehicle", con);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        vehicles.Add(new Vehicle((int)reader["id"]));
                    }
                }
                catch (Exception ex)
                {
                    DialogResult dialogResult = MessageBox.Show(ex.ToString(), "Error in Fill Vehicle Combo");
                }
            }

            return vehicles;
        }
    }
}
