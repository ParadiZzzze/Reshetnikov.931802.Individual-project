using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Delivery
    {
        const int i = 5;
        string[] countries = new string[i] { "Russia", "Germany", "USA", "UK", "France" };

        public bool canBeDelivered(string clientcountry)
        {
            int n = i-1;
            while (n >= 0)
            {
                if (clientcountry == countries[n])
                {
                    return true;
                }
                n--;
            }
            return false;
        }
    }
}
