using System;
using System.Collections.Generic;
using System.Text;

using Store.Models;

namespace Store.Services
{
    /// <summary> Керує списком товарів у магазині. </summary>
    public class StoreManager
    {
        /// <summary> Список усіх товарів у магазині. </summary>
        public List<Product> Products { get; set; } = new();

        /// <summary> Додає новий товар у список. </summary>
        public void AddProduct(Product item)
        {
            Products.Add(item);
        }

        /// <summary> Видаляє товар зі списку. </summary>
        public bool DeleteProduct(Product item)
        {
            return Products.Remove(item);
        }

        /// <summary> Повертає товар за назвою (без урахування регістру). </summary>
        public Product? GetByName(string name)
        {
            return Products.FirstOrDefault(p =>
                p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary> Обчислює загальну вартість усіх товарів на складі. </summary>
        public decimal CalculateTotalStockPrice()
        {
            decimal total = 0;

            foreach (var product in Products)
            {
                total += product.GetStockValue();
            }

            return total;
        }

        /// <summary> Перевіряє, чи достатньо товару для операції. </summary>
        public bool HasEnough(Product product, int count)
        {
            return product.Quantity >= count;
        }
    }
}
