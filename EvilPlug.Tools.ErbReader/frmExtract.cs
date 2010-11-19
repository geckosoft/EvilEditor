using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using EvilBase;
namespace EvilPlug.Tools.ErbReader
{
    public partial class frmExtract : Form
    {
        protected Thread m_Thread = null;
        public frmExtract()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            StopExtracting();
            Close();
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            StartExtracting();
        }

        private void StartExtracting()
        {
            txtOutput.Text = "ErbReader by Franscisco Scaramanga\r\nFound at: http://www.n1nj4.com/viewtopic.php?t=2145\r\n\r\nStarting extraction process...\r";

            m_Thread = new Thread(new ThreadStart(ExtractThread));
            m_Thread.Start();

        }

        private void StopExtracting()
        {
            if (m_Thread != null)
                m_Thread.Abort();

            m_Thread = null;
        }
        public delegate void AddLogCallback(string text);

        private void AddLog(string text)
        {
            if (!InvokeRequired)
            {
                try
                {
                    txtOutput.Text += text + "\r\n";
                    txtOutput.SelectionStart = txtOutput.Text.Length - 1;
                    txtOutput.ScrollToCaret();
                    Application.DoEvents();
                }
                catch { }
                return;
            }
            txtOutput.Invoke(new AddLogCallback(this.AddLog), 
            new object[]{text});

        }

        private void ExtractThread()
        {
            Process proc = new Process();
            proc.StartInfo.FileName = EvilTools.GetExecutingPath("erbreader.exe");
            proc.StartInfo.Arguments = "\"" + txtSource.Text + "\"";
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.StartInfo.CreateNoWindow = true;
            proc.Start();

            while (!proc.StandardOutput.EndOfStream)
            {
                string info =  proc.StandardOutput.ReadLine();
                AddLog(info);
            }

            AddLog("\r\n\r\nDone! If no errors occured, you can locate the extracted files in a submap found at the same folder as your erb file.");
            StopExtracting();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            DialogResult res = openFile.ShowDialog();

            if (res != DialogResult.OK)
                return;

            txtSource.Text = openFile.FileName;
        }
    }
}
