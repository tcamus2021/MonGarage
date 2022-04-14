using MonGarage.Models;
using MonGarage.Models.BLL;
using MonGarage.Models.BLL.implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Results;

namespace MonGarage.Controllers
{
    public class FichesController : ApiController
    {
        FicheManager fm = new FicheManagerImpl();
        // GETALL
        public JsonResult<List<Fiche>> Get()
        {
            List<Fiche> allVoiture = fm.GetAll();
            return Json(allVoiture);
        }

        public JsonResult<Fiche> Get(int id)
        {
            return Json(fm.GetById(id));
        }

        public void Post([FromBody] Fiche fiche)
        {
            fm.Insert(fiche);
        }

        public void Put([FromBody] Fiche fiche)
        {
            fm.Update(fiche);
        }

        public void Delete(int id)
        {
            fm.Delete(id);
        }
    }
}
