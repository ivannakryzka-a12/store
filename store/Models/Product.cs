using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    /// <summary>
    /// Опис одного товару магазину.
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Назва товару.
        /// </summary>
        public string Name { get; set; } = "";

        /// <summary>
        /// Одиниця виміру товару.
        /// </summary>
        public string Unit { get; set; } = "";

        /// <summary>
        /// Ціна товару.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Кількість товару на складі.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Дата останнього постачання.
        /// </summary>
        public DateTime LastDeliveryDate { get; set; } = DateTime.Now;

        /// <summary>
        /// Обчислює загальну вартість товару на складі.
        /// </summary>
        public decimal GetStockValue()
        {
            return Quantity * Price;
        }

        /// <summary>
        /// Повертає текстове представлення товару.
        /// </summary>
        public override string ToString()
        {
            return $"{Name} ({Quantity} {Unit})";
        }
    }
}
