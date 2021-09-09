using ErickEspinosa.AbstractFactory.Commons;
using ErickEspinosa.AbstractFactory.Commons.Products;
using ErickEspinosa.AbstractFactory.Victorian.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Victorian
{
    public class VictorianFactory : IAbstractFactory
    {
        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ICoffeTable CreateCoffeTable()
        {
            return new VictorianCoffeTable();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
