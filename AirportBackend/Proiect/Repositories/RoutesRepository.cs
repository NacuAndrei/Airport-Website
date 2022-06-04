using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class RoutesRepository : IRoutesRepository
    {
        private readonly ProiectContext db;
        public RoutesRepository(ProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Route> GetRoutes()
        {
            var routes = db.Routes;

            return routes;
        }

        public void Create(Route route)
        {
            db.Routes.Add(route);

            db.SaveChanges();
        }

        public void Update(Route route)
        {
            db.Routes.Update(route);

            db.SaveChanges();
        }

        public void Delete(Route route)
        {
            db.Routes.Remove(route);

            db.SaveChanges();
        }

    }
}
