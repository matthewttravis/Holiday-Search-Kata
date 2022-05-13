using Newtonsoft.Json;

namespace HolidaySearchKata
{
    public class HolidaySearch
    {
        private List<Flight> _flights;
        private List<Hotel> _hotels;

        public HolidaySearch()
        {
            var directory = Directory.GetCurrentDirectory();
            var flightPath = Path.Combine(directory, "FlightData.json");
            var hotelPath = Path.Combine(directory, "HotelData.json");

            _flights = JsonConvert.DeserializeObject<List<Flight>>(File.ReadAllText(flightPath));
            _hotels = JsonConvert.DeserializeObject<List<Hotel>>(File.ReadAllText(hotelPath));
        }

        public List<string> PerformSearch(string jsonQuery)
        {
            throw new NotImplementedException();
        }
    }
}