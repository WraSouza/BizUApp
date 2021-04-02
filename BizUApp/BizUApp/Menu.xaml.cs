using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BizUApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : FlyoutPage
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void abreInicialView(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage(new Views.BizuInicialView());
        }

        private void abreCotacaoView(object sender, EventArgs e)
        {
            IsPresented = false;
            Detail = new NavigationPage( new Views.CotacaoMoedaView());            
        }
    }
}