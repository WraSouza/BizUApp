using BizUApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

            Root dadosObtidos = BuscaValores.buscaBolsas();

            txtNomeBolsa.Text = dadosObtidos.results.stocks.IBOVESPA.name;

            txtPontosBolsa.Text = dadosObtidos.results.stocks.IBOVESPA.points.ToString();
        }
    }
}