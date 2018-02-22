using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeVacinas.Models
{
    public class Ficha
    {
        public int FichaId { get; set; }
        public int Vacina { get; set; }
        public int Data { get; set; }
        public Cliente Cliente { get; set; }

    }
}