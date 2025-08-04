using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace DIT_AIO
{
    public static class ResourceHelper
    {
        public static Stream GetResourceStream(string resourceFileName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            // Dynamically search for the correct resource
            string resourceName = assembly.GetManifestResourceNames()
                .FirstOrDefault(r => r.EndsWith(resourceFileName, StringComparison.OrdinalIgnoreCase));

            if (resourceName == null)
            {
                throw new FileNotFoundException($"Embedded resource '{resourceFileName}' not found in assembly.");
            }

            Stream resourceStream = assembly.GetManifestResourceStream(resourceName);
            if (resourceStream == null)
            {
                throw new FileNotFoundException($"Resource '{resourceFileName}' found but stream could not be opened.");
            }

            return resourceStream;
        }

        public static void RunEmbeddedBat(string fileName)
        {
            try
            {
                using (Stream stream = GetResourceStream(fileName))
                {
                    string tempPath = Path.Combine(Path.GetTempPath(), fileName);

                    // Write BAT file to temp location
                    using (FileStream fileStream = new FileStream(tempPath, FileMode.Create, FileAccess.Write))
                    {
                        stream.CopyTo(fileStream);
                    }

                    // Execute BAT file
                    ProcessStartInfo psi = new ProcessStartInfo
                    {
                        FileName = tempPath,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to run embedded script: {ex.Message}");
            }
        }
    }
}
