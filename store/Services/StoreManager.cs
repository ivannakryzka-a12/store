using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

using Store.Models;

namespace Store.Services
{
    /// <summary> Керує списком товарів у магазині. </summary>
    public class StoreManager
    {
        public List<Product> Products { get; set; } = new();

        public void AddProduct(Product item)
        {
            if (item == null) 
                return;

            Products.Add(item);
        }

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

        public bool DeleteProduct(Product item)
        {
            return Products.Remove(item);
        }

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
