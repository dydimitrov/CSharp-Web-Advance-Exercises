using Eventures.Models;
using Eventures.Models.Enum;
using Eventures.Services.Contracts;
using System;
using System.Linq;
using Eventures.Data;
using Eventures.Models.ViewModels.Product;
using System.Collections.Generic;

namespace Eventures.Services
{
    public class EventService : IEventService
    {
        private readonly EventuresDbContext db;
        public EventService(EventuresDbContext db)
        {
            this.db = db;
        }        
        
    }
}
