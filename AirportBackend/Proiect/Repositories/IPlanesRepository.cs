using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public interface IPlanesRepository
    {
        IQueryable<Plane> GetPlanes();  //gets all planes
        IQueryable<Plane> GetPlanesWithTickets();   //join between planes and tickets
        IQueryable<Object> JoinPlanesTickets();
        IQueryable<Object> GetGroupBy();    //Average of ticket price for each plane
        void Create(Plane author);
        void Update(Plane author);
        void Delete(Plane author);
    }
}
