using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGarage.Models.BLL
{
    interface FicheManager
    {
        List<Fiche> GetAll();
        Fiche GetById(int id);
        void Insert(Fiche fiche);
        void Delete(int id);
        void Update(Fiche fiche);
    }
}
