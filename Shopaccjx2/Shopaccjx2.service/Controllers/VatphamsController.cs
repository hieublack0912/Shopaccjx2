using Shopaccjx2.data.Model;
using Shopaccjx2.service.Models;
using Shopaccjx2.service.Models.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shopaccjx2.service.Controllers
{
    [RoutePrefix("api/vp")]
    public class VatphamsController : ApiController
    {
        VatphamDAO vpDAO = new VatphamDAO();
        // GET: api/Vatphams
        [Route("vatpham")]
        [HttpGet]
        public IHttpActionResult Getallvatpham()
        {
            var lst = vpDAO.Laytatcavatpham();
            return Json(lst);
        }

        [Route("vatphamban")]
        [HttpGet]
        public IHttpActionResult Getallvpban()
        {
            var lst = vpDAO.Layvatphamban();
            return Json(lst);
        }

        [HttpGet]
        [Route("getvatpham")]
        // GET: api/vp/getvatpham?id=1
        public IHttpActionResult Getvatphamtheoid(int id)
        {
            var a = vpDAO.Layvatphamtheoid(id);
            return Json(a);
        }

        // POST: api/Vatphams
        [HttpPost]
        [Route("themvatpham")]
        public IHttpActionResult Postvatpham(Vatpham vp)
        {

            vpDAO.Themvatpham(vp);
            return Ok();
        }

        // PUT: api/Vatphams/5
        [HttpPut]
        [Route("suavatpham")]
        public IHttpActionResult Putvatpham(Vatpham vp)
        {
            vpDAO.Suavatpham(vp);
            return Ok();
        }

        // DELETE: api/Vatphams/5
        [HttpDelete]
        [Route("deletevatpham")]
        public int Deletevatpham(int id)
        {
            try
            {
                var re = vpDAO.Xoavatpham(id);
                return re;
            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return 0;
            }
        }
    }
}
