using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        public AddressControl()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Значение для отключения события при true.
        /// </summary>
        private bool _suppressTextChanged = false;

        /// <summary>
        /// Хранит текущий объект адреса.
        /// </summary>
        private Address _address;
        /// <summary>
        /// Возвращает и задаёт объект <see cref="Address"/>.
        /// При установке обновляются текстовые поля, при получении возвращаются актуальные данные.
        /// </summary>
        public Address Address
        {
            get 
            {
                if (_address == null)
                {
                    _address = new Address();
                }
                UpdateAddressFromTextBoxes();
                return _address; 
            }
            set
            {
                if (value != null)
                {
                    _address = value;
                }
                else
                {
                    _address = new Address();
                }
                UpdateTextBoxes();
            }
        }
        /// <summary>
        /// Выставляет всем текстовым полям модификатор ReadOnly.
        /// </summary>
        public void AddressReadOnlyTrue()
        {
            PostIndexTextBox.ReadOnly = true;
            CountryTextBox.ReadOnly = true;
            CityTextBox.ReadOnly = true;
            StreetTextBox.ReadOnly = true;
            BuildingTextBox.ReadOnly = true;
            ApartmentTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Обновляет текстовые поля на основе текущего объекта <see cref="_address"/>.
        /// </summary>
        private void UpdateTextBoxes()
        {
            _suppressTextChanged = true;

            if (_address.Index != 0)
            {
                PostIndexTextBox.Text = _address.Index.ToString();
            }
            else
            {
                PostIndexTextBox.Text = "";
            }
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;

            _suppressTextChanged = false;
        }

        /// <summary>
        /// Обновляет объект <see cref="_address"/> на основе данных из текстовых полей.
        /// </summary>
        private void UpdateAddressFromTextBoxes()
        {
            if (int.TryParse(PostIndexTextBox.Text, out int index))
                _address.Index = index;

            _address.Country = CountryTextBox.Text;
            _address.City = CityTextBox.Text;
            _address.Street = StreetTextBox.Text;
            _address.Building = BuildingTextBox.Text;
            _address.Apartment = ApartmentTextBox.Text;
        }
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            if (PostIndexTextBox.Text != "")
            {
                try
                {
                    PostIndexTextBox.BackColor = Color.White;
                    Address.Index = Int32.Parse(PostIndexTextBox.Text);
                    ErrorLabel.Text = "";
                }
                catch
                {
                    PostIndexTextBox.BackColor = Color.Red;
                    ErrorLabel.Text = "Значение должно быть целым шестизначный числом";
                }
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            if (CountryTextBox.Text != "")
            {
                try
                {
                    CountryTextBox.BackColor = Color.White;
                    Address.Country = CountryTextBox.Text;
                    ErrorLabel.Text = "";
                }
                catch
                {
                    CountryTextBox.BackColor = Color.Red;
                    ErrorLabel.Text = "Строка не должна превышать 50 символов";
                }
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            if (CityTextBox.Text != "")
            {
                try
                {
                    CityTextBox.BackColor = Color.White;
                    Address.City = CityTextBox.Text;
                    ErrorLabel.Text = "";
                }
                catch
                {
                    CityTextBox.BackColor = Color.Red;
                    ErrorLabel.Text = "Строка не должна превышать 50 символов";
                }
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            if (StreetTextBox.Text != "")
            {
                try
                {
                    StreetTextBox.BackColor = Color.White;
                    Address.Street = StreetTextBox.Text;
                    ErrorLabel.Text = "";
                }
                catch
                {
                    StreetTextBox.BackColor = Color.Red;
                    ErrorLabel.Text = "Строка не должна превышать 100 символов";
                }
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            if (BuildingTextBox.Text != "")
            {
                try
                {
                    BuildingTextBox.BackColor = Color.White;
                    Address.Building = BuildingTextBox.Text;
                    ErrorLabel.Text = "";
                }
                catch
                {
                    BuildingTextBox.BackColor = Color.Red;
                    ErrorLabel.Text = "Строка не должна превышать 10 символов";
                }
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_suppressTextChanged) return;

            if (ApartmentTextBox.Text != "")
            {
                try
                {
                    ApartmentTextBox.BackColor = Color.White;
                    Address.Apartment = ApartmentTextBox.Text;
                    ErrorLabel.Text = "";
                }
                catch
                {
                    ApartmentTextBox.BackColor = Color.Red;
                    ErrorLabel.Text = "Строка не должна превышать 10 символов";
                }
            }
        }
    }
}
