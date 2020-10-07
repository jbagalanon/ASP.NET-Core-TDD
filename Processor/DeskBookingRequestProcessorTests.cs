using System;
using System.Collections.Generic;
using System.Text;
using DeskBooker.Core.Domain;
using Xunit;

namespace DeskBooker.Core.Processor
{
    public class DeskBookingRequestProcessorTests
    {
        private readonly DeskBookingRequestProcessor _processor;
        public DeskBookingRequestProcessorTests()
        {
            _processor=new DeskBookingRequestProcessor();
        }
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

           
            //Act
            DeskBookingResult result = _processor.BookDesk(request);

            //assert
            Assert.NotNull(result);
            Assert.Equal(request.FirstName, result.FirstName);
            Assert.Equal(request.LastName, result.LastName);
            Assert.Equal(request.Email, result.Email);
            Assert.Equal(request.Date, result.Date);
        }

        [Fact]
        public void ShouldThrowExceptionIfRequestIsNull()
        {
            var exception = Assert.Throws<ArgumentNullException>(() => _processor.BookDesk(null));

            Assert.Equal("request",exception.ParamName);
        }
      
    }
}
