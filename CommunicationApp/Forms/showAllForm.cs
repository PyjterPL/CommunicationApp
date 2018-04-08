using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicationApp.Forms
{
    public partial class showAllForm : Form
    {
        public showAllForm(string content)
        {
            InitializeComponent();
            this.richTextBoxWholeResponse.Text = content;
        }

        private void showAllForm_SizeChanged(object sender, EventArgs e)
        {
            this.richTextBoxWholeResponse.Height = this.Size.Height - 10;
            this.richTextBoxWholeResponse.Width = this.Size.Width - 10;
        }
    }
}
