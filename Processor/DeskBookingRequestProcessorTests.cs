using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        [Fact]
        public void ShouldReturnDeskBookingResultWithValueRequest()
        {


            var request = new DeskBookingRequest
            {
                FirstName = "Joms",
                LastName = "Huber",
                Email = "jbagalanpon@gmail.com",
                Date = new DateTime(2020, 2, 27)
            };

            var processor = new DeskBookingRequestProcessor();

            //Act
            DeskBookingResult result = processor.BookDesk(request);

            //assert
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }

      
    }
}
