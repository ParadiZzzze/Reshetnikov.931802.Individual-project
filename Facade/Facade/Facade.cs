using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Facade
    {
        TaxInspection taxInspection = new TaxInspection();
        Storage storage = new Storage();
        Delivery delivery = new Delivery();

        public double orderStuff(string clienttype, string clientsize, string clientcountry)
        {
            taxInspection = new TaxInspection();
            storage = new Storage();
            delivery = new Delivery();
            double result = storage.isAvailable(clienttype, clientsize);
            bool isDelivered = delivery.canBeDelivered(clientcountry);
            if (!isDelivered) return 0;
            double withTax = taxInspection.payTax(result);
            return withTax;
        }
    }
}
