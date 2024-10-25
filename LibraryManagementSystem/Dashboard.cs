﻿using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            this.HidePanels();
            this.dashboardPanel.Visible = true;
        }

        private void DashboardBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.dashboardPanel.Visible = true;
        }
        private void ManageBooksBtn_Click(object sender, EventArgs e)
        {
            this.HidePanels();
            this.manageBookPanel.Visible = true;
        }

        private void HidePanels()
        {
            this.dashboardPanel.Visible = false;
            this.manageBookPanel.Visible = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
