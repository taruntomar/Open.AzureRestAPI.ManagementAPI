using Newtonsoft.Json;

namespace Open.AzureRestAPI.ManagementAPI.Entities.VirtualMachine
{
    public partial class WindowsConfiguration
    {
        [JsonProperty("enableAutomaticUpdates")]
        public bool EnableAutomaticUpdates { get; set; }

        [JsonProperty("provisionVMAgent")]
        public bool ProvisionVMAgent { get; set; }
    }
}
