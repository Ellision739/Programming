using System.ComponentModel;

namespace View.Model;

/// <summary>
/// Описывает контакт с именем, почтой и телефоном.
/// </summary>
public class Contact : INotifyPropertyChanged
{
    /// <summary>
    /// Ивент, срабатывает при изменении свойства.
    /// </summary>
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Имя контакта.
    /// </summary>
    private string _name;

    /// <summary>
    /// Возвращает и задаёт имя контакта.
    /// </summary>
    public string Name
    {
        get 
        { 
            return _name; 
        }
        set
        {
            _name = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Name)));
        }
    }

    /// <summary>
    /// Почта контакта.
    /// </summary>
    private string _email;

    /// <summary>
    /// Возвращает и задаёт почту контакта.
    /// </summary>
    public string Email
    {
        get 
        { 
            return _email; 
        }
        set 
        { 
            _email = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Email)));
        }
    }

    /// <summary>
    /// Телефон контакта.
    /// </summary>
    private string _phone;

    /// <summary>
    /// Возвращает и задаёт телефон контакта.
    /// </summary>
    public string Phone
    {
        get 
        { 
            return _phone; 
        }
        set 
        { 
            _phone = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Phone)));
        }
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Contact"/>.
    /// </summary>
    /// <param name="name">Имя контакта.</param>
    /// <param name="email">Почта контакта.</param>
    /// <param name="phone">Телефон контакта.</param>
    public Contact(string name, string email, string phone)
    {
        Name = name;
        Email = email;
        Phone = phone;
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="Contact"/>.
    /// </summary>
    public Contact()
    {

    }
}
