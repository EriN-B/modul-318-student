using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;

namespace SwissTransportApplication
{
    public partial class FormMap : Form
    {
        private readonly List<Station> listStations = new List<Station>();
        private List<string> listStaionNames = new List<string>();

        public FormMap()
        {
            InitializeComponent();
        }

        private void FormMap_Load(object sender, EventArgs e)
        {
        }

        private void buttonLocation_Click(object sender, EventArgs e)
        {
            string xCoordinate;

            string yCoordinate;

            if (checkInternetConnection())
                try
                {
                    listStations.Clear();

                    var transport = new Transport();

                    var listStationsResult = transport.GetStations(inputLocation.Text).StationList;

                    var stationFoundStation = listStationsResult.Find(x => x.Name == inputLocation.Text);

                    if (stationFoundStation != null)
                    {
                        xCoordinate = stationFoundStation.Coordinate.XCoordinate.ToString();

                        yCoordinate = stationFoundStation.Coordinate.YCoordinate.ToString();

                        if (radioWeb.Checked)
                            Process.Start("https://www.google.com/maps/search/?api=1&query=" +
                                          xCoordinate.Replace(",", ".") + "," + yCoordinate.Replace(",", "."));
                        else if (radioApp.Checked)
                            webBrowserMaps.Navigate("https://www.google.com/maps/search/?api=1&query=" +
                                                    xCoordinate.Replace(",", ".") + "," +
                                                    yCoordinate.Replace(",", "."));
                    }
                    else
                    {
                        MessageBox.Show("Station konnte nicht gefunden werden.", "Maps", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Diese Station scheint keine Coordinaten zu haben", "Maps", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            else
                MessageBox.Show("Bitte stellen Sie sicher, dass Sie mit dem Internet verbunden sind. ", "Maps",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void inputLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (inputLocation.Text != "")
                {
                    var transport = new Transport();

                    var stations = transport.GetStations(inputLocation.Text);

                    listStations.Clear();

                    inputLocation.Items.Clear();

                    Cursor.Current = Cursors.Default;

                    inputLocation.Items.Add(" ");

                    inputLocation.SelectionStart = inputLocation.Text.Length;

                    inputLocation.SelectionLength = 0;

                    foreach (var station in stations.StationList)
                        if (station != null)
                            listStations.Add(station);

                    foreach (var station in listStations)
                        if (station != null)
                        {
                            inputLocation.DroppedDown = true;
                            inputLocation.Items.Add(station.Name);
                        }
                }
            }
            catch
            {
                //if the request results in a "null" value, this "catch" prevents the program from Quitting.
            }
        }

        private bool checkInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}