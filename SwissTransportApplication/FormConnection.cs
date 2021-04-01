using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SwissTransport.Core;

namespace SwissTransportApplication
{
    public partial class FormConnection : Form
    {
        private readonly List<string> typeAheadStations = new List<string>();

        private int mailIndex;
        public FormConnection()
        {
            InitializeComponent();
        }

        private void buttonSearchConnection_Click(object sender, EventArgs e)
        {
            if (inputDeparture.Text == "" || inputArrival.Text == "")
                showMessageBox("Bitte geben Sie 2 Werte ein.", "Alert", messageBoxType.Error);
            else
                try
                {
                    dataConnections.Visible = true;

                    dataConnections.Rows.Clear();

                    var transport = new Transport();

                    var connections = transport.GetConnections(inputDeparture.Text, inputArrival.Text);

                    var buttonSend = new DataGridViewButtonColumn();

                    buttonSend.HeaderText = "Share";

                    buttonSend.Name = "buttonSend";

                    buttonSend.Text = "Share";

                    buttonSend.UseColumnTextForButtonValue = true;

                    foreach (var connection in connections.ConnectionList)
                        dataConnections.Rows.Add
                        (
                            connection.From.Platform,
                            connection.From.Station.Name,
                            connection.To.Station.Name,
                            connection.From.Departure.Value.Hour + ":" + connection.From.Departure.Value.Minute,
                            connection.To.Arrival.Value.Hour + ":" + connection.To.Arrival.Value.Minute
                        );
                    mailIndex += 1;
                    if (mailIndex == 1)
                    {
                        dataConnections.Columns.Add(buttonSend);
                    }
                }
                catch
                {
                    showMessageBox("Die angegeben Station kann nicht gefunden werden", "Error", messageBoxType.Error);
                }
        }

        private void inputDeparture_KeyPressed(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (inputDeparture.Text != "")
                {
                    var transport = new Transport();

                    var stations = transport.GetStations(inputDeparture.Text);

                    Cursor.Current = Cursors.Default;

                    autoCompleteSetConfig(inputValue.Departure);

                    foreach (var station in stations.StationList)
                        if (station != null)
                            typeAheadStations.Add(station.Name);

                    foreach (var station in typeAheadStations)
                        if (station != null)
                        {
                            inputDeparture.DroppedDown = true;
                            inputDeparture.Items.Add(station);
                        }
                }
            }
            catch
            {
                //if the request results in a "null" value, this "catch" prevents the program from Quitting.
            }
        }

        public void inputArrival_KeyPressed(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (inputArrival.Text != "")
                {
                    var ts = new Transport();

                    var st = ts.GetStations(inputArrival.Text);

                    inputArrival.DroppedDown = true;

                    autoCompleteSetConfig(inputValue.Arrival);

                    foreach (var station in st.StationList) typeAheadStations.Add(station.Name);

                    if (typeAheadStations.Count != 0)
                        foreach (var station in typeAheadStations)
                            if (station != null)
                                inputArrival.Items.Add(station);
                }
            }
            catch
            {
                //if the request results in a "null" value, this "catch" prevents the program from Quitting.
            }
        }

        private void showMessageBox(string message, string caption, messageBoxType messageBoxType)
        {
            if (messageBoxType == messageBoxType.Error)
                MessageBox.Show(message, caption, MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            else
                MessageBox.Show(message, caption, MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
        }

        private void autoCompleteSetConfig(inputValue inputValue)
        {
            if (inputValue == inputValue.Arrival)
            {
                typeAheadStations.Clear();

                inputArrival.Items.Clear();

                Cursor.Current = Cursors.Default;

                inputArrival.Items.Add(" ");

                inputArrival.SelectionStart = inputArrival.Text.Length;

                inputArrival.SelectionLength = 0;
            }
            else
            {
                typeAheadStations.Clear();

                inputDeparture.Items.Clear();

                Cursor.Current = Cursors.Default;

                inputDeparture.Items.Add(" ");

                inputDeparture.SelectionStart = inputDeparture.Text.Length;

                inputDeparture.SelectionLength = 0;
            }
        }

        private void dataConnections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Regex.IsMatch(inputEmail.Text, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"))
            {
                if (e.ColumnIndex == 5 && e.RowIndex < 4)
                {
                    var toAdress = new MailAddress(inputEmail.Text);

                    var fromAdress = new MailAddress("noreply.m318@gmail.com", "noreply@m318.com");

                    const string fromPassword = "Luzern2021!#";

                    var dataGridRow = dataConnections.Rows[e.RowIndex];

                    string dataPlatform = "Keine Daten";

                    if (dataGridRow.Cells["platform"].Value != null)
                    {
                        dataPlatform = dataGridRow.Cells["platform"].Value.ToString();
                    }

                    string dataFrom = dataGridRow.Cells["fromPlace"].Value.ToString();

                    string dataTo = dataGridRow.Cells["toPlace"].Value.ToString();

                    string dataTimeFrom = dataGridRow.Cells["fromTime"].Value.ToString();

                    string dataTimeTo = dataGridRow.Cells["toTime"].Value.ToString();

                    var smtpClient = new SmtpClient
                    {
                        Host = "smtp.gmail.com",
                        Port = 587,
                        EnableSsl = true,
                        DeliveryMethod = SmtpDeliveryMethod.Network,
                        UseDefaultCredentials = false,
                        Credentials = new NetworkCredential(fromAdress.Address, fromPassword)
                    };

                    try
                    {
                        using (var message = new MailMessage(fromAdress, toAdress))
                        {
                            message.To.Add(toAdress.Address);
                            message.Subject = "Fahrplan";
                            message.Body = 
                            (
                                "Gleis: " + dataPlatform + "\n" +
                                "Von: " + dataFrom + "\n" + 
                                "Nach: " + dataTo + "\n" + 
                                "Zeit (ab): " + dataTimeFrom + "\n" +
                                "Zeit (an): " + dataTimeTo + "\n"
                            );
                            smtpClient.Send(message);
                            MessageBox.Show("E-Mail Erfolgreich an: "+inputEmail.Text + " versendet", "E-Mail Sender", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Geben Sie eine gültige E-Mail Adresse ein" , "E-Mail Sender", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private enum messageBoxType
        {
            Error,
            Alert
        }

        private enum inputValue
        {
            Arrival,
            Departure
        }
    }
}