
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
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}

internal class TicketBookingRequestProcessor
{
    public TicketBookingRequestProcessor()
    {
    }

    internal TicketBookingResponse Book(TicketBookingRequest request)
    {
      throw new NotImplementedException();
    }
}

internal class TicketBookingResponse
{
    public IAsyncEnumerable<char>? FirstName { get; internal set; }
    public IAsyncEnumerable<char>? LastName { get; internal set; }
    public IAsyncEnumerable<char>? Email { get; internal set; }
}
