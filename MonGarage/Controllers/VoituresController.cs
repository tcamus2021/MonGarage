using MonGarage.Models;
using MonGarage.Models.BLL.implementation;
using System;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace MonGarage.Controllers
{
    public class VoituresController : ApiController
    {
        VoitureManager vm = new VoitureManagerImpl();
        // GETALL
        public JsonResult<List<Voiture>> Get()
        {
            List<Voiture> allVoiture = vm.GetAll();
            return Json(allVoiture);
        }

        public JsonResult<Voiture> Get(int id)
        {
            return Json(vm.GetById(id));
        }

        public void Post([FromBody] Voiture voiture)
        {
            vm.Insert(voiture);
        }

        public void Put([FromBody] Voiture voiture)
        {
            vm.Update(voiture);
        }

        [System.Web.Http.HttpPost]
        public void Delete(int id)
        {
            vm.Delete(id);
        }
    }
}
