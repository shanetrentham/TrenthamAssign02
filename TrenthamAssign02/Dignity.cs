﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrenthamAssign02
{
    class Dignity
    {
        ArrayList dignity = new ArrayList();

        public void AddDragon(Dragon dragon)
        {
            dignity.Add(dragon);
        }

        public int Count()
        {
            return dignity.Count;
        }

        public override string ToString()
        {
            foreach(string dragon in dignity)
            {
               return dragon;
            }
            return "";
        }
    }
}
