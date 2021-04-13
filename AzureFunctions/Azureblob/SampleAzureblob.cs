using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace Azureblob
{
    public static class SampleAzureblob
    {
        [FunctionName("SampleAzureblob")]
        public static void Run([BlobTrigger("images/{name}", Connection = "SampleAzureblob")]Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
