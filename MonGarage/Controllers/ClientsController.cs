using MonGarage.Models;
using MonGarage.Models.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MonGarage.Controllers
{
    public class ClientsController : ApiController
    {
        ClientManager cm = new ClientManagerImpl();

        public JsonResult<List<Client>> Get()
        {
            List<Client> allClient = cm.GetAll();
            return Json(allClient);
        }

        public JsonResult<Client> Get(int id)
        {
            return Json(cm.GetById(id));
        }

        public void Post([FromBody] Client client)
        {
            cm.Insert(client);
        }

        public void Put([FromBody] Client client)
        {
            cm.Update(client);
        }

        public void Delete(int id)
        {
            cm.Delete(id);
        }
    }
}
