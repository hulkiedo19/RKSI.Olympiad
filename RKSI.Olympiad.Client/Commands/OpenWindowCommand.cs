using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RKSI.Olympiad.Client.Commands
{
    public class OpenWindowCommand : Command
    {
        private Window _newWindow;
        private Window _oldWindow;

        public OpenWindowCommand(Window newWindow, Window oldWindow)
        {
            _newWindow = newWindow;
            _oldWindow = oldWindow;
        }

        public override void Execute(object parameter)
        {
            _newWindow.Show();
            _oldWindow.Close();
        }
    }
}
