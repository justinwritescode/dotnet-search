using System.Collections.Generic;
using Newtonsoft.Json;

namespace DotNet.Search
{
    public class Package
    {
        [JsonProperty("@id")]
        public string ApiId { get; set; } = string.Empty;
        
        [JsonProperty("@package")]
        public string Type { get; set; } = string.Empty;

        public string Registration { get; set; } = string.Empty;
        public string Id { get; set; } = string.Empty;
        public string Version { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Summary { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string IconUrl { get; set; } = string.Empty;
        public string LicenseUrl { get; set; } = string.Empty;
        public string ProjectUrl { get; set; } = string.Empty;
        public IEnumerable<string> Tags { get; set; } = new List<string>();
        public IEnumerable<string> Authors { get; set; } = new List<string>();
        public long TotalDownloads { get; set; }
        public bool Verified { get; set; }
        public IEnumerable<PackageVersion> Versions { get; set; } = new List<PackageVersion>();
    }
}
