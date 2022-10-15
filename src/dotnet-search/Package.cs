using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotNet.Search
{
    /// <summary>
    /// A record for a package.
    /// </summary>
    public class Package
    {
        /// <summary>
        /// The package's ID
        /// </summary>
        [JsonProperty("@id")]
        public string ApiId { get; set; } = string.Empty;
        /// <summary>
        /// The type of the package
        /// </summary>
        
        [JsonProperty("@package")]
        public string Type { get; set; } = string.Empty;

        /// <summary>
        /// The package's registration
        /// </summary>
        public string Registration { get; set; } = string.Empty;
        /// <summary>
        /// The package's ID
        /// </summary>
        public string Id { get; set; } = string.Empty;
        /// <summary>
        /// The package's version
        /// </summary>
        public string Version { get; set; } = string.Empty;
        /// <summary>
        /// The package's description
        /// </summary>
        public string Description { get; set; } = string.Empty;
        /// <summary>
        /// The package's summary
        /// </summary>
        public string Summary { get; set; } = string.Empty;
        /// <summary>
        /// The package's title
        /// </summary>
        public string Title { get; set; } = string.Empty;
        /// <summary>
        /// The package's icon URL
        /// </summary>
        [Obsolete("This property is deprecated. Use the IconFile property instead.")]
        public string IconUrl { get; set; } = string.Empty;
        /// <summary>
        /// The package's license URL
        /// </summary>
        [Obsolete("This property is deprecated. Use the LicenseExpression property instead.")]
        public string LicenseUrl { get; set; } = string.Empty;
        /// <summary>
        /// The package's project URL
        /// </summary>
        public string ProjectUrl { get; set; } = string.Empty;
        /// <summary>
        /// The package's tags
        /// </summary>
        public IEnumerable<string> Tags { get; set; } = Array.Empty<string>();
        /// <summary>
        /// The package's authors
        /// </summary>
        public IEnumerable<string> Authors { get; set; } = Array.Empty<string>();
        /// <summary>
        /// The package's total number of downloads
        /// </summary>
        public int TotalDownloads { get; set; } = 0;
        /// <summary>
        /// <c>true</c> if the package is verified; otherwise, <c>false</c>.
        /// </summary>
        public bool Verified { get; set; } = false;
        /// <summary>
        /// Other package versions
        /// </summary>
        public IEnumerable<PackageVersion>? Versions { get; set; } = Array.Empty<PackageVersion>();
    }
}