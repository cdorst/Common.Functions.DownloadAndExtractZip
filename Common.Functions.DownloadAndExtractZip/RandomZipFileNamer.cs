using static Common.Functions.GetRandomAlphaNumericString.StringGenerator;
using static System.IO.Path;

namespace Common.Functions.DownloadAndExtractZip
{
    internal static class RandomZipFileNamer
    {
        private const byte FileNameChars = 7;

        public static string RandomArchivePath(string directory)
            => Combine(directory,
                $"{Random(FileNameChars)}.zip");
    }
}
