using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGarage.Models.BLL
{
    interface MarqueManager
    {
        List<Marque> GetAll();
        Marque GetById(string id);
        void Insert(Marque marque);
        void Update(Marque marque);
    }
}
