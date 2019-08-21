using System;

using System.Collections.Generic;

using System.Linq;

using System.Net.Http;

using System.Text;

using System.Web.Http;

using TalkingClock_RestService;

using TalkingClock_RestService.Controllers;

using NUnit.Framework;

 

namespace TalkingClock_RestService.Tests.Controllers

{

    [TestFixture]

    public class TalkingClockControllerTest

    {

        [Test]

        public void CheckMinutes_Text()

        {

            // Arrange

            TalkingClockController controller = new TalkingClockController();

            

            decimal cMinInput = 13.48m;

 

            string[] checkMinsText = { "O'clock", "One minute past", "Quarter past", "Half past", "Quarter to", "One minute to", "minutes past", "minutes to" };

            

            // Act

            string minsResult = controller.GetTime(cMinInput);

 

            //Assert

            if (checkMinsText.Any(minsResult.Contains))

                    Assert.Pass();

            else

                Assert.Fail();

 

            

        }

 

        [Test]

       public void GetHour_Text()

        {

           // Arrange

           TalkingClockController controller = new TalkingClockController();

 

           decimal cInput = 18.00m;

 

           string[] sArraycheck = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve" };

 

           // Act

           string result = controller.GetTime(cInput).Trim();

 

            //Assert

            if (sArraycheck.Any(result.Contains))

                Assert.Pass();

            else

                Assert.Fail();

 

       }

        

 

    }

}
