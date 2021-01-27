﻿using System;
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
        /// Om nästa index är större eller lika med längden av listan så skrivs "Array length exceeded" ut.
        /// </summary>
        /// <param name="obj"></param>
        public void AbbObject(T obj)
        {
            if (nextIndex >= theList.Length)
            {
                Console.WriteLine("Array length exceeded");
                return;
            }
            theList[nextIndex] = obj;
            nextIndex++;              
        }

        /// <summary>
        /// Om indexet är större än listans längd, alltså 9, skrivs det ut att indexet är för högt och null kommer returneras. 
        /// </summary>
        /// <param name="index"></param>
        /// <returns> Metoden kommer att returna null. Detta sker när ett tomt objekt returneras. Om indexet inte är för högt så kommer den returnera listans värde på indexet. </returns>
        public T GetObject(int index)
        {
            if (index >= theList.Length)
            {
                Console.WriteLine("Array index to high");
                return default(T);
            }
            return theList[index];
        }
    }
}
