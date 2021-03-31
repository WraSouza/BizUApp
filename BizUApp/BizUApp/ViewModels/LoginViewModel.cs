using BizUApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BizUApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _Nome;
        private string _Senha;
        private bool _Result;
        private bool _IsBusy;

        public Command LoginCommand { get; set; }
        public Command RegisterCommand { get; set; }

        public string Nome
        {
            get
            {
                return this._Nome;
            }
            set
            {
                this._Nome = value;
                OnPropertyChanged();
            }
        }

        public string Senha
        {
            get
            {
                return this._Senha;
            }
            set
            {
                this._Senha = value;
                OnPropertyChanged();
            }
        }

        //Método para verificar se o login foi realizado com sucesso
        public bool Result
        {
            get
            {
                return this._IsBusy;
            }
            set
            {
                this._IsBusy = value;
                OnPropertyChanged();
            }
        }

        //Método para verificar se o login está sendo realizado para evitar concorrência
        public bool IsBusy
        {
            get
            {
                return this._Result;
            }
            set
            {
                this._Result = value;
                OnPropertyChanged();
            }
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await LoginCommandAsync()); //Nome do comando, qualquer um nome de preferência
            RegisterCommand = new Command(async () => await RegisterCommandAsync());
        }

        private async Task RegisterCommandAsync()
        {
            if (IsBusy)
                return;

            try
            {
                IsBusy = true;
                var userService = new UserServices();
                Result = await userService.RegisterUser(Nome, Senha);

                if (Result)
                {
                    await Application.Current.MainPage.DisplayAlert("Sucesso", "Usuário Registrado", "OK");
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Erro", "Usuário Já Cadastrado", "OK");
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

        //Login
        private async Task LoginCommandAsync()
        {
            if (IsBusy)
                return;

            try
            {

                IsBusy = true;
                var userService = new UserServices();
                Result = await userService.LoginUser(Nome, Senha);

                if (Result)
                {
                    Preferences.Set("Nome", Nome);
                   
                    await Application.Current.MainPage.Navigation.PushAsync(new Views.BizuInicialView());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Erro", "Usuário/Senha Inválidos", "OK");
                }

            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Erro", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}
