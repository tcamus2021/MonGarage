using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

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
            try
            {
                db.Marques.Add(marque);
                db.SaveChanges();
            } catch
            {
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            }
        }

        public void Update(Marque marque)
        {
            Marque dbMarque = this.GetById(marque.Sigle);
            dbMarque.NomComplet = marque.NomComplet;
            db.SaveChanges();
        }
    }
}