namespace AutomateResticWindowsApp
{
    partial class EntryForm
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
            this.progressBarSoftwareCheck = new System.Windows.Forms.ProgressBar();
            this.LabelCheckResticText = new System.Windows.Forms.Label();
            this.labelCheckResticPercent = new System.Windows.Forms.Label();
            this.buttonCheckAgain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // progressBarSoftwareCheck
            // 
            this.progressBarSoftwareCheck.Location = new System.Drawing.Point(71, 129);
            this.progressBarSoftwareCheck.Name = "progressBarSoftwareCheck";
            this.progressBarSoftwareCheck.Size = new System.Drawing.Size(456, 23);
            this.progressBarSoftwareCheck.TabIndex = 0;
            this.progressBarSoftwareCheck.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // LabelCheckResticText
            // 
            this.LabelCheckResticText.AutoSize = true;
            this.LabelCheckResticText.Location = new System.Drawing.Point(68, 99);
            this.LabelCheckResticText.Name = "LabelCheckResticText";
            this.LabelCheckResticText.Size = new System.Drawing.Size(0, 16);
            this.LabelCheckResticText.TabIndex = 1;
            this.LabelCheckResticText.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelCheckResticPercent
            // 
            this.labelCheckResticPercent.AutoSize = true;
            this.labelCheckResticPercent.Location = new System.Drawing.Point(499, 99);
            this.labelCheckResticPercent.Name = "labelCheckResticPercent";
            this.labelCheckResticPercent.Size = new System.Drawing.Size(0, 16);
            this.labelCheckResticPercent.TabIndex = 3;
            // 
            // buttonCheckAgain
            // 
            this.buttonCheckAgain.Enabled = false;
            this.buttonCheckAgain.ForeColor = System.Drawing.Color.Black;
            this.buttonCheckAgain.Location = new System.Drawing.Point(423, 253);
            this.buttonCheckAgain.Name = "buttonCheckAgain";
            this.buttonCheckAgain.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckAgain.TabIndex = 4;
            this.buttonCheckAgain.Text = "&Refresh";
            this.buttonCheckAgain.UseVisualStyleBackColor = true;
            this.buttonCheckAgain.Visible = false;
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(665, 324);
            this.Controls.Add(this.buttonCheckAgain);
            this.Controls.Add(this.labelCheckResticPercent);
            this.Controls.Add(this.LabelCheckResticText);
            this.Controls.Add(this.progressBarSoftwareCheck);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automate Restic for Windows";
            this.Load += new System.EventHandler(this.EntryForm_Load);
            this.Shown += new System.EventHandler(this.EntryFormShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarSoftwareCheck;
        private System.Windows.Forms.Label LabelCheckResticText;
        private System.Windows.Forms.Label labelCheckResticPercent;
        private System.Windows.Forms.Button buttonCheckAgain;
    }
}