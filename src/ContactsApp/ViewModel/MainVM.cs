using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using Model.Services;
using Newtonsoft.Json.Linq;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace ViewModel;

/// <summary>
/// Использует данные из Contact и выполняет функцию VM.
/// </summary>
public partial class MainVM : ObservableObject
{
    /// <summary>
    /// Подгрузка/сохранение контактов из файла.
    /// </summary>
    private ContactSerializer _contactSerializer;

    /// <summary>
    /// Флаг добавления нового контакта.
    /// </summary>
    private bool _isAddingMode = false;

    /// <summary>
    /// Бэкап переменной Имя
    /// </summary>
    private string _backupName;

    /// <summary>
    /// Бэкап переменной Телефон
    /// </summary>
    private string _backupPhone;

    /// <summary>
    /// Бэкап переменной Почта
    /// </summary>
    private string _backupEmail;

    /// <summary>
    /// Коллекция контактов.
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<Contact> _contacts;

    /// <summary>
    /// Выбранный контакт.
    /// </summary>
    [ObservableProperty]
    private Contact _selectedContact;

    /// <inheritdoc />
    [ObservableProperty]
    private string _name;

    /// <inheritdoc />
    [ObservableProperty]
    private string _phone;

    /// <inheritdoc />
    [ObservableProperty]
    private string _email;

    /// <summary>
    /// Cтатус "только на чтение".
    /// </summary>
    [ObservableProperty]
    private bool _isReadOnly = true;

    /// <summary>
    /// Cтатус видимости для кнопки.
    /// </summary>
    [ObservableProperty]
    private bool _isApplyVisible = false;

    /// <summary>
    /// Cтатус активности/неактивности для кнопки.
    /// </summary>
    [ObservableProperty]
    private bool _isButtonEnabled;

    /// <summary>
    /// Добавляет новый контакт.
    /// </summary>
    [RelayCommand]
    private void Add()
    {
        SelectedContact = new Contact();
        SelectedContact.PropertyChanged += OnSelectedContactPropertyChanged;
        _isAddingMode = true;
        IsApplyVisible = true;
        IsReadOnly = false;
        IsButtonEnabled = false;
    }

    /// <summary>
    /// Редактирует выбранный контакт.
    /// </summary>
    [RelayCommand]
    private void Edit()
    {
        if (SelectedContact == null) return;
        IsButtonEnabled = false;
        IsApplyVisible = true;
        IsReadOnly = false;
    }

    /// <summary>
    /// Удаляет выбранный контакт.
    /// </summary>
    [RelayCommand]
    private void Remove()
    {
        if (SelectedContact == null) return;
        int index = Contacts.IndexOf(SelectedContact);
        SelectedContact.PropertyChanged -= OnSelectedContactPropertyChanged;
        Contacts.Remove(SelectedContact);

        if (Contacts.Count == 0)
        {
            SelectedContact = null;
        }
        else if (Contacts.Count == index)
        {
            SelectedContact = Contacts[index - 1];
        }
        else
        {
            SelectedContact = Contacts[index];
        }

        _contactSerializer.Save(Contacts);
    }

    /// <summary>
    /// Применяет изменения к выбранному контакту.
    /// </summary>
    [RelayCommand(CanExecute = nameof(CanApply))]
    private void Apply()
    {
        if (_isAddingMode)
        {
            Contacts.Add(SelectedContact);
            _isAddingMode = false;
        }

        if (SelectedContact != null)
        {
            _backupName = SelectedContact.Name;
            _backupPhone = SelectedContact.Phone;
            _backupEmail = SelectedContact.Email;
        }

        IsReadOnly = true;
        IsApplyVisible = false;
        IsButtonEnabled = true;
        _contactSerializer.Save(Contacts);
    }

    /// <summary>
    /// Определяет, можно ли применить изменения к выбранному контакту.
    /// </summary>
    /// <returns>Возвращает true, если выбранный контакт не равен null и является допустимым.</returns>
    private bool CanApply() => SelectedContact != null && SelectedContact.IsValid;

    /// <summary>
    /// Обрабатывает изменение выбранного контакта.
    /// </summary>
    /// <param name="value">Новый выбранный контакт.</param>
    partial void OnSelectedContactChanged(Contact value)
    {
        if (value != null)
        {
            _backupName = value.Name;
            _backupPhone = value.Phone;
            _backupEmail = value.Email;

            Name = value.Name;
            Phone = value.Phone;
            Email = value.Email;
        }
        else
        {
            Name = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
        }

        IsApplyVisible = false;
        IsButtonEnabled = true;
        IsReadOnly = true;
        _isAddingMode = false;

        ApplyCommand.NotifyCanExecuteChanged();
    }

    /// <summary>
    /// Обрабатывает событие изменения свойства выбранного контакта.
    /// </summary>
    /// <param name="sender">Источник события.</param>
    /// <param name="e">Аргументы события.</param>
    private void OnSelectedContactPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(Contact.Name) ||
            e.PropertyName == nameof(Contact.Phone) ||
            e.PropertyName == nameof(Contact.Email))
        {
            ApplyCommand.NotifyCanExecuteChanged();
        }
    }

    /// <summary>
    /// Срабатывает перед тем, как SelectedContact изменит свое значение.
    /// </summary>
    partial void OnSelectedContactChanging(Contact value)
    {
        if (_selectedContact != null && IsApplyVisible && !_isAddingMode)
        {
            _selectedContact.Name = _backupName;
            _selectedContact.Phone = _backupPhone;
            _selectedContact.Email = _backupEmail;
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        _contactSerializer = new ContactSerializer();
        _contacts = _contactSerializer.Load() ?? new ObservableCollection<Contact>();

        IsButtonEnabled = true;
    }
}