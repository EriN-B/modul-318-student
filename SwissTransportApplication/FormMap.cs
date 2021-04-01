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
    public partial class FormMap : Form
    {

        List<SwissTransport.Models.Station> listStations = new List<SwissTransport.Models.Station>();

        List<string> listStaionNames = new List<string>();
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

            string stationName;

            string stationId;

            try
            {
                listStations.Clear();

                var transport = new Transport();

                List <Station> listStationsResult = transport.GetStations(inputLocation.Text).StationList;

                Station stationFoundStation = listStationsResult.Find(x => x.Name == inputLocation.Text);

                MessageBox.Show(stationFoundStation.Name);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
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
    }
}
