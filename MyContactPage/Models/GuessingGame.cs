using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyContactPage.Models
{
    public class GuessingGame
    {
        public static int RandomNumber()
        {
            int Number = 0;
            Random rng = new Random();
            Number = Convert.ToInt32(rng.Next(1, 101));

            return Number;

        }
    }
}