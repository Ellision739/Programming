using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Определяет возможные диапазоны времени доставки для приоритетного заказа.
    /// </summary>
    public enum DeliveryTime
    {
        Time_9_00_11_00,
        Time_11_00_13_00,
        Time_13_00_15_00,
        Time_15_00_17_00,
        Time_17_00_19_00,
        Time_19_00_21_00
    }
}