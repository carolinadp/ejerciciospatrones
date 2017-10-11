using Common;
using SeahawksWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SeahawksWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AllPlayers()
        {
            PlayerListModel model = new PlayerListModel();
            model.PlayerCount = 3;

            Player a = new Player();

            a.Name = "Juan";
            a.LastName = "Lopez";
            a.Number = 23;
            a.College = "Stanford";
            a.Age = 22;
            a.Position = 1;

            Player b = new Player();

            b.Name = "Jose";
            b.LastName = "Perez";
            b.Number = 13;
            b.College = "Stanford";
            b.Age = 21;
            b.Position = 2;

            Player[] players = new Player[2];
            players[0] = a;
            players[1] = b;

            return View(players);
        }
    }
}