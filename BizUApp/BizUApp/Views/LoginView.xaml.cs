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
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void abrePaginaYoutube(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.BizuYoutubeView());
        }

        private async void abrePaginaWeb(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.BizuWebView());
        }

        private async void abreCadastraUserPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Views.CadastroUserView());
        }
    }
}