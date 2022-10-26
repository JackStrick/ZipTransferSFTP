using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinSCP;

namespace ZipTransferSFTP.Tools
{
    public class SessionManager
    {
        public void Pull(SessionOptions sessionOptions)
        {
            try
            {
                using (Session session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Download files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult = session.GetFiles("/ZipTransferTest/-test/*.png", @"C:\Transfer Data\archival\", false, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Print results
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    {
                        Console.WriteLine("Download of {0} succeeded", transfer.FileName);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }

        }
        public void Upload(SessionOptions sessionOptions)
        {
            try
            {
                using (Session session = new Session())
                {
                    // Connect
                    session.Open(sessionOptions);

                    // Download files
                    TransferOptions transferOptions = new TransferOptions();
                    transferOptions.TransferMode = TransferMode.Binary;

                    TransferOperationResult transferResult;
                    transferResult = session.PutFiles(@"C:\Transfer Data\zipped\", "/ZipTransferTest/-archived/", true, transferOptions);

                    // Throw on any error
                    transferResult.Check();

                    // Print results
                    foreach (TransferEventArgs transfer in transferResult.Transfers)
                    {
                        Console.WriteLine("Upload of {0} succeeded", transfer.FileName);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}", e);
            }
        }
    }
}
