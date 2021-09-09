using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Commons.Products
{
    public interface ICoffeTable
    {
        public string Name { get; }
        public string Description { get; }
        public decimal Price { get; }
        public string Color { get; }
    }
}
