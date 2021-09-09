using ErickEspinosa.AbstractFactory.Commons;
using ErickEspinosa.AbstractFactory.Commons.Products;
using ErickEspinosa.AbstractFactory.Modern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Modern
{
    public class ModernFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new ModernCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
