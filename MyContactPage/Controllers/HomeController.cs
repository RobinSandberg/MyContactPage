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
        public ActionResult FeverCheck(float temperature = 0)
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
            return View();
        }

        [HttpPost]
        public ActionResult GuessGame(int GuessNum = 0)
        {
            List<int> Guesses = new List<int>();
            string msg = "";
           
            if (Session["Guesses"] != null)
            {
                Guesses = (List<int>)Session["Guesses"];
            }
            Session["Guesses"] = Guesses;
            Guesses.Add(GuessNum);
            
            if (Session["Random"] != null)
            {
                if (GuessNum <= 0 || GuessNum >= 101)
                {
                    msg = "You not guessing within the limit range!";
                    Guesses.Remove(Guesses.Last());
                }
                else if (GuessNum == Convert.ToInt32(Session["Random"]))
                {
                    msg = "You guessed Correct with " + Guesses.Count + " guesses. New number drawn." ;
                    Session["Random"] = GuessingGame.RandomNumber();
                    Guesses.Clear();
                }
                else if (GuessNum < Convert.ToInt32(Session["Random"]))
                {
                    msg = "You guessed to low. You guessed " + Guesses.Count + " times so far.";
                }
                else if (GuessNum > Convert.ToInt32(Session["Random"]))
                {
                    msg = "You guessed to high. You guessed " + Guesses.Count + " times so far.";
                }
                
            } 
            Session["msg"] = msg; 
            return View();
        }
    }
}