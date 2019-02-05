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
		User CurrentUser;

		public ActionResult Avtorization()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Avtorization(User user)
		{
			CurrentUser = DataBase.Users.FirstOrDefault(u => u.Login == user.Login);

			if (CurrentUser.Password == user.Password)
				return View("Main");
			else
				return View("Error");
		}

		public ActionResult Registration()
		{
			return View();
		}

		[HttpPost]
		public ActionResult Registration(User newUser)
		{
			DataBase.Users.Add(newUser);
			DataBase.SaveChanges();
			return View("Main");
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