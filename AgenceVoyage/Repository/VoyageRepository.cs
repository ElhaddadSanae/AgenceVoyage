using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage.Repository
{
    internal class VoyageRepository: IRepositoryGenerique<Voyage>
    {
        private DbSet<Voyage> table = null;
        private AgencyEtities db;
        public VoyageRepository() {
            this.db = new AgencyEtities();
            table = db.Set<Voyage>();
        }
        public VoyageRepository(AgencyEtities db) {
            this.db = new AgencyEtities();
            table = db.Set<Voyage>();
        }
        public void delete(object id)
        {
            Voyage found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Voyage> GetAll()
        {
            return table.ToList();
        }

        public Voyage GetById(object id)
        {
            return table.Find(id);
        }

        public void insert(Voyage entity)
        {
            table.Add(entity);
        }

        public void update(Voyage entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
