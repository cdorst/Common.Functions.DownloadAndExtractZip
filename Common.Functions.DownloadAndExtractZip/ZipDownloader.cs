using static Common.Functions.DownloadFile.FileDownloader;
using static Common.Functions.DownloadAndExtractZip.RandomZipFileNamer;

namespace Common.Functions.DownloadAndExtractZip
{
    internal static class ZipDownloader
    {
        private const byte FileNameChars = 7;

        public static string DownloadArchive(string uri, string destination)
        {
            var path = RandomArchivePath(destination);
            Download(uri, path);
            return path;
        }
    }
}
