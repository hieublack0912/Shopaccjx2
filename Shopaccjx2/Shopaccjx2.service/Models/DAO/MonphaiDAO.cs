using Shopaccjx2.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopaccjx2.service.Models.DAO
{
    public class MonphaiDAO
    {
        public List<Monphai> Laytatcamonphai()
        {
            using (var mp = new Shopaccjx2Entities())
            {
                var lst = mp.Database.SqlQuery<Monphai>("select * from Monphai").ToList();
                if (lst.Count() > 0)
                {
                    return lst;
                }

                return null;
            }
        }
    }
}