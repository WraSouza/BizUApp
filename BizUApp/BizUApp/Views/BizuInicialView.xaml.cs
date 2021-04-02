using BizUApp.Models;
using SkiaSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static BizUApp.Models.Bolsas;

[assembly: ExportFont("MontserratRegular.ttf", Alias = "Montserrat")]
namespace BizUApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BizuInicialView : ContentPage
    {
        public BizuInicialView()
        {
            InitializeComponent();

        }


        protected override void OnAppearing()
        {

            Root dadosObtidos = BuscaValores.buscaBolsas();

            DateTime data = DateTime.Now;

            var hora = data.Hour.ToString();

            txtNomeBolsa.Text = dadosObtidos.results.stocks.IBOVESPA.name;

            txtPontosBolsa.Text = dadosObtidos.results.stocks.IBOVESPA.points.ToString();

            float pontosIbovespa = (float)dadosObtidos.results.stocks.IBOVESPA.points;

            List<Microcharts.ChartEntry> entries = new List<Microcharts.ChartEntry>
            {
                new Microcharts.ChartEntry(pontosIbovespa)
                {
                    Label = data.ToString(),
                    ValueLabel = pontosIbovespa.ToString(),
                    Color = SKColor.Parse("#266489")
                },

                new Microcharts.ChartEntry(pontosIbovespa - 8000)
                {
                    Label = data.ToString(),
                    ValueLabel = pontosIbovespa.ToString(),
                    Color = SKColor.Parse("#266489")
                }
            };

            grafico1.Chart = new Microcharts.LineChart() { Entries = entries };


        }


    }
}