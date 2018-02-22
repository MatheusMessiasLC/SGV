using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeVacinas.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public List<Ficha> Fichas { get; set; }

    }
}