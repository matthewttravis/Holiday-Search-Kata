using Newtonsoft.Json;

namespace HolidaySearchKata
{
    public class HolidaySearch
    {
        private readonly List<Flight> _flights;
        private readonly List<Hotel> _hotels;

        public HolidaySearch()
        {
            var directory = Directory.GetCurrentDirectory();
            var flightPath = Path.Combine(directory, "FlightData.json");
            var hotelPath = Path.Combine(directory, "HotelData.json");

            _flights = JsonConvert.DeserializeObject<List<Flight>>(File.ReadAllText(flightPath));
            _hotels = JsonConvert.DeserializeObject<List<Hotel>>(File.ReadAllText(hotelPath));
        }

        public List<Holiday> PerformSearch(Query query)
        {
            var results = new List<Holiday>();

            var flights = _flights.Where(x => x.From == query.DepartureCode && x.DepartureDate == query.DepartureDate).ToList();

            var hotels = _hotels.Where(x => x.Nights == query.Duration && x.ArrivalDate == query.DepartureDate && x.LocalAirports.Contains(query.ArrivalCode)).ToList();

            foreach (var hotel in hotels)
            {
                results.AddRange(flights.Select(flight => new Holiday(flight, hotel)));
            }

            results = results.OrderBy(x => x.TotalCost).ToList();

            return results;
        }
    }
}