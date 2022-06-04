using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public class RoutesManager : IRoutesManager
    {
        private readonly IRoutesRepository routesRepository;

        public RoutesManager(IRoutesRepository routesRepository)
        {
            this.routesRepository = routesRepository;
        }

        public List<Route> AlphabeticalOrder()
        {
            var sortedRoutes = routesRepository.GetRoutes()
                .ToList()
                .OrderBy(x => x.Name)
                .ToList();

            return sortedRoutes;
        }

        public Route GetRouteById(string id)
        {
            var route = routesRepository.GetRoutes()
                .FirstOrDefault(x => x.Id == id);

            return route;
        }

        public List<Route> GetRoutes()
        {
            return routesRepository.GetRoutes().ToList();
        }

        public List<string> GetRoutesIds()
        {
            var routes = routesRepository.GetRoutes();
            var idList = routes.Select(x => x.Id)
                .ToList();

            return idList;
        }

        public void Create(RouteCreationModel model)
        {
            var newRoute = new Route
            {
                Id = model.Id,
                Name = model.Name,
            };

            routesRepository.Create(newRoute);
        }

        public void Update(RouteCreationModel model)
        {
            var route = GetRouteById(model.Id);

            route.Id = model.Id;
            route.Name = model.Name;

            routesRepository.Update(route);
        }

        public void Delete(string id)
        {
            var route = GetRouteById(id);

            routesRepository.Delete(route);
        }
    }
}
