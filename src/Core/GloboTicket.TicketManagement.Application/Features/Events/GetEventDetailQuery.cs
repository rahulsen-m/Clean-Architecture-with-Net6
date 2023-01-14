using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}