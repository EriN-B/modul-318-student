using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApplication
{
    public partial class FormConnection : Form
    {
        private string currentTextBox = "inputDeparture";
        public FormConnection()
        {
            InitializeComponent();
        }
         //Muss verbessert werden.
        private void buttonSearchConnection_Click(object sender, EventArgs e)
        {
            if (inputDeparture.Text != "" && inputArrival.Text != "")
            {
                dataConnections.Rows.Clear();
                Transport ts = new Transport();
                Connections connections = ts.GetConnections(inputDeparture.Text, inputArrival.Text);
                foreach (var connection in connections.ConnectionList)
                {
                    string platform = connection.From.Platform;
                    string timeDeparture = connection.From.Departure.Value.Hour.ToString() + ":"  
                                           + connection.From.Departure.Value.Minute.ToString();
                    string timeArrival = connection.To.Arrival.Value.Hour.ToString() + ":" 
                                         + connection.To.Arrival.Value.Minute.ToString();
                    dataConnections.Rows.Add(platform,connection.From.Station.Name, connection.To.Station.Name,timeDeparture, timeArrival);
                }
            }
        }

        private void listStation_doubleClick(object sender, EventArgs e)
        {
            if (currentTextBox == "inputDeparture")
            {
                inputDeparture.Text = listStations.SelectedItem.ToString();
            }
            else
            {
                inputArrival.Text = listStations.SelectedItem.ToString();
            }
        }

        private void inputDeparture_TextChanged(object sender, EventArgs e)
        {
            inputDeparture.Focus();
            listStations.Items.Clear();
                try
                {

                    if (inputDeparture.Text != "")
                    {
                        Transport ts = new Transport();
                        Stations st = ts.GetStations(inputDeparture.Text);
                        foreach (var station in st.StationList)
                        {
                            listStations.Items.Add(station.Name);
                        }
                    }
                }
                catch
                {
                   //if the request results in a "null" value, this "catch" prevents the program from Quitting.
                }
        }

        public void currentInput_FocusChanged(object sender, EventArgs e)
        {
            string senderName = ((TextBox)sender).Name;
            if (senderName == "inputDeparture")
            {
                currentTextBox = "inputDeparture";
            }
            else
            {
                currentTextBox = "inputArrival";
            }
        }

        private void inputArrival_TextChanged(object sender, EventArgs e)
        {
            listStations.Items.Clear();
            try
            {

                if (inputDeparture.Text != "")
                {
                    Transport ts = new Transport();
                    Stations st = ts.GetStations(inputArrival.Text);
                    foreach (var station in st.StationList)
                    {
                        listStations.Items.Add(station.Name);
                    }
                }
            }
            catch
            {
                //if the request results in a "null" value, this "catch" prevents the program from Quitting.
            }
        }
    }
}
