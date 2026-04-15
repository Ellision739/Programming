using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using View.Model;
using View.Model.Services;

namespace View.ViewModel;

/// <summary>
/// Использует данные из Contact и выполняет функцию VM.
/// </summary>
public class MainVM : ObservableObject
{
    /// <summary>
    /// Подгрузка/сохранение контактов из файла.
    /// </summary>
    private ContactSerializer _contactSerializer;

    /// <summary>
    /// Коллекция контактов.
    /// </summary>
    private ObservableCollection<Contact> _contacts;

    /// <summary>
    /// Выбранный контакт.
    /// </summary>
    private Contact _selectedContact;

    /// <inheritdoc />
    private string _name;

    /// <inheritdoc />
    private string _phone;

    /// <inheritdoc />
    private string _email;

    /// <summary>
    /// Cтатус "только на чтение".
    /// </summary>
    private bool _isReadOnly = true;

    /// <summary>
    /// Cтатус видимости для кнопки.
    /// </summary>
    private bool _isApplyVisible = false;

    /// <summary>
    /// Cтатус активности/неактивности для кнопки.
    /// </summary>
    private bool _isButtonEnabled;

    /// <summary>
    /// Флаг добавления нового контакта.
    /// </summary>
    private bool _isAddingMode = false;

    /// <summary>
    /// Кнопка добавления.
    /// </summary>
    private ICommand _addCommand;

    /// <summary>
    /// Кнопка удаления.
    /// </summary>
    private ICommand _removeCommand;

    /// <summary>
    /// Кнопка изменения.
    /// </summary>
    private ICommand _editCommand;

    /// <summary>
    /// Кнопка подтверждения.
    /// </summary>
    private ICommand _applyCommand;

    /// <summary>
    /// Срабатывает при изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Возвращает и задаёт коллекцию контактов.
    /// </summary>
    public ObservableCollection<Contact> Contacts
    {
        get => _contacts;
        set => SetProperty(ref _contacts, value);
    }

    /// <summary>
    /// Возвращает и задаёт выбранный контакт.
    /// </summary>
    public Contact SelectedContact
    {
        get 
        {
            return _selectedContact; 
        }
        set 
        {
            if (SetProperty(ref _selectedContact, value))
            {
                IsApplyVisible = false;
                IsButtonEnabled = true;
                IsReadOnly = true;
                _isAddingMode = false;

                if (_selectedContact != null)
                {
                    Name = SelectedContact.Name;
                    Phone = SelectedContact.Phone;
                    Email = SelectedContact.Email;
                }
                else
                {
                    Name = string.Empty;
                    Phone = string.Empty;
                    Email = string.Empty;
                }
            }
        }
    }

    /// <inheritdoc />
    public string Name
    {
        get => _name;
        set => SetProperty(ref _name, value);
    }

    /// <inheritdoc />
    public string Phone
    {
        get => _phone;
        set => SetProperty(ref _phone, value);
    }

    /// <inheritdoc />
    public string Email
    {
        get => _email;
        set => SetProperty(ref _email, value);
    }

    /// <summary>
    /// Возвращает и задаёт команду добавления в список контактов.
    /// </summary>
    public ICommand AddCommand 
    {
        get
        {
            if (_addCommand == null)
            {
                new RelayCommand<object>(obj =>
                {
                    SelectedContact = null;
                    _isAddingMode = true;
                    IsApplyVisible = true;
                    IsReadOnly = false;
                    IsButtonEnabled = false;
                });
            }

            return _addCommand;
        }
    }

    /// <summary>
    /// Возвращает и задаёт команду изменения контакта.
    /// </summary>
    public ICommand EditCommand 
    { 
        get
        {
            if ( _editCommand == null)
            {
                new RelayCommand<object>(obj =>
                {
                    if (SelectedContact == null) return;
                    IsButtonEnabled = false;
                    IsApplyVisible = true;
                    IsReadOnly = false;
                });
            }

            return _editCommand;
        }
    }

    /// <summary>
    /// Возвращает и задаёт команду удаления из списка контактов.
    /// </summary>
    public ICommand RemoveCommand 
    {
        get
        {
            if (_removeCommand == null)
            {
                new RelayCommand<object>(obj =>
                {
                    if (SelectedContact == null) return;
                    int index = _contacts.IndexOf(SelectedContact);
                    _contacts.Remove(SelectedContact);
                    if (_contacts.Count == 0)
                    {
                        SelectedContact = null;
                    }
                    else if (_contacts.Count == index)
                    {
                        SelectedContact = _contacts[index - 1];
                    }
                    else
                    {
                        SelectedContact = _contacts[index];
                    }

                    _contactSerializer.Save(_contacts);
                });
            }

            return _removeCommand;
        }
    }

    /// <summary>
    /// Возвращает и задаёт команду подтверждения изменений в правой панели.
    /// </summary>
    public ICommand ApplyCommand 
    {
        get
        {
            if (_applyCommand == null)
            {
                new RelayCommand<object>(obj =>
                {
                    if (_isAddingMode)
                    {
                        Contact newContact = new Contact(Name, Email, Phone);
                        _contacts.Add(newContact);

                        _isAddingMode = false;
                        SelectedContact = newContact;
                    }
                    else if (SelectedContact != null)
                    {
                        SelectedContact.Name = Name;
                        SelectedContact.Email = Email;
                        SelectedContact.Phone = Phone;
                    }

                    IsReadOnly = true;
                    IsApplyVisible = false;
                    IsButtonEnabled = true;
                    _contactSerializer.Save(_contacts);
                });
            }

            return _editCommand;
        }
    }

    /// <summary>
    /// Возвращает и задаёт статус "только на чтение".
    /// </summary>
    public bool IsReadOnly
    {
        get => _isReadOnly;
        set => SetProperty(ref _isReadOnly, value);
    }

    /// <summary>
    /// Возвращает и задаёт статус видимости для кнопки.
    /// </summary>
    public bool IsApplyVisible
    {
        get => _isApplyVisible;
        set => SetProperty(ref _isApplyVisible, value);
    }

    /// <summary>
    /// Возвращает и задаёт статус активности/неактивности для кнопки.
    /// </summary>
    public bool IsButtonEnabled
    {
        get => _isButtonEnabled;
        set => SetProperty(ref _isButtonEnabled, value);
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        _contactSerializer = new ContactSerializer();
        if (_contactSerializer.Load() == null)
        {
            _contacts = new ObservableCollection<Contact>();
        }
        else
        {
            _contacts = _contactSerializer.Load();
        }
        
        IsButtonEnabled = true;
    }
}