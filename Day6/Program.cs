using System.Security.Cryptography;

namespace Day6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Human h1 = new Human();
            Human h2 = new Human();
            h1.id = 1;
            h1.name = "ZOZ";
            h2.id = 1;
            h2.name = "zOz";
            // Equlas fun
            if (h1.Equals(h2)) { 
            Console.WriteLine("Both objects are equal");
            }
            else
            {
                Console.WriteLine("Both objects are not equal");    
            }
            // to string fun
            string msg = h1.ToString();
            string result = h2.ToString();
            Console.WriteLine(msg); // until this return namespace.classname
            // if we want to print the value of object we need to override the ToString() method
            Console.WriteLine(result);
            Console.WriteLine(h1); // this will call the ToString() method 
            //of the object
            // تحفههه
            Console.WriteLine(h2);


            // memberwise clone
            Human h3 = h1.Clone();
            h1.name= "Ali";
            Console.WriteLine(h3.name);
            Console.WriteLine(h3.Equals(h2));*/
           Proudct p1 = new Proudct();
           Proudct p2 = new Proudct();
            p1.id = 1;
            p1.name = "Laptop";
            p1.price = 1000;
            p1.category = "Electronics";
            p2.id = 1;
            p2.name= "computer";
            p2.price = 1000;
            p2.category = "Electronics";
            if (p1.Equals(p2))
            {
                Console.WriteLine("Both objects are equal");
            }
            else
            {
                Console.WriteLine("Both objects are not equal");
            }
            string msg = p1.ToString();
            string result = p2.ToString();
            Console.WriteLine(msg);
            Console.WriteLine(result);
            Proudct proudct = p1.Clone();
            Console.WriteLine(proudct.name);
            Console.WriteLine(proudct.Equals(p2));
            Console.WriteLine( proudct.GetType());
            Console.WriteLine(proudct.GetHashCode());

        }
    }
}
