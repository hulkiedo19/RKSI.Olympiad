using RKSI.Olympiad.Client.Models;
using RKSI.Olympiad.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace RKSI.Olympiad.Client.Commands
{
    public class CreateTreatyCommand : Command
    {
        private readonly AdminWindowViewModel _viewModel;
        public CreateTreatyCommand(AdminWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            CalculateResultSum();

            Treaty treaty = new Treaty()
            {
                TreatyDate = DateTime.Now,
                DateEntrance = Convert.ToDateTime(_viewModel.DateEntrance),
                DateEscape = Convert.ToDateTime(_viewModel.DateEscape),
                SumOfPay = Convert.ToInt32(_viewModel.ResultSum),
                PaymentMethod = "card",
                Client = (_viewModel.SelectedClient as Models.Client),
                HotelRoom = (_viewModel.SelectedHotelRoom as HotelRoom)
            };

            using (var DbContext = new DatabaseEntities())
            {
                DbContext.Treaties.Add(treaty);
                DbContext.SaveChanges();
            }
        }

        private void CalculateResultSum()
        {
            var entrance = Convert.ToDateTime(_viewModel.DateEntrance);
            var escape = Convert.ToDateTime(_viewModel.DateEscape);
            var dayCount = (escape - entrance).TotalDays;
            var hotelRoom = _viewModel.SelectedHotelRoom as HotelRoom;
            var client = _viewModel.SelectedClient as Models.Client;
            double discount;

            switch (client.BonusCard)
            {
                case "обычная": discount = 0.01; break;
                case "золотая": discount = 0.03; break;
                case "платиновая": discount = 0.05; break;
                default: discount = 0; break;
            }

            discount = 1 - discount;

            double sum = (hotelRoom.CostPerDay * dayCount) * discount;

            _viewModel.ResultSum = sum.ToString();
        }

        //public override bool CanExecute(object parameter)
        //{
        //    if (_viewModel.SelectedClient != null
        //        && _viewModel.SelectedHotelRoom != null)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //    return true;
        //}
    }
}
