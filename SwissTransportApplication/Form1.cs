using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportApplication
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTable_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormPlan formPlan = new FormPlan() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            formPlan.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formPlan);
            formPlan.Show();
            labelTitle.Text = "Abfahrtstafel";
        }

        private void buttonConnections_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormConnection formConnection = new FormConnection() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formConnection.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formConnection);
            formConnection.Show();
            labelTitle.Text = "Verbindungen";
        }

        private void buttonMap_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormMap formMap = new FormMap() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formMap.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formMap);
            formMap.Show();
            labelTitle.Text = "Karte";
        }

        private void buttonStation_Click(object sender, EventArgs e)
        {
            //Load Station-Serch Component
            panelMain.Controls.Clear();
            FormStation formStation = new FormStation { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formStation.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formStation);
            formStation.Show();
            labelTitle.Text = "Stationen";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();
            FormConnection formConnection = new FormConnection() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formConnection.FormBorderStyle = FormBorderStyle.None;
            panelMain.Controls.Add(formConnection);
            formConnection.Show();
            labelTitle.Text = "Verbindungen";
        }
    }
}
