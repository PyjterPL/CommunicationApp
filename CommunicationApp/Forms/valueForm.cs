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
    public partial class valueForm : Form
    {
        public int Value { get; set; }
        public valueForm()
        {
            InitializeComponent();
            this.numericValue.Value = 500;
            this.lblInformation.Text = "Minimum = 0 and maximum = 500"+ Environment.NewLine + "Even if you make other values it will be in range";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Value = (int)this.numericValue.Value; 
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
