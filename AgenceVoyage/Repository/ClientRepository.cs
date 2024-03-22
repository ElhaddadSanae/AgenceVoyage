using AgenceVoyage.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenceVoyage.Repository
{
    internal class ClientRepository: IRepositoryGenerique<Client>
    {
        private DbSet<Client> table = null;
        private AgencyEtities db;
        public ClientRepository() {
            this.db = new AgencyEtities();
            table = db.Set<Client>();
        }
        public ClientRepository(AgencyEtities db) {
            this.db = new AgencyEtities();
            table = db.Set<Client>();
        }
        public void delete(object id)
        {
            Client found = GetById(id);
            table.Remove(found);
        }

        public IEnumerable<Client> GetAll()
        {
            return table.ToList();
        }

        public Client GetById(object id)
        {
            return table.Find(id);
        }

        public void insert(Client entity)
        {
            table.Add(entity);
        }

        public void update(Client entity)
        {
            table.Attach(entity);
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}
