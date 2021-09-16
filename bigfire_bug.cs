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
    abstract class bigfire_bug
    {
        //int for attack skill
        private int AttackSkill;

        //constructor for class
        public bigfire_bug(int attackskill)
        {
            this.AttackSkill = attackskill;
        }

        //abstract attack method (will be inherited later)
        public abstract void Attack();

        //method chechking if attack is successful
        protected static bool IsAttackSuccessful(int attackskill)
        {
            bool AttackSuccess = true;
            //getting the dieroll method from config
            int DieRoll = config.DiceRoll(1,7);

            if (attackskill >= DieRoll)
            {
                AttackSuccess = true;
            }
            else if (attackskill < DieRoll)
            {
                AttackSuccess = false;
            }

            return AttackSuccess;
        }
    }
}
