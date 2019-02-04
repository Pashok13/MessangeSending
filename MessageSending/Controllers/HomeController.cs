using MessengeSending.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MessageSending.Controllers
{
	public class HomeController : Controller
	{
		MessengerContext DataBase = new MessengerContext();

		//public ActionResult Index()
		//{
		//	return View();
		//}

		public ActionResult Registration()
		{
			return View();
		}

		[HttpPost]
		public string Registration(User newUser)
		{
			DataBase.Users.Add(newUser);
			DataBase.SaveChanges();
			return "Account are added!";
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
	}
}