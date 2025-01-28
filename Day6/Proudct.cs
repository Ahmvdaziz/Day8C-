using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    internal class Proudct
    {
        public int id;
        public string name;
        public double price;
        public string category;

        public override bool Equals(object obj)
        {
            Proudct p = (Proudct)obj;
          //  return this.id == p.id && this.name == p.name && this.price == p.price && this.category == p.category;
            if (obj is Proudct) { 
            
            return this.id == p.id && this.name == p.name && this.price == p.price && this.category == p.category;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "Id: " + id + " Name: " + name + " Price: " + price + " Category: " + category;
        }
        public Type GetType()
        {
            return typeof(Proudct);
        }
        public Proudct Clone()
        {
            return (Proudct)this.MemberwiseClone();
        }
        public override int GetHashCode()
        {
            return this.id;
        }
    }
}
