using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using View.Model;

namespace View.ViewModel
{
    public class MainVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Contact _contact;

        public string Name
        {
            get { return _contact.Name; }
            set
            {
                _contact.Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }

        public string Phone
        {
            get { return _contact.Phone; }
            set
            {
                _contact.Phone = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Phone"));
            }
        }

        public string Email
        {
            get { return _contact.Email; }
            set
            {
                _contact.Email = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
            }
        }

        public SaveCommand SaveAction { get; set; }
        public LoadCommand LoadAction { get; set; }

        public MainVM()
        {
            _contact = new Contact();
            SaveAction = new SaveCommand(this);
            LoadAction = new LoadCommand(this);
        }
    }
}