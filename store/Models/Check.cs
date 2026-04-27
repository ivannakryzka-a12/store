using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Models
{
    /// <summary>
    /// Чек покупки.
    /// </summary>
    public class Check
    {
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public List<CheckItem> Items { get; set; } = new();

        /// <summary> Обчислює загальну суму чеку. </summary>
        public decimal TotalAmount()
        {
            decimal result = 0;

            foreach (var item in Items)
            {
                result += item.Sum;
            }

            return result;
        }
    }
}
