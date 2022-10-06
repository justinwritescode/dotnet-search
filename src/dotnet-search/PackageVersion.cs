using Newtonsoft.Json;

namespace DotNet.Search
{
    /// <summary>
    /// Represents a package version.
    /// </summary>
    public class PackageVersion
    {
        /// <summary>
        /// The ID of the packafeversion.
        /// </summary>
        [JsonProperty("@id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// The version string
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// The number of downloads.
        /// </summary>
        public long Downloads { get; set; } = 0;
    }
}
