using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Shopaccjx2.service.Models.DAO;

namespace Shopaccjx2.service.Controllers
{
    [RoutePrefix("api/monphai")]
    public class MonphaiController : ApiController
    {
        MonphaiDAO mpDAO = new MonphaiDAO();

        [Route("allmonphai")]
        [HttpGet]
        public IHttpActionResult Getallvatpham()
        {
            var lst = mpDAO.Laytatcamonphai();
            return Json(lst);
        }
    }
}
