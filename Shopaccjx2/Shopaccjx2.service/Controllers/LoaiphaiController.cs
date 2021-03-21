using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using Shopaccjx2.service.Models.DAO;
using System.Web.Http;

namespace Shopaccjx2.service.Controllers
{
    [RoutePrefix("api/lp")]
    public class LoaiphaiController : ApiController
    {
        LoaiphaiDAO lpDAO = new LoaiphaiDAO();

        [Route("hephai")]
        [HttpGet]
        public IHttpActionResult Gettatcahephai()
        {
            var lst = lpDAO.Laytatcaloaiphai();
            return Json(lst);
        }
    }
}
