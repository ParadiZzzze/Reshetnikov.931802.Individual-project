using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class Stuff
    {
        public double price;
        public string type;
        public string size;

        public  Stuff()
        {
            Random rnd = new Random();
            price = rnd.Next(0, 10000); //рандомно задаем цену
            string[] type_list = new string[] { "jeans", "shirt", "trousers", "jacket", "coat", "scarf" };
            string[] size_list = new string[] { "S", "M", "L" };
            int type_rand = rnd.Next(0, 6); //рандомно выбираем тип имеющейся вещи
            int size_rand = rnd.Next(0, 3); //рандомно выбираем размер имеющейся вещи
            type = type_list[type_rand];
            size = size_list[size_rand];
        }

    }
}
