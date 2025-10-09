using ObjectOrientedPractics.Servies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Описывает адрес покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Валидатор для проверки свойств адреса.
        /// </summary>
        private readonly ValueValidator validator = new ValueValidator();

        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;
        /// <summary>
        /// Возвращает и задаёт почтовый индекс.
        /// Должно быть целое шестизначное число.
        /// </summary>
        public int Index
        {
            get { return _index; }
            set
            {
                if (value != 0 && (value < 100000 || value > 999999))
                {
                    throw new ArgumentException("Значение должно быть целым шестизначный числом");
                }
                _index = value;
            }
        }

        /// <summary>
        /// Страна/регион адреса.
        /// </summary>
        private string _country;

        /// <summary>
        /// Возвращает и задаёт страну/регион в адресе. 
        /// Длина строки не должна превышать 50 символов.
        /// </summary>
        public string Country
        {
            get { return _country; }
            set
            {
                validator.AssertStringOnLength(value, 50, "Country");
                _country = value;
            }
        }

        /// <summary>
        /// Город (населенный пункт) адреса.
        /// </summary>
        private string _city;

        /// <summary>
        /// Возвращает и задаёт город (населенный пункт) в адресе. 
        /// Длина строки не должна превышать 50 символов.
        /// </summary>
        public string City
        {
            get { return _city; }
            set
            {
                validator.AssertStringOnLength(value, 50, "City");
                _city = value;
            }
        }

        /// <summary>
        /// Улица адреса.
        /// </summary>
        private string _street;

        /// <summary>
        /// Возвращает и задаёт улицу в адресе. 
        /// Длина строки не должна превышать 100 символов.
        /// </summary>
        public string Street
        {
            get { return _street; }
            set
            {
                validator.AssertStringOnLength(value, 100, "Street");
                _street = value;
            }
        }

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;
        /// <summary>
        /// Возвращает и задаёт номер дома.
        /// Не должен превышать 10 символов.
        /// </summary>
        public string Building
        {
            get { return _building; }
            set
            {
                validator.AssertStringOnLength(value, 10, "Building");
                _building = value;
            }
        }

        /// <summary>
        /// Номер квартиры/помещения.
        /// </summary>
        private string _apartment;
        /// <summary>
        /// Возвращает и задаёт номер квартиры/помещения.
        /// Не должен превышать 10 символов.
        /// </summary>
        public string Apartment
        {
            get { return _apartment; }
            set
            {
                validator.AssertStringOnLength(value, 10, "Apartment");
                _apartment = value;
            }
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс адреса (целое шестизначное число).</param>
        /// <param name="country">Страна/регион адреса (не более 50 символов).</param>
        /// <param name="city">Город/населенный пункт адреса (не более 50 символов).</param>
        /// <param name="street">Улица проживания адреса (не более 100 символов).</param>
        /// <param name="building">Номер дома адреса (не более 10 символов).</param>
        /// <param name="apartment">Номер квартиры/помещения адреса (не более 10 символов).</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }
        /// <summary>
        /// Создаёт экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            
        }
    }
}
