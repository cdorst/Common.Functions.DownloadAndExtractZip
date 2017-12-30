using System.IO;

namespace Common.Functions.DownloadAndExtractZip
{
    internal static class TemporaryArtifactDeleter
    {
        public static void Delete(string downloadedZipPath, string extractPath)
        {
            Directory.Delete(extractPath);
            File.Delete(downloadedZipPath);
        }
    }
}
