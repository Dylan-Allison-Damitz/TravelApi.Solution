namespace TravelApi.Models
{
    public class Destination
    {
        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Country  { get; set; }
        public string City  { get; set; }
        public string Description { get; set; }

        public int Rating { get; set; }

        public string Review { get; set; }
    }
}