using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;

namespace GloboTicket.TicketManagement.Application.Features.Events
{
    public class GetEventListQuery : IRequest<List<EventListViewModel>>
    { }
}