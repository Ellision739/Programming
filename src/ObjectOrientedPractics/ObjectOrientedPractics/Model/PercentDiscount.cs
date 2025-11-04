using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PercentDiscount
    {
		private int _currentDiscount;

		public int CurrentDiscount
		{
			get { return _currentDiscount; }
			set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Значение должно быть положительное");
                }
                if (value > 10)
                {
                    throw new ArgumentException("Значение не должно быть больше 10");
                }
                _currentDiscount = value; 
			}
		}

		private Category _category;

		public Category Category
		{
			get { return _category; }
			set { _category = value; }
		}

		private int _currentAmount;

		public int CurrentAmount
		{
			get { return _currentAmount; }
			set { _currentAmount = value; }
		}

        public double Calculate(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                if (item.Category == Category.Books)
                {

                }
                switch(item.Category)
                {
                    case Category.Books:

                }
            }
            amount *= 0.3;
            if (CumulativePoints > amount)
            {
                return amount;
            }
            return amount;
        }

        public double Apply(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            amount *= 0.3;
            if (CumulativePoints > amount)
            {
                CumulativePoints -= amount;
                return amount;
            }
            amount = CumulativePoints;
            CumulativePoints = 0;
            return amount;
        }

        public void Update(List<Item> items)
        {
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            CumulativePoints += Math.Ceiling(amount *= 0.1);
        }
    }
}
