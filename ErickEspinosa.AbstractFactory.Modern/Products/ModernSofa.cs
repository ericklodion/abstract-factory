using ErickEspinosa.AbstractFactory.Commons.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ErickEspinosa.AbstractFactory.Modern.Products
{
    public class ModernSofa : ISofa
    {
        public string Name => "Sofá Áustria";
        public string Description => @"Por que o Sofá de Canto Áustria ? 
Sofás de canto são a nova sensação do design de interiores! 
Muito elegante e ótimo para otimizar o espaço do ambiente, este tipo de sofá é perfeito para juntar amigos e familiares para assistir ao futebol ou maratonar a sua série favorita. 
Ele conta com um chaise que oferece muito mais conforto e aconchego. 
Suas almofadas do encosto e assentos possuem um acabamento maravilhoso, o que, em conjunto com o tom em Suede de todo o móvel, contribui para deixar a sala de estar mais sofisticada, elegante e acolhedora. Imperdível!";
        public decimal Price => 849m;
        public int SeaterQuantiy => 6;
    }
}
