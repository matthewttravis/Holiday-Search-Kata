using Newtonsoft.Json;

namespace HolidaySearchKata;

public class Hotel
{
    public int Id { get; set; }
    public string Name { get; set; }
    [JsonProperty(PropertyName = "arrival_date")]
    public DateTime ArrivalDate { get; set; }
    [JsonProperty(PropertyName = "price_per_night")]
    public int PricePerNight { get; set; }
    [JsonProperty(PropertyName = "local_airports")]
    public List<string> LocalAirports { get; set; }
    public int Nights { get; set; }
}