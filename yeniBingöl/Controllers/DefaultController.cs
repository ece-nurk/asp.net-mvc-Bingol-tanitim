using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using yeniBingöl.Models;
using System.Data.SqlClient;
using Microsoft.AspNet.Identity;
using System.Globalization;
using System.Threading;

namespace yeniBingöl.Controllers
{
    public class DefaultController : Controller
    {
        private string connectionString = "Server=ECENUR\\SQLEXPRESS;Database=Foto;Trusted_Connection=True;";

        // GET: Default
        public ActionResult Index()
        {
            List<Foto> fotolar = new List<Foto>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Table]", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Foto foto = new Foto
                    {
                        Id = Convert.ToInt32(reader["Id"]),
                        Baslik = reader["baslik"].ToString(),
                        Url = reader["url"].ToString()
                    };
                    fotolar.Add(foto);
                }
            }
            ViewBag.Fotolar = fotolar;
            return View();
        }

        // GET: Default
        private CityDataContext db = new CityDataContext();
        [Authorize]

        public ActionResult Nufus()
        {
            var model = new CityViewModel
            {
                Ilceler = db.Ilceler.ToList(),
                NufusBilgi = db.NufusBilgi.ToList()
            };
            return View(model);
        }
        [Authorize]

        public ActionResult Tarih()
        {
            return View();
        }
        [Authorize]

        public ActionResult Iletisim()
        {
            return View();
        }

        public ActionResult ChangeLanguage(string lang)
        {
            if (lang != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(lang);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
            }
            else
            {
                lang = "tr";  // Default language
            }

            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = lang;
            Response.Cookies.Add(cookie);

            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}
