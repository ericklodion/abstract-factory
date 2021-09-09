using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Modern.Products
{
    public class ModernCoffeTable : ICoffeTable
    {
        public string Name => "Mesa De Centro";
        public string Description => @"A START HOME SHOP desenvolveu este móvel para agregar na decoração do seu ambiente, fazendo que seu espaço fique ainda mais moderno e elegante. 
Nossa mesinha de centro Classic tem uma base retangular, pés de madeira maciça (Eucalipto tratado) e um lindo design no estilo retrô. 
Este móvel vai aprimorar ainda mais o seu ambiente!";
        public decimal Price => 152m;
        public string Color => "Marrom";
    }
}
