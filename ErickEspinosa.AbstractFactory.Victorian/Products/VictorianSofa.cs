using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Victorian.Products
{
    public class VictorianSofa : ISofa
    {
        public string Name => "Poltrona Victoriana Classico Finos Entalhes Tecido Nobre Lux";
        public string Description => "GM46 Poltrona Victoriana Classico Finos Entalhes Tecido Nobre";
        public decimal Price => 6900m;
        public int SeaterQuantiy => 2;
    }
}
