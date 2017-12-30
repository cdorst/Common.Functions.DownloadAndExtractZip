using System.IO;

namespace Common.Functions.DownloadAndExtractZip
{
    internal static class TemporaryArtifactDeleter
    {
        public static void Delete(string archive, string extract)
        {
            Directory.Delete(extract, recursive: true);
            File.Delete(archive);
        }
    }
}
