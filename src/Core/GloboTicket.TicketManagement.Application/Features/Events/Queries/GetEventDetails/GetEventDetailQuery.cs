using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetails
{
    public class GetEventDetailQuery : IRequest<EventDetailsViewModel>
    {
        public Guid Id { get; set; }
    }
}