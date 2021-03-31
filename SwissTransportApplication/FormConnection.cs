﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SwissTransport.Core;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace SwissTransportApplication
{
    public partial class FormConnection : Form
    {
        private readonly List<string> typeAheadStations = new List<string>();
        public FormConnection()
        {
            InitializeComponent();
        }

        private void buttonSearchConnection_Click(object sender, EventArgs e)
        {
            if (inputDeparture.Text == "" || inputArrival.Text == "")
            {
                showMessageBox("Bitte geben Sie 2 Werte ein.", "Alert", messageBoxType.Error);
            }
            else
            {
                try
                {
                    dataConnections.Visible = true;

                    dataConnections.Rows.Clear();

                    var transport = new Transport();

                    var connections = transport.GetConnections(inputDeparture.Text, inputArrival.Text);

                    DataGridViewButtonColumn buttonSend = new DataGridViewButtonColumn();

                    buttonSend.HeaderText = "Share";

                    buttonSend.Name = "buttonSend";

                    buttonSend.Text = "Share";

                    buttonSend.UseColumnTextForButtonValue = true;

                    foreach (var connection in connections.ConnectionList)
                    {
                        dataConnections.Rows.Add
                        (
                            connection.From.Platform,
                            connection.From.Station.Name,
                            connection.To.Station.Name,
                            connection.From.Departure.Value.Hour.ToString() + ":" + connection.From.Departure.Value.Minute.ToString(),
                            connection.To.Arrival.Value.Hour.ToString() + ":" + connection.To.Arrival.Value.Minute.ToString()
                        );
                    }
                    dataConnections.Columns.Add(buttonSend);
                }
                catch
                {
                    showMessageBox("Die angegeben Station kann nicht gefunden werden", "Error", messageBoxType.Error);
                }
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
                    {
                        foreach (var station in typeAheadStations)
                            if (station != null)
                            {
                                inputArrival.Items.Add(station);
                            }
                    }
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

        private void dataConnections_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 5 && e.RowIndex < 4)
            {
                var toAdress = new MailAddress("noreply.m318@gmail.com");
                var fromAdress = new MailAddress("noreply.m318@gmail.com", "m318-student");
                const string fromPassword = "Luzern2021!#";

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
                    using(var message = new MailMessage(fromAdress, toAdress))
                    {
                        message.To.Add(toAdress.Address);
                        message.Subject = "Test";
                        message.Body = "Test";
                        smtpClient.Send(message);
                    }
                }
                catch(Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
    }
}