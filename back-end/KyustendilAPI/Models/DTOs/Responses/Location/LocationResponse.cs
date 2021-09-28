namespace KyustendilAPI.Models.DTOs.Responses.Location
{
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
        /// Description of the place
        /// </summary>
        public string Picture { get; set; }

        /// <summary>
        /// The location on which the place can be found
        /// </summary>
        public string Information { get; set; }
    }
}
