using MonGarage.Models;
using MonGarage.Models.BLL;
using MonGarage.Models.BLL.implementation;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace MonGarage.Controllers
{
    public class MarquesController : ApiController
    {
        MarqueManager mm = new MarqueManagerImpl();
        // GETALL
        public JsonResult<List<Marque>> Get()
        {
            List<Marque> allMarques = mm.GetAll();
            return Json(allMarques);
        }

        public JsonResult<Marque> Get(string id)
        {
            return Json(mm.GetById(id));
        }

        public void Post([FromBody] Marque marque)
        {
            mm.Insert(marque);
        }

        public void Put([FromBody] Marque marque)
        {
            mm.Update(marque);
        }
    }
}
