using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrbitInjector
{
    public partial class ProcessListUC : UserControl
    {
        public ProcessListUC()
        {
            InitializeComponent();

            Process[] allProcs = Process.GetProcesses();

            if (allProcs.Length > 0)
            {
                this.comboBox1.ResetText();

                Console.WriteLine("Loading processes...");
                Dictionary<int, string> processDictionary = new Dictionary<int, string>();

                foreach (Process proc in allProcs)
                {
                    if (proc.StartInfo.WindowStyle == ProcessWindowStyle.Normal)
                    {
                        ProcessThreadCollection myThreads = proc.Threads;
                        Console.WriteLine("process: {0},  id: {1}", proc.ProcessName, proc.Id);
                        processDictionary.Add(proc.Id, proc.ProcessName);
                    }
                }
                this.comboBox1.DataSource = new BindingSource(processDictionary, null);
                this.comboBox1.DisplayMember = "Value";
                this.comboBox1.ValueMember = "Key";
            }
        }

        private void button_attachproc_Click(object sender, EventArgs e)
        {

        }

        private void button_refreshproc_Click(object sender, EventArgs e)
        {

        }
    }
}
