using Newtonsoft.Json;

namespace HolidaySearchKata.Models;

public class Flight
{
    public int Id { get; set; }
    public string Airline { get; set; }
    public Airport From { get; set; }
    public Airport To { get; set; }
    public int Price { get; set; }
    [JsonProperty(PropertyName = "departure_date")]
    public DateTime DepartureDate { get; set; }
}