namespace ScholarSync.Forms;
using System;
using System.Management;
using System.Collections.Generic;
using System.Windows.Forms;

public partial class BlockedApps : Form
{
    private const string filePath = "applicationsList.txt";
    private List<string> applications = new List<string>();
    private string wmiQuery = "SELECT * FROM Win32_ProcessStartTrace";
    private int PageWidth { get; set; }
    private int PageHeight { get; set; }
    private Button? btnAddApp;
    private Button? btnBack;
    private System.ComponentModel.IContainer components = new System.ComponentModel.Container();

    public BlockedApps()
    {
        PageWidth = (int)(Screen.PrimaryScreen?.Bounds.Width * 0.5 ?? 0);
        PageHeight = (int)(Screen.PrimaryScreen?.Bounds.Height * 0.5 ?? 0);
        InitializeComponent();
        InitializeButtons();
    }

    private void InitializeComponent()
    {
        ManagementEventWatcher watcher = new ManagementEventWatcher(wmiQuery);
        watcher.EventArrived += new EventArrivedEventHandler(ProcessStarted);
        watcher.Start();

        components = new System.ComponentModel.Container();
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(PageWidth, PageHeight);
        Text = "Aplicaicones Bloqueadas";
        Resize += new EventHandler(SettingsForm_Resize);
    }

    static void ProcessStarted(object sender, EventArrivedEventArgs e)
    {
        string processName = e.NewEvent.Properties["ProcessName"].Value.ToString();
        uint processId = (uint)e.NewEvent.Properties["ProcessID"].Value;
    }

    private Button CreateButton(string text)
    {
        Button button = new Button
        {
            Text = text,
            TextAlign = ContentAlignment.MiddleCenter
        };

        return button;
    }

    private void InitializeButtons()
    {
        btnAddApp = CreateButton("Anadir Aplicacion");
        btnAddApp.Name = "btnAddApp";
        btnAddApp.Click += new EventHandler(AddAppButton_Clicked);
        Controls.Add(btnAddApp);

        btnBack = CreateButton("Atras");
        btnBack.Name = "btnBack";
        btnBack.Click += new EventHandler(BackButton_Clicked);
        Controls.Add(btnBack);
        
        LoadApplicationList(filePath);

        ResizeButtons();
    }

    private void SettingsForm_Resize(object? sender, EventArgs e)
    {
        ResizeButtons();
    }

    private void ResizeButtons()
    {
        int buttonWidth = (int)(ClientSize.Width / 3.0);
        int buttonHeight = (int)(ClientSize.Height / 6.0);
        int spacing = 20;

        // Calculate the total height needed for all buttons and spacing
        int totalHeight = 3 * buttonHeight + 2 * spacing;
        // Calculate the top margin so that the space above the first button and below the last button is equal to the spacing between buttons
        int margin = (ClientSize.Height - totalHeight) / 4;

        if (btnAddApp != null)
        {
            btnAddApp.Width = buttonWidth;
            btnAddApp.Height = buttonHeight;
            btnAddApp.Left = 0;
            btnAddApp.Top = margin;
        }
    }

    private void BackButton_Clicked(object? sender, EventArgs e)
    {
        this.Close();
    }

    private void AddAppButton_Clicked(object? sender, EventArgs e)
    {
        using (OpenFileDialog openFileDialog = new OpenFileDialog())
        {
            openFileDialog.Filter = "Executable Files (*.exe)|*.exe|All files (*.*)|*.*";
            openFileDialog.Title = "Select an Application";
            openFileDialog.InitialDirectory = @"C:\Program Files";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;
                string appName = Path.GetFileName(selectedFilePath);
                if (!applications.Contains(appName))
                {
                    applications.Add(appName);
                    SaveApplicationsList(applications, filePath);
                }
            }
        }
    }

    private void SaveApplicationsList(List<string> applicationList, string filePath)
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

    private List<string> LoadApplicationList(string filePath)
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