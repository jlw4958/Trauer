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
    public interface IEdible
    {
        void Bite(bool consume);
        bool IsConsumed();
    }
}
