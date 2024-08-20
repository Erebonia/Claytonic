using System.IO;
using System.Reflection;

namespace DIT_AIO
{
    public static class ResourceHelper
    {
        public static Stream GetResourceStream(string resourceName)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream resourceStream = assembly.GetManifestResourceStream(resourceName);

            if (resourceStream == null)
            {
                throw new FileNotFoundException($"Resource '{resourceName}' not found.");
            }

            return resourceStream;
        }
    }
}
