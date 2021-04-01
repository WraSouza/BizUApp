using System;
using System.Collections.Generic;
using System.Text;

namespace BizUApp.Models
{
    public class Bolsas
    {
        public class USD
        {
            public string name { get; set; }
            public double buy { get; set; }
            public double sell { get; set; }
            public double variation { get; set; }
        }

        public class EUR
        {
            public string name { get; set; }
            public double buy { get; set; }
            public double sell { get; set; }
            public double variation { get; set; }
        }

        public class GBP
        {
            public string name { get; set; }
            public double buy { get; set; }
            public object sell { get; set; }
            public double variation { get; set; }
        }

        public class ARS
        {
            public string name { get; set; }
            public double buy { get; set; }
            public object sell { get; set; }
            public double variation { get; set; }
        }

        public class CAD
        {
            public string name { get; set; }
            public double buy { get; set; }
            public object sell { get; set; }
            public double variation { get; set; }
        }

        public class AUD
        {
            public string name { get; set; }
            public double buy { get; set; }
            public object sell { get; set; }
            public double variation { get; set; }
        }

        public class JPY
        {
            public string name { get; set; }
            public double buy { get; set; }
            public object sell { get; set; }
            public double variation { get; set; }
        }

        public class CNY
        {
            public string name { get; set; }
            public double buy { get; set; }
            public object sell { get; set; }
            public double variation { get; set; }
        }

        public class BTC
        {
            public string name { get; set; }
            public double buy { get; set; }
            public double sell { get; set; }
            public double variation { get; set; }
        }

        public class Currencies
        {
            public string source { get; set; }
            public USD USD { get; set; }
            public EUR EUR { get; set; }
            public GBP GBP { get; set; }
            public ARS ARS { get; set; }
            public CAD CAD { get; set; }
            public AUD AUD { get; set; }
            public JPY JPY { get; set; }
            public CNY CNY { get; set; }
            public BTC BTC { get; set; }
        }

        public class IBOVESPA
        {
            public string name { get; set; }
            public string location { get; set; }
            public double points { get; set; }
            public double variation { get; set; }
        }

        public class NASDAQ
        {
            public string name { get; set; }
            public string location { get; set; }
            public double points { get; set; }
            public double variation { get; set; }
        }

        public class CAC
        {
            public string name { get; set; }
            public string location { get; set; }
            public double variation { get; set; }
        }

        public class NIKKEI
        {
            public string name { get; set; }
            public string location { get; set; }
            public double variation { get; set; }
        }

        public class Stocks
        {
            public IBOVESPA IBOVESPA { get; set; }
            public NASDAQ NASDAQ { get; set; }
            public CAC CAC { get; set; }
            public NIKKEI NIKKEI { get; set; }
        }

        public class Results
        {
            public Currencies currencies { get; set; }
            public Stocks stocks { get; set; }
            public List<string> available_sources { get; set; }
            public List<object> taxes { get; set; }
        }

        public class Root
        {
            public string by { get; set; }
            public bool valid_key { get; set; }
            public Results results { get; set; }
            public double execution_time { get; set; }
            public bool from_cache { get; set; }
        }

    }
}
