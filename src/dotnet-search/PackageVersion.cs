using Newtonsoft.Json;

namespace DotNet.Search
{
    /// <summary>
    /// A record for a package's version
    /// </summary>
    public class PackageVersion
    {
        /// <summary>
        /// The package version's ID
        /// </summary>
        [JsonProperty("@id")]
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// The SemVer version number
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// The number of times this particular version has been downloaded
        /// </summary>
        public int Downloads { get; set; }
    }
}