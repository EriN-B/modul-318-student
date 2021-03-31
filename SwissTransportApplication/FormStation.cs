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
            {
  
                Transport ts = new Transport();
                Stations st = ts.GetStations(inputStation.Text);
                foreach (var station in st.StationList)
                {
                    listStations.Items.Add(station.Name);
                }
            }
        }

        private void FormStation_Load(object sender, EventArgs e)
        {
            
        }
    }
}
