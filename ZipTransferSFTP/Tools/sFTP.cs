using System;
using WinSCP;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ZipTransferSFTP.Tools
{
    public class sFTP
    {
        public SessionOptions SFTP()
        {
            SessionOptions sessionOptions = new SessionOptions //Sets All SFTP values
            {
                Protocol = Protocol.Sftp,
                HostName = ConfigurationManager.AppSettings["HostName"],
                UserName = ConfigurationManager.AppSettings["UserName"],
                Password = ConfigurationManager.AppSettings["Password"],
                SshHostKeyFingerprint = ConfigurationManager.AppSettings["SshHostKeyFingerprint"]
            };
            return sessionOptions;
        }
    }
}
