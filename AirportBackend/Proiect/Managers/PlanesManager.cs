using Proiect.Entities;
using Proiect.Models;
using Proiect.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Managers
{
    public class PlanesManager : IPlanesManager
    {
        private readonly IPlanesRepository planesRepository;

        public PlanesManager(IPlanesRepository planesRepository)
        {
            this.planesRepository = planesRepository;
        }


        public void Create(PlaneCreationModel model)
        {
            var newPlane = new Plane
            {
                Id = model.Id,
                Name = model.Name
            };

            planesRepository.Create(newPlane);
        }

        public void Update(PlaneCreationModel model)
        {
            var plane = GetPlaneById(model.Id);

            plane.Id = model.Id;
            plane.Name = model.Name;

            planesRepository.Update(plane);
        }

        public void Delete(string id)
        {
            var ticket = GetPlaneById(id);

            planesRepository.Delete(ticket);
        }

        public Plane GetPlaneById(string id)
        {
            var plane = planesRepository.GetPlanes()
                .FirstOrDefault(x => x.Id == id);

            return plane;
        }

        public List<Plane> GetPlanes()
        {
            return planesRepository.GetPlanes().ToList();
        }

        public List<string> GetPlanesIds()
        {
            var planes = planesRepository.GetPlanes();
            var idList = planes.Select(x => x.Id)
                .ToList();

            return idList;
        }

        public List<Plane> GetPlanesWithTickets()
        {
            var planesWithTickets = planesRepository.GetPlanesWithTickets();

            return planesWithTickets.ToList();
        }

        public List<Object> JoinPlanesTickets()
        {
            var planesWithTickets = planesRepository.JoinPlanesTickets();
            return planesWithTickets.ToList();
        }

        public List<Object> GetGroupBy()
        {
            var gradeAverage = planesRepository.GetGroupBy();
            return gradeAverage.ToList();
        }
    }
}
