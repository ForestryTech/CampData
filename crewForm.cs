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
    public partial class crewForm : Form
    {

        public enum CrewNumber
        {
            crew1 = 1,
            crew2 = 2,
            crew3 = 3,
            crew4 = 4
        }

        Crew currentCrew;
        Dictionary<string, int> hookline;
        List<ComboBox> comboBoxes;
        private CrewNumber crewNum;
        public crewForm(CrewNumber crew)
        {
            InitializeComponent();
           
            Counts count = new Counts();
            crewNum = crew;
            //hookline = new List<Hookline>();
            hookline = new Dictionary<string, int>();
            currentCrew = new Crew((int)crew);
            this.Tag = (int)crew;
            lblSaveStatus.Visible = false;

            loadComboBoxes(cboFirstSaw, count, currentCrew.FirstSaw);
            loadComboBoxes(cboFirstPuller, count, currentCrew.FirstPuller);
            loadComboBoxes(cboSecondSaw, count, currentCrew.SecondSaw);
            loadComboBoxes(cboSecondPuller, count, currentCrew.SecondPuller);
            loadComboBoxes(cboRhino, count, currentCrew.Rhino);
            loadComboBoxes(cboLeadPulaski, count, currentCrew.FirstPulaski);
            loadComboBoxes(cboSecondPulaski, count, currentCrew.SecondPulaski);
            loadComboBoxes(cboThirdPulaski, count, currentCrew.ThirdPulaski);
            loadComboBoxes(cboFourthPulaski, count, currentCrew.FourthPulaski);
            loadComboBoxes(cboFifthPulaski, count, currentCrew.FifthPulaski);
            loadComboBoxes(cboFirstMcLeod, count, currentCrew.FirstMcLeod);
            loadComboBoxes(cboSecondMcLeod, count, currentCrew.SecondMcLeod);
            loadComboBoxes(cboThirdMcLeod, count, currentCrew.ThirdMcLeod);
            loadComboBoxes(cboFourthMcLeod, count, currentCrew.FourthMcLeod);
            loadComboBoxes(cboFifthMcLeod, count, currentCrew.FifthMcLeod);
            loadComboBoxes(cboDragSpoon, count, currentCrew.Dragspoon);
            loadComboBoxes(cboSwamper, count, currentCrew.Swamper);
            loadCaptainCombo(count);
            loadVehicleCombo(count);
        }
        private void loadCaptainCombo(Counts count)
        {
            cboCaptain.DataSource = count.FillStaffCombo("CALFIRE");
            cboCaptain.DisplayMember = "FullName";
            cboCaptain.ValueMember = "Id";
            cboCaptain.FormattingEnabled = true;
            cboCaptain.SelectedValue = currentCrew.Captain;
        }

        private void loadVehicleCombo(Counts count)
        {
            cboVehicle.DataSource = count.FillVehicleCombo();
            cboVehicle.DisplayMember = "RadioId";
            cboVehicle.ValueMember = "Id";
            cboVehicle.SelectedValue = currentCrew.Vehicle;
        }
        private void loadComboBoxes(ComboBox comboBox, Counts count, int crewMemberID)
        {
            //ComboBox comboBox = (ComboBox)this.Controls[comboName];
            //Counts count = new Counts();
            comboBox.DataSource = count.FillCrewCombo(crewNumber(crewNum));
            comboBox.DisplayMember = "ComboListName";
            comboBox.ValueMember = "id";
            comboBox.FormattingEnabled = true;
            comboBox.SelectedValue = crewMemberID;
            hookline.Add(comboBox.Tag.ToString(), crewMemberID);
            loadCrewLabels(crewMemberID, comboBox.Tag.ToString());
        }

        private List<ComboBox> getComboBoxes()
        {
            List<ComboBox> boxes = new List<ComboBox>();

            foreach(Control c in this.Controls)
            {
                if(c.GetType() == typeof(System.Windows.Forms.ComboBox))
                {
                    boxes.Add((ComboBox)c);
                }
                
                
            }

            return boxes;
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }


        private void comboBoxClicked(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            //Console.WriteLine(comboBox.Tag);
            // Make hookline a Dictionary<string, int> to set hookline and imediatley check for duplicates
            // Use the Hookline class as a List<Hookline> to check for duplicates before saving hookline to database
            // Use the Dictionary to fill the list 

            if(hookline.ContainsValue((int)comboBox.SelectedValue) & (int)comboBox.SelectedValue != 0)
            {
                DialogResult result = MessageBox.Show("Crewmember already in hookline!", "Duplilcate in Hookline", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            hookline[comboBox.Tag.ToString()] = (int)comboBox.SelectedValue;

            loadCrewLabels((int)comboBox.SelectedValue, comboBox.Tag.ToString());
        }



        private void loadCrewLabels(int inmateId, string row)
        {
            string label = "lblSawStatus" + row;
            InmateData inmate = new InmateData(inmateId);


            this.Controls[label].Text = inmate.SawStatus;
            this.Controls[label].ForeColor = new System.Drawing.Color();
            this.Controls[label].Visible = true;
            label = "lblLaundry" + row;
            this.Controls[label].Text = inmate.LaundryNumber;
            this.Controls[label].ForeColor = new System.Drawing.Color();
            this.Controls[label].Visible = true;
            label = "lblHousing" + row;
            this.Controls[label].Text = inmate.HousingNumber;
            this.Controls[label].ForeColor = new System.Drawing.Color();
            this.Controls[label].Visible = true;
            this.Controls["lblEthnicity" + row].Text = inmate.Ethnicity;
            this.Controls["lblEthnicity" + row].ForeColor = new System.Drawing.Color();
            this.Controls["lblEthnicity" + row].Visible = true;
            this.Controls["lblFlightWeight" + row].Text = inmate.FlightWeight;
            this.Controls["lblFlightWeight" + row].ForeColor = new System.Drawing.Color();
            this.Controls["lblFlightWeight" + row].Visible = true;
            //this.Refresh();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private string crewNumber(CrewNumber crew)
        {
            string retVal = "";

            switch (crew) {
                case CrewNumber.crew1:
                    retVal = "1";
                    lblTitle.Text = "Crew 1 Hookline";
                    break;
                case CrewNumber.crew2:
                    retVal = "2";
                    lblTitle.Text = "Crew 2 Hookline";
                    break;
                case CrewNumber.crew3:
                    retVal = "3";
                    lblTitle.Text = "Crew 3 Hookline";
                    break;
                case CrewNumber.crew4:
                    retVal = "4";
                    lblTitle.Text = "Crew 4 Hookline";
                    break;
            }
            return retVal;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            getComboBoxValue();
            if (checkForDuplicateInHookline())
            {
                lblSaveStatus.Text = "Duplicate entries in hookline. Cannot Save.";
                lblSaveStatus.Visible = true;
                return;
            }
            if(Crew.SaveStatus.Succsess == currentCrew.SaveCrew())
            {
                lblSaveStatus.Text = "Hookline saved successfully.";
                lblSaveStatus.Visible = true;
            }
            else
            {
                lblSaveStatus.Text = "There was an error in saving the hookline.";
                lblSaveStatus.Visible = true;
            }
        }

        private void getComboBoxValue()
        {
            currentCrew.FirstSaw = ((cboFirstSaw.SelectedValue == null) ? 0 : (int)cboFirstSaw.SelectedValue);
            currentCrew.SecondSaw = ((cboSecondSaw.SelectedValue == null) ? 0 : (int)cboSecondSaw.SelectedValue);
            currentCrew.FirstPuller = ((cboFirstPuller.SelectedValue == null) ? 0 : (int)cboFirstPuller.SelectedValue);
            currentCrew.SecondPuller = ((cboSecondPuller.SelectedValue == null) ? 0 : (int)cboSecondPuller.SelectedValue);
            currentCrew.Rhino = ((cboRhino.SelectedValue == null) ? 0 : (int)cboRhino.SelectedValue);
            currentCrew.FirstPulaski = ((cboLeadPulaski.SelectedValue == null) ? 0 : (int)cboLeadPulaski.SelectedValue);
            currentCrew.SecondPulaski = ((cboSecondPulaski.SelectedValue == null) ? 0 : (int)cboSecondPulaski.SelectedValue);
            currentCrew.ThirdPulaski = ((cboThirdPulaski.SelectedValue == null) ? 0 : (int)cboThirdPulaski.SelectedValue);
            currentCrew.FourthPulaski = ((cboFourthPulaski.SelectedValue == null) ? 0 : (int)cboFourthPulaski.SelectedValue);
            currentCrew.FifthPulaski = ((cboFifthPulaski.SelectedValue == null) ? 0 : (int)cboFifthPulaski.SelectedValue);
            currentCrew.FirstMcLeod = ((cboFirstMcLeod.SelectedValue == null) ? 0 : (int)cboFirstMcLeod.SelectedValue);
            currentCrew.SecondMcLeod = ((cboSecondMcLeod.SelectedValue == null) ? 0 : (int)cboSecondMcLeod.SelectedValue);
            currentCrew.ThirdMcLeod = ((cboThirdMcLeod.SelectedValue == null) ? 0 : (int)cboThirdMcLeod.SelectedValue);
            currentCrew.FourthMcLeod = ((cboFourthMcLeod.SelectedValue == null) ? 0 : (int)cboFourthMcLeod.SelectedValue);
            currentCrew.FifthMcLeod = ((cboFifthMcLeod.SelectedValue == null) ? 0 : (int)cboFifthMcLeod.SelectedValue);
            currentCrew.Dragspoon = ((cboDragSpoon.SelectedValue == null) ? 0 : (int)cboDragSpoon.SelectedValue);
            currentCrew.Swamper = ((cboSwamper.SelectedValue == null) ? 0 : (int)cboSwamper.SelectedValue);
            currentCrew.Captain = ((cboCaptain.SelectedValue == null) ? 0 : (int)cboCaptain.SelectedValue);
            currentCrew.Vehicle = ((cboVehicle.SelectedValue == null) ? 0 : (int)cboVehicle.SelectedValue);
        }

        private bool checkForDuplicateInHookline()
        {
            List<Hookline> newHookline = new List<Hookline>();
            List<string> duplicateRows = new List<string>();
            foreach(KeyValuePair<string, int> keyValue in hookline)
            {
                //if(keyValue.Value != 0) 
                    newHookline.Add(new Hookline(keyValue.Value, keyValue.Key));
            }

            var matches = hookline.Where(x => x.Value != 0).GroupBy(x => x.Value).Where(x => x.Count() > 1);

            //Dictionary<int, Dictionary<string, int>> = (Dictionary<int, Dictionary<string, int>>)matches;
            Console.WriteLine("Matches Count: " + matches.Count().ToString());
            if (matches.Count() > 0)
            {
                foreach (var m in matches)
                {
                    Console.WriteLine("Duplicate Entries: " + m.Count());
                    foreach (var d in m)
                    {
                        Console.WriteLine("Row: " + d.Key + " Id: " + d.Value.ToString());
                        duplicateRows.Add(d.Key);
                    }
                }
                //var test = from t in newHookline where t == t select t.Row;
                foreach(string i in duplicateRows)
                {
                    colorLabelForDuplicate(i);
                }
                DialogResult dialogResult = MessageBox.Show("There are duplicate entries in the hookline. Duplicates are marked in red.", "Unable To Save Hookline", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }

        private void colorLabelForDuplicate(string row)
        {
            {
                string label = "lblSawStatus" + row;
                this.Controls[label].ForeColor = System.Drawing.Color.Red;
                label = "lblLaundry" + row;
                this.Controls[label].ForeColor = System.Drawing.Color.Red;
                label = "lblHousing" + row;
                this.Controls[label].ForeColor = System.Drawing.Color.Red;
                this.Controls["lblEthnicity" + row].ForeColor = System.Drawing.Color.Red;
                this.Controls["lblFlightWeight" + row].ForeColor = System.Drawing.Color.Red;
                //this.Refresh();
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            comboBoxes = getComboBoxes();
            foreach(ComboBox c in comboBoxes)
            {
                c.SelectedValue = 0;
            }

            for(int i = 1; i <= 17; i++)
            {
                clearLabels(i.ToString());
            }

        }

        private void clearLabels(string row)
        {
            string label = "lblSawStatus" + row;
            this.Controls[label].Text = "";
            this.Controls[label].ForeColor = new System.Drawing.Color();
            this.Controls[label].Visible = false;
            label = "lblLaundry" + row;
            this.Controls[label].Text = "";
            this.Controls[label].ForeColor = new System.Drawing.Color();
            this.Controls[label].Visible = false;
            label = "lblHousing" + row;
            this.Controls[label].Text = "";
            this.Controls[label].ForeColor = new System.Drawing.Color();
            this.Controls[label].Visible = false;
            this.Controls["lblEthnicity" + row].Text = "";
            this.Controls["lblEthnicity" + row].ForeColor = new System.Drawing.Color();
            this.Controls["lblEthnicity" + row].Visible = false;
            this.Controls["lblFlightWeight" + row].Text = "";
            this.Controls["lblFlightWeight" + row].ForeColor = new System.Drawing.Color();
            this.Controls["lblFlightWeight" + row].Visible = false;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintCamp printCamp = new PrintCamp();
        }
    }

    public class Hookline
    {
        public int Id { get; set; }
        public string Row { get; set; }

        public Hookline(int id, string row)
        {
            Id = id;
            Row = row;
        }

        public override bool Equals(object obj)
        {
            var other = obj as Hookline;
            if (obj == null) return false;
            if (!(obj is Hookline)) return false;
            if (other.Id == 0) return false;
            if (this.Id != other.Id) return false;

            return true;
            //return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return this.Id.GetHashCode();
        }
    }
}
