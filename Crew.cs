using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace CampData
{


    class Crew
    {
        private InmateData firstSaw;
        private InmateData secondSaw;
        private InmateData firstPuller;
        private InmateData secondPuller;
        private InmateData rhino;
        private InmateData firstPulaski;
        private InmateData secondPulaski;
        private InmateData thirdPulaski;
        private InmateData fourthPulaski;
        private InmateData fifthPulaski;
        private InmateData firstMcLeod;
        private InmateData secondMcLeod;
        private InmateData thirdMcLeod;
        private InmateData fourthMcLeod;
        private InmateData fifthMcLeod;
        private InmateData dragspoon;
        private InmateData swamper;
        private Staff captain;
        private Vehicle vehicle;
        private int crewNum;
        private string connString;

        public Dictionary<string, int> Seating;

        public enum SaveStatus
        {
            Error = 1,
            Succsess = 2
        }
        public static string ShortName(int id)
        {
            InmateData inmate = new InmateData(id);
            string inmateReturn;
            inmateReturn = inmate.LabelName;
            return inmateReturn;
        }

        public bool OnFire { get; set; }
        public int Captain { get { return captain.Id; } set { captain = new Staff(value); } }
        public int Vehicle { get { return vehicle.Id; } set { vehicle = new Vehicle(value); } }
        public int FirstSaw { get { return firstSaw.Id; } set { firstSaw = new InmateData(value); } }

        public int SecondSaw
        {
            get
            {
                return secondSaw.Id;
            }
            set
            {
                secondSaw = new InmateData(value);
            }
        }

        public int FirstPuller
        {
            get
            {
                return firstPuller.Id;
            }
            set
            {
                firstPuller = new InmateData(value);
            }
        }

        public int SecondPuller
        {
            get
            {
                return secondPuller.Id;
            } 
            set
            {
                secondPuller = new InmateData(value);
            }
        }
        public int Rhino { get { return rhino.Id; } set { rhino = new InmateData(value); } }
        public int FirstPulaski {
            get
            {
                return firstPulaski.Id;
            }
            set
            {
                firstPulaski = new InmateData(value);
            } 
        }
        public int SecondPulaski {
            get
            {
                return secondPulaski.Id;
            }
            set
            {
                secondPulaski = new InmateData(value);
            }
        }
        public int ThirdPulaski
        {
            get
            {
                return thirdPulaski.Id;
            }
            set
            {
                thirdPulaski = new InmateData(value);
            }
        }
        public int FourthPulaski { get { return fourthPulaski.Id; } set { fourthPulaski = new InmateData(value); } }

        public int FifthPulaski { get { return fifthPulaski.Id;  } set { fifthPulaski = new InmateData(value); } }
        public int FirstMcLeod { get { return firstMcLeod.Id; } set { firstMcLeod = new InmateData(value); } }
        public int SecondMcLeod { get { return secondMcLeod.Id; } set { secondMcLeod = new InmateData(value); } }
        public int ThirdMcLeod { get { return thirdMcLeod.Id; } set { thirdMcLeod = new InmateData(value); } }
        public int FourthMcLeod { get { return fourthMcLeod.Id; } set { fourthMcLeod = new InmateData(value); } }
        public int FifthMcLeod { get { return fifthMcLeod.Id; } set { fifthMcLeod = new InmateData(value); } }
        public int Dragspoon { get { return dragspoon.Id; } set { dragspoon = new InmateData(value); } }
        public int Swamper { get { return swamper.Id; } set { swamper = new InmateData(value); } }


        public static void RemoveFromCrew(int id, int crewNum)
        {
            string updateSQLString = "";
            string connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
            Dictionary<string, int> crewLine = new Dictionary<string, int>();
            Dictionary<string, int> crewmemberToRemove = new Dictionary<string, int>();
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * FROM crew WHERE id=@1", conn);
                    command.Parameters.AddWithValue("@1", crewNum);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        //Console.WriteLine("0: " + reader.GetName(0) + " -1: " + reader.GetName(1) + " -2: " + reader.GetName(2) + " -3: " + reader.GetName(3));
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            switch (reader.GetName(i)) {
                                case "ID":
                                case "captain":
                                case "vehicle":
                                    crewLine.Add(reader.GetName(i), (int)reader[i]);
                                    break;
                                case "onFire":
                                    if ((bool)reader[i] == true)
                                    {
                                        crewLine.Add(reader.GetName(i), 1);
                                    }
                                    else
                                    {
                                        crewLine.Add(reader.GetName(i), 0);
                                    }
                                    break;
                                default:
                                    if ((int)reader[i] == id)
                                    {
                                        crewLine.Add(reader.GetName(i), 0);
                                        crewmemberToRemove.Add(reader.GetName(i), 0);
                                    }
                                    else
                                    {
                                        crewLine.Add(reader.GetName(i), (int)reader[i]);
                                    }
                                    break;
                            }
                        }


                    }

                    updateSQLString = "UPDATE crew SET ";
                    if (crewmemberToRemove.Count != 0)
                    {
                        string keyToUpdate;
                        foreach (KeyValuePair<string, int> pair in crewmemberToRemove) {
                            updateSQLString += pair.Key;
                            updateSQLString += "=@" + pair.Key + ", ";

                        }
                        updateSQLString = updateSQLString.Trim(',', ' ');
                        updateSQLString += " WHERE id=@id";

                        OleDbCommand commandUpdate = new OleDbCommand(updateSQLString, conn);
                        foreach(KeyValuePair<string, int> pair in crewmemberToRemove)
                        {
                            keyToUpdate = "@" + pair.Key;
                            commandUpdate.Parameters.AddWithValue(keyToUpdate, pair.Value);
                        }
                        commandUpdate.Parameters.AddWithValue("@id", crewNum);
                        commandUpdate.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Removing crew member");
                    //throw;
                }
            }
        }
        public void GetCrew()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * FROM crew WHERE id=@1", conn);
                    command.Parameters.AddWithValue("@1", crewNum);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {

                        //id = (int)reader["id"];
                        firstSaw = ((int)reader["firstSaw"]) == 0 ? new InmateData() :new InmateData((int)reader["firstSaw"]);
                        firstPuller = ((int)reader["firstPuller"]) == 0 ? new InmateData() : new InmateData((int)reader["firstPuller"]);
                        secondSaw = ((int)reader["secondSaw"]) == 0 ? new InmateData() : new InmateData((int)reader["secondSaw"]);
                        secondPuller = ((int)reader["secondPuller"]) == 0 ? new InmateData() : new InmateData((int)reader["secondPuller"]);
                        rhino = ((int)reader["rhino"]) == 0 ? new InmateData() : new InmateData((int)reader["rhino"]);
                        firstPulaski = ((int)reader["firstPulaski"]) == 0 ? new InmateData() : new InmateData((int)reader["firstPulaski"]);
                        secondPulaski = ((int)reader["secondPulaski"]) == 0 ? new InmateData() : new InmateData((int)reader["secondPulaski"]);
                        thirdPulaski = ((int)reader["thirdPulaski"]) == 0 ? new InmateData() : new InmateData((int)reader["thirdPulaski"]);
                        fourthPulaski = ((int)reader["fourthPulaski"]) == 0 ? new InmateData() : new InmateData((int)reader["fourthPulaski"]);
                        fifthPulaski = ((int)reader["fifthPulaski"]) == 0 ? new InmateData() : new InmateData((int)reader["fifthPulaski"]);
                        firstPulaski = ((int)reader["firstPulaski"]) == 0 ? new InmateData() : new InmateData((int)reader["firstPulaski"]);
                        firstMcLeod = ((int)reader["firstMcLeod"]) == 0 ? new InmateData() : new InmateData((int)reader["firstMcLeod"]);
                        secondMcLeod = ((int)reader["secondMcLeod"]) == 0 ? new InmateData() : new InmateData((int)reader["secondMcLeod"]);
                        thirdMcLeod = ((int)reader["thirdMcLeod"]) == 0 ? new InmateData() : new InmateData((int)reader["thirdMcLeod"]);
                        fourthMcLeod = ((int)reader["fourthMcLeod"]) == 0 ? new InmateData() : new InmateData((int)reader["fourthMcLeod"]);
                        fifthMcLeod = ((int)reader["fifthMcLeod"]) == 0 ? new InmateData() : new InmateData((int)reader["fifthMcLeod"]);
                        dragspoon = ((int)reader["dragspoon"]) == 0 ? new InmateData() : new InmateData((int)reader["dragspoon"]);
                        swamper = ((int)reader["swamper"]) == 0 ? new InmateData() : new InmateData((int)reader["swamper"]);
                        captain = ((int)reader["captain"]) == 0 ? new Staff() : new Staff((int)reader["captain"]);
                        vehicle = ((int)reader["vehicle"]) == 0 ? new Vehicle() : new Vehicle((int)reader["vehicle"]);
                    }
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Getting Crew Information");
                    //throw;
                }
            }
        }

        public SaveStatus SaveCrew()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE crew SET firstSaw=@firstSaw, firstPuller=@firstPuller, secondSaw=@secondSaw, secondPuller=@secondPuller," +
                        " rhino=@rhino, firstPulaski=@firstPulaski, secondPulaski=@secondPulaski, thirdPulaski=@thirdPulaski, fourthPulaski=@fourthPulaski, fifthPulaski=@fifthPulaski," +
                        " firstMcLeod=@firstMcLeod, secondMcLeod=@secondMcLeod, thirdMcLeod=@thirdMcLeod, fourthMcLeod=@fourthMcLeod, fifthMcLeod=@fifthMcLeod," +
                        " dragspoon=@dragspoon, swamper=@swamper, captain=@captain, vehicle=@vehicle, onFire=@onFire " +
                        "WHERE id=@crewNum", conn);

                    command.Parameters.AddWithValue("@firstSaw", firstSaw.Id);
                    command.Parameters.AddWithValue("@firstPuller", firstPuller.Id);
                    command.Parameters.AddWithValue("@secondSaw", secondSaw.Id);
                    command.Parameters.AddWithValue("@secondPuller", secondPuller.Id);
                    command.Parameters.AddWithValue("@rhino", rhino.Id);
                    command.Parameters.AddWithValue("@firstPulaski", firstPulaski.Id);
                    command.Parameters.AddWithValue("@secondPulaski", secondPulaski.Id);
                    command.Parameters.AddWithValue("@thirdPulaski", thirdPulaski.Id);
                    command.Parameters.AddWithValue("@fourthPulaski", fourthPulaski.Id);
                    command.Parameters.AddWithValue("@fifthPulaski", fifthPulaski.Id);
                    command.Parameters.AddWithValue("@firstMcLeod", firstMcLeod.Id);
                    command.Parameters.AddWithValue("@secondMcLeod", secondMcLeod.Id);
                    command.Parameters.AddWithValue("@thirdMcLeod", thirdMcLeod.Id);
                    command.Parameters.AddWithValue("@fourthMcLeod", fourthMcLeod.Id);
                    command.Parameters.AddWithValue("@fifthMcLeod", fifthMcLeod.Id);
                    command.Parameters.AddWithValue("@dragspoon", dragspoon.Id);
                    command.Parameters.AddWithValue("@swamper", swamper.Id);
                    command.Parameters.AddWithValue("@captain", captain.Id);
                    command.Parameters.AddWithValue("@vehicle", vehicle.Id);
                    command.Parameters.AddWithValue("@onFire", false);
                    command.Parameters.AddWithValue("@crewNum", crewNum);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Save Hookline");
                    return SaveStatus.Error;
                }
                
            }
            return SaveStatus.Succsess;
            
        }

        public Crew(int crew)
        {
            connString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jpete\source\repos\Camp Data\CampData\pilotrockdata.mdb";
            crewNum = crew;
            Seating = new Dictionary<string, int>();
            GetCrew();
        }

        public Dictionary<string, int> GetSeatingChart()
        {
            //int x = 1;
            string fieldString = "";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbDataReader reader = null;
                    OleDbCommand command = new OleDbCommand("SELECT * FROM crew WHERE id=@1", conn);
                    command.Parameters.AddWithValue("@1", crewNum);
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        for(int i = 1; i < 5;i++)
                        {
                            fieldString = "s" + i.ToString();
                            Seating.Add(fieldString + "A", (int)reader[fieldString + "A"]);
                            Seating.Add(fieldString + "B", (int)reader[fieldString + "B"]);
                            Seating.Add(fieldString + "C", (int)reader[fieldString + "C"]);
                            Seating.Add(fieldString + "D", (int)reader[fieldString + "D"]);
                        }

                        //Seating.Add("s1A", 0);
                        //firstSaw = ((int)reader["firstSaw"]) == 0 ? new InmateData() : new InmateData((int)reader["firstSaw"]);
                    }
                } catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Getting Crew Information");
                    return Seating;
                }
            }
            return Seating;
        }

        public void SaveSeating(Dictionary<string, int> seating)
        {
            string commandParameter = "";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand command = new OleDbCommand("UPDATE crew SET s1A=@s1A, s1B=@s1B, s1C=@s1C, s1D=@s1D," +
                                                                            "s2A=@s2A, s2B=@s2B, s2C=@s2C, s2D=@s2D," +
                                                                            "s3A=@s3A, s3B=@s3B, s3C=@s3C, s3D=@s3D," +
                                                                            "s4A=@s4A, s4B=@s4B, s4C=@s4C, s4D=@s4D " +
                                                                            "WHERE id=@crewNum", conn);


                    for (int i = 1; i < 5; i++)
                    {
                        commandParameter = "s" + i.ToString() + "A";
                        command.Parameters.AddWithValue("@s" + i.ToString() + "A", seating[commandParameter]);
                        commandParameter = "s" + i.ToString() + "B";
                        command.Parameters.AddWithValue("@s" + i.ToString() + "B", seating[commandParameter]);
                        commandParameter = "s" + i.ToString() + "C";
                        command.Parameters.AddWithValue("@s" + i.ToString() + "C", seating[commandParameter]);
                        commandParameter = "s" + i.ToString() + "D";
                        command.Parameters.AddWithValue("@s" + i.ToString() + "D", seating[commandParameter]);
                    }
                    command.Parameters.AddWithValue("@id", crewNum);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.DialogResult result = System.Windows.Forms.MessageBox.Show(ex.ToString(), "Update Inmate Information");
                }

            }
        }
    }
}
