using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Servies
{
    public delegate bool ItemsFilter(Item item, string text);
    public delegate List<Item> ItemsSort(List<Item> items);

    public static class DataTools
    {

        public static bool ExpensiveItemsFilter(Item item, string priceThresholdString)
        {
            if (double.TryParse(priceThresholdString, out double priceThreshold))
            {
                return item.Cost > priceThreshold;
            }
            return false;

        }


        public static bool FoodFilter(Item item, string categoryString)
        {
            if (Enum.TryParse(categoryString, out Category category))
            {
                return item.Category == category;
            }
            return false;
        }


        public static bool TextFilter(Item item, string searchText)
        {
            return item.Name.Contains(searchText, StringComparison.OrdinalIgnoreCase);
        }

        public static List<Item> Filter(List<Item> items, Func<Item, string, bool> filt, string text)
        {
            List<Item> list = new List<Item>();
            foreach (Item item in items)
            {
                if (filt(item, text))
                {
                    list.Add(item);
                }
            }

            return list;
        }


        public static List<Item> SortForNames(List<Item> items)
        {
            if (items == null) return new List<Item>();

            var comparer = StringComparer.Create(new System.Globalization.CultureInfo("ru-RU"), true);
            items.Sort((x, y) => comparer.Compare(x.Name, y.Name));
            return items;
        }


        public static List<Item> SortForCostAscending(List<Item> items)
        {
            items.Sort((x, y) => x.Cost.CompareTo(y.Cost));
            return items;
        }


        public static List<Item> SortForCostDescending(List<Item> items)
        {
            items.Sort((y, x) => x.Cost.CompareTo(y.Cost));
            return items;
        }


        public static List<Item> Sort(List<Item> items, ItemsSort sort)
        {
            return sort(items);
        }
    }
}