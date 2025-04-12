using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab3.Model
{
    /// <summary>
    /// Хранит контактные данные человека.
    /// </summary>
    class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;
        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;
        /// <summary>
        /// Возраст контакта.
        /// </summary>
        private int _age;
        /// <summary>
        /// Номер контакта.
        /// </summary>
        private int _number;
        
        /// <summary>
        /// Проверяет, что строка состоит только из английских букв.
        /// </summary>
        /// <param name="value">Проверяемая строка.</param>
        /// <param name="nameException">Имя свойства или объекта, которое подлежит проверке. Указывать не нужно, встаёт автоматически.</param>
        /// <exception cref="ArgumentException">Ошибка подаваемого аргумента.</exception>
        private void AssertStringContainsOnlyLetters(string value, [CallerMemberName] string nameException = null)
        {
            if (Regex.IsMatch(value, "^[a-zA-Z]+$") == false)
            {
                throw new ArgumentException($"Ожидается {nameException} на английском.");
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должно состоять только из английских букв. Не допускает null.
        /// </summary>
        public string Name
        {
            get { return _name; }
            set 
            {
                AssertStringContainsOnlyLetters(value);
                _name = value; 
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из английских букв. Не допускает null.
        /// </summary>
        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт возраст контакта. Должен варьироваться от 0 до 120.
        /// </summary>
        public int Age
        {
            get { return _age; }
            set
            {
                Validator.AssertValueInRange(value, 0, 120);
                _age = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт номер контакта.
        /// </summary>
        public int Number { get { return _number; } set { _number = value; } }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно состоять только из английских букв. Не допускает null.</param>
        /// <param name="surname">Фамилия. Должна состоять только из английских букв. Не допускает null.</param>
        /// <param name="age">Возраст. Должен варьироваться от 0 до 120.</param>
        /// <param name="number">Номер телефона</param>
        public Contact(string name, string surname, int age, int number)
        {
            Name = name;
            Surname = surname;  
            Age = age;
            Number = number;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {
            
        }
    }
}
