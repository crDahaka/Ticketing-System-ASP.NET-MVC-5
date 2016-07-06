namespace TicketingSystem.Web.Areas.Administration.Controllers
{
    using Common;
    using System.Web.Mvc;
    using TicketingSystem.Web.Controllers;
    using Data;

    [Authorize(Roles = GlobalConstants.AdminRole)]
    public abstract class AdminController : BaseController
    {
        public AdminController(ITicketSystemData data) : base(data)
        {

        }
        
    }
}