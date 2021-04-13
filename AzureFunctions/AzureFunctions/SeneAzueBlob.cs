using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;

namespace AzureFunctions
{
    public static class SeneAzueBlob
    {
        [FunctionName("SeneAzueBlob")]
        public static void Run([BlobTrigger("Images/{name}", Connection = "DefaultEndpointsProtocol=https;AccountName=seneazurestorage;AccountKey=y0WXi45WqR4YrmdXpIfN1YZu2cm/Tot0tf9EWicf4je8RqPcRrvEx9FbgtwdnsROSePLpnchpnb1HX8TYf4JNA==;EndpointSuffix=core.windows.net")]Stream myBlob, string name, TraceWriter log)
        {
            log.Info($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
