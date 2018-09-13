using System;
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
            string alldragons = "";
            foreach(string dragon in dignity)
            {
               alldragons += dragon + "\n";
            }
            return alldragons;
        }

        public Dragon GetLargest()
        {
            Dragon largest = null;

            foreach(Dragon dragon in dignity)
            {
                if (dragon.GetSize() > largest.GetSize())
                {
                    largest = dragon;
                }
            }
            return largest;
        }
        
        public Dragon GetLargestofType(string type)
        {
            foreach(Dragon dragon in dignity)
            {
                if(dragon.getType() == type)
                {
                    GetLargest();
                }
                  
            }
        }
    }
}
