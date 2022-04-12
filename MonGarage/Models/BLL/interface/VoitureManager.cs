using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGarage.Models
{
    interface VoitureManager
    {
        List<Voiture> GetAll();
        Voiture GetById(int id);
        void Insert(Voiture voiture);
        void Delete(int id);
        void Update(Voiture voiture);
    }
}
