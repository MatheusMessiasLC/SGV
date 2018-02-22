using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeVacinas.Models
{
    public class Classificacao
    {
        public int ClassidicacaoId { get; set; }
        public  List<Vacina> Vacinas { get; set; }
    }
}