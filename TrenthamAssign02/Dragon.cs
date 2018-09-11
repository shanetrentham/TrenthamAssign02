using System;

namespace TrenthamAssign02
    {
        class Dragon
        {
            public string Name;
            public string Type;
            public decimal Size;
            //Is the dragon good or evil?
            public Boolean Good;

            public Dragon(string name, string type, decimal size, Boolean good)
            {
                Name = name;
                Type = type;
                Size = size;
                Good = good;
            }

            public string GetName()
            {
                return Name;
            }

            public string getType()
            {
                return Type;
            }

            public decimal GetSize()
            {
                return Size;
            }
            //Return True if Dragon is good and False if the Dragon is Evil
            public Boolean GetGood()
            {
                return Good;
            }

            public void SetName(string name)
            {
                Name = name;
            }

            public void SetType(string type)
            {
                Type = type;
            }

            public void SetSize(decimal size)
            {
                Size = size;
            }

            public void SetGood(Boolean good)
            {
                Good = good;
            }

            public void ToString()
            {
                Console.Write(Name + " - " + Type + " - " + Size + " - ");
                if (Good == true)
                {
                    Console.Write("Good");
                }
                else
                    Console.Write("Evil");
            }

        }
    }
