using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage.Repository
{
    internal class AdminRepository: IRepositoryGenerique<Admin>
    {
        private DbSet<Admin> table = null;
        // private TacheEntitie db;
        private AgencyEtities db;

        public AdminRepository()
        {
            this.db = new AgencyEtities();
            // table = db.Set<T>();
            table = db.Set<Admin>();
        }
        public AdminRepository(AgencyEtities db)
        {
            this.db = new AgencyEtities();
            table = db.Set<Admin>();
        }
        public void delete(object id)
        {
            Admin found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Admin> GetAll()
        {
            return table.ToList();
        }

        public Admin GetById(object id)
        {
            return table.Find(id);
        }

        public void insert(Admin entity)
        {
            table.Add(entity);
        }

        public void update(Admin entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
