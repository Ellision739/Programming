using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public class PointsDiscount
    {
		private double _cumulativePoints;

		public double CumulativePoints
        {
			get { return _cumulativePoints; }
			private set 
			{
                if (value < 0)
                {
                    throw new ArgumentException("Значение должно быть положительное");
                }
                _cumulativePoints = value; 
			}
		}

        private string _info;

        public string Info
        {
            get { return _info; }
        }


        public double Calculate(List<Item> items)
		{
            double amount = 0;
            foreach (Item item in items)
            {
                amount += item.Cost;
            }
            amount *= 0.3;
            if (CumulativePoints > amount)
            {
                return amount;
            }
            return CumulativePoints;
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

        public PointsDiscount()
        {
            _info = $"Накопительная - {CumulativePoints} баллов";
        }
    }
}
