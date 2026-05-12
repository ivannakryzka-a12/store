using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Globalization; 
using System.Threading;
using Store.Models;
using Store.Services;

namespace Store.Forms
{
    /// <summary>
    /// лас для управління надходженням товарів на склад.
    /// </summary>
    public partial class DeliveryForm : Form
    {
        private StoreManager _storeManager = new();
        private const string FilePath = "products.json";

        /// <summary>
        /// Конструктор форми: налаштовує компоненти та завантажує дані з файлу.
        /// </summary>
        public DeliveryForm()
        {
            InitializeComponent();

            _storeManager.Products = DataStorage.Load(FilePath);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void addDeliveryButton_Click(object sender, EventArgs e)
        {
            int quantity;

            bool quantityCorrect =
                int.TryParse(quantityTextBox.Text, out quantity);

            if (!quantityCorrect || quantity <= 0)
            {
                MessageBox.Show("Некоректна кількість");
                return;
            }

            string productName = productNameTextBox.Text;

            Product product = _storeManager.GetByName(productName);

            if (product == null)
            {
                MessageBox.Show("Товар не знайдено");
                return;
            }

            product.Quantity += quantity;

            product.LastDeliveryDate = deliveryDatePicker.Value;

            DataStorage.Save(_storeManager.Products, FilePath);

            lastDeliveryLabel.Text = $"{product.Name} | {quantity} {product.Unit} | {product.LastDeliveryDate:dd.MM.yyyy}";

            MessageBox.Show("Надходження додано");

            productNameTextBox.Clear();
            quantityTextBox.Clear();
        }
    }
}
