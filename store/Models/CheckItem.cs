using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    /// <summary>
    /// Один рядок у чеку.
    /// </summary>
    public class CheckItem
    {
        /// <summary>
        /// Назва товару у чеку.
        /// </summary>
        public string ProductName { get; set; } = "";

        /// <summary>
        /// Кількість товару.
        /// </summary>
        public int Count { get; set; }

        /// <summary>
        /// Ціна одиниці товару.
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Загальна вартість товару.
        /// </summary>
        public decimal Sum => Count * Price;
    }
}