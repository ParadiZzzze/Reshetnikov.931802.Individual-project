using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class TaxInspection
    {
        const double taxRate = 1.2;
        public double withTax;

        public double payTax(double price)
        {
            if (price > 5000)
            {
                withTax = price * 1.2;
                return withTax;
            }
            else return price;
        }
    }
}
