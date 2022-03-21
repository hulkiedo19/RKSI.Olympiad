using RKSI.Olympiad.Client.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace RKSI.Olympiad.Client.ViewModels
{
    public class AdminWindowViewModel : ViewModel
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private string _gender;
        private string _dateOfBirth; // to datetime
        private string _series;
        private string _number;
        private string _issuedBy;
        private string _address;
        private string _documentType;
        private string _issuedCountry;
        private string _bonusCard;

        public ICommand RegistrationCommand => new RegistrationCommand(this);

        public string FirstName
        {
            get => _firstName;
            set => Set(ref _firstName, value, nameof(FirstName));
        }

        public string LastName
        {
            get => _lastName;
            set => Set(ref _lastName, value, nameof(LastName));
        }

        public string MiddleName
        {
            get => _middleName;
            set => Set(ref _middleName, value, nameof(MiddleName));
        }

        public string Gender
        {
            get => _gender;
            set => Set(ref _gender, value, nameof(Gender));
        }

        public string DateOfBirth
        {
            get => _dateOfBirth;
            set => Set(ref _dateOfBirth, value, nameof(DateOfBirth));
        }

        public string Series
        {
            get => _series;
            set => Set(ref _series, value, nameof(Series));
        }

        public string Number
        {
            get => _number;
            set => Set(ref _number, value, nameof(Number));
        }

        public string IssuedBy
        {
            get => _issuedBy;
            set => Set(ref _issuedBy, value, nameof(IssuedBy));
        }

        public string Address
        {
            get => _address;
            set => Set(ref _address, value, nameof(Address));
        }

        public string DocumentType
        {
            get => _documentType;
            set => Set(ref _documentType, value, nameof(DocumentType));
        }

        public string IssuedCountry
        {
            get => _issuedCountry;
            set => Set(ref _issuedCountry, value, nameof(IssuedCountry));
        }

        public string BonusCard
        {
            get => _bonusCard;
            set => Set(ref _bonusCard, value, nameof(BonusCard));
        }
    }
}
