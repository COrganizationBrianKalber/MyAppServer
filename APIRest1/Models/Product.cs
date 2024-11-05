using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace APIRest1.Models
{
    public class Product
    {
        //Las propiedades siempre empiezan con mayusculas
        public int IdProduct { get; set; }
        //Lo que quiere decir get y set de que lo puedo tener y modificar.
        public string Name { get; set; }

        public string Description { get; set; }

        public int Valor { get; set; }
    }
}