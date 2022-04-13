using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonGarage.Models.BLL.implementation
{
    public class MarqueManagerImpl : MarqueManager
    {
        Context db = new Context();

        public List<Marque> GetAll()
        {
            return db.Marques.ToList<Marque>();
        }

        public Marque GetById(string id)
        {
            return db.Marques.Where((marque) => marque.Sigle == id).ToList<Marque>().FirstOrDefault();
        }

        public void Insert(Marque marque)
        {
            db.Marques.Add(marque);
            db.SaveChanges();
        }

        public void Update(Marque marque)
        {
            Marque dbMarque = this.GetById(marque.Sigle);
            dbMarque.NomComplet = marque.NomComplet;
            db.SaveChanges();
        }
    }
}