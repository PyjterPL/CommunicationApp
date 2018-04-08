using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationApp
{
    public partial class orderValueForm : Form
    {
        public string Value { get; set; }
        public orderValueForm()
        {
            InitializeComponent();
            foreach (Places places in Enum.GetValues(typeof(Places)))
            {
                this.comboBoxOrderValues.Items.Add(places.ToString());
            }
            this.comboBoxOrderValues.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Value = this.comboBoxOrderValues.SelectedItem.ToString();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
