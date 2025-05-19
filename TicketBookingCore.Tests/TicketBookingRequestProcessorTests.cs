
using Moq;

namespace TicketBookingCore.Tests;

public class TicketBookingRequestProcessorTests
{
    private readonly TicketBookingRequest _request;
    private readonly Mock<ITicketBookingRepository> _ticketBookingRepositoryMock;
    private readonly TicketBookingRequestProcessor _processor;

    public TicketBookingRequestProcessorTests()
    {
        _request = new TicketBookingRequest
        {
            FirstName = "Abdul",
            LastName = "Rahman",
            Email = "abdulrahman@demo.com"
        };

        _ticketBookingRepositoryMock = new Mock<ITicketBookingRepository>();

        _processor = new TicketBookingRequestProcessor(_ticketBookingRepositoryMock.Object);
    }

    [Fact]
    public void ShouldSaveToDatabase()
    {
        // Arrange
        TicketBooking savedTicketBooking = null;

        _ticketBookingRepositoryMock.Setup(x => x.Save(It.IsAny<TicketBooking>()))
            .Callback<TicketBooking>((ticketBooking) =>
            {
                savedTicketBooking = ticketBooking;
            });

        // Act
        _processor.Book(_request);

        // Assert
        _ticketBookingRepositoryMock.Verify(x => x.Save(It.IsAny<TicketBooking>()), Times.Once);

        Assert.NotNull(savedTicketBooking);
        Assert.Equal(_request.FirstName, savedTicketBooking.FirstName);
        Assert.Equal(_request.LastName, savedTicketBooking.LastName);
        Assert.Equal(_request.Email, savedTicketBooking.Email);
    }
}
