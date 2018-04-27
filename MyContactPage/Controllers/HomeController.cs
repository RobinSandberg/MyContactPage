using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyContactPage.Models;

namespace MyContactPage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        }
        [HttpGet]
        public ActionResult FeverCheck()
        {
            Fever check = new Fever();

            return View(check);
        }

        [HttpPost]
        public ActionResult FeverCheck(float temperature)
        {
            Fever check = new Fever();
            check.Temperature = temperature;
            Fever.FeverControl(check);
            return View(check);
        }

        [HttpGet]
        public ActionResult GuessGame()
        {
      
            Session["Random"] = GuessingGame.RandomNumber();
            return View(GuessingGame.Guesses);
        }

        [HttpPost]
        public ActionResult GuessGame(int GuessNum, GuessingGame temp)
        {
            
            temp.GuessNum = GuessNum;
            GuessingGame.NumberCheck(temp);
            GuessingGame.Guesses.Add(temp);
            return View(GuessingGame.Guesses);
        }
    }
}