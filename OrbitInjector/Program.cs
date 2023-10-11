using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.IO;
using OrbitInjector;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSGOInjector
{
    class Program
    {
        private const string Kernel32_DllName = "kernel32.dll";

        [DllImport(Kernel32_DllName)]
        private static extern bool AllocConsole();

        [STAThread]
        static void Main(string[] args)
        {
            AllocConsole();
            Console.WriteLine("Welcome to L33T undetectable game DLL injector");

            Application.SetCompatibleTextRenderingDefault(false);
            Application.EnableVisualStyles();
            ProcessListForm f1 = new ProcessListForm();
            Application.Run(f1);

            Console.WriteLine("Please choose a .DLL to inject... (opening file selector)");
            try
            {
                if (VACBypass.Run(GetPathDLL()))
                {
                    MessageBox.Show("DLL injected!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    MessageBox.Show("Failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static string GetPathDLL()
        {
            string dllPath = string.Empty;

            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.InitialDirectory = Directory.GetCurrentDirectory();
                fileDialog.Filter = "DLL files (*.dll)|*.dll";
                fileDialog.FilterIndex = 2;
                fileDialog.RestoreDirectory = true;

                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    dllPath = fileDialog.FileName;
                }
                else
                {
                    throw new ApplicationException("Dll opening error");
                }
            }

            return dllPath;
        }
    }
}