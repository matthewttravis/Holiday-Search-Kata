namespace HolidaySearchKata.Models;

public class Holiday
{
    public Holiday(Flight flight, Hotel hotel)
    {
        Flight = flight;
        Hotel = hotel;
    }
    public int TotalCost => Flight.Price + (Hotel.PricePerNight * Hotel.Nights);
    public Flight Flight { get; set; }
    public Hotel Hotel { get; set; }
}