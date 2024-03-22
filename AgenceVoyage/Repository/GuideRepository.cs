using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage.Repository
{
    internal class GuideRepository: IRepositoryGenerique<Guide>
    {
        private DbSet<Guide> table = null;
        private AgencyEtities db;
        public GuideRepository()
        {
            this.db = new AgencyEtities();
            table = db.Set<Guide>();
        }
        public GuideRepository(AgencyEtities db)
        {
            this.db = new AgencyEtities();
            table = db.Set<Guide>();
        }
        public void delete(object id)
        {
            Guide found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Guide> GetAll()
        {
            return table.ToList();
        }

        public Guide GetById(object id)
        {
            return table.Find(id);
        }

        public void insert(Guide entity)
        {
            table.Add(entity);
        }

        public void update(Guide entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
