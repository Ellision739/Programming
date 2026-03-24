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
public class MainVM : INotifyPropertyChanged
{
    /// <summary>
    /// Ивент, срабатывает при изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Подгрузка/сохранение контактов из файла.
    /// </summary>
    private ContactSerializer _contactSerializer;

    /// <summary>
    /// Коллекция контактов.
    /// </summary>
    private ObservableCollection<Contact> _contacts;

    /// <summary>
    /// Возвращает и задаёт коллекцию контактов.
    /// </summary>
    public ObservableCollection<Contact> Contacts
    {
        get { return _contacts; }
        set
        {
            _contacts = value;
            OnPropertyChanged(nameof(Contacts));
        }
    }

    /// <summary>
    /// Выбранный контакт.
    /// </summary>
    private Contact _selectedContact;

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
            IsApplyVisible = false;
            IsButtonEnabled = true;
            IsReadOnly = true;
            _selectedContact = value;
            OnPropertyChanged(nameof(SelectedContact));
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Email));
            OnPropertyChanged(nameof(Phone));
        }
    }


    /// <inheritdoc />
    public string Name
    {
        get 
        { 
            if (SelectedContact == null)
            {
                return string.Empty;
            }
            return SelectedContact.Name; 
        }
        set
        {
            if (SelectedContact == null)
            {
                return;
            }
            SelectedContact.Name = value;
            OnPropertyChanged(nameof(Name));
        }
    }

    /// <inheritdoc />
    public string Phone
    {
        get 
        {
            if (SelectedContact == null)
            {
                return string.Empty;
            }
            return SelectedContact.Phone; 
        }
        set
        {
            if (SelectedContact == null)
            {
                return;
            }
            SelectedContact.Phone = value;
            OnPropertyChanged(nameof(Phone));
        }
    }

    /// <inheritdoc />
    public string Email
    {
        get 
        {
            if (SelectedContact == null)
            {
                return string.Empty;
            }
            return SelectedContact.Email; 
        }
        set
        {
            if (SelectedContact == null)
            {
                return;
            }
            SelectedContact.Email = value;
            OnPropertyChanged(nameof(Email));
        }
    }

    /// <summary>
    /// Возвращает и задаёт команду добавления в список контактов.
    /// </summary>
    public ICommand AddCommand { get; set; }

    /// <summary>
    /// Возвращает и задаёт команду изменения контакта.
    /// </summary>
    public ICommand EditCommand { get; set; }

    /// <summary>
    /// Возвращает и задаёт команду удаления из списка контактов.
    /// </summary>
    public ICommand RemoveCommand { get; set; }

    /// <summary>
    /// Возвращает и задаёт команду подтверждения изменений в правой панели.
    /// </summary>
    public ICommand ApplyCommand { get; set; }

    /// <summary>
    /// Cтатус "только на чтение".
    /// </summary>
    private bool _isReadOnly = true;

    /// <summary>
    /// Возвращает и задаёт статус "только на чтение".
    /// </summary>
    public bool IsReadOnly
    {
        get { return _isReadOnly; }
        set 
        { 
            _isReadOnly = value;
            OnPropertyChanged(nameof(IsReadOnly));
        }
    }

    /// <summary>
    /// Cтатус видимости для кнопки.
    /// </summary>
    private bool _isApplyVisible = false;

    /// <summary>
    /// Возвращает и задаёт статус видимости для кнопки.
    /// </summary>
    public bool IsApplyVisible
    {
        get { return _isApplyVisible; }
        set 
        { 
            _isApplyVisible = value;
            OnPropertyChanged(nameof(IsApplyVisible));
        }
    }

    /// <summary>
    /// Cтатус активности/неактивности для кнопки.
    /// </summary>
    private bool _isButtonEnabled;

    /// <summary>
    /// Возвращает и задаёт статус активности/неактивности для кнопки.
    /// </summary>
    public bool IsButtonEnabled
    {
        get { return _isButtonEnabled; }
        set 
        { 
            _isButtonEnabled = value;
            OnPropertyChanged(nameof(IsButtonEnabled));
        }
    }

    /// <summary>
    /// Флаг добавления нового контакта.
    /// </summary>
    private bool _isAddingMode = false;

    /// <summary>
    /// Вызывает событие изменения свойства.
    /// </summary>
    /// <param name="propertyName">Название свойства.</param>
    private void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
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

        AddCommand = new RelayCommand<object>(obj =>
        {
            _isAddingMode = true;
            SelectedContact = new Contact("", "", "");
            IsApplyVisible = true;
            IsReadOnly = false;
            IsButtonEnabled = false;
        });

        EditCommand = new RelayCommand<object>(obj =>
        {
            if (SelectedContact == null) return;
            IsButtonEnabled = false;
            IsApplyVisible = true;
            IsReadOnly = false;
        });

        RemoveCommand = new RelayCommand<object>(obj =>
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

        ApplyCommand = new RelayCommand<object>(obj =>
        {
            if (_isAddingMode)
            {
                _contacts.Add(SelectedContact);
                OnPropertyChanged(nameof(SelectedContact));
            }
            IsReadOnly = true;
            IsApplyVisible = false;
            IsButtonEnabled = true;
            _isAddingMode = false;
            _contactSerializer.Save(_contacts);
        });
    }
}