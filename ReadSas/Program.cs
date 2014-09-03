using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadSas
{
    class Program
    {
        static void Main(string[] args)
        {
            string sas = "https://jamborstorage.blob.core.windows.net/sascontainer?sv=2014-02-14&sr=c&sig=HaD3DPQYd%2FQMJnuvYRafx0NuQQWSm0ZelODLxbyjEWI%3D&se=2014-09-03T09%3A43%3A28Z&sp=wl";
            CloudBlobContainer container = new CloudBlobContainer(new Uri(sas));

            //Create a list to store blob URIs returned by a listing operation on the container.
            List<Uri> blobUris = new List<Uri>();

            try
            {
                //Write operation: write a new blob to the container. 
                CloudBlockBlob blob = container.GetBlockBlobReference("blobCreatedViaSAS.txt");
                string blobContent = "This blob was created with a shared access signature granting write permissions to the container. ";
                MemoryStream msWrite = new MemoryStream(Encoding.UTF8.GetBytes(blobContent));
                msWrite.Position = 0;
                using (msWrite)
                {
                    blob.UploadFromStream(msWrite);
                }
                Console.WriteLine("Write operation succeeded for SAS " + sas);
                Console.WriteLine();
            }
            catch (StorageException e)
            {
                Console.WriteLine("Write operation failed for SAS " + sas);
                Console.WriteLine("Additional error information: " + e.Message);
                Console.WriteLine();
            }


        }
    }
}
