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
    public partial class CommandsForm : Form
    {

        List<string> commands = new List<string>();
        BindingSource bs = new BindingSource();

        public CommandsForm()
        {
            InitializeComponent();
            bs.DataSource = commands;
            listBoxCommands.DataSource = bs;
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(CommandsForm_FormClosed);
        }

        private void CommandsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {
            commands.Add(textBoxCommand.Text);
            bs.DataSource = commands;
            bs.ResetBindings(false);
            textBoxCommand.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            commands.Clear();
            bs.DataSource = commands;
            bs.ResetBindings(false);
        }

        private void btnDeleteCommand_Click(object sender, EventArgs e)
        {
            // Remove by index in case of duplicate strings
            commands = commands.Where((item, index) => !(listBoxCommands.SelectedIndices.Cast<int>().ToList()).Contains(index)).ToList();
            bs.DataSource = commands;
            bs.ResetBindings(false);
        }

        private void btnEditCommand_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var editPopup = new EditCommandPopupForm(listBoxCommands.SelectedItem.ToString());
                editPopup.DataSentHandler += EditPopup_dataSentHandler;
                editPopup.ShowDialog();
            }
        }

        private void EditPopup_dataSentHandler(string newCommand)
        {
            commands[listBoxCommands.SelectedIndex] = newCommand;
            bs.DataSource = commands;
            bs.ResetBindings(false);
        }

        private void listBoxCommands_Validating(object sender, CancelEventArgs e)
        {
            if (listBoxCommands.SelectedItems.Count != 1)
            {
                e.Cancel = true;
                errorProvider1.SetError(btnEditCommand, "Select one value to edit");
            }
            else
            {
                errorProvider1.SetError(btnEditCommand, "");
            }
        }
    }
}
