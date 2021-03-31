using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BizUApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BizuYoutubeView : ContentPage
    {
        public BizuYoutubeView()
        {
            InitializeComponent();

            navegador.Source = "https://www.youtube.com/channel/UCeqRrtUX9bfTuOGqnDonjdw";
        }

        private void carregandoPagina(object sender, WebNavigatingEventArgs e)
        {
            lblStatus.Text = "Carregando Página...";
        }

        private void paginaCarregada(object sender, WebNavigatedEventArgs e)
        {
            lblStatus.Text = "Pronto";
        }
    }
}