using Shopaccjx2.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopaccjx2.service.Models.DAO
{
    public class LoaiphaiDAO
    {
        public List<LoaiphaiModel> Laytatcaloaiphai()
        {
            List<LoaiphaiModel> lst = null;

            using (var vp = new Shopaccjx2Entities())
            {
                lst = vp.Database.SqlQuery<LoaiphaiModel>("Laytatcaloaiphai").ToList();
                if (lst.Count() > 0)
                {
                    return lst;
                }

                return null;
            }
        }
    }
}