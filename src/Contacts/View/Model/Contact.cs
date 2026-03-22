namespace View.Model;

/// <summary>
/// Описывает контакт с именем, почтой и телефоном.
/// </summary>
public class Contact
{
    /// <summary>
    /// Возвращает и задаёт имя контакта.
    /// </summary>
    public string Name { get; set; }
    /// <summary>
    /// Возвращает и задаёт почту контакта.
    /// </summary>
    public string Email { get; set; }
    /// <summary>
    /// Возвращает и задаёт телефон контакта.
    /// </summary>
    public string Phone { get; set; }

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
