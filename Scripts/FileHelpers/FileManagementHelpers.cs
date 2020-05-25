using System.IO;
using UnityHelpers.StringHelpers;

namespace UnityHelpers.FileHelpers
{
    public static class FileManagementHelpers
    {
        private readonly static int RandomNameLength = 64;

        /// <summary>
        /// Copies the file from the source path to the destination path and returns the generated name of the new file.
        /// </summary>
        public static string CopyFile(string sourceFilePath, string destinationPath)
        {
            if (sourceFilePath.Contains("file:///"))
                sourceFilePath = sourceFilePath.Replace("file:///", "");
            Directory.CreateDirectory(destinationPath);

            string randomFileName = StringHelpers.StringGenerator.GenerateRandomString(RandomNameLength) + Path.GetExtension(sourceFilePath);
            string fullDestinationPath = Path.Combine(destinationPath, randomFileName);

            File.Copy(sourceFilePath, fullDestinationPath, false);

            return randomFileName;
        }

        public static void DeleteFile(string fileFullPath) => File.Delete(fileFullPath);

        public static void DeleteAllFilesInTheFolder(string folderFullPath)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(folderFullPath);

            foreach (var file in directoryInfo.GetFiles())
            {
                file.Delete();
            }
        }
        
        public static string GenerateUniqueFileNameInDirectory(string originalFileName, string destinationPath)
        {
            if (!File.Exists(Path.Combine(destinationPath, originalFileName)))
                return originalFileName;

            string newFileName;
            string extension = Path.GetExtension(originalFileName);

            int counter = 1;
            do
            {
                newFileName = Path.GetFileNameWithoutExtension(originalFileName);
                newFileName += $" ({counter})";
                counter++;
            }
            while (File.Exists(Path.Combine(destinationPath, newFileName + extension)));

            newFileName += extension;
            return newFileName;
        }
    }
}