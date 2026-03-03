using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class LoadCommand : ICommand
    {
        private readonly MainVM _vm;
        private readonly ContactSerializer _serializer;


        public bool CanExecute(object parameter)
        { return true; }


        public event EventHandler CanExecuteChanged;

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Execute(object parameter)
        {
            Contact contact = _serializer.LoadJson();
            _vm.Name = contact.Name;
            _vm.Email = contact.Email;
            _vm.Phone = contact.Phone;
        }

        public LoadCommand(MainVM mainVM)
        {
            _vm = mainVM;
            _serializer = new ContactSerializer();
        }
    }
}
