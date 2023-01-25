using GloboTicket.TicketManagement.Application.Contracts.Persistence;
using GloboTicket.TicketManagement.Domain.Entities;

namespace GloboTicket.TicketManagement.Persistence.Repositories
{
    public class EventRepository : BaseRepositories<Event>, IEventRepository
    {
        public EventRepository(GloboTicketDbContext dbContext)
            : base(dbContext)
        {

        }
        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventDate)
        {
            var matchs = _dbContext.Events.Any(e => e.Name.Equals(name) &&
                e.Date.Date.Equals(eventDate.Date));
            return Task.FromResult(matchs);
        }
    }
}
