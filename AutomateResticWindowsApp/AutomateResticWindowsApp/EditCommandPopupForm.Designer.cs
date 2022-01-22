namespace AutomateResticWindowsApp
{
    partial class EditCommandPopupForm
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
            this.groupBoxEditCommand = new System.Windows.Forms.GroupBox();
            this.TextBoxEditCommand = new System.Windows.Forms.TextBox();
            this.BtnOkEditCommand = new System.Windows.Forms.Button();
            this.BtnCancelEditCommand = new System.Windows.Forms.Button();
            this.EditErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBoxEditCommand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxEditCommand
            // 
            this.groupBoxEditCommand.Controls.Add(this.TextBoxEditCommand);
            this.groupBoxEditCommand.ForeColor = System.Drawing.Color.White;
            this.groupBoxEditCommand.Location = new System.Drawing.Point(42, 39);
            this.groupBoxEditCommand.Name = "groupBoxEditCommand";
            this.groupBoxEditCommand.Size = new System.Drawing.Size(723, 95);
            this.groupBoxEditCommand.TabIndex = 0;
            this.groupBoxEditCommand.TabStop = false;
            this.groupBoxEditCommand.Text = "Edit Command";
            // 
            // TextBoxEditCommand
            // 
            this.TextBoxEditCommand.CausesValidation = false;
            this.TextBoxEditCommand.Location = new System.Drawing.Point(16, 39);
            this.TextBoxEditCommand.Name = "TextBoxEditCommand";
            this.TextBoxEditCommand.Size = new System.Drawing.Size(688, 22);
            this.TextBoxEditCommand.TabIndex = 0;
            this.TextBoxEditCommand.TextChanged += new System.EventHandler(this.textBoxEditCommand_TextChanged);
            // 
            // BtnOkEditCommand
            // 
            this.BtnOkEditCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnOkEditCommand.ForeColor = System.Drawing.Color.Black;
            this.BtnOkEditCommand.Location = new System.Drawing.Point(512, 174);
            this.BtnOkEditCommand.Name = "BtnOkEditCommand";
            this.BtnOkEditCommand.Size = new System.Drawing.Size(112, 29);
            this.BtnOkEditCommand.TabIndex = 5;
            this.BtnOkEditCommand.Text = "Ok";
            this.BtnOkEditCommand.UseVisualStyleBackColor = false;
            this.BtnOkEditCommand.Click += new System.EventHandler(this.BtnOkEditCommand_Click);
            this.BtnOkEditCommand.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxEditCommand_Validating);
            // 
            // BtnCancelEditCommand
            // 
            this.BtnCancelEditCommand.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnCancelEditCommand.ForeColor = System.Drawing.Color.Black;
            this.BtnCancelEditCommand.Location = new System.Drawing.Point(653, 174);
            this.BtnCancelEditCommand.Name = "BtnCancelEditCommand";
            this.BtnCancelEditCommand.Size = new System.Drawing.Size(112, 29);
            this.BtnCancelEditCommand.TabIndex = 6;
            this.BtnCancelEditCommand.Text = "Cancel";
            this.BtnCancelEditCommand.UseVisualStyleBackColor = false;
            this.BtnCancelEditCommand.Click += new System.EventHandler(this.BtnCancelEditCommand_Click);
            // 
            // EditErrorProvider
            // 
            this.EditErrorProvider.ContainerControl = this;
            // 
            // EditPopupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(819, 229);
            this.ControlBox = false;
            this.Controls.Add(this.BtnCancelEditCommand);
            this.Controls.Add(this.BtnOkEditCommand);
            this.Controls.Add(this.groupBoxEditCommand);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditPopupForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.groupBoxEditCommand.ResumeLayout(false);
            this.groupBoxEditCommand.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEditCommand;
        private System.Windows.Forms.TextBox TextBoxEditCommand;
        private System.Windows.Forms.Button BtnOkEditCommand;
        private System.Windows.Forms.Button BtnCancelEditCommand;
        private System.Windows.Forms.ErrorProvider EditErrorProvider;
    }
}