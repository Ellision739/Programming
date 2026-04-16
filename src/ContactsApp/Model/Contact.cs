using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel;

namespace Model;

/// <summary>
/// Описывает контакт с именем, почтой и телефоном.
/// </summary>
public partial class Contact : ObservableObject, IDataErrorInfo
{
    /// <summary>
    /// Имя контакта.
    /// </summary>
    [ObservableProperty]
    private string _name;

    /// <summary>
    /// Почта контакта.
    /// </summary>
    [ObservableProperty]
    private string _email;

    /// <summary>
    /// Телефон контакта.
    /// </summary>
    [ObservableProperty]
    private string _phone;

    /// <summary>
    /// Возвращает сообщение об ошибке проверки для указанного свойства или null, если ошибок нет.
    /// </summary>
    /// <param name="columnName">Имя свойства для проверки. Допустимые значения: "Name", "Email" или "Phone".</param>
    /// <returns>Строка с сообщением об ошибке, если значение свойства некорректно; в противном случае — null.</returns>
    public string this[string columnName]
    {
        get
        {
            if (columnName == nameof(Name))
            {
                if (string.IsNullOrWhiteSpace(Name))
                {
                    return "Имя не может быть пустым";
                }
                else if (Name.Length > 100)
                {
                    return "Имя не должно превышать 100 символов";
                }
            }
            if (columnName == nameof(Email))
            {
                if (string.IsNullOrWhiteSpace(Email))
                {
                    return "Почта не может быть пустой";
                }
                else if (!Email.Contains("@"))
                {
                    return "Почта должна содержать символ @";
                }
                else if (Email.Length > 100)
                {
                    return "Почта не должна превышать 100 символов";
                }
            }
            if (columnName == nameof(Phone))
            {
                if (string.IsNullOrWhiteSpace(Phone))
                {
                    return "Телефон не может быть пустым";
                }
                else if (!Phone.All(c => char.IsDigit(c) || "+()- ".Contains(c)))
                {
                    return "Номер телефона может содержать только цифры или символы '+()-'. Например: 7 (999) 111-22-33";
                }
                else if (Phone.Length > 100)
                {
                    return "Телефон не должен превышать 100 символов";
                }
            }

            return null;
        }
    }

    /// <summary>
    /// Возвращает сообщение об ошибке для объекта.
    /// </summary>
    public string Error => null;

    /// <summary>
    /// Возвращает значение, указывающее, что все свойства объекта прошли проверку и не содержат ошибок.
    /// </summary>
    public bool IsValid
    {
        get
        {
            return string.IsNullOrEmpty(this[nameof(Name)]) &&
                   string.IsNullOrEmpty(this[nameof(Phone)]) &&
                   string.IsNullOrEmpty(this[nameof(Email)]);
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