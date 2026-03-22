using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services;

/// <summary>
/// Серелизирует контакт с типом json.
/// </summary>
public class ContactSerializer
{
    /// <summary>
    /// Возвращает и задаёт путь к файлу.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Путь к папки документов.
    /// </summary>
    private string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    /// <summary>
    /// Загружает контакт из json формата.
    /// </summary>
    /// <returns>Экземпляр типа <see cref="Contact"/>.</returns>
    public Contact Load()
    {
        if (!File.Exists(Path))
        {
            return new Contact();
        }

        if (File.ReadAllText(Path) == "")
        {
            return new Contact();
        }

        Contact contact = JsonConvert.DeserializeObject<Contact>(File.ReadAllText(Path));
        return contact;
    }
    /// <summary>
    /// Сохраняет контакт в файл json формата.
    /// </summary>
    /// <param name="contact">Экземпляр типа <see cref="Contact"/>.</param>
    public void Save(Contact contact) 
    {
        if (Directory.Exists(System.IO.Path.GetDirectoryName(Path)) == false)
        {
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path));
        }

        File.WriteAllText(Path, JsonConvert.SerializeObject(contact));
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="ContactSerializer"/>.
    /// </summary>
    public ContactSerializer()
    {
        Path = System.IO.Path.Combine(docPath, "Contacts/contacts.json");
    }
}
