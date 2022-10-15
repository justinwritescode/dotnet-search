using System.Collections.Generic;

namespace DotNet.Search
{
    /// <summary>
    /// A response from the search service.
    /// </summary>
    public class SearchResponse
    {
        /// <summary>
        /// The total number of results found.
        /// </summary>
        public int TotalHits { get; set; }
        /// <summary>
        /// The package payload
        /// </summary>
        public IEnumerable<Package> Data { get; set; } = Array.Empty<Package>();
    }
}