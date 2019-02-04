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

		public ActionResult Index()
		{
			// получаем из бд все объекты Book
			IEnumerable<User> users = DataBase.Users;
			// передаем все объекты в динамическое свойство Books в ViewBag
			ViewBag.Users = users;
			// возвращаем представление
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
	}
}