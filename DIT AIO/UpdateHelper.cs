using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace DIT_AIO.Helpers
{
    public static class UpdateHelper
    {
        public static bool CheckForUpdates(string remoteExePath, string localExePath)
        {
            string batchScriptPath = Path.Combine(Path.GetDirectoryName(localExePath), "update.bat");

            try
            {
                FileInfo remoteFile = new FileInfo(remoteExePath);
                FileInfo localFile = new FileInfo(localExePath);

                if (remoteFile.LastWriteTime > localFile.LastWriteTime)
                {
                    MessageBox.Show("A new update is available. The application will now update and restart.", "Update Available", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Create a batch script to replace the executable and restart the application
                    string batchScriptContent = $@"
                    @echo off
                    taskkill /f /im ""{Path.GetFileName(localExePath)}""
                    copy /b /y ""{remoteExePath}"" ""{localExePath}""
                    start """" ""{localExePath}""
                    del ""{batchScriptPath}""
                    ";

                    File.WriteAllText(batchScriptPath, batchScriptContent);

                    // Run the batch script
                    ProcessStartInfo processStartInfo = new ProcessStartInfo
                    {
                        FileName = batchScriptPath,
                        UseShellExecute = true,
                        CreateNoWindow = true
                    };
                    Process.Start(processStartInfo);

                    // Exit the current application
                    Application.Exit();
                    return true; // Update is in progress
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to check for updates: {ex.Message}", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false; // No update needed
        }
    }
}
