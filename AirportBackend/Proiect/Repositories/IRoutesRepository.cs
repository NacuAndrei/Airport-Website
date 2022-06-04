using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IRoutesRepository
    {
        IQueryable<Route> GetRoutes();  //gets all routes
        void Create(Route route);
        void Update(Route route);
        void Delete(Route route);
    }
}
