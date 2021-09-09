using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Victorian.Products
{
    public class VictorianCoffeTable : ICoffeTable
    {
        public string Name => "Mesa De Madeira Vintage";
        public string Description => @"Nós do rei da madeira somos qualidade garantida, referência no mercado de decoração a mais de 5 anos. 
Compre sua mesinha porta bebidas com a tranquilidade de estar adquirindo o melhor produto do mercado!";
        public decimal Price => 360m;
        public string Color => "Marrom";
    }
}
