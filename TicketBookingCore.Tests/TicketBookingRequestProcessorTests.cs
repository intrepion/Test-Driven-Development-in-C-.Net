
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

internal class TicketBookingRequest
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}

internal class TicketBookingRequestProcessor
{
    public TicketBookingRequestProcessor()
    {
    }

    internal TicketBookingResponse Book(TicketBookingRequest request)
    {
        return new TicketBookingResponse
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };
    }
}

internal class TicketBookingResponse
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}
