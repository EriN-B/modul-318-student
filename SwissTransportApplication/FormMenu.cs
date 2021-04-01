using System;
using System.Windows.Forms;

namespace SwissTransportApplication
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var formPlan = new FormPlan {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formPlan.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formPlan);
            formPlan.Show();
            labelTitle.Text = "Abfahrtstafel";
        }

        private void buttonConnections_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var formConnection = new FormConnection {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formConnection.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formConnection);
            formConnection.Show();
            labelTitle.Text = "Verbindungen";
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var formMap = new FormMap {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formMap.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formMap);
            formMap.Show();
            labelTitle.Text = "Karte";
        }

        private void buttonStation_Click(object sender, EventArgs e)
        {
            //Load Station-Serch Component
            panelMain.Controls.Clear();
            var formStation = new FormStation {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formStation.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formStation);
            formStation.Show();
            labelTitle.Text = "Stationen";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            var formConnection = new FormConnection {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formConnection.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formConnection);
            formConnection.Show();
            labelTitle.Text = "Verbindungen";
        }
    }
}