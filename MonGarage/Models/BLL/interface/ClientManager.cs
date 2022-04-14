using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonGarage.Models.BLL
{
    interface ClientManager
    {
        List<Client> GetAll();
        Client GetById(int id);
        void Insert(Client client);
        void Delete(int id);
        void Update(Client client);
    }
}
