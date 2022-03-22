using RKSI.Olympiad.Client.ViewModels;
using RKSI.Olympiad.Client.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RKSI.Olympiad.Client.Commands
{
    public class LoginCommand : Command
    {
        private const string AdminLogin = "admin";
        private const string AdminPassword = "admin";
        private const string UserLogin = "user";
        private const string UserPassword = "user";

        private readonly LoginWindowViewModel _viewModel;

        public LoginCommand(LoginWindowViewModel viewModel) 
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            if(_viewModel.Login == AdminLogin && _viewModel.Password == AdminPassword)
            {
                var command = new OpenWindowCommand(new AdminWindow(), Application.Current.MainWindow);
                command.Execute(parameter);
            }
            else if (_viewModel.Login == UserLogin && _viewModel.Password == UserPassword)
            {
                var command = new OpenWindowCommand(new UserWindow(), Application.Current.MainWindow);
                command.Execute(parameter);
            } else
            {
                var command = new OpenErrorWindowCommand(new ErrorWindow());
                command.Execute(parameter);
            }
        }
    }
}
