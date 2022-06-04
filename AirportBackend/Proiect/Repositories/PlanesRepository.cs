using Microsoft.EntityFrameworkCore;
using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proiect.Repositories
{
    public class PlanesRepository : IPlanesRepository
    {
        private ProiectContext db;

        public PlanesRepository(ProiectContext db)
        {
            this.db = db;
        }

        public IQueryable<Plane> GetPlanes()
        {
            var planes = db.Planes;

            return planes;
        }

        public IQueryable<Plane> GetPlanesWithTickets()
        {
            var planes = GetPlanes().Include(x => x.Tickets);

            return planes ;
        }

        public IQueryable<Object> JoinPlanesTickets()
        {
            var planesTickets = db.Planes.Join
                 (db.Tickets,
                 p => p.Id,
                 t => t.PlaneId,
                 (p, t) => new { p.Id, t.DateOfPurchase });

            return planesTickets;
        }

        public IQueryable<Object> GetGroupBy()
        {
            var gradeAverage = db.Tickets.GroupBy(x => x.PlaneId).Select(x => new
            {
                Key = x.Key,
                Average = x.Average(x => (long)Convert.ToDouble(x.Price)),
            });

            return gradeAverage;
        }

        public void Create(Plane plane)
        {
            db.Planes.Add(plane);

            db.SaveChanges();
        }

        public void Update(Plane plane)
        {
            db.Planes.Update(plane);

            db.SaveChanges();
        }

        public void Delete(Plane plane)
        {
            db.Planes.Remove(plane);

            db.SaveChanges();
        }

    }
}
