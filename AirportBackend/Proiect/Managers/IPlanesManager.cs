using Proiect.Entities;
using Proiect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public interface IPlanesManager
    {
        List<Plane> GetPlanes();  //gets all planes
        List<string> GetPlanesIds();  //gets all ids from planes
        Plane GetPlaneById(string id);   //gets plane with given id
        List<Plane> GetPlanesWithTickets();   //join between planes and tickets*/
        List<Object> JoinPlanesTickets();
        List<Object> GetGroupBy();


        void Create(PlaneCreationModel model);
        void Update(PlaneCreationModel model);
        void Delete(string id);
    }
}
