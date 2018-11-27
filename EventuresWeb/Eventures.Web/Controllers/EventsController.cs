using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Eventures.Models.ViewModels.Event;
using Eventures.Services.Contracts;
using Eventures.Web.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Eventures.Web.Controllers
{
    public class EventsController : BaseController
    {
        private readonly IEventService events;
        public EventsController(IEventService events)
        {
            this.events = events;
        }
        public IActionResult All()
        {
            var eventsList = events.All();

            return View(eventsList);
        }

        public IActionResult MyEvents()
        {
            var user = this.User.Identity.Name;
            var models = events.MyEvents(user);
            return View(models);
        }

        public IActionResult Create()
        {
            return this.View();
        }
        [HttpPost]
        [TypeFilter(typeof(CreateEventFilter))]
        public IActionResult Create(EventCreateViewModel model)
        {
            events.Create(model.Name, model.Place, model.Start, model.End, model.Tickets, model.PricePerTicket);

            return this.RedirectToAction(nameof(All));
        }
    }
}