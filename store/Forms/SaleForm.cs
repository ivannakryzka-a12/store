using Store.Forms;
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
    /// Форма для оформлення продажу товарів та формування чека.
    /// </summary>
    public partial class SaleForm : Form
    {
        private StoreManager _storeManager = new();

        private CheckManager _checkManager;

        private Check _currentCheck;

        private const string FilePath = "products.json";

        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Конструктор форми: ініціалізує менеджери, завантажує товари та налаштовує таблицю.
        /// </summary>
        public SaleForm()
        {
            InitializeComponent();

            _storeManager.Products = DataStorage.Load(FilePath);

            _checkManager = new CheckManager(_storeManager);

            _currentCheck = _checkManager.CreateCheck();

            SetupGrid();

            UpdateGrid();
        }

        private void SetupGrid()
        {
            productsGrid.DataSource = _bindingSource;

            _bindingSource.DataSource = _storeManager.Products;

            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            productsGrid.MultiSelect = false;
        }

        private void UpdateGrid()
        {
            _bindingSource.DataSource = null;

            _bindingSource.DataSource = _storeManager.Products;

            RenameColumns();
        }

        private void RenameColumns()
        {
            if (productsGrid.Columns["Name"] != null)
                productsGrid.Columns["Name"].HeaderText = "Назва";

            if (productsGrid.Columns["Unit"] != null)
                productsGrid.Columns["Unit"].HeaderText = "Одиниця";

            if (productsGrid.Columns["Price"] != null)
                productsGrid.Columns["Price"].HeaderText = "Ціна";

            if (productsGrid.Columns["Quantity"] != null)
                productsGrid.Columns["Quantity"].HeaderText = "Кількість";

            if (productsGrid.Columns["LastDeliveryDate"] != null)
                productsGrid.Columns["LastDeliveryDate"].HeaderText = "Дата завезення";
        }

        private void finishSaleButton_Click(object sender, EventArgs e)
        {
            if (_currentCheck.Items.Count == 0)
            {
                MessageBox.Show("Чек порожній");
                return;
            }

            decimal total = _checkManager.GetCheckTotal(_currentCheck);

            MessageBox.Show($"Покупку завершено\nСума: {total} грн");

            _currentCheck = _checkManager.CreateCheck();

            checkListBox.Items.Clear();

            label4.Text = "Сума: 0 грн";

            UpdateGrid();
        }

        private void addToCheckButton_Click(object sender, EventArgs e)
        {
            if (productsGrid.CurrentRow == null)
            {
                MessageBox.Show("Виберіть товар");
                return;
            }

            int quantity;

            bool correct = int.TryParse(quantityTextBox.Text, out quantity);

            if (!correct || quantity <= 0)
            {
                MessageBox.Show("Некоректна кількість");
                return;
            }

            Product selectedProduct = (Product)productsGrid.CurrentRow.DataBoundItem;

            bool success = _checkManager.AddProductToCheck(_currentCheck, selectedProduct.Name, quantity);

            if (!success)
            {
                MessageBox.Show("Недостатньо товару");
                return;
            }

            checkListBox.Items.Add($"{selectedProduct.Name} | " + $"{quantity} x {selectedProduct.Price} грн");

            label4.Text = $"Сума: {_checkManager.GetCheckTotal(_currentCheck)} грн";

            DataStorage.Save(_storeManager.Products, FilePath);

            UpdateGrid();

            quantityTextBox.Clear();
        }
    }
}
