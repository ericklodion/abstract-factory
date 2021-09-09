using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Commons
{
    public interface IAbstractFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
        ICoffeTable CreateCoffeTable();
    }
}
