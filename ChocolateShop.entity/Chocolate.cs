﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateShop.entity
{
    public class Chocolate
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Protein { get; set; }

        public Chocolate(Chocolate chocolate)
        {
            Name = chocolate.Name;
            Price = chocolate.Price;
            Protein = chocolate.Protein;
        }
        public Chocolate()
        {

        }
    }
}