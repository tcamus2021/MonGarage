using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonGarage.Models.BLL.implementation
{
    public class FicheManagerImpl : FicheManager
    {
        Context db = new Context();
        public void Delete(int id)
        {
            Fiche fiche = this.GetById(id);
            db.Fiches.Remove(fiche);
            db.SaveChanges();
        }

        public List<Fiche> GetAll()
        {
            return db.Fiches.ToList<Fiche>();
        }

        public Fiche GetById(int id)
        {
            return db.Fiches.Find(id);
        }

        public void Insert(Fiche fiche)
        {
            fiche.Client = db.Clients.Find(fiche.Client.IdClient);
            fiche.Voiture = db.Voitures.Find(fiche.Voiture.IdVoiture);
            db.Fiches.Add(fiche);
            db.SaveChanges();
        }

        public void Update(Fiche fiche)
        {
            Fiche dbFiche = this.GetById(fiche.IdFiche);
            dbFiche.Prix = fiche.Prix;
            dbFiche.Client = db.Clients.Find(fiche.Client.IdClient);
            dbFiche.Voiture = db.Voitures.Find(fiche.Voiture.IdVoiture);
            db.SaveChanges();
        }
    }
}