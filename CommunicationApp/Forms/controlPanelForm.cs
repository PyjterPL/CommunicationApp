using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunicationApp.Forms;
using CommunicationApp.Helpers;

namespace CommunicationApp
{
    public partial class controlPanelForm : Form
    {
        private bool simulationSelected = true;
        private Log simulationLog;
        private Log chaarrLog;
        public controlPanelForm()
        {
            InitializeComponent();
            radioButtonSimulation.Select();
            simulationLog = new Log();
            chaarrLog = new Log();
            var helloForm = new helloForm();
            helloForm.ShowDialog();
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(ConnectionHelper.GetParametersAdress(simulationSelected));
            var request = ConnectionHelper.CreateRequest();
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                short iterator = 0;
                if (simulationSelected)
                {
                    simulationLog.Response = JsonConvert.DeserializeObject<Response>(response.Content);
                    richTextBoxActions.Text = "";
                    foreach (var Action in simulationLog.Actions)
                    {
                        iterator++;
                        richTextBoxActions.Text += iterator.ToString() + '.' + Action.ToString() + Environment.NewLine;
                    }
                    this.richTextBoxAllEvents.Text = simulationLog.Response.EventsToString();
                    this.richTextBoxParameters.Text = simulationLog.Response.Parameters.ToString();
                    this.richTextBoxScores.Text = simulationLog.Response.Scores.ToString();
                    this.richTextBoxEquipments.Text = simulationLog.Response.EquipmentsToString();
                    this.richTextBoxLastTurnEvents.Text = simulationLog.Response.LastTurnEventsToString();
                    this.labelTurn.Text = "Turn: " + simulationLog.Response.Turn;
                    this.labelLocation.Text = "Location: " + simulationLog.Response.Location;
                    this.labelTerminated.Text = "Is terminated: " + simulationLog.Response.IsTerminated.ToString();

                    if (simulationLog.Response.IsTerminated)
                    {
                        FileWriterReaderHelper.WriteLog(simulationLog.ToString());
                    }
                }
                else
                {
                    chaarrLog.Response = JsonConvert.DeserializeObject<Response>(response.Content);
                    richTextBoxActions.Text = "";
                    foreach (var Action in chaarrLog.Actions)
                    {
                        iterator++;
                        richTextBoxActions.Text += iterator.ToString() + '.' + Action.ToString() + Environment.NewLine;
                    }
                    this.richTextBoxAllEvents.Text = chaarrLog.Response.EventsToString();
                    this.richTextBoxParameters.Text = chaarrLog.Response.Parameters.ToString();
                    this.richTextBoxScores.Text = chaarrLog.Response.Scores.ToString();
                    this.richTextBoxEquipments.Text = chaarrLog.Response.EquipmentsToString();
                    this.richTextBoxLastTurnEvents.Text = chaarrLog.Response.LastTurnEventsToString();
                    this.labelTurn.Text = "Turn: " + chaarrLog.Response.Turn;
                    this.labelLocation.Text = "Location: " + chaarrLog.Response.Location;
                    this.labelTerminated.Text = "Is terminated: " + chaarrLog.Response.IsTerminated.ToString();

                    if (chaarrLog.Response.IsTerminated)
                    {
                        FileWriterReaderHelper.WriteLog(chaarrLog.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Something gone wrong!");
            }
        }

        private void radioButtonSimulation_CheckedChanged(object sender, EventArgs e)
        {
            simulationSelected = true;
        }

        private void radioButtonChaarr_CheckedChanged(object sender, EventArgs e)
        {
            simulationSelected = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            var payload = new Payload("Restart", ConnectionHelper.Login, ConnectionHelper.Token).ToJson();
            var client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
            var request = ConnectionHelper.CreateRequest(payload);
            IRestResponse response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Clear();
                    richTextBoxActions.Text = "";
                }
                else
                {
                    chaarrLog.Actions.Clear();
                    richTextBoxActions.Text = "";
                }
                this.btnStatus.PerformClick();
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm(new Action("Scan"), simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Add(parametersForm.Action);
                }
                else
                {
                    chaarrLog.Actions.Add(parametersForm.Action);
                }

                btnStatus.PerformClick();
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm(new Action("MoveTo"), simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Add(parametersForm.Action);
                }
                else
                {
                    chaarrLog.Actions.Add(parametersForm.Action);
                }
                btnStatus.PerformClick();
            }
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm(new Action("Harvest"), simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Add(parametersForm.Action);
                }
                else
                {
                    chaarrLog.Actions.Add(parametersForm.Action);
                }
                btnStatus.PerformClick();
            }
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm(new Action("Produce"), simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Add(parametersForm.Action);
                }
                else
                {
                    chaarrLog.Actions.Add(parametersForm.Action);
                }
                btnStatus.PerformClick();
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm(new Action("Repair"), simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Add(parametersForm.Action);
                }
                else
                {
                    chaarrLog.Actions.Add(parametersForm.Action);
                }
                btnStatus.PerformClick();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm(new Action("Order"), simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                if (simulationSelected)
                {
                    simulationLog.Actions.Add(parametersForm.Action);
                }
                else
                {
                    chaarrLog.Actions.Add(parametersForm.Action);
                }
                btnStatus.PerformClick();
            }
        }

        private void controlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO zapis do pliku
            MessageBox.Show("Goodbye!");
        }

        private void buttonShowFullResponse_Click(object sender, EventArgs e)
        {
            if (simulationSelected)
            {
                if (simulationLog.Response != null)
                {
                    var wholeResponseForm = new showAllForm(simulationLog.Response.ToString());
                    wholeResponseForm.ShowDialog();
                    //MessageBox.Show(simulationLog.Response.ToString());
                }
                else
                {
                    MessageBox.Show("First you must get status!");
                }
                
            }
            else
            {
                if (simulationLog.Response != null)
                {
                    var wholeResponseForm = new showAllForm(chaarrLog.Response.ToString());
                    wholeResponseForm.ShowDialog();
                   // MessageBox.Show(chaarrLog.Response.ToString());
                }
                else
                {
                    MessageBox.Show("First you must get status!");
                }
                
            }
            
        }
    }
}
