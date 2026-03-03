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
    public class SaveCommand : ICommand
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
            Contact contact = new Contact(_vm.Name, _vm.Email, _vm.Phone);
            _serializer.SaveJson(contact);
        }

        public SaveCommand(MainVM mainVM)
        {
            _vm = mainVM;
            _serializer = new ContactSerializer();
        }
    }
}
