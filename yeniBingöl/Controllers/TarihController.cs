using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TarihController : Controller
    {
        // Solhan Yüzen Adalar 
        public ActionResult SolhanYuzenAdalar()
        {
            return View();
        }

        // Kalkanlı Mağaraları  
        public ActionResult KalkanliMagralari()
        {
            return View();
        }

        // Çır Şelalesi  
        public ActionResult CirSelalesi()
        {
            return View();
        }

        // Zağ Mağaraları  
        public ActionResult ZagMagralari()
        {
            return View();
        }
    }
}