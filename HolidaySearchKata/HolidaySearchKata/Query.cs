namespace HolidaySearchKata;

public class Query
{
    public Airport DepartingFrom { get; set; }
    public Airport TravelingTo { get; set; }
    public DateTime DepartureDate { get; set; }
    public int Duration { get; set; }
}