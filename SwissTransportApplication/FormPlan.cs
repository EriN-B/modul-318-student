using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport.Core;

namespace SwissTransportApplication
{
    public partial class FormPlan : Form
    {
        private readonly List<string> typeAheadStations = new List<string>();

        public FormPlan()
        {
            InitializeComponent();
        }

        private void buttonSearchStation_Click(object sender, EventArgs e)
        {
            if (inputStation.Text != "")
                try
                {
                    dataStainBoard.Rows.Clear();
                    var transport = new Transport();
                    var stationBoard = transport.GetStationBoard(inputStation.Text);
                    foreach (var stations in stationBoard.Entries)
                        dataStainBoard.Rows.Add
                        (
                            inputStation.Text,
                            stations.To,
                            stations.Category,
                            stations.Stop.Departure.Hour + ":" + stations.Stop.Departure.Minute
                        );
                }
                catch
                {
                    //showMessageBox("Die angegeben Station kann nicht gefunden werden", "Error", messageBoxType.Error);
                }
        }

        private void autoCompleteSetConfig()
        {
            typeAheadStations.Clear();

            inputStation.Items.Clear();

            inputStation.Items.Add("");

            Cursor.Current = Cursors.Default;

            inputStation.SelectionStart = inputStation.Text.Length;

            inputStation.SelectionLength = 0;

            inputStation.DroppedDown = true;
        }

        private void inputStation_KeyPressed(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (inputStation.Text != "")
                {
                    dataStainBoard.Visible = true;

                    var transport = new Transport();

                    var stations = transport.GetStations(inputStation.Text);

                    autoCompleteSetConfig();

                    foreach (var station in stations.StationList)
                        if (station != null)
                            typeAheadStations.Add(station.Name);
                    foreach (var station in typeAheadStations)
                        if (station != null)
                            inputStation.Items.Add(station);
                }
            }
            catch
            {
                //if the request results in a "null" value, this "catch" prevents the program from Quitting.
            }
        }

        private void FormPlan_Load(object sender, EventArgs e)
        {
            ActiveControl = inputStation;
        }

        private enum inputValue
        {
            Arrival,
            Departure
        }
    }
}