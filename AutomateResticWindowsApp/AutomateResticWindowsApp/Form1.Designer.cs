namespace AutomateResticWindowsApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBoxAddCommand = new System.Windows.Forms.GroupBox();
            this.btnAddCommandFile = new System.Windows.Forms.Button();
            this.btnAddCommand = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.groupBoxCommandList = new System.Windows.Forms.GroupBox();
            this.btnEditCommand = new System.Windows.Forms.Button();
            this.btnDeleteCommand = new System.Windows.Forms.Button();
            this.btnClearCommands = new System.Windows.Forms.Button();
            this.listBoxCommands = new System.Windows.Forms.ListBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxAddCommand.SuspendLayout();
            this.groupBoxCommandList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAddCommand
            // 
            this.groupBoxAddCommand.Controls.Add(this.btnAddCommandFile);
            this.groupBoxAddCommand.Controls.Add(this.btnAddCommand);
            this.groupBoxAddCommand.Controls.Add(this.textBoxCommand);
            this.groupBoxAddCommand.ForeColor = System.Drawing.Color.White;
            this.groupBoxAddCommand.Location = new System.Drawing.Point(50, 46);
            this.groupBoxAddCommand.Name = "groupBoxAddCommand";
            this.groupBoxAddCommand.Size = new System.Drawing.Size(1019, 74);
            this.groupBoxAddCommand.TabIndex = 0;
            this.groupBoxAddCommand.TabStop = false;
            this.groupBoxAddCommand.Text = "Add Command";
            this.groupBoxAddCommand.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnAddCommandFile
            // 
            this.btnAddCommandFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCommandFile.ForeColor = System.Drawing.Color.Black;
            this.btnAddCommandFile.Location = new System.Drawing.Point(864, 30);
            this.btnAddCommandFile.Name = "btnAddCommandFile";
            this.btnAddCommandFile.Size = new System.Drawing.Size(82, 23);
            this.btnAddCommandFile.TabIndex = 2;
            this.btnAddCommandFile.Text = "Add File...";
            this.btnAddCommandFile.UseVisualStyleBackColor = false;
            // 
            // btnAddCommand
            // 
            this.btnAddCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddCommand.ForeColor = System.Drawing.Color.Black;
            this.btnAddCommand.Location = new System.Drawing.Point(783, 30);
            this.btnAddCommand.Name = "btnAddCommand";
            this.btnAddCommand.Size = new System.Drawing.Size(75, 23);
            this.btnAddCommand.TabIndex = 1;
            this.btnAddCommand.Text = "Add";
            this.btnAddCommand.UseVisualStyleBackColor = false;
            this.btnAddCommand.Click += new System.EventHandler(this.btnAddCommand_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(16, 31);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(748, 22);
            this.textBoxCommand.TabIndex = 0;
            // 
            // groupBoxCommandList
            // 
            this.groupBoxCommandList.Controls.Add(this.btnEditCommand);
            this.groupBoxCommandList.Controls.Add(this.btnDeleteCommand);
            this.groupBoxCommandList.Controls.Add(this.btnClearCommands);
            this.groupBoxCommandList.Controls.Add(this.listBoxCommands);
            this.groupBoxCommandList.ForeColor = System.Drawing.Color.White;
            this.groupBoxCommandList.Location = new System.Drawing.Point(50, 150);
            this.groupBoxCommandList.Name = "groupBoxCommandList";
            this.groupBoxCommandList.Size = new System.Drawing.Size(1019, 462);
            this.groupBoxCommandList.TabIndex = 1;
            this.groupBoxCommandList.TabStop = false;
            this.groupBoxCommandList.Text = "Commands";
            this.groupBoxCommandList.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnEditCommand
            // 
            this.btnEditCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditCommand.ForeColor = System.Drawing.Color.Black;
            this.btnEditCommand.Location = new System.Drawing.Point(810, 90);
            this.btnEditCommand.Name = "btnEditCommand";
            this.btnEditCommand.Size = new System.Drawing.Size(112, 29);
            this.btnEditCommand.TabIndex = 4;
            this.btnEditCommand.Text = "Edit...";
            this.btnEditCommand.UseVisualStyleBackColor = false;
            this.btnEditCommand.Click += new System.EventHandler(this.btnEditCommand_Click);
            this.btnEditCommand.Validating += new System.ComponentModel.CancelEventHandler(this.btnEditCommand_Validating);
            // 
            // btnDeleteCommand
            // 
            this.btnDeleteCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteCommand.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCommand.Location = new System.Drawing.Point(810, 138);
            this.btnDeleteCommand.Name = "btnDeleteCommand";
            this.btnDeleteCommand.Size = new System.Drawing.Size(112, 29);
            this.btnDeleteCommand.TabIndex = 3;
            this.btnDeleteCommand.Text = "Delete";
            this.btnDeleteCommand.UseVisualStyleBackColor = false;
            this.btnDeleteCommand.Click += new System.EventHandler(this.btnDeleteCommand_Click);
            // 
            // btnClearCommands
            // 
            this.btnClearCommands.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClearCommands.ForeColor = System.Drawing.Color.Black;
            this.btnClearCommands.Location = new System.Drawing.Point(810, 189);
            this.btnClearCommands.Name = "btnClearCommands";
            this.btnClearCommands.Size = new System.Drawing.Size(112, 29);
            this.btnClearCommands.TabIndex = 2;
            this.btnClearCommands.Text = "Clear";
            this.btnClearCommands.UseVisualStyleBackColor = false;
            this.btnClearCommands.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxCommands
            // 
            this.listBoxCommands.CausesValidation = false;
            this.listBoxCommands.FormattingEnabled = true;
            this.listBoxCommands.ItemHeight = 16;
            this.listBoxCommands.Location = new System.Drawing.Point(16, 35);
            this.listBoxCommands.Name = "listBoxCommands";
            this.listBoxCommands.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBoxCommands.Size = new System.Drawing.Size(740, 388);
            this.listBoxCommands.TabIndex = 0;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1244, 739);
            this.Controls.Add(this.groupBoxCommandList);
            this.Controls.Add(this.groupBoxAddCommand);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automate Restic for Windows";
            this.groupBoxAddCommand.ResumeLayout(false);
            this.groupBoxAddCommand.PerformLayout();
            this.groupBoxCommandList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddCommand;
        private System.Windows.Forms.Button btnAddCommand;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button btnAddCommandFile;
        private System.Windows.Forms.GroupBox groupBoxCommandList;
        private System.Windows.Forms.ListBox listBoxCommands;
        private System.Windows.Forms.Button btnClearCommands;
        private System.Windows.Forms.Button btnDeleteCommand;
        private System.Windows.Forms.Button btnEditCommand;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

