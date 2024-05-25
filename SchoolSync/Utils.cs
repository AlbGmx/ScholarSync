using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Management;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SchoolSync
{
    internal class Utils
    {
        private const string wmiQuery = "SELECT * FROM Win32_ProcessStartTrace";
        private const string filePath = "applicationsList.txt";
        private static List<string> applicationList = new List<string>();

        public static void processWatcher()
        {
            ManagementEventWatcher watcher = new ManagementEventWatcher(wmiQuery);
            watcher.EventArrived += new EventArrivedEventHandler(ProcessStarted);
        }

        static void ProcessStarted(object sender, EventArrivedEventArgs e)
        {
            string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
            uint processId = (uint)e.NewEvent.Properties["ProcessId"].Value;
        }

        public static void AddApplicationList()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Executable Files (*.exe)|*.exe|All Files (*.*)|*.*";
                ofd.Title = "Select an Application";
                ofd.InitialDirectory = @"C:\Program Files";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string appName = Path.GetFileName(ofd.FileName);
                    if (!applicationList.Contains(appName))
                    {
                        applicationList.Add(appName);
                        SaveApplicationList(applicationList, filePath);
                    }
                }
            }
        }

        public static void SaveApplicationList(List<string> applicationList, string filePath)
        {
            try
            {
                File.WriteAllLines(filePath, applicationList);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving application list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static List<string> LoadApplicationList(string filePath)
        {
            List<string> applicationList = new List<string>();

            try
            {
                if (File.Exists(filePath))
                {
                    applicationList.AddRange(File.ReadAllLines(filePath));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading application list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return applicationList;
        }
    }
}
