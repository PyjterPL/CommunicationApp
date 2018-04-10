using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommunicationApp.Properties;

namespace CommunicationApp.Forms
{
    public partial class helloGoodbyeForm : Form
    {
        public helloGoodbyeForm(bool hello=true)
        {
            InitializeComponent();
            if (hello)
            {
                this.pictureBoxMessage.Image = Resources.GeneralKenobi;
                this.btnHello.Text = "Hello there!";
            }
            else
            {
                this.pictureBoxMessage.Image = Resources.goodbye;
                this.btnHello.Text = "May the force be with you!";
            }
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
