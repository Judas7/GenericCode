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
        }
    }
}
