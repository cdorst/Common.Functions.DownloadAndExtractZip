using static Common.Functions.CopyAndPasteDirectory.DirectoryCopier;
using static Common.Functions.DownloadAndExtractZip.TemporaryArtifactDeleter;
using static Common.Functions.DownloadAndExtractZip.ZipDownloader;
using static Common.Functions.ExtractZipToNewSubdirectory.ZipExtractor;

namespace Common.Functions.DownloadAndExtractZip
{
    public static class ZipDownloaderAndExtractor
    {
        public static void DownloadAndExtract(string uri, string destination)
        {
            var archive = DownloadArchive(uri, destination);
            var extract = Extract(archive);
            Copy(extract, destination);
            Delete(archive, extract);
        }
    }
}
