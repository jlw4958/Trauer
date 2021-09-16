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
    class bluefire_bug : bigfire_bug
    {
        //skill level (constant int)
        const int SKILL_LEVEL = 4;

        //constructor
        public bluefire_bug() : base(SKILL_LEVEL)
        {

        }

        //overridden attack method
        public override void Attack()
        {
            Console.WriteLine("Blue Fire Bug breathes orange fire!");
            bool success = IsAttackSuccessful(SKILL_LEVEL);

            if (success == true)
            {
                Console.WriteLine("Attack was a success!");
            }
            else if (success == false)
            {
                Console.WriteLine("Attack was unsuccessful!");
            }
        }
    }
}
