using HolidaySearchKata.Models;
using Newtonsoft.Json;

namespace HolidaySearchKata;

public class HolidaySearch
{
    private readonly List<Flight> _flights;
    private readonly List<Hotel> _hotels;

    public HolidaySearch()
    {
        //import data from files.
        var directory = Directory.GetCurrentDirectory();
        var flightPath = Path.Combine(directory, "FlightData.json");
        var hotelPath = Path.Combine(directory, "HotelData.json");

        _flights = JsonConvert.DeserializeObject<List<Flight>>(File.ReadAllText(flightPath));
        _hotels = JsonConvert.DeserializeObject<List<Hotel>>(File.ReadAllText(hotelPath));
    }

    public List<Holiday> PerformSearch(Query query)
    {
        //filter flights and hotels based on query terms.
        var flights = FindFlights(query.DepartingFrom, query.TravelingTo, query.DepartureDate);
        var hotels = FindHotels(query.TravelingTo, query.Duration, query.DepartureDate);

        var results = new List<Holiday>();
        
        //compile collection of every possible flight and hotel combination.
        foreach (var hotel in hotels)
        {
            results.AddRange(flights.Select(flight => new Holiday(flight, hotel)));
        }

        //sort the results by total cost to get best value first.
        results = results.OrderBy(x => x.TotalCost).ToList();

        return results;
    }

    private List<Hotel> FindHotels(Airport queryTravelingTo, int queryDuration, DateTime queryDepartureDate)
    {
        //return a filtered collection of hotels, using bitwise operation to determine airport match from Airport enum.
        return _hotels.Where(x => x.Nights == queryDuration 
                                  && x.ArrivalDate == queryDepartureDate
                                  && (x.LocalAirportsCombined & queryTravelingTo) == queryTravelingTo).ToList();
    }

    private List<Flight> FindFlights(Airport queryDepartingFrom, Airport queryTravelingTo, DateTime queryDepartureDate)
    {
        //return a filtered collection of flights, using bitwise operation to determine airport match from Airport enum.
        return _flights.Where(x => (x.From & queryDepartingFrom) == x.From 
                                   && (x.To & queryTravelingTo) == x.To 
                                   && x.DepartureDate == queryDepartureDate).ToList();
    }
}