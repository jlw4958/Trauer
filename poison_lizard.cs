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
    class poison_lizard: IEdible
    {
        private bool isConsumed = false;

        private int numChunks = 3;

        public void Bite(bool consume)
        {
            if (isConsumed == false)
            {
                numChunks -= 1;
                Console.WriteLine("You continue to eat the small animal.");
            }
            else if (isConsumed == true)
            {
                Console.WriteLine("You finally finished eating the animal.");
            }
        }

        public bool IsConsumed()
        {
            if (numChunks > 0)
            {
                isConsumed = false;
            }
            else if(numChunks == 0)
            {
                isConsumed = true;
            }
            return isConsumed;
        }
    }
}
