namespace HolidaySearchKata;

public class Query
{
    public string DepartingFrom { get; set; }
    public string TravelingTo { get; set; }
    public DateTime DepartureDate { get; set; }
    public int Duration { get; set; }

    public string DepartureCode => DepartingFrom.Substring(DepartingFrom.IndexOf('(') + 1, 3);
    public string ArrivalCode => TravelingTo.Substring(TravelingTo.IndexOf('(') + 1, 3);
}