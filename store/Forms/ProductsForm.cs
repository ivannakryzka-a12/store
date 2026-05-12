using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Store.Models;
using Store.Services;

namespace Store.Forms
{
    public partial class ProductsForm : Form
    {
        private StoreManager _storeManager = new();

        private void UpdateGrid()
        {
            productsGrid.DataSource = null;
            productsGrid.DataSource = _storeManager.Products;

            productsGrid.Columns["Name"].HeaderText = "Назва";
            productsGrid.Columns["Unit"].HeaderText = "Одиниця";
            productsGrid.Columns["Price"].HeaderText = "Ціна";
            productsGrid.Columns["Quantity"].HeaderText = "Кількість";
            productsGrid.Columns["LastDeliveryDate"].HeaderText = "Дата завезення";
        }
        public ProductsForm()
        {
            InitializeComponent();
            UpdateGrid();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            decimal price;
            int quantity;

            bool priceCorrect = decimal.TryParse(priceTextBox.Text, out price);
            bool quantityCorrect = int.TryParse(quantityTextBox.Text, out quantity);

            if (!priceCorrect || !quantityCorrect)
            {
                MessageBox.Show("Некоректні дані");
                return;
            }

            Product product = new Product
            {
                Name = nameTextBox.Text,
                Unit = unitTextBox.Text,
                Price = price,
                Quantity = quantity,
                LastDeliveryDate = DateTime.Now
            };

            _storeManager.AddOrUpdateProduct(product);

            UpdateGrid();

            nameTextBox.Clear();
            unitTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
        }
    }
}
