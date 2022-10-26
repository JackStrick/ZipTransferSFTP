using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZipTransferSFTP.Tools;
using WinSCP;

namespace ZipTransferSFTP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            sFTP sftp = new sFTP();
            SessionManager manager = new SessionManager();
            FileCompression compress = new FileCompression();

            SessionOptions options = sftp.SFTP();
            manager.Pull(options);
            compress.Zip();
            manager.Upload(options);
        }
    }
}
