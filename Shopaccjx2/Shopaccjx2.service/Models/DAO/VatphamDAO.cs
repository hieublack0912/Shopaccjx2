using Shopaccjx2.data.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Shopaccjx2.service.Models.DAO
{
    public class VatphamDAO
    {
        public List<VatphamModel> Laytatcavatpham()
        {
            List<VatphamModel> lst = null;

            using (var vp = new Shopaccjx2Entities())
            {
                lst = vp.Database.SqlQuery<VatphamModel>("exec Layallvp").ToList();
                if (lst.Count() > 0)
                {
                    return lst;
                }

                return null;
            }
        }

        public List<VatphamModel> Layvatphamban()
        {
            List<VatphamModel> lst = null;

            using (var vp = new Shopaccjx2Entities())
            {
                lst = vp.Database.SqlQuery<VatphamModel>("exec Layallvpban").ToList();
                if (lst.Count() > 0)
                {
                    return lst;
                }

                return null;
            }
        }

        public List<Vatpham> Layvatphamtheoid(int id_vp)
        {
            using (var ef = new Shopaccjx2Entities())
            {
                List<Vatpham> re = ef.Database.SqlQuery<Vatpham>("exec Layvptheoid " + id_vp).ToList();
                return re;
            }

        }

        public void Themvatpham(Vatpham vp)
        {
            using (var ef = new Shopaccjx2Entities())
            {
                ef.Database.ExecuteSqlCommand("Themvatpham (@ten , @gia , @mota , @anh , @trangthai , @madanhmuc)",
                new[]
                {
                        new SqlParameter("ten", vp.Tenvatpham),
                        new SqlParameter("gia", vp.Giaban),
                        new SqlParameter("mota", vp.Mota),
                        new SqlParameter("anh", vp.Anhvatpham),
                        new SqlParameter("trangthai", vp.Trangthai),
                        new SqlParameter("madanhmuc", vp.Ma_danhmuc),
                });
            }
        }

        public void Suavatpham(Vatpham vp)
        {
            using (var ef = new Shopaccjx2Entities())
            {
                ef.Database.ExecuteSqlCommand("Suavatpham (@id, @ten , @gia , @mota , @anh , @trangthai , @madanhmuc)",
                new[]
                {
                        new SqlParameter("ten", vp.Tenvatpham),
                        new SqlParameter("gia", vp.Giaban),
                        new SqlParameter("mota", vp.Mota),
                        new SqlParameter("anh", vp.Anhvatpham),
                        new SqlParameter("trangthai", vp.Trangthai),
                        new SqlParameter("madanhmuc", vp.Ma_danhmuc),
                });
            }
        }

        public int Xoavatpham(int id)
        {
            using (var ef = new Shopaccjx2Entities())
            {
                int re = ef.Database.ExecuteSqlCommand("Xoavatpham " + id);
                return re;
            }
        }
    }
}