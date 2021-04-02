using BizUApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static BizUApp.Models.Bolsas;

namespace BizUApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CotacaoMoedaView : ContentPage
    {
        public CotacaoMoedaView()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            Root dadosObtidos = BuscaValores.buscaBolsas();

            txtDolar.Text = dadosObtidos.results.currencies.USD.name;
            txtCompra.Text = dadosObtidos.results.currencies.USD.buy.ToString("F2");
            txtVenda.Text = dadosObtidos.results.currencies.USD.sell.ToString("F2");
            txtVariacao.Text = dadosObtidos.results.currencies.USD.variation.ToString("F2");

            //Euro
            txtEuro.Text = dadosObtidos.results.currencies.EUR.name;
            txtCompraEuro.Text = dadosObtidos.results.currencies.EUR.buy.ToString("F2");
            txtVendaEuro.Text = dadosObtidos.results.currencies.EUR.sell.ToString("F2");
            txtVariacaoEuro.Text = dadosObtidos.results.currencies.EUR.variation.ToString("F2");
           
        }
    }
}