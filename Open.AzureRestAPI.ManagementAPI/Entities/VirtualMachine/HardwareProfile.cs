using Newtonsoft.Json;

namespace Open.AzureRestAPI.ManagementAPI.Entities.VirtualMachine
{
    public partial class HardwareProfile
    {
        [JsonProperty("vmSize")]
        public string VmSize { get; set; }
    }
}
