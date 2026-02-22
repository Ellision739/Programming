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
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public MainVM()
        {
            Contact contact = new Contact(Name, Email, Phone);
        }
    }
}
