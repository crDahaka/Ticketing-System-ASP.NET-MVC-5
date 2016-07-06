namespace TicketingSystem.Web.Infrastructure.Services
{
    using System.Collections.Generic;
    using TicketingSystem.Web.ViewModels.Home;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Base;
    using Data;
    using Contracts;
    public class HomeServices : BaseServices, IHomeServices
    {
        public HomeServices(ITicketSystemData data)
            :base(data)
        {

        }

        public IList<TicketViewModel>GetIndexViewModel(int numberOfTickets)
        {
            var indexViewModel = this.Data
                .Tickets
                .All()
                .OrderByDescending(t => t.Comments.Count())
                .Take(6)
                .Project()
                .To<TicketViewModel>()
                .ToList();

            return indexViewModel;
        }
    }
}