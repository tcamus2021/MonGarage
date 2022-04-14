using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonGarage.Models.BLL
{
    public class ClientManagerImpl : ClientManager
    {

        Context db = new Context();

        public void Delete(int id)
        {
            Client client = this.GetById(id);
            db.Clients.Remove(client);
            db.SaveChanges();
        }

        public List<Client> GetAll()
        {
            return db.Clients.ToList<Client>();
        }

        public Client GetById(int id)
        {
            return db.Clients.Find(id);
        }

        public void Insert(Client client)
        {
            db.Clients.Add(client);
            db.SaveChanges();
        }

        public void Update(Client client)
        {
            Client dbClient = this.GetById(client.IdClient);
            dbClient.Nom = client.Nom;
            dbClient.Numero = client.Numero;
            db.SaveChanges();
        }
    }
}