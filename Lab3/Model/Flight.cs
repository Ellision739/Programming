using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3.Model
{
    class Flight
    {
        private string _departurePoint;
        private string _destination;
        private int _flightTimeMin;

        public string DeparturePoint { get { return _departurePoint; } set { _departurePoint = value; } }
        public string Destination { get { return _destination; } set { _destination = value; } }
        public int FlightTimeMin
        {
            get
            {
                return _flightTimeMin;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ожидается неотрицательное значение.");
                }
                _flightTimeMin = value;
            }
        }
        public Flight(string departurePoint, string destination, int flightTimeMin)
        {
            DeparturePoint = departurePoint;
            Destination = destination;
            FlightTimeMin = flightTimeMin;
        }
        public Flight()
        {
            
        }
    }
}
