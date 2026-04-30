using System.Text.Json;
using Store.Models;

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
                    WriteIndented = true
                };

                string json = JsonSerializer.Serialize(products, options);
                File.WriteAllText(path, json);
            }
            catch
            {
                
            }
        }

        /// <summary>
        /// Завантажує список товарів з файлу.
        /// Якщо файл не існує або виникла помилка — повертає порожній список.
        /// </summary>
        public static List<Product> Load(string path)
        {
            try
            {
                if (!File.Exists(path))
                    return new List<Product>();

                string json = File.ReadAllText(path);

                var data = JsonSerializer.Deserialize<List<Product>>(json);

                return data ?? new List<Product>();
            }
            catch
            {
                return new List<Product>();
            }
        }
    }
}
