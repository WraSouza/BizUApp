using System;
using System.Collections.Generic;
using System.Text;

namespace BizUApp.Models
{
    public class Movimentacao
    {
        public string DataHora { get; set; }
        public string Assessor { get; set; }
        public string Conta { get; set; }
        public string Cliente { get; set; }
        public string Ativo { get; set; }
        public string Tipo { get; set; }
        public string Qtd { get; set; }
        public string QtdeAparente { get; set; }
        public string QtdeExec { get; set; }
        public double PrecoDisparo { get; set; }
        public double PrecoLimite { get; set; }
        public double PrecoExecutado { get; set; }
        public string Situacao { get; set; }
        public string Plataforma { get; set; }
        public string Ferramenta { get; set; }
        public string Mensagem { get; set; }
        public string IdBolsa { get; set; }
        public string IdCorretora { get; set; }
        public string Rotulo { get; set; }

    }
}
