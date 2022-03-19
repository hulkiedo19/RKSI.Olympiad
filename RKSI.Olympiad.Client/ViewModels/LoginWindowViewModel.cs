using RKSI.Olympiad.Client.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RKSI.Olympiad.Client.ViewModels
{
    public class LoginWindowViewModel : ViewModel
    {
        private string _password;
        private string _login;

        public ICommand LoginCommand => new LoginCommand(this);

        public string Password
        {
            get { return _password; }
            set { Set(ref _password, value, nameof(Password)); }
        }

        public string Login
        {
            get { return _login; }
            set { Set(ref _login, value, nameof(Login)); }
        }
    }
}
