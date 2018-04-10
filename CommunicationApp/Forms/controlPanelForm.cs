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
                Log selectedLog;
                if (simulationSelected)
                {
                    selectedLog = simulationLog;
                }
                else
                {
                    selectedLog = chaarrLog;
                }
                selectedLog.Response = JsonConvert.DeserializeObject<Response>(response.Content);
                richTextBoxActions.Text = "";
                foreach (var Action in selectedLog.Actions)
                {
                    iterator++;
                    richTextBoxActions.Text += iterator.ToString() + '.' + Action.ToString() + Environment.NewLine;
                }
                this.richTextBoxAllEvents.Text = selectedLog.Response.EventsToString(this.checkBoxShowImportantOnly.Checked);
                this.richTextBoxParameters.Text = selectedLog.Response.Parameters.ToString();
                this.richTextBoxScores.Text = selectedLog.Response.Scores.ToString();
                this.richTextBoxEquipments.Text = selectedLog.Response.EquipmentsToString();
                this.richTextBoxLastTurnEvents.Text = selectedLog.Response.LastTurnEventsToString(this.checkBoxShowImportantOnly.Checked);
                this.richTextBoxLogBook.Text = selectedLog.Response.LogBookToString();
                this.labelTurn.Text = "Turn: " + selectedLog.Response.Turn;
                this.labelLocation.Text = "Location: " + selectedLog.Response.Location;
                this.labelTerminated.Text = "Is terminated: " + selectedLog.Response.IsTerminated.ToString();

                if (selectedLog.Response.IsTerminated)
                {
                    FileWriterReaderHelper.WriteLog(selectedLog.ToString(), simulationSelected);
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

        private void checkBoxShowImportantOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (simulationSelected)
            {
                if (simulationLog.Response != null)
                {
                    this.richTextBoxAllEvents.Text = simulationLog.Response.EventsToString(this.checkBoxShowImportantOnly.Checked);
                    this.richTextBoxLastTurnEvents.Text = simulationLog.Response.LastTurnEventsToString(this.checkBoxShowImportantOnly.Checked);
                }
                else
                {
                    MessageBox.Show("First you must get status!");
                }
            }
            else
            {
                if (chaarrLog.Response != null)
                {
                    this.richTextBoxAllEvents.Text = chaarrLog.Response.EventsToString(this.checkBoxShowImportantOnly.Checked);
                    this.richTextBoxLastTurnEvents.Text = chaarrLog.Response.LastTurnEventsToString(this.checkBoxShowImportantOnly.Checked);
                }
                else
                {
                    MessageBox.Show("First you must get status!");
                }
            }

        }

        private void buttonStartProcedure_Click(object sender, EventArgs e)
        {
            if (simulationSelected)
            {
                this.btnReset.PerformClick();
                var payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                var client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                var request = ConnectionHelper.CreateRequest(payload);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Scan", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");
                    
                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");
                        
                    }
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");
                    
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Supplies","500").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.simulationLog.Actions.Add(new Action("Produce", "Supplies", "500"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");
                }
                payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 3; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Supplies", "500").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.simulationLog.Actions.Add(new Action("Produce", "Supplies", "500"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");
                }
                payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                //zmiana w AL z 4 na 3 - ok; z 3 na 2 -ok
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 2; i++)
               {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Chaarr").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Scan", "Chaarr"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }

                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                //zmiana w AL

     //           this.btnStatus.PerformClick();
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Shuttlewrench").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Shuttlewrench"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 3; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                 payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                 client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                 request = ConnectionHelper.CreateRequest(payload);
                 response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Scan", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }

                payload = new Payload("Repair", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Repair", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Shuttle").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.simulationLog.Actions.Add(new Action("Scan", "Shuttle"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.simulationLog.Actions.Add(new Action("Produce", "Energy"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }

                this.btnStatus.PerformClick();
            }
            else
            {
                this.btnReset.PerformClick();
                var payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                var client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                var request = ConnectionHelper.CreateRequest(payload);
                IRestResponse response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Scan", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Supplies", "500").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.chaarrLog.Actions.Add(new Action("Produce", "Supplies", "500"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");
                }
                payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 3; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Supplies", "500").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    this.chaarrLog.Actions.Add(new Action("Produce", "Supplies", "500"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");
                }
                payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                //zmiana w AL z 4 na 3 - ok; z 3 na 2 -ok
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }

                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Chaarr").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Scan", "Chaarr"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }

                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                //zmiana w AL

                //           this.btnStatus.PerformClick();
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Shuttlewrench").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Shuttlewrench"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 3; i++)
                {
                    payload = new Payload("Harvest", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Harvest", "Asteroids"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }
                payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Scan", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }

                payload = new Payload("Repair", ConnectionHelper.Login, ConnectionHelper.Token, "Asteroids").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Repair", "Asteroids"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                payload = new Payload("Scan", ConnectionHelper.Login, ConnectionHelper.Token, "Shuttle").ToJson();
                client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                request = ConnectionHelper.CreateRequest(payload);
                response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.OK)
                {

                    this.chaarrLog.Actions.Add(new Action("Scan", "Shuttle"));
                }
                else
                {
                    MessageBox.Show("Something gone wrong!");

                }
                for (int i = 0; i < 2; i++)
                {
                    payload = new Payload("Produce", ConnectionHelper.Login, ConnectionHelper.Token, "Energy").ToJson();
                    client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                    request = ConnectionHelper.CreateRequest(payload);
                    response = client.Execute(request);
                    if (response.StatusCode == HttpStatusCode.OK)
                    {

                        this.chaarrLog.Actions.Add(new Action("Produce", "Energy"));
                    }
                    else
                    {
                        MessageBox.Show("Something gone wrong!");

                    }
                }

                this.btnStatus.PerformClick();
            }
        }
    }
}
