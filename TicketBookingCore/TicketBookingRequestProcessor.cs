namespace TicketBookingCore;

public class TicketBookingRequestProcessor
{
    private readonly ITicketBookingRepository _ticketBookingRepository;

    public TicketBookingRequestProcessor(ITicketBookingRepository ticketBookingRepository)
    {
        _ticketBookingRepository = ticketBookingRepository;
    }

    public TicketBookingResponse Book(TicketBookingRequest request)
    {
        if (request is null)
        {
            throw new ArgumentNullException(nameof(request));
        }

        _ticketBookingRepository.Save(new TicketBooking
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        });

        return new TicketBookingResponse
        {
            FirstName = request.FirstName,
            LastName = request.LastName,
            Email = request.Email
        };
    }
}
