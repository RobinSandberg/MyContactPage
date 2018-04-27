using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyContactPage.Models
{
    public class GuessingGame
    {
        static int idCount = 0;
        public static List<GuessingGame> Guesses = new List<GuessingGame>();
        public int GuessNum { get; set; }

        public int GuessCount { get; set; }
        //static Random rng = new Random();
        //public int RandomNum = rng.Next(1,5);
        public string msg;
        

        public static int RandomNumber()
        {
            int Number = 0;
            Random rng = new Random();
            Number = Convert.ToInt32(rng.Next(1, 5));

            return Number;

        }
        public int num = GuessingGame.RandomNumber();
        public static void NumberCheck(GuessingGame number)
        {
            
            if (number.GuessNum == number.num)
            {
                number.msg = "You guessed Correct ";
            }
            else if(number.GuessNum < number.num)
            {
                number.msg = "You guessed to low ";
            }
            else if (number.GuessNum > number.num)
            {
                number.msg = "You guessed to high ";
            }

        }

        public GuessingGame()
        {
            GuessCount = idCount++;

        }

    }
}