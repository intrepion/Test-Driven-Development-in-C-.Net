
namespace TicketBookingCore.Tests;

public class TicketBookingRequestProcessorTests
{
    private readonly TicketBookingRequestProcessor _processor;

    public TicketBookingRequestProcessorTests()
    {
        _processor = new TicketBookingRequestProcessor();
    }

    [Fact]
    public void ShouldReturnTicketBookingResultWithRequestValues()
    {
        // Arrange
        var request = new TicketBookingRequest
        {
            FirstName = "Abdul",
            LastName = "Rahman",
            Email = "abdulrahman@demo.com"
        };

        // Act
        TicketBookingResponse response = _processor.Book(request);

        // Assert
        Assert.NotNull(response);
        Assert.Equal(request.FirstName, response.FirstName);
        Assert.Equal(request.LastName, response.LastName);
        Assert.Equal(request.Email, response.Email);
    }

    [Fact]
    public void ShouldThrowExceptionIfRequestIsNull()
    {
        // Act
        var exception = Assert.Throws<ArgumentNullException>(() => _processor.Book(null));

        // Assert
        Assert.Equal("request", exception.ParamName);
    }
}
