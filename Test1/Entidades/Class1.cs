using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Entidades
{
    public class Entidad
    {
        public string id { get; set; }
        public DateTime? createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
        public String name { get; set; }
        public String lastName { get; set; }
        public decimal? age { get; set; }
        public bool? active { get; set; }
    }

    public class Filtros
    {
       public String q { get; set; }

    /*    page opcional Number
Page number.

Valor por defecto: 1

Tamaño de rango: 1..30

limit opcional  Number
Amount of returned items.

Valor por defecto: 30

Tamaño de rango: 1..100

sort opcional   String[]
Order of returned items.

Valor por defecto: -createdAt

fields*/
    }

}
