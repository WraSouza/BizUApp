using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static BizUApp.Models.Bolsas;

namespace BizUApp.Models
{
    public class BuscaValores
    {
        public static Root buscaBolsas()
        {
            //private static string cotacaoBolsas = "https://api.hgbrasil.com/finance";

            string valores = string.Format("https://api.hgbrasil.com/finance");

           WebClient wc = new WebClient();

            string dadosObtidos = wc.DownloadString(valores);

            Root valoresObtidos = JsonConvert.DeserializeObject<Root>(dadosObtidos);

            return valoresObtidos;

        }
    }
}
