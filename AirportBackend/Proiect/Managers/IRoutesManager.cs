using Proiect.Entities;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface IRoutesManager
    {
        List<Route> GetRoutes();  //gets all routes
        List<string> GetRoutesIds(); //gets all ids from routes
        Route GetRouteById(string id); //gets a ticket with given id
        List<Route> AlphabeticalOrder(); //sorts routes
        void Create(RouteCreationModel model);
        void Update(RouteCreationModel model);
        void Delete(string id);
    }
}
