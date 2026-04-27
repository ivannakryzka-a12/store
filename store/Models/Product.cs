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
        public string Name { get; set; } = "";
        public string Unit { get; set; } = "";
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; } = DateTime.Now;

        public decimal GetStockValue()
        {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return $"{Name} ({Quantity} {Unit})";
        }
    }
}
