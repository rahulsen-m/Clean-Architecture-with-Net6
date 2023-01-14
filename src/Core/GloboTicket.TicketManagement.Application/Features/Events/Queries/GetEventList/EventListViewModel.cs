namespace GloboTicket.TicketManagement.Application.Features.Events.Queries.GetEventList
{
    public class EventListViewModel
    {
        public Guid EventId { get; set; }
        public string Name { get; set; } = default!;
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; } = default!;
    }
}