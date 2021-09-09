using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Victorian.Products
{
    public class VictorianChair : IChair
    {
        public string Name => "Cadeira Victoriana Classica Dourada";
        public string Description => "Cadeira Victoriana Classica Dourada c Tecido Nobre Capitone Luxo";
        public decimal Price => 2600m;
    }
}
