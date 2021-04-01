using System;
using System.Windows.Forms;
using SwissTransport.Core;

namespace SwissTransportApplication
{
    public partial class FormStation : Form
    {
        public FormStation()
        {
            InitializeComponent();
        }

        private void inputStation_TextChanged(object sender, EventArgs e)
        {
            listStations.Items.Clear();
            if (inputStation.Text != null)
                try
                {
                    var ts = new Transport();
                    var st = ts.GetStations(inputStation.Text);
                    foreach (var station in st.StationList) listStations.Items.Add(station.Name);
                }
                catch
                {
                    //if the request results in a "null" value, this "catch" prevents the program from Quitting.
                }
        }

        private void FormStation_Load(object sender, EventArgs e)
        {
        }
    }
}