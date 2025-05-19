
namespace TicketBookingCore.Tests;

public class TicketBookingRequestProcessorTests
{
    [Fact]
    public void ShouldReturnTicketBookingResultWithRequestValues()
    {
        // Arrange
        var processor = new TicketBookingRequestProcessor();

        var request = new TicketBookingRequest
        {
            FirstName = "Abdul",
            LastName = "Rahman",
            Email = "abdulrahman@demo.com"
        };

        // Act
        TicketBookingResponse response = processor.Book(request);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(request.FirstName, response.FirstName);
        Assert.Equal(request.LastName, response.LastName);
        Assert.Equal(request.Email, response.Email);
    }
}
