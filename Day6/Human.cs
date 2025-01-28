using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Human
    {
        public int id;
        public string name;

        public override bool Equals(object obj)
        {
            /* Human h = (Human)obj;
             return this.id == h.id;
            */
            //if(obj is Human)
            //  {
            //      Human h = (Human)obj;
            //      return this.id == h.id;
            //  }
            //  else
            //  {
            //      return false;
            //  }

            Human? h = obj as Human;// return  null or no null dosnot return expetion // casting
            if (h != null)
            {
                return this.id == h.id && this.name == h.name;
            }
            else
            {
                return false;
            }
            

        }
        public override string ToString()
        {
            return "Id: " + id + " Name: " + name;
            return base.ToString();
        }

        public Human Clone()
        {
            return (Human)this.MemberwiseClone();
        }
    }
}
