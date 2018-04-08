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

namespace CommunicationApp
{
    public partial class parametersForm : Form
    {
        public Action Action { get; set; }
        private bool simulationSelected { get; }
        public parametersForm(Action Action, bool simulationSelected)
        {
            InitializeComponent();
            this.Action = Action;
            this.simulationSelected = simulationSelected;
            this.lblParameter.Text = Action.Command;
            switch (Action.Command)
            {
                case "Order":
                    foreach (OrderParameters orderParameters in Enum.GetValues(typeof(OrderParameters)))
                    {
                        this.comboBoxParameters.Items.Add(orderParameters.ToString());
                    }
                    break;
                case "Repair":
                    foreach (RepairParameters repairParameters in Enum.GetValues(typeof(RepairParameters)))
                    {
                        this.comboBoxParameters.Items.Add(repairParameters.ToString());
                    }
                    break;
                case "Produce":
                    foreach (ProduceParameters produceParameters in Enum.GetValues(typeof(ProduceParameters)))
                    {
                        this.comboBoxParameters.Items.Add(produceParameters.ToString());
                    }
                    break;
                default://For Scan,MoveTo and Harvest
                    foreach (Places place in Enum.GetValues(typeof(Places)))
                    {
                        this.comboBoxParameters.Items.Add(place.ToString());
                    }
                    break;
            }
            this.comboBoxParameters.SelectedIndex = 0;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            switch (Action.Command)
            {
                case "Order":
                    var orderForm = new orderValueForm();
                    orderForm.ShowDialog();
                    if (orderForm.DialogResult == DialogResult.OK)
                    {
                        var payload = new Payload(Action.Command, ConnectionHelper.Login, ConnectionHelper.Token,
                            this.comboBoxParameters.SelectedItem.ToString(), orderForm.Value).ToJson();
                        var client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                        var request = ConnectionHelper.CreateRequest(payload);
                        IRestResponse response = client.Execute(request);
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Action.Parameter = this.comboBoxParameters.SelectedItem.ToString();
                            this.Action.Value = orderForm.Value;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Something gone wrong!");
                            this.Close();
                        }
                    }
                    break;
                default:
                    if (this.comboBoxParameters.SelectedItem.ToString() == "Supplies")
                    {
                        var valueForm = new valueForm();
                        valueForm.ShowDialog();
                        if (valueForm.DialogResult == DialogResult.OK)
                        {
                            var payload = new Payload(Action.Command, ConnectionHelper.Login, ConnectionHelper.Token, 
                                this.comboBoxParameters.SelectedItem.ToString(),valueForm.Value.ToString()).ToJson();
                            var client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                            var request = ConnectionHelper.CreateRequest(payload);
                            IRestResponse response = client.Execute(request);
                            if (response.StatusCode == HttpStatusCode.OK)
                            {
                                this.DialogResult = DialogResult.OK;
                                this.Action.Parameter = this.comboBoxParameters.SelectedItem.ToString();
                                this.Action.Value = valueForm.Value.ToString();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Something gone wrong!");
                                this.Close();
                            }
                        }
                    }
                    else
                    {
                        var payload = new Payload(Action.Command, ConnectionHelper.Login, ConnectionHelper.Token, this.comboBoxParameters.SelectedItem.ToString()).ToJson();
                        var client = new RestClient(ConnectionHelper.ExecuteAdress(simulationSelected));
                        var request = ConnectionHelper.CreateRequest(payload);
                        IRestResponse response = client.Execute(request);
                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            this.DialogResult = DialogResult.OK;
                            this.Action.Parameter = this.comboBoxParameters.SelectedItem.ToString();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Something gone wrong!");
                            this.Close();
                        }
                    }
                    break;
            }

        }

        private void comboBoxParameters_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.comboBoxParameters.SelectedItem.ToString())
            {
                case "Supplies":
                    break;
                default:
                    break;

            }
        }
    }
}
