using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomateResticWindowsApp
{
    public partial class EditPopupForm : Form
    {
        public EditPopupForm(string command)
        {
            InitializeComponent();
            textBoxEditCommand.Text = command;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEditCommand_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
