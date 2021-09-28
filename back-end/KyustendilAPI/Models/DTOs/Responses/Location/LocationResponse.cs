namespace KyustendilAPI.Models.DTOs.Responses.Location
{
    /// <summary>
    /// The location object that is returned as a respose
    /// </summary>
    public class LocationResponse
    {
        /// <summary>
        /// Unique id of the place
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title of the place
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Picture of the place
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// The location on which the place can be found
        /// </summary>
        public string Information { get; set; }

        /// <summary>
        /// The latitude of the location
        /// </summary>
        public int Lat { get; set; }

        /// <summary>
        /// The longitude of the location
        /// </summary>
        public int Lgn { get; set; }
    }
}
