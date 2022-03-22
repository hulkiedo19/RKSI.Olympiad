using RKSI.Olympiad.Client.Commands;
using RKSI.Olympiad.Client.Models;
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

        private string _migrationCardNumber;
        private string _whereCountry;
        private string _stayWith;
        private string _stayBy;
        private string _tripPurpose;

        private object _dateEntrance;
        private object _dateEscape;

        private List<Models.Client> _clients;
        private List<HotelRoom> _hotelRooms;

        private object _selectedHotelRoom = null;
        private object _selectedClient = null;

        public ICommand RegistrationCommand => new RegistrationCommand(this);
        public ICommand MovingInClientCommand => new CreateTreatyCommand(this);

        public AdminWindowViewModel()
        {
            using (var DbContext = new DatabaseEntities())
            {
                var today = DateTime.Today;

                Clients = DbContext.Clients
                    //.Where(c => DbFunctions.TruncateTime(c.))
                    .ToList();

                HotelRooms = DbContext.HotelRooms
                    .Include(nameof(HotelRoom.Category))
                    .ToList();
            }
        }

        private string _resultSum;

        public string ResultSum 
        {
            get => _resultSum;
            set => Set(ref _resultSum, value, nameof(ResultSum));
        }

        public object SelectedHotelRoom
        {
            get => _selectedHotelRoom;
            set
            {
                Set(ref _selectedHotelRoom, value, nameof(SelectedHotelRoom));
            }
        }

        public object SelectedClient
        {
            get => _selectedClient;
            set
            {
                Set(ref _selectedClient, value, nameof(SelectedClient));
            }
        }

        public List<Models.Client> Clients
        {
            get => _clients;
            set
            {
                Set(ref _clients, value, nameof(Clients));
            }
        }

        public List<HotelRoom> HotelRooms
        {
            get => _hotelRooms;
            set
            {
                Set(ref _hotelRooms, value, nameof(HotelRooms));
            }
        }

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

        public string MigrationCardNumber
        {
            get => _migrationCardNumber;
            set => Set(ref _migrationCardNumber, value, nameof(MigrationCardNumber));
        }

        public string WhereCountry
        {
            get => _whereCountry;
            set => Set(ref _whereCountry, value, nameof(WhereCountry));
        }

        public string StayWith
        {
            get => _stayWith;
            set => Set(ref _stayWith, value, nameof(StayWith));
        }

        public string StayBy
        {
            get => _stayBy;
            set => Set(ref _stayBy, value, nameof(StayBy));
        }

        public string TripPurpose
        {
            get => _tripPurpose;
            set => Set(ref _tripPurpose, value, nameof(TripPurpose));
        }

        public object DateEntrance
        {
            get => _dateEntrance;
            set => Set(ref _dateEntrance, value, nameof(DateEntrance));
        }

        public object DateEscape
        {
            get => _dateEscape;
            set => Set(ref _dateEscape, value, nameof(DateEscape));
        }
    }
}
