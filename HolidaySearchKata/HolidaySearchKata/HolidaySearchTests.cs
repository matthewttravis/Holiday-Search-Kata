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

            //Expectation
            //Flight 2 and Hotel 9
            Assert.Fail();
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