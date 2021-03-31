using BizUApp.Models;
using Firebase.Database;
using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizUApp.Services
{
    public class UserServices
    {
        FirebaseClient firebase;

        public UserServices()
        {
            firebase = new FirebaseClient("https://bizu-a4e81-default-rtdb.firebaseio.com/");
        }

        public async Task<bool> IsUSerExists(string name)
        {
            var user = (await firebase.Child("Usuarios")
                .OnceAsync<User>())
                .Where(u => u.Object.Nome == name)
                .FirstOrDefault();

            return (user != null);
        }

        public async Task<bool> RegisterUser(string name, string password)
        {
            if (await IsUSerExists(name) == false)
            {
                await firebase.Child("Usuarios")
                    .PostAsync(new User()
                    {
                        Nome = name,
                        Senha = password
                    });
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<bool> LoginUser(string name, string passwd)
        {
            var user = (await firebase.Child("Usuarios")
                .OnceAsync<User>())
                .Where(u => u.Object.Nome == name)
                .Where(u => u.Object.Senha == passwd)
                .FirstOrDefault();

            return (user != null);
        }
    }
}
