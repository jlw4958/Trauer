using System;
using System.Collections.Generic;
using System.Text;
/*
 * Program Name: Trauer
 * Date: 11/14/2020
 * Creator: Jabrecia Washington
 * Updated By: Jabrecia Washington
 * Description: creation of a text based suspense/mystery game modeled after Zork :)
 */

namespace WashingtonJ_HW1
{
    class lazer_bird : IEdible
    {
        private bool isConsumed = false;

        public void Bite(bool consume)
        {
            if (isConsumed == true)
            {
                Console.WriteLine("You have eaten the strange creature. It made your stomach feel funny.");
            }
            else if (isConsumed == false)
            {
                Console.WriteLine("You are still eating the strange creature. It sure is taking a while.");
            }
        }

        public bool IsConsumed()
        {
            return isConsumed;
        }
    }
}
