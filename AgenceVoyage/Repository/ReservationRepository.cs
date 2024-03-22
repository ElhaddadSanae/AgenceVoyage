using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage.Repository
{
     internal class ReservationRepository: IRepositoryGenerique<Reservation>
    {
        private DbSet<Reservation> table = null;
        private AgencyEtities db;
        public ReservationRepository()
        {
            this.db = new AgencyEtities();
            table = db.Set<Reservation>();
        }
        public ReservationRepository(AgencyEtities db)
        {
            this.db = new AgencyEtities();
            table = db.Set<Reservation>();
        }

        public void delete(object id)
        {
            Reservation found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return table.ToList();
        }

        public Reservation GetById(object id)
        {
            return table.Find(id);
        }

        public void insert(Reservation entity)
        {
            table.Add(entity);
        }

        public void update(Reservation entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
