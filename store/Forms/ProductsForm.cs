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
    /// <summary>
    /// Головна форма для керування списком товарів (склад).
    /// </summary>
    public partial class ProductsForm : Form
    {
        private StoreManager _storeManager = new();
        private const string FilePath = "products.json";
        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Конструктор форми: завантажує дані та налаштовує таблицю
        /// </summary>
        public ProductsForm()
        {
            InitializeComponent();

            _storeManager.Products = DataStorage.Load(FilePath);

            SetupGrid();
            UpdateGrid();
        }
        private void SetupGrid()
        {
            productsGrid.DataSource = _bindingSource;

            _bindingSource.DataSource = typeof(List<Product>);
            _bindingSource.DataSource = _storeManager.Products;
        }

        private void UpdateGrid()
        {
            _bindingSource.DataSource = null;
            _bindingSource.DataSource = _storeManager.Products;
            RenameColumns();
        }

        private void RenameColumns()
        {
            if (productsGrid.Columns["Name"] != null) productsGrid.Columns["Name"].HeaderText = "Назва";
            if (productsGrid.Columns["Unit"] != null) productsGrid.Columns["Unit"].HeaderText = "Одиниця";
            if (productsGrid.Columns["Price"] != null) productsGrid.Columns["Price"].HeaderText = "Ціна";
            if (productsGrid.Columns["Quantity"] != null) productsGrid.Columns["Quantity"].HeaderText = "Кількість";
            if (productsGrid.Columns["LastDeliveryDate"] != null) productsGrid.Columns["LastDeliveryDate"].HeaderText = "Дата завезення";
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

            DataStorage.Save(_storeManager.Products, FilePath);

            UpdateGrid();

            nameTextBox.Clear();
            unitTextBox.Clear();
            priceTextBox.Clear();
            quantityTextBox.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null || productsGrid.CurrentRow.Index < 0)
            {
                MessageBox.Show("Виберіть товар у таблиці (натисніть на рядок)");
                return;
            }

            Product selectedProduct = (Product)productsGrid.CurrentRow.DataBoundItem;

            if (selectedProduct != null)
            {
                _storeManager.DeleteProduct(selectedProduct);

                DataStorage.Save(_storeManager.Products, FilePath);

                UpdateGrid();

                nameTextBox.Clear();
                unitTextBox.Clear();
                priceTextBox.Clear();
                quantityTextBox.Clear();
            }
        }

        private void productsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = productsGrid.Rows[e.RowIndex];
            Product selectedProduct = (Product)row.DataBoundItem;

            if (selectedProduct != null)
            {
                nameTextBox.Text = selectedProduct.Name;
                unitTextBox.Text = selectedProduct.Unit;
                priceTextBox.Text = selectedProduct.Price.ToString();
                quantityTextBox.Text = selectedProduct.Quantity.ToString();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null)
            {
                MessageBox.Show("Виберіть товар");
                return;
            }

            Product selectedProduct = (Product)productsGrid.CurrentRow.DataBoundItem;

            decimal price;
            int quantity;

            bool priceCorrect = decimal.TryParse(priceTextBox.Text, out price);

            bool quantityCorrect = int.TryParse(quantityTextBox.Text, out quantity);

            if (!priceCorrect || !quantityCorrect)
            {
                MessageBox.Show("Некоректні дані");
                return;
            }

            selectedProduct.Name = nameTextBox.Text;
            selectedProduct.Unit = unitTextBox.Text;
            selectedProduct.Price = price;
            selectedProduct.Quantity = quantity;

            DataStorage.Save(_storeManager.Products, FilePath);

            UpdateGrid();
        }

        private void discountButton_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null)
            {
                MessageBox.Show("Виберіть товар");
                return;
            }

            Product selectedProduct = (Product)productsGrid.CurrentRow.DataBoundItem;

            decimal newPrice;

            bool correct = decimal.TryParse(priceTextBox.Text, out newPrice);

            if (!correct || newPrice <= 0)
            {
                MessageBox.Show("Некоректна ціна");
                return;
            }

            _storeManager.UpdatePrice(selectedProduct, newPrice);

            DataStorage.Save(_storeManager.Products, FilePath);

            UpdateGrid();
        }

        private void writeOffButton_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null)
            {
                MessageBox.Show("Виберіть товар");
                return;
            }

            Product selectedProduct = (Product)productsGrid.CurrentRow.DataBoundItem;

            int quantity;

            bool correct = int.TryParse(quantityTextBox.Text, out quantity);

            if (!correct || quantity <= 0)
            {
                MessageBox.Show("Некоректна кількість");
                return;
            }

            bool success = _storeManager.WriteOff(selectedProduct, quantity);

            if (!success)
            {
                MessageBox.Show("Недостатньо товару");
                return;
            }

            DataStorage.Save(_storeManager.Products, FilePath);

            UpdateGrid();
        }
    }
}
