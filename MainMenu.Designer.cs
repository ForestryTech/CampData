namespace CampData
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.campCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLT1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hooklineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLT2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hooklineToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pLT3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hooklineToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pLT4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hooklineToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.seatingChartToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bugCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmBugCrew = new System.Windows.Forms.ToolStripMenuItem();
            this.inCampToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALFIREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.campRosterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireRollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fireAssignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projectsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALFIREToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cDCRToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.campCountsToolStripMenuItem,
            this.crewsToolStripMenuItem,
            this.inCampToolStripMenuItem,
            this.campRosterToolStripMenuItem,
            this.loadOutToolStripMenuItem,
            this.fireRollToolStripMenuItem,
            this.fireAssignmentsToolStripMenuItem,
            this.specialStatusToolStripMenuItem,
            this.projectsToolStripMenuItem,
            this.personnelToolStripMenuItem,
            this.vehiclesToolStripMenuItem,
            this.formsToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(137, 967);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // campCountsToolStripMenuItem
            // 
            this.campCountsToolStripMenuItem.Name = "campCountsToolStripMenuItem";
            this.campCountsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.campCountsToolStripMenuItem.Text = "Camp Counts";
            this.campCountsToolStripMenuItem.Click += new System.EventHandler(this.CampSnapShotMenu_Click);
            // 
            // crewsToolStripMenuItem
            // 
            this.crewsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pLT1ToolStripMenuItem,
            this.pLT2ToolStripMenuItem,
            this.pLT3ToolStripMenuItem,
            this.pLT4ToolStripMenuItem,
            this.bugCrewToolStripMenuItem});
            this.crewsToolStripMenuItem.Name = "crewsToolStripMenuItem";
            this.crewsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.crewsToolStripMenuItem.Text = "Crews";
            // 
            // pLT1ToolStripMenuItem
            // 
            this.pLT1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hooklineToolStripMenuItem,
            this.seatingToolStripMenuItem});
            this.pLT1ToolStripMenuItem.Name = "pLT1ToolStripMenuItem";
            this.pLT1ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pLT1ToolStripMenuItem.Text = "PLT 1";
            // 
            // hooklineToolStripMenuItem
            // 
            this.hooklineToolStripMenuItem.Name = "hooklineToolStripMenuItem";
            this.hooklineToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.hooklineToolStripMenuItem.Tag = "1";
            this.hooklineToolStripMenuItem.Text = "Hookline";
            this.hooklineToolStripMenuItem.Click += new System.EventHandler(this.HooklineMenu_Click);
            // 
            // seatingToolStripMenuItem
            // 
            this.seatingToolStripMenuItem.Name = "seatingToolStripMenuItem";
            this.seatingToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.seatingToolStripMenuItem.Tag = "1";
            this.seatingToolStripMenuItem.Text = "Seating Chart";
            this.seatingToolStripMenuItem.Click += new System.EventHandler(this.SeatingChartMenu_Click);
            // 
            // pLT2ToolStripMenuItem
            // 
            this.pLT2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hooklineToolStripMenuItem1,
            this.seatingChartToolStripMenuItem});
            this.pLT2ToolStripMenuItem.Name = "pLT2ToolStripMenuItem";
            this.pLT2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pLT2ToolStripMenuItem.Text = "PLT 2";
            // 
            // hooklineToolStripMenuItem1
            // 
            this.hooklineToolStripMenuItem1.Name = "hooklineToolStripMenuItem1";
            this.hooklineToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.hooklineToolStripMenuItem1.Tag = "2";
            this.hooklineToolStripMenuItem1.Text = "Hookline";
            this.hooklineToolStripMenuItem1.Click += new System.EventHandler(this.HooklineMenu_Click);
            // 
            // seatingChartToolStripMenuItem
            // 
            this.seatingChartToolStripMenuItem.Name = "seatingChartToolStripMenuItem";
            this.seatingChartToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.seatingChartToolStripMenuItem.Tag = "2";
            this.seatingChartToolStripMenuItem.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem.Click += new System.EventHandler(this.SeatingChartMenu_Click);
            // 
            // pLT3ToolStripMenuItem
            // 
            this.pLT3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hooklineToolStripMenuItem2,
            this.seatingChartToolStripMenuItem1});
            this.pLT3ToolStripMenuItem.Name = "pLT3ToolStripMenuItem";
            this.pLT3ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pLT3ToolStripMenuItem.Text = "PLT 3";
            // 
            // hooklineToolStripMenuItem2
            // 
            this.hooklineToolStripMenuItem2.Name = "hooklineToolStripMenuItem2";
            this.hooklineToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.hooklineToolStripMenuItem2.Tag = "3";
            this.hooklineToolStripMenuItem2.Text = "Hookline";
            this.hooklineToolStripMenuItem2.Click += new System.EventHandler(this.HooklineMenu_Click);
            // 
            // seatingChartToolStripMenuItem1
            // 
            this.seatingChartToolStripMenuItem1.Name = "seatingChartToolStripMenuItem1";
            this.seatingChartToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.seatingChartToolStripMenuItem1.Tag = "3";
            this.seatingChartToolStripMenuItem1.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem1.Click += new System.EventHandler(this.SeatingChartMenu_Click);
            // 
            // pLT4ToolStripMenuItem
            // 
            this.pLT4ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hooklineToolStripMenuItem3,
            this.seatingChartToolStripMenuItem2});
            this.pLT4ToolStripMenuItem.Name = "pLT4ToolStripMenuItem";
            this.pLT4ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.pLT4ToolStripMenuItem.Text = "PLT 4";
            // 
            // hooklineToolStripMenuItem3
            // 
            this.hooklineToolStripMenuItem3.Name = "hooklineToolStripMenuItem3";
            this.hooklineToolStripMenuItem3.Size = new System.Drawing.Size(216, 26);
            this.hooklineToolStripMenuItem3.Tag = "4";
            this.hooklineToolStripMenuItem3.Text = "Hookline";
            this.hooklineToolStripMenuItem3.Click += new System.EventHandler(this.HooklineMenu_Click);
            // 
            // seatingChartToolStripMenuItem2
            // 
            this.seatingChartToolStripMenuItem2.Name = "seatingChartToolStripMenuItem2";
            this.seatingChartToolStripMenuItem2.Size = new System.Drawing.Size(216, 26);
            this.seatingChartToolStripMenuItem2.Tag = "4";
            this.seatingChartToolStripMenuItem2.Text = "Seating Chart";
            this.seatingChartToolStripMenuItem2.Click += new System.EventHandler(this.SeatingChartMenu_Click);
            // 
            // bugCrewToolStripMenuItem
            // 
            this.bugCrewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmBugCrew});
            this.bugCrewToolStripMenuItem.Name = "bugCrewToolStripMenuItem";
            this.bugCrewToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.bugCrewToolStripMenuItem.Text = "Bug Crew";
            // 
            // tsmBugCrew
            // 
            this.tsmBugCrew.Name = "tsmBugCrew";
            this.tsmBugCrew.Size = new System.Drawing.Size(216, 26);
            this.tsmBugCrew.Text = "Roster";
            this.tsmBugCrew.Click += new System.EventHandler(this.BugCrewRoster_Click);
            // 
            // inCampToolStripMenuItem
            // 
            this.inCampToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cALFIREToolStripMenuItem,
            this.cDCRToolStripMenuItem});
            this.inCampToolStripMenuItem.Name = "inCampToolStripMenuItem";
            this.inCampToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.inCampToolStripMenuItem.Text = "In Camp";
            // 
            // cALFIREToolStripMenuItem
            // 
            this.cALFIREToolStripMenuItem.Name = "cALFIREToolStripMenuItem";
            this.cALFIREToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.cALFIREToolStripMenuItem.Text = "CAL FIRE";
            // 
            // cDCRToolStripMenuItem
            // 
            this.cDCRToolStripMenuItem.Name = "cDCRToolStripMenuItem";
            this.cDCRToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.cDCRToolStripMenuItem.Text = "CDCR";
            // 
            // campRosterToolStripMenuItem
            // 
            this.campRosterToolStripMenuItem.Name = "campRosterToolStripMenuItem";
            this.campRosterToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.campRosterToolStripMenuItem.Text = "Camp Roster";
            this.campRosterToolStripMenuItem.Click += new System.EventHandler(this.CampRosterMenu_Click);
            // 
            // loadOutToolStripMenuItem
            // 
            this.loadOutToolStripMenuItem.Name = "loadOutToolStripMenuItem";
            this.loadOutToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.loadOutToolStripMenuItem.Text = "Load Out";
            // 
            // fireRollToolStripMenuItem
            // 
            this.fireRollToolStripMenuItem.Name = "fireRollToolStripMenuItem";
            this.fireRollToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.fireRollToolStripMenuItem.Text = "Fire Roll";
            // 
            // fireAssignmentsToolStripMenuItem
            // 
            this.fireAssignmentsToolStripMenuItem.Name = "fireAssignmentsToolStripMenuItem";
            this.fireAssignmentsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.fireAssignmentsToolStripMenuItem.Text = "Fire Assignments";
            // 
            // specialStatusToolStripMenuItem
            // 
            this.specialStatusToolStripMenuItem.Name = "specialStatusToolStripMenuItem";
            this.specialStatusToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.specialStatusToolStripMenuItem.Text = "Special Status";
            // 
            // projectsToolStripMenuItem
            // 
            this.projectsToolStripMenuItem.Name = "projectsToolStripMenuItem";
            this.projectsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.projectsToolStripMenuItem.Text = "Projects";
            // 
            // personnelToolStripMenuItem
            // 
            this.personnelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cALFIREToolStripMenuItem1,
            this.cDCRToolStripMenuItem1,
            this.allToolStripMenuItem});
            this.personnelToolStripMenuItem.Name = "personnelToolStripMenuItem";
            this.personnelToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.personnelToolStripMenuItem.Text = "Personnel";
            // 
            // cALFIREToolStripMenuItem1
            // 
            this.cALFIREToolStripMenuItem1.Name = "cALFIREToolStripMenuItem1";
            this.cALFIREToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.cALFIREToolStripMenuItem1.Tag = "1";
            this.cALFIREToolStripMenuItem1.Text = "CALFIRE";
            this.cALFIREToolStripMenuItem1.Click += new System.EventHandler(this.PersonnelMenu_Click);
            // 
            // cDCRToolStripMenuItem1
            // 
            this.cDCRToolStripMenuItem1.Name = "cDCRToolStripMenuItem1";
            this.cDCRToolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.cDCRToolStripMenuItem1.Tag = "2";
            this.cDCRToolStripMenuItem1.Text = "CDCR";
            this.cDCRToolStripMenuItem1.Click += new System.EventHandler(this.PersonnelMenu_Click);
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.allToolStripMenuItem.Tag = "3";
            this.allToolStripMenuItem.Text = "All";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.PersonnelMenu_Click);
            // 
            // vehiclesToolStripMenuItem
            // 
            this.vehiclesToolStripMenuItem.Name = "vehiclesToolStripMenuItem";
            this.vehiclesToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.vehiclesToolStripMenuItem.Text = "Vehicles";
            this.vehiclesToolStripMenuItem.Click += new System.EventHandler(this.VehicleMenu_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 967);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem campCountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crewsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLT1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLT2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLT3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pLT4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bugCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inCampToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALFIREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cDCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem campRosterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireRollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fireAssignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projectsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehiclesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALFIREToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cDCRToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hooklineToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seatingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hooklineToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hooklineToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hooklineToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem seatingChartToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tsmBugCrew;
    }
}