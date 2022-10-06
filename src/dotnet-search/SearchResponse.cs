using System.Collections.Generic;

namespace DotNet.Search
{
    /// <summary>
    /// Represents a search response.
    /// </summary>
    public class SearchResponse
    {
        /// <summary>
        /// The total number of results.
        /// </summary>
        public long TotalHits { get; set; }
        /// <summary>
        /// The matching packages
        /// </summary>
        public IEnumerable<Package> Data { get; set; } = new List<Package>();
    }
}
