using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Model;
using Model.Services;

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
        IsApplyVisible = false;
        IsButtonEnabled = true;
        IsReadOnly = true;
        _isAddingMode = false;

        if (value != null)
        {
            value.PropertyChanged += OnSelectedContactPropertyChanged;
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
    /// Создаёт экземпляр класса <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        _contactSerializer = new ContactSerializer();
        _contacts = _contactSerializer.Load() ?? new ObservableCollection<Contact>();

        IsButtonEnabled = true;
    }
}