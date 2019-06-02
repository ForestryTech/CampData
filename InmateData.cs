using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CampData
{
    class InmateData
    {
        //private string sql;
        private bool gradeEligible;
        private bool paroled;
        private bool atCamp;
        private bool specialStatus;
        private string connString;
        private int id;
        private DateTime ?eprd;
        enum Status
        {
            Yes = 1,
            No = 2
        }

        enum Mode
        {
            Read = 1,
            Write = 2,
            Edit = 3
        }
        // 1- Define delegate
        // 2 define event
        // raise event

        public delegate void CampDataUpdatedEventHandler(object sender, EventArgs e);
        public event CampDataUpdatedEventHandler CampDataUpdated;



        public enum SaveStatus
        {
            Error = 1,
            Succsess = 2
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CDCRNumber { get; set; }
        public string HousingNumber { get; set; }
        public string LaundryNumber { get; set; }
        public string SawStatus { get; set; }
        public string FlightWeight { get; set; }
        public string Job { get; set; }
        public string Crew { get; set; }
        public string CampJob { get; set; }
        public string SpecialStausText { get; set; }
        public string Ethnicity { get; set; }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public DateTime ?EPRD
        {
            get
            {
                if(eprd == null)
                {
                    return null;
                } else
                {
                    return eprd.Value.Date;
                }
            }
            set
            {
                if(value == DateTime.Now.Date)
                {
                    eprd = null;
                } else
                {
                    eprd = value;
                }
            }
        }

        public string GradeEligible
        {
            get
            {
                if(gradeEligible)
                {
                    return "Yes";
                } else
                {
                    return "No";
                }
            }
            set
            {
                if (value == "Yes" || value == "YES")
                {
                    gradeEligible = true;
                } else
                {
                    gradeEligible = false;
                }

            }
        }

        public string Paroled
        {
            get
            {
                if(paroled)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            set
            {
                if (value == "Yes")
                {
                    paroled = true;
                }
                else
                {
                    paroled = false;
                }
            }
        }

        public string AtCamp
        {
            get
            {
                if (atCamp)
                {
                    return "Yes";
                } else
                {
                    return "No";
                }
            }
            set
            {
                if(value == "Yes")
                {
                    atCamp = true;
                } else
                {
                    atCamp = false;
                }
            }
        }

        public string SpecialStatus
        {
            get
            {
                if (specialStatus)
                {
                    return "Yes";
                }
                else
                {
                    return "No";
                }
            }
            set
            {
                if(value == "Yes")
                {
                    specialStatus = true;
                }
                else
                {
                    specialStatus = false;
                }
            }
        }

        public string ComboListName
        {
            get
            {
                if(FullName == "")
                {
                    return "";
                }
                else
                {
                    return String.Format("{0, -15} - {1, -2}", FullName.Trim(), CDCRNumber);
                }
                
            }
        }

        public string LabelName
        {
            get
            {
                if (FullName == "")
                {
                    return "";
                }
                else
                {
                    return String.Format("{0, -10} - {1, -2}", FullName.Trim(), CDCRNumber.Substring(4, 2));
                }
            }
        }
        public string FullName
        {
            get
            {
                if (LastName == null)
                {
                    return "";
                }
                else
                {
                    return LastName + ", " + FirstName.Substring(0,1);
                }
            }
        }
        public InmateData()
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
            id = 0;
        }

        public InmateData(int id)
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
            if(id != 0)
                GetData(id);

        }

        public void GetData(int inmateId)
        {
            
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * FROM inmate WHERE id=@1", conn);
                    command.Parameters.AddWithValue("@1", inmateId);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        id = (int)reader["id"];
                        FirstName = reader["firstName"].ToString();
                        LastName = reader["lastName"].ToString();
                        CDCRNumber = reader["cdcrNumber"].ToString();
                        HousingNumber = reader["housingNumber"].ToString();
                        LaundryNumber = reader["laundryNumber"].ToString();
                        FlightWeight = reader["flightWeight"].ToString();
                        Job = reader["job"].ToString();
                        Crew = reader["crew"].ToString();
                        CampJob = reader["campJob"].ToString();
                        Ethnicity = reader["ethnicity"].ToString();
                        SpecialStausText = reader["specialStatusText"].ToString();
                        //Console.WriteLine("EPRD: " + reader["eprd"].ToString());
                        if (reader["eprd"] == DBNull.Value)
                        {
                            EPRD = null;
                        }
                        else
                        {
                            EPRD = (DateTime)reader["eprd"];
                        }
                        gradeEligible = (bool)reader["gradeEligible"];
                        specialStatus = (bool)reader["specialStatus"];
                        paroled = (bool)reader["paroled"];
                        SawStatus = reader["sawStatus"].ToString();
                        atCamp = (bool)reader["atCamp"];
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Getting Inmate Information");
                    //throw;
                }
            }
        }

        public SaveStatus WriteData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    OleDbCommand command = new OleDbCommand("INSERT INTO inmate(firstName, lastName, cdcrNumber, housingNumber, laundryNumber," +
                        "flightWeight, job, crew, campJob, ethnicity, specialStatusText, eprd, gradeEligible, specialStatus, paroled, sawStatus, atCamp)" +
                        "VALUES(@firstName, @lastName, @cdcrNumber, @housingNumber, @laundryNumber, @flightWeight, @job, @crew, @campJob, @ethnicity," +
                        "@specialStatusText, @eprd, @gradeEligible, @specialStatus, @paroled, @sawStatsu, @atCamp)", conn);
                    command.Parameters.AddWithValue("@firstName", FirstName);
                    command.Parameters.AddWithValue("@secondName", LastName);
                    command.Parameters.AddWithValue("@cdcrNumber", CDCRNumber);
                    command.Parameters.AddWithValue("@housingNumber", HousingNumber);
                    command.Parameters.AddWithValue("@laundryNumber", LaundryNumber);
                    command.Parameters.AddWithValue("@flightWeight", FlightWeight);
                    command.Parameters.AddWithValue("@job", Job);
                    command.Parameters.AddWithValue("@crew", Crew);
                    command.Parameters.AddWithValue("@campJob", CampJob);
                    command.Parameters.AddWithValue("@ethnicity", Ethnicity);
                    command.Parameters.AddWithValue("@specialStatusText", SpecialStausText);
                    if(eprd == null)
                    {
                        //Console.WriteLine("EPRD is null");
                        command.Parameters.AddWithValue("@eprd", DBNull.Value);
                    } else
                    {
                        command.Parameters.AddWithValue("@eprd", eprd);
                    }

                    command.Parameters.AddWithValue("@gradeEligible", gradeEligible);
                    command.Parameters.AddWithValue("@specialStatus", specialStatus);
                    command.Parameters.AddWithValue("@paroled", paroled);
                    command.Parameters.AddWithValue("@sawStatus", SawStatus);
                    command.Parameters.AddWithValue("@atCamp", atCamp);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Add Inmate Information");
                    //throw;
                    return SaveStatus.Error;
                }
            }
            OnCampDataUpdated();
            return SaveStatus.Succsess;
        }

        public SaveStatus UpdateData()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE inmate SET firstName=@firstName, lastName=@lastName,cdcrNumber=@cdcrNumber,housingNumber=@housingNumber," +
                        "laundryNumber=@laundryNumber, flightWeight=@flightWeight, job=@job, crew=@crew, campJob=@campJob, ethnicity=@ethnicity," +
                        "specialStatusText=@specialStatusText, eprd=@eprd, gradeEligible=@gradeEligible, specialStatus=@specialStatus, paroled=@paroled," +
                        "sawStatus=@sawStatus, atCamp=@atCamp WHERE id=@id", conn);
                    command.Parameters.AddWithValue("@firstName", FirstName);
                    command.Parameters.AddWithValue("@secondName", LastName);
                    command.Parameters.AddWithValue("@cdcrNumber", CDCRNumber);
                    command.Parameters.AddWithValue("@housingNumber", HousingNumber);
                    command.Parameters.AddWithValue("@laundryNumber", LaundryNumber);
                    command.Parameters.AddWithValue("@flightWeight", FlightWeight);
                    command.Parameters.AddWithValue("@job", Job);
                    command.Parameters.AddWithValue("@crew", Crew);
                    command.Parameters.AddWithValue("@campJob", CampJob);
                    command.Parameters.AddWithValue("@ethnicity", Ethnicity);
                    command.Parameters.AddWithValue("@specialStatusText", SpecialStausText);
                    if (eprd == null)
                    {
                        //Console.WriteLine("EPRD is null");
                        command.Parameters.AddWithValue("@eprd", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@eprd", eprd);
                    }
                    command.Parameters.AddWithValue("@gradeEligible", gradeEligible);
                    command.Parameters.AddWithValue("@specialStatus", specialStatus);
                    command.Parameters.AddWithValue("@paroled", paroled);
                    command.Parameters.AddWithValue("@sawStatus", SawStatus);
                    command.Parameters.AddWithValue("@atCamp", atCamp);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Update Inmate Information");
                    //throw;
                    return SaveStatus.Error;
                }
                OnCampDataUpdated();
            }
            return SaveStatus.Succsess;
        }

        protected virtual void OnCampDataUpdated()
        {
            if(CampDataUpdated != null)
            {
                Console.WriteLine("Event Raised in InmateData!");
                CampDataUpdated(this, EventArgs.Empty);
            }
        }
        
    }
}
