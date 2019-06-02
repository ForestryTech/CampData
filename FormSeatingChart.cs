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
    public partial class FormSeatingChart : Form
    {
        Crew crew;
        private Point offset = Point.Empty;
        private Dictionary<string, int> seating;
        private Dictionary<int, Label> labelKey;
        public FormSeatingChart(int crewNum)
        {
            InitializeComponent();
            this.Tag = crewNum;
            crew = new Crew(crewNum);
            seating = crew.GetSeatingChart();
            labelKey = new Dictionary<int, Label>();
            loadLabels();
            assignSeats();
            //assignSeatTest();
        }

        private void Label1_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                offset = new Point(e.X, e.Y);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    if (c.Controls.Count != 0)
                    {
                        //Console.WriteLine("Panel " + c.Name + " has " + c.Controls.Count.ToString());
                        //Console.WriteLine("Panel " + c.Name + " has child control: " + c.Controls[0].Text + " - " + c.Controls[0].Tag.ToString().Split(':').First());
                        seating[c.Name] = Int32.Parse(c.Controls[0].Tag.ToString().Split(':').First());
                    }
                    else
                    {
                        seating[c.Name] = 0;
                    }

                }
            }
            crew.SaveSeating(seating);
        }

        /*private void assignSeats_OLD()
        {
            int id;
            string labelName = "";
            Label labelToMove;
            foreach (Control c in this.Controls)
            {
                
                if(c.GetType() == typeof(System.Windows.Forms.Panel))
                {
                    Console.WriteLine("Control: " + c.GetType() + " :Name: " + c.Name);
                   
                        if (seating[c.Name] != 0)
                        {
                            labelName = locateLabel(seating[c.Name]);
                            labelToMove = (Label)this.Controls[labelName];
                            c.Controls.Add(labelToMove);
                            labelToMove.Location = new Point(10, 30);
                        }
                    

                }
            }
        }*/

        private void assignSeats()
        {
            Label labelToMove;
            Panel panelToAdd;
            foreach(KeyValuePair<string, int> pair in seating)
            {
                
                if (pair.Value != 0)
                {
                    labelToMove = locateLabel(pair.Value);
                    if (labelToMove != null)
                    {
                        panelToAdd = (Panel)this.Controls[pair.Key];
                        panelToAdd.Controls.Add(labelToMove);
                        labelToMove.Location = new Point(10, 30);
                        //Console.WriteLine(pair.Key + " : " + pair.Value.ToString() + " : " + labelToMove.Text);
                    }
                }
            }
        }

        /*private string locateLabel_OLD(int id)
        {
            string labelTag = "";
            string[] tags;
            foreach (Control c in this.Controls)
            {
                if(c.GetType() == typeof(System.Windows.Forms.Label))
                {
                    if(c.Tag != null)
                    {
                        labelTag = c.Tag.ToString();
                        tags = labelTag.Split(':');
                        if(id == Int32.Parse(tags[0]))
                        {
                            tags = null;
                            return c.Name;
                        }
                    }
                }
            }
            return "";
        }*/

        private Label locateLabel(int id)
        {
            if (labelKey.ContainsKey(id))
            {
                return labelKey[id];
            } else
            {
                return null;
            }
        }
        private void loadLabels()
        {
            //Crew crew = new Crew(1);


            setLabel(lblFirstSaw, crew.FirstSaw);
            setLabel(lblFirstPuller, crew.FirstPuller);
            setLabel(lblSecondSaw, crew.SecondSaw);
            setLabel(lblSecondPuller, crew.SecondPuller);
            setLabel(lblRhino, crew.Rhino);
            setLabel(lblFirstPulaski, crew.FirstPulaski);
            setLabel(lblSecondPulaski, crew.SecondPulaski);
            setLabel(lblThirdPulaski, crew.ThirdPulaski);
            setLabel(lblFourthPulaski, crew.FourthPulaski);
            setLabel(lblFifthPulaski, crew.FifthPulaski);
            setLabel(lblFirstMcLeod, crew.FirstMcLeod);
            setLabel(lblSecondMcLeod, crew.SecondMcLeod);
            setLabel(lblThirdMcLeod, crew.ThirdMcLeod);
            setLabel(lblFourthMcLeod, crew.FourthMcLeod);
            setLabel(lblFifthMcLeod, crew.FifthMcLeod);
            setLabel(lblDragspoon, crew.Dragspoon);
        }

        private void setLabel(Label l, int id)
        {
            l.Text = Crew.ShortName(id);
            l.Tag = id.ToString() + ":" + l.Location.X.ToString() + ":" + l.Location.Y.ToString();
            if (id != 0)
            {
                if (!labelKey.ContainsKey(id))
                {
                    labelKey.Add(id, l);
                }
            }
            
        }
        private void Label1_MouseMove(object sender, MouseEventArgs e)
        {
            if(offset != Point.Empty)
            {
                Point newLocation = lblFirstSaw.Location;
                newLocation.X += e.X;
                newLocation.Y += e.Y;
                lblFirstSaw.Location = newLocation;
            }
        }

        private void Label1_MouseUp(object sender, MouseEventArgs e)
        {
            offset = Point.Empty;
        }

        private void Panel7_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void panel_DragDrop(object sender, DragEventArgs e)
        {
            Label label = e.Data.GetData(e.Data.GetFormats()[0]) as Label;
            Panel p = sender as Panel;
            //Console.WriteLine(p.Controls.Count.ToString());
            if (label != null)
            {
                p.Controls.Add(label);
                //p.Controls[0].Dock = DockStyle.Fill;
                //Console.WriteLine("label X: " + label.Location.X + " Y: " + label.Location.Y.ToString());
                //Console.WriteLine("Control[0]X: " + p.Controls[0].Location.X.ToString() + " Y: " + p.Controls[0].Location.Y.ToString());
                label.Location = new Point(10, 30);
            }
        }

        private void form_DragDrop(object sender, DragEventArgs e)
        {
           // Console.WriteLine("E: -> X: " + e.X.ToString() + "Y: " + e.Y.ToString());
            //Console.WriteLine(e.ToString());
            Label label = e.Data.GetData(e.Data.GetFormats()[0]) as Label;
            //Console.WriteLine("Label When in Panel->X: " + label.Location.X.ToString() + " Y: " + label.Location.Y.ToString());
            Form f = sender as Form;
            Panel p;
            int px;
            int py;
            string s = label.Tag.ToString();
            string[] tags = s.Split(':');
            px = Int32.Parse(tags[1]);
            py = Int32.Parse(tags[2]);
            //Console.WriteLine(label.Name.ToString());
            if (label.Parent is Panel)
            {
                p = (Panel)label.Parent;
                p.Controls.Remove(label);
                f.Controls.Add(label);
                f.Controls[label.Name.ToString()].Dock = DockStyle.None;
                //Console.WriteLine("Label assigned to form->X: " + label.Location.X.ToString() + " Y: " + label.Location.Y.ToString());
                int x = px;
                int y = py;

                label.Location = new Point(px, py);
            }


        }
        private void Panel7_DragEnter(object sender, DragEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show(e.ToString(), "Drag", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            e.Effect = DragDropEffects.Move;
        }

        private void panel_DrageEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void form_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void Panel7_MouseUp(object sender, MouseEventArgs e)
        {
    
        }

        void l_MouseDown(object sender, MouseEventArgs e)
        {
            Label l = sender as Label;
            l.DoDragDrop(l, DragDropEffects.Move);
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            //Console.WriteLine("Label Click->X: " + this.Location.X + " " + "Y: " + this.Location.Y);
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
