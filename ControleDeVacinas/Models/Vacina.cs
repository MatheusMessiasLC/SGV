using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ControleDeVacinas.Models
{
    public class Vacina
    {
        public int VacinasId { get; set; }
        public int Nome { get; set; }
        public int Descricao { get; set; }
        public int EfeitoColaterais { get; set; }
        public int ContraIndicacao { get; set; }
        public int Doses { get; set; }
        public int Idade { get; set; }
        public Classificacao Classsificacoes{ get; set; }

    }
}