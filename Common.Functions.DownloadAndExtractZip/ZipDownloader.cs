using static Common.Functions.DownloadFile.FileDownloader;
using static Common.Functions.GetRandomAlphaNumericString.StringGenerator;
using static System.IO.Path;

namespace Common.Functions.DownloadAndExtractZip
{
    internal static class ZipDownloader
    {
        private const byte FileNameChars = 7;

        public static string DownloadArchive(string uri, string destination)
        {
            var path = Combine(destination, $"{Random(FileNameChars)}.zip");
            Download(uri, path);
            return path;
        }
    }
}
