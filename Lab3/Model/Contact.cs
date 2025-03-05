using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Contact
    {
        private string _name;
        private string _surname;
        private int _age;
        private int _number;

        public string Name { get { return _name; } set { _name = value; } }

        public string Surname { get { return _surname; } set { _surname = value; } }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 120 || value < 0)
                {
                    throw new ArgumentException("Ожидается корректный возраст (не отрицательный меньше 120).");
                }
                _age = value;
            }
        }
        //public void SetAge(int newAge)
        //{
        //    if (newAge > 120 && newAge < 0)
        //    {
        //        throw new ArgumentException("Ожидается корректный возраст (не отрицательный меньше 120).");
        //    }
        //    _age = newAge;
        //}

        public int Number { get { return _number; } set { _number = value; } }

        public Contact(string name, string surname, int age, int number)
        {
            Name = name;
            Surname = surname;  
            Age = age;
            Number = number;
        }
        public Contact()
        {
            
        }
    }
}
