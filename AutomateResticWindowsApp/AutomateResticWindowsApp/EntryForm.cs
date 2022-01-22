using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Automation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomateResticWindowsApp
{
    public partial class EntryForm : Form
    {
        bool Success;
        
        public EntryForm()
        {
            InitializeComponent();
            FormClosed += new System.Windows.Forms.FormClosedEventHandler(EntryForm_FormClosed);
            Success = false;
        }

        private void EntryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Success)
                (new CommandsForm()).Show();
            else
                Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (int i = 0; i < totalProcess; i++)
                {
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10); // simulate long task
                }
            });
        }

        private async void EntryFormShown(object sender, EventArgs e)
        {
            //List<string> list = new List<string>();
            //for (int i = 0; i < 1000; i++)
            //{
            //    list.Add(i.ToString());
            //}
            //LabelCheckResticText.Text = "Verifying restic is installed...";
            //var progress = new Progress<ProgressReport>();
            //progress.ProgressChanged += (o, report) => {
            //    labelCheckResticPercent.Text = String.Format("{0}%", report.PercentComplete);
            //    progressBarRestic.Value = report.PercentComplete;
            //    progressBarRestic.Update();
            //};
            //await ProcessData(list, progress);
            //LabelCheckResticText.Text = "Done";
            //Close();

            LabelCheckResticText.Text = "Verifying restic and credential manager are installed...";
            progressBarSoftwareCheck.Value = 0;
            progressBarSoftwareCheck.Update();
            PowerShell ps = PowerShell.Create()
                .AddScript("get-command restic; get-command get-storedcredential");
            IAsyncResult res = ps.BeginInvoke();
            while (!res.IsCompleted)
            {
                if (progressBarSoftwareCheck.Value < 100)
                    progressBarSoftwareCheck.Value++;
                else
                    progressBarSoftwareCheck.Value = 0;
                progressBarSoftwareCheck.Update();
                await Task.Delay(100);
            }
            List<PSObject> output = new List<PSObject>();
            PSDataCollection<PSObject> test = ps.EndInvoke(res);
            foreach (PSObject pso in ps.EndInvoke(res))
            {
                output.Add(pso);
            }

            progressBarSoftwareCheck.Value = 0;
            progressBarSoftwareCheck.Update();

            if (output.Count == 1)
            {
                Success = true;
                //Close();
            }
            else
            {
                LabelCheckResticText.Text = "Restic and Windows Credential Manager must be installed to use this script.";
                buttonCheckAgain.Visible = true;
                buttonCheckAgain.Enabled = true;
            }
        }

        private void EntryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
