using System;
using static Common.Functions.DownloadAndExtractZip.RandomZipFileNamer;
using static Common.Functions.DownloadFile.FileDownloader;

namespace Common.Functions.DownloadAndExtractZip
{
    internal static class ZipDownloader
    {
        public static string DownloadArchive(Uri uri, string destination)
        {
            var path = RandomArchivePath(destination);
            Download(uri, path);
            return path;
        }
    }
}
