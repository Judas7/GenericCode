using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCode
{
    class ListOfObjects<T>
    {
        private T[] theList;  //Listan T skapas i variabeln theList
        private int noOfElements = 10; //Värdet 10 läggs i variabeln "noOfElement"
        private int nextIndex; //Variabeln "nextIndex" skapas och ska innehålla heltal. 

        //En ny lista skapas i theList och värdet från "noOfElement" blir max antal index i listan.
        public ListOfObjects()
        {
            theList = new T[noOfElements];
            nextIndex = 0;
        }


        /// <summary>
        /// AddObject får in ett värde som programmet vill lägga i listan. Om indexet är okej så kommer detta ske.
        /// </summary>
        /// <param name="obj"> Värdet från programmet när funktionen kallas på hamnar i obj som senare läggs i listan</param>
        public void AbbObject(T obj)
        {
            //Om nästa index är större eller lika med längden av listan så skrivs "Array length exceeded" ut. Detta sker alltså när listan är full med objekt.
            if (nextIndex >= theList.Length)
            {
                Console.WriteLine("Array length exceeded");
                return;
            }
            theList[nextIndex] = obj;
            nextIndex++;              
        }

        /// <summary>
        ///  GetObject får ett index från programmet. Om indexet inte är för högt så kommer den returnera listans värde på indexet. 
        /// </summary>
        /// <param name="index">Den tar hand om siffran som kommer när GetObject blir kallad. Den används för att ta ut värdet ur listan från det indexet</param>
        /// <returns> Metoden kommer att returnera det objekt som ligger på det specifika indexet i listan.</returns>
        public T GetObject(int index)
        {
            //Om indexet är större än listans längd, alltså 9, skrivs det ut att indexet är för högt och null kommer returneras.
            if (index >= theList.Length)
            {
                Console.WriteLine("Array index to high");
                return default(T);
            }
            return theList[index];
        }
    }
}
