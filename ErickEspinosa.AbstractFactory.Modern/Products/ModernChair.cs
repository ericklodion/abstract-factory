using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Modern.Products
{
    public class ModernChair : IChair
    {
        public string Name => "Cadeira Slim Estofada";
        public string Description => "Polipropileno Revestido em PU (Couro Sintético)";
        public decimal Price => 229m;
    }
}
