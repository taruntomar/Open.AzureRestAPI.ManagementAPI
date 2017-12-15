using Newtonsoft.Json;

namespace Open.AzureRestAPI.ManagementAPI.Entities.VirtualMachine
{
    public partial class NetworkProfile
    {
        [JsonProperty("networkInterfaces")]
        public NetworkInterface[] NetworkInterfaces { get; set; }
    }
}
