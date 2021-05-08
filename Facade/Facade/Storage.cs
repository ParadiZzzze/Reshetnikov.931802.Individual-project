using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Storage
    {
                
        public double isAvailable(string clienttype, string clientsize)
        {
            int j = 5; //допускаем, что на складе имеется j вещей
            Stuff[] stuffs = new Stuff[j];
            for (int i = j-1; i >= 0; i--)
            {
                stuffs[i] = new Stuff();
            }
          
                foreach (var stuff in stuffs)
                {
                    if (clienttype == stuff.type && clientsize == stuff.size)
                    { 
                        return stuff.price; 
                    }
                }
                return -1;
        }
    }
}
