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
    public partial class Form1 : Form
    {

        List<string> commands = new List<string>();
        BindingSource bs = new BindingSource();

        public Form1()
        {
            InitializeComponent();
            bs.DataSource = commands;
            listBoxCommands.DataSource = bs;
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
                var editPopup = new EditPopupForm(listBoxCommands.SelectedItem.ToString());
                editPopup.ShowDialog();
            }
        }

        private void btnEditCommand_Validating(object sender, CancelEventArgs e)
        {
            if (listBoxCommands.SelectedItems.Count != 1)
            {
                e.Cancel = true;
                btnEditCommand.Focus();
                errorProvider1.SetError(btnEditCommand, "Select one value to edit");
            }
            else
            {
                e.Cancel = false;
                this.ActiveControl = null;
                errorProvider1.SetError(btnEditCommand, null);
            }
        }
    }
}
