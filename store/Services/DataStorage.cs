using Store.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;

namespace Store.Services
{
    /// <summary>
    /// Відповідає за збереження та завантаження даних у JSON файл.
    /// </summary>
    public static class DataStorage
    {
        /// <summary>
        /// Зберігає список товарів у файл.
        /// </summary>
        public static void Save(List<Product> products, string path)
        {
            try
            {
                var options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic)
                };

                string json = JsonSerializer.Serialize(products, options);
                File.WriteAllText(path, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка збереження: {ex.Message}");
            }
        }

        /// <summary>
        /// Завантажує список товарів з файлу.
        /// Якщо файл не існує — автоматично створює базу з демонстраційними продуктами.
        /// </summary>
        public static List<Product> Load(string path)
        {
            try
            {
                if (!File.Exists(path))
                {
                    var defaultProducts = new List<Product>
                    {
                        new Product { Name = "Хліб Бородинський", Price = 24, Quantity = 15, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Молоко 2.5% 1л", Price = 42, Quantity = 20, Unit = "л", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Олія соняшникова", Price = 65, Quantity = 12, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Цукор білий", Price = 34, Quantity = 50, Unit = "кг", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Борошно 2кг", Price = 48, Quantity = 10, Unit = "уп", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Яйця курячі", Price = 55, Quantity = 18, Unit = "уп", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Масло вершкове", Price = 82, Quantity = 25, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Сир твердий", Price = 320, Quantity = 8, Unit = "кг", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Ковбаса Лікарська", Price = 260, Quantity = 6, Unit = "кг", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Вода 1.5л", Price = 18, Quantity = 40, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Кава мелена 250г", Price = 145, Quantity = 14, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Чай чорний", Price = 52, Quantity = 22, Unit = "уп", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Макарони", Price = 28, Quantity = 35, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Рис 1кг", Price = 58, Quantity = 15, Unit = "шт", LastDeliveryDate = DateTime.Now },
                        new Product { Name = "Шоколад молочний", Price = 45, Quantity = 30, Unit = "шт", LastDeliveryDate = DateTime.Now }
                    };

                    Save(defaultProducts, path);

                    return defaultProducts;
                }

                string json = File.ReadAllText(path);
                var data = JsonSerializer.Deserialize<List<Product>>(json);

                return data ?? new List<Product>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження: {ex.Message}");
                return new List<Product>();
            }
        }
    }
}