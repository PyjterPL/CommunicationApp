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

namespace CommunicationApp
{
    public partial class controlPanelForm : Form
    {
        private bool simulationSelected = true;
        private Response statusResponse;
        private List<string> actions;
        private string lastAction;
        public controlPanelForm()
        {
            InitializeComponent();
            radioButtonSimulation.Select();
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
                //TODO: Zrobić porządne wyświetlanie
                statusResponse = JsonConvert.DeserializeObject<Response>(response.Content);
                this.richTextBoxStatus.Text = response.Content;
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
                this.btnStatus.PerformClick();
                //TODO:Osobna metoda na pobieranie z serwera odpowiedzi
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm("Scan",simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                btnStatus.PerformClick();
            }
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm("MoveTo", simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                btnStatus.PerformClick();
            }
        }

        private void btnHarvest_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm("Harvest", simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                btnStatus.PerformClick();
            }
        }

        private void btnProduce_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm("Produce", simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                btnStatus.PerformClick();
            }
        }

        private void btnRepair_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm("Repair", simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                btnStatus.PerformClick();
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            var parametersForm = new parametersForm("Order", simulationSelected);
            parametersForm.ShowDialog();
            if (parametersForm.DialogResult == DialogResult.OK)
            {
                btnStatus.PerformClick();
            }
        }

        private void controlPanelForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //TODO zapis do pliku
            MessageBox.Show("Goodbye!");
        }
    }
}
