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
        public string ProductName { get; set; } = "";
        public int Count { get; set; }
        public decimal Price { get; set; }

        public decimal Sum => Count * Price;
    }
}