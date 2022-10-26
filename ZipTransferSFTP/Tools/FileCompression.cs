using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;

namespace ZipTransferSFTP.Tools
{
    internal class FileCompression
    {
        string startPath = @"C:\Transfer Data\archival";
        string zipPath = @"C:\Transfer Data\zipped\ZippedFiles.zip";
        public void Zip()
        {
            ZipFile.CreateFromDirectory(startPath, zipPath);
            deleteLocal();
        }
        public void deleteLocal()
        {
            string[] filePaths = Directory.GetFiles(startPath);
            foreach (string filePath in filePaths)
            {
                File.Delete(filePath);
            }
        }
    }
}
