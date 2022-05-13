using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HolidaySearchKata
{
    [TestClass]
    public class HolidaySearchTests
    {
        [TestMethod]
        public void UserStory1Test()
        {
            //Input Query
            //Departing from: Manchester Airport (MAN)
            //Traveling to: Malaga Airport (AGP)
            //Departure Date: 2023/07/01
            //Duration: 7 nights
            const string query = "{'departingFrom': 'Manchester Airport (MAN)', 'travelingTo': 'Malaga Airport (AGP), 'departureDate': '2023/07/01', 'duration': 7}";

            var holidaySearch = new HolidaySearch();

            var results = holidaySearch.PerformSearch(query);

            //Expectation
            //Flight 2 and Hotel 9
            Assert.Fail("{{'flight': {'id': 2, 'airline': 'Oceanic Airlines', 'from': 'MAN', 'to': 'AGP', 'price': 245, 'departure_date': '2023-07-01'}, " +
                        "'hotel': {'id': 9, 'name': 'Nh Malaga', 'arrival_date': '2023-07-01', 'price_per_night': 83, 'local_airports': ['AGP'], 'nights': 7}}", results.First());
        }
        
        [TestMethod]
        public void UserStory2Test()
        {
            //Input Query
            //Departing from: Any London Airport
            //Traveling to: Mallorca Airport (PMI)
            //Departure Date: 2023/06//15
            //Duration: 10 nights
            
            //Expectation
            //Flight 6 and Hotel 5
            Assert.Fail();
        }
        
        [TestMethod]
        public void UserStory3Test()
        {
            //Input Query
            //Departing from: Any Airport
            //Traveling to: Gran Canaria Airport (LPA)
            //Departure Date: 2022/11/10
            //Duration: 14 nights
            
            //Expectation
            //Flight 7 and Hotel 6
            Assert.Fail();
        }
    }
}