namespace AutomateResticWindowsApp
{
    partial class EditPopupForm
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
            this.groupBoxEditCommand = new System.Windows.Forms.GroupBox();
            this.textBoxEditCommand = new System.Windows.Forms.TextBox();
            this.btnOkEditCommand = new System.Windows.Forms.Button();
            this.btnCancelEditCommand = new System.Windows.Forms.Button();
            this.groupBoxEditCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEditCommand
            // 
            this.groupBoxEditCommand.Controls.Add(this.textBoxEditCommand);
            this.groupBoxEditCommand.ForeColor = System.Drawing.Color.White;
            this.groupBoxEditCommand.Location = new System.Drawing.Point(42, 39);
            this.groupBoxEditCommand.Name = "groupBoxEditCommand";
            this.groupBoxEditCommand.Size = new System.Drawing.Size(723, 95);
            this.groupBoxEditCommand.TabIndex = 0;
            this.groupBoxEditCommand.TabStop = false;
            this.groupBoxEditCommand.Text = "Edit Command";
            // 
            // textBoxEditCommand
            // 
            this.textBoxEditCommand.Location = new System.Drawing.Point(16, 39);
            this.textBoxEditCommand.Name = "textBoxEditCommand";
            this.textBoxEditCommand.Size = new System.Drawing.Size(688, 22);
            this.textBoxEditCommand.TabIndex = 0;
            this.textBoxEditCommand.TextChanged += new System.EventHandler(this.textBoxEditCommand_TextChanged);
            // 
            // btnOkEditCommand
            // 
            this.btnOkEditCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOkEditCommand.ForeColor = System.Drawing.Color.Black;
            this.btnOkEditCommand.Location = new System.Drawing.Point(512, 174);
            this.btnOkEditCommand.Name = "btnOkEditCommand";
            this.btnOkEditCommand.Size = new System.Drawing.Size(112, 29);
            this.btnOkEditCommand.TabIndex = 5;
            this.btnOkEditCommand.Text = "Ok";
            this.btnOkEditCommand.UseVisualStyleBackColor = false;
            // 
            // btnCancelEditCommand
            // 
            this.btnCancelEditCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelEditCommand.ForeColor = System.Drawing.Color.Black;
            this.btnCancelEditCommand.Location = new System.Drawing.Point(653, 174);
            this.btnCancelEditCommand.Name = "btnCancelEditCommand";
            this.btnCancelEditCommand.Size = new System.Drawing.Size(112, 29);
            this.btnCancelEditCommand.TabIndex = 6;
            this.btnCancelEditCommand.Text = "Cancel";
            this.btnCancelEditCommand.UseVisualStyleBackColor = false;
            this.btnCancelEditCommand.Click += new System.EventHandler(this.button1_Click);
            // 
            // EditPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(819, 229);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelEditCommand);
            this.Controls.Add(this.btnOkEditCommand);
            this.Controls.Add(this.groupBoxEditCommand);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBoxEditCommand.ResumeLayout(false);
            this.groupBoxEditCommand.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditCommand;
        private System.Windows.Forms.TextBox textBoxEditCommand;
        private System.Windows.Forms.Button btnOkEditCommand;
        private System.Windows.Forms.Button btnCancelEditCommand;
    }
}