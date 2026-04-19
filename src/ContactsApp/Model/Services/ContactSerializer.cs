using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace Model.Services;

/// <summary>
/// Серелизирует контакты с типом json.
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
    private string _docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

    /// <summary>
    /// Загружает контакты из json формата.
    /// </summary>
    /// <returns>Список контактов типа <see cref="Contact"/>.</returns>
    public ObservableCollection<Contact> Load()
    {
        if (!File.Exists(Path))
        {
            return new ObservableCollection<Contact>();
        }

        if (File.ReadAllText(Path) == "")
        {
            return new ObservableCollection<Contact>();
        }

        string text = File.ReadAllText(Path);
        var contacts = JsonConvert.DeserializeObject<ObservableCollection<Contact>>(text);
        return contacts;
    }

    /// <summary>
    /// Сохраняет контакты в файл json формата.
    /// </summary>
    /// <param name="contacts">Список контактов типа <see cref="Contact"/>.</param>
    public void Save(ObservableCollection<Contact> contacts)
    {
        if (Directory.Exists(System.IO.Path.GetDirectoryName(Path)) == false)
        {
            Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path));
        }

        File.WriteAllText(Path, JsonConvert.SerializeObject(contacts));
    }

    /// <summary>
    /// Создаёт экземпляр класса <see cref="ContactSerializer"/>.
    /// </summary>
    public ContactSerializer()
    {
        Path = System.IO.Path.Combine(_docPath, "Contacts v2/contacts.json");
    }
}