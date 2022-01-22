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
    public delegate void DataSentHandler(string newCommand);
    public partial class EditCommandPopupForm : Form
    {
        public event DataSentHandler DataSentHandler;
        public EditCommandPopupForm(string command)
        {
            InitializeComponent();
            TextBoxEditCommand.Text = command;
        }

        private void BtnCancelEditCommand_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBoxEditCommand_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnOkEditCommand_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                DataSentHandler(TextBoxEditCommand.Text);
                Close();
            }
        }

        private void TextBoxEditCommand_Validating(object sender, CancelEventArgs e)
        {
            if (TextBoxEditCommand.Text.Equals(""))
            {
                e.Cancel = true;
                EditErrorProvider.SetError(BtnOkEditCommand, "Must enter new command");
            } 
            else
            {
                EditErrorProvider.SetError(BtnOkEditCommand, "");
            }
        }
    }
}
