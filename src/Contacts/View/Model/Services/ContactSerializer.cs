using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        public string Path { get; set; }

        public Contact LoadJson()
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
        public void SaveJson(Contact contact) 
        {
            if (Directory.Exists(System.IO.Path.GetDirectoryName(Path)) == false)
            {
                Directory.CreateDirectory(System.IO.Path.GetDirectoryName(Path));
            }

            File.WriteAllText(Path, JsonConvert.SerializeObject(contact));
        }

        public ContactSerializer()
        {
            Path = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Contacts/contacts.json");
        }
    }
}
