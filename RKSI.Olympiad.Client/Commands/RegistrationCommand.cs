using RKSI.Olympiad.Client.Models;
using RKSI.Olympiad.Client.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RKSI.Olympiad.Client.Commands
{
    public class RegistrationCommand : Command
    {
        private readonly AdminWindowViewModel _viewModel;

        public RegistrationCommand(AdminWindowViewModel viewModel)
        {
            _viewModel = viewModel;
        }

        public override void Execute(object parameter)
        {
            using(var dbContext = new DatabaseEntities())
            {
                Models.Client client = new Models.Client()
                {
                    FirstName = _viewModel.FirstName,
                    LastName = _viewModel.LastName,
                    MiddleName = _viewModel.MiddleName,
                    Gender = _viewModel.Gender,
                    DateOfBirth = Convert.ToDateTime(_viewModel.DateOfBirth),
                    BonusCard = _viewModel.BonusCard,
                };

                Passport passport = new Passport()
                {
                    Client = client,
                    Series = _viewModel.Series,
                    Number = _viewModel.Number,
                    DocumentType = _viewModel.DocumentType,
                    Issued = _viewModel.IssuedBy,
                    IssuedAddress = _viewModel.Address,
                    CountryIssued = _viewModel.IssuedCountry
                };

                client.Passport = passport;

                dbContext.Clients.Add(client);
                dbContext.SaveChanges();
            }
            //base.Execute(parameter);
        }
    }
}
