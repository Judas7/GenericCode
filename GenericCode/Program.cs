using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    class Program
    {
        static void Main(string[] args)
        {
            ListOfObjects<object> myListOfObjects = new ListOfObjects<object>();
            myListOfObjects.AbbObject(42);
            myListOfObjects.AbbObject("Mr. Fantastic");
            myListOfObjects.AbbObject(true);
            myListOfObjects.AbbObject(47.11);
            myListOfObjects.AbbObject("test5");
            myListOfObjects.AbbObject("test6");
            myListOfObjects.AbbObject("test7");
            myListOfObjects.AbbObject("test8");
            myListOfObjects.AbbObject("test9");
            myListOfObjects.AbbObject("test10");
            myListOfObjects.AbbObject("test11");
            Console.WriteLine(myListOfObjects.GetObject(3));
            Console.WriteLine(myListOfObjects.GetObject(10)); //Skrivs inte ut eftersom indexet är 10
            Console.WriteLine(myListOfObjects.GetObject(5));
            Console.WriteLine(myListOfObjects.GetObject(11)); //Skrivs inte ut eftersom incdexet är över 10
            Console.ReadKey();

        }
    }
}
