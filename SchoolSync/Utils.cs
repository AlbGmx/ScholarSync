﻿using Newtonsoft.Json;
using SchoolSync.Forms;
using System.Management;


namespace SchoolSync
{
    public class SettingsData
    {
        public int? FromDate { get; set; }
        public int? UntilDate { get; set; }
    }

    internal class Utils
    {
        private static List<string> applicationList = new();
        private const string wmiQuery = "SELECT * FROM Win32_ProcessStartTrace";
        private const string filePath = "applicationsList.bin";
        private const string settingsPath = "../../../settings.bin";


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

        public static void SaveSettings(SettingsData data)
        {
            string json = JsonConvert.SerializeObject(data);
            File.WriteAllText(settingsPath, json);
        }

        public static SettingsData LoadSettings()
        {
            const int defaultDayDifference = SettingsForm.MINIMUM_DAY_DIFFERENCE;
            SettingsData defaultData = new()
            {
                FromDate = defaultDayDifference,
                UntilDate = defaultDayDifference,
            };

            if (!File.Exists(settingsPath))
            {
                MessageBox.Show("Settings file not found. Default settings will be used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return defaultData;
            }

            string json = File.ReadAllText(settingsPath);
            SettingsData data = JsonConvert.DeserializeObject<SettingsData>(json) ?? defaultData;

            if (data == defaultData)
            {
                MessageBox.Show("Settings file is invalid. Default settings will be used.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return data;
        }
    }
}
