using System.ComponentModel;
using View.Model;

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

    /// <inheritdoc />
    private Contact _contact;

    /// <inheritdoc />
    public string Name
    {
        get { return _contact.Name; }
        set
        {
            _contact.Name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    /// <inheritdoc />
    public string Phone
    {
        get { return _contact.Phone; }
        set
        {
            _contact.Phone = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Phone"));
        }
    }

    /// <inheritdoc />
    public string Email
    {
        get { return _contact.Email; }
        set
        {
            _contact.Email = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Email"));
        }
    }

    /// <summary>
    /// Возвращает и задаёт команду сохранения.
    /// </summary>
    public SaveCommand SaveCommand { get; set; }

    /// <summary>
    /// Возвращает и задаёт команду загрузки. 
    /// </summary>
    public LoadCommand LoadCommand { get; set; }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="MainVM"/>.
    /// </summary>
    public MainVM()
    {
        _contact = new Contact();
        SaveCommand = new SaveCommand(this);
        LoadCommand = new LoadCommand(this);
    }
}