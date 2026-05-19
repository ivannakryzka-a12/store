using Store.Models;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

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
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження: {ex.Message}");
                return new List<Product>();
            }
        }
    }
}
