using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonGarage.Models.BLL.implementation
{
    public class VoitureManagerImpl : VoitureManager
    {
        Context db = new Context();

        public void Delete(int id)
        {
            Voiture voiture = this.GetById(id);
            db.Voitures.Remove(voiture);
            db.SaveChanges();
        }

        public List<Voiture> GetAll()
        {
            return db.Voitures.ToList<Voiture>();
        }

        public Voiture GetById(int id)
        {
            return db.Voitures.Find(id);
        }

        public void Insert(Voiture voiture)
        {
            voiture.Marque = db.Marques.Find(voiture.Marque.Sigle);
            db.Voitures.Add(voiture);
            db.SaveChanges();
        }

        public void Update(Voiture voiture)
        {
            Voiture voitureDb = this.GetById(voiture.IdVoiture);
            voitureDb.Marque = db.Marques.Find(voiture.Marque.Sigle);
            voitureDb.Model = voiture.Model;
            db.SaveChanges();
        }
    }
}