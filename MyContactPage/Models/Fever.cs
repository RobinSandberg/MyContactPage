using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MyContactPage.Models
{
    public class Fever
    {
        public float Temperature;
        const float fever = 37;
        const float hypothermia = 34;
        public string messege;

        public Fever()
        {
            Temperature = 36;
        }

        public static void FeverControl(Fever fever)
        {

            if (fever.Temperature >= Fever.fever)
            {
                fever.messege = "You got a fever";
            }
            else if (fever.Temperature <= Fever.hypothermia)
            {
                fever.messege = "You got hypothermia";
            }
            else
            {
                fever.messege = "You are in good health";
            }
        }

    }
}