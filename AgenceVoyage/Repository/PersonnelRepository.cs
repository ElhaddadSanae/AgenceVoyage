using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage.Repository
{
    internal class PersonnelRepository : IRepositoryGenerique<Personnel>
    {
        private DbSet<Personnel> table = null;
        private AgencyEtities db;

        public PersonnelRepository(AgencyEtities db)
        {
            this.db = db;
            table = db.Set<Personnel>();
        }

        public void delete(object id)
        {
            Personnel found = GetById(id);
            if (found != null)
                table.Remove(found);
        }

        public IEnumerable<Personnel> GetAll()
        {
            return table.ToList();
        }

        public Personnel GetById(object id)
        {
            return table.Find(id);
        }

        public void insert(Personnel entity)
        {
            table.Add(entity);
        }

        public void update(Personnel entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
