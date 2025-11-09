using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Интерфейс для реализации различных типов скидок.
    /// Определяет основные методы и свойства, которые должны реализовывать все классы скидок.
    /// </summary>
    public interface IDiscount
    {
        /// <summary>
        /// Получает информацию о скидке в виде строки.
        /// Например, для накопительной скидки: "Накопительная – {Баллы} баллов",
        /// для процентной: "Процентная – {Категория} - {Процент}%".
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Рассчитывает возможную сумму скидки для переданного списка товаров
        /// без её фактического применения.
        /// </summary>
        /// <param name="items">Список товаров, для которых рассчитывается скидка.</param>
        /// <returns>Размер скидки в рублях.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Применяет скидку к переданному списку товаров.
        /// Метод также списывает соответствующие ресурсы (баллы или суммы), если это необходимо.
        /// </summary>
        /// <param name="items">Список товаров, к которым применяется скидка.</param>
        /// <returns>Размер применённой скидки в рублях.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Обновляет состояние скидки после покупки.
        /// Например, увеличивает количество накопленных баллов или процент скидки.
        /// </summary>
        /// <param name="items">Список купленных товаров.</param>
        void Update(List<Item> items);
    }
}
