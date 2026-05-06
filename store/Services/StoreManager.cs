using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Store.Models;

namespace Store.Services
{
    /// <summary> 
    /// Керує списком товарів у магазині. 
    /// </summary>
    public class StoreManager
    {
        /// <summary>
        /// Список товарів у магазині.
        /// </summary>
        public List<Product> Products { get; set; } = new();

        /// <summary>
        /// Додає новий товар у список.
        /// </summary>
        public void AddProduct(Product item)
        {
            if (item == null) 
                return;

            Products.Add(item);
        }

        /// <summary>
        /// Додає товар або оновлює його кількість, якщо він вже існує.
        /// </summary>
        public void AddOrUpdateProduct(Product newProduct)
        {
            var existing = GetByName(newProduct.Name);

            if (existing != null)
            {
                existing.Quantity += newProduct.Quantity;
                existing.LastDeliveryDate = DateTime.Now;
            }
            else
            {
                Products.Add(newProduct);
            }
        }

        /// <summary>
        /// Видаляє товар зі списку.
        /// </summary>
        public bool DeleteProduct(Product item)
        {
            return Products.Remove(item);
        }

        /// <summary>
        /// Повертає товар за назвою без урахування регістру.
        /// </summary>
        public Product? GetByName(string name)
        {
            return Products.FirstOrDefault(p =>
                p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        /// <summary> 
        /// Обчислює загальну вартість усіх товарів на складі. 
        /// </summary>
        public decimal CalculateTotalStockPrice()
        {
            decimal total = 0;

            foreach (var product in Products)
            {
                total += product.GetStockValue();
            }

            return total;
        }
        
        /// <summary>
        /// Перевіряє, чи достатньо товару на складі.
        /// </summary>
        public bool HasEnough(Product product, int count)
        {
            return product.Quantity >= count;
        }

        /// <summary>
        /// Уцінка товару.
        /// </summary>
        public bool UpdatePrice(Product product, decimal newPrice)
        {
            if (product == null || newPrice <= 0)
                return false;

            product.Price = newPrice;
            return true;
        }

        /// <summary>
        /// Списання товару (зменшення кількості не через продаж).
        /// </summary>
        public bool WriteOff(Product product, int quantity)
        {
            if (product == null || quantity <= 0)
                return false;

            if (product.Quantity < quantity)
                return false;

            product.Quantity -= quantity;
            return true;
        }
    }
}
