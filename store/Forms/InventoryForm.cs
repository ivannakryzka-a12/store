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
    /// Форма інвентаризації для перегляду залишків товарів та загальної вартості складу.
    /// </summary>
    public partial class InventoryForm : Form
    {
        private StoreManager _storeManager;

        private const string FilePath = "products.json";

        private BindingSource _bindingSource = new BindingSource();

        /// <summary>
        /// Ініціалізує компоненти та запускає завантаження даних.
        /// </summary>
        public InventoryForm(StoreManager storeManager)
        {
            InitializeComponent();

            _storeManager = storeManager;

            LoadData();
        }

        private void LoadData()
        {
            inventoryGrid.DataSource = null;

            inventoryGrid.DataSource = _storeManager.Products;

            inventoryGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            RenameColumns();

            totalLabel.Text = $"{_storeManager.CalculateTotalStockPrice()} грн";
        }

        private void RenameColumns()
        {
            if (inventoryGrid.Columns["Name"] != null)
                inventoryGrid.Columns["Name"].HeaderText = "Назва";

            if (inventoryGrid.Columns["Unit"] != null)
                inventoryGrid.Columns["Unit"].HeaderText = "Одиниця";

            if (inventoryGrid.Columns["Price"] != null)
                inventoryGrid.Columns["Price"].HeaderText = "Ціна";

            if (inventoryGrid.Columns["Quantity"] != null)
                inventoryGrid.Columns["Quantity"].HeaderText = "Кількість";

            if (inventoryGrid.Columns["LastDeliveryDate"] != null)
                inventoryGrid.Columns["LastDeliveryDate"].HeaderText = "Дата завезення";
        }

        private void saveReportButton_Click(object sender, EventArgs e)
        {
            string report = "ЗВІТ ПРО ІНВЕНТАРИЗАЦІЮ\n\n";

            foreach (Product product in _storeManager.Products)
            {
                report +=
                    $"{product.Name} | " +
                    $"{product.Quantity} {product.Unit} | " +
                    $"{product.Price} грн\n";
            }

            report +=
                $"\nЗагальна вартість: " +
                $"{_storeManager.CalculateTotalStockPrice()} грн";

            File.WriteAllText("inventory_report.txt", report);

            MessageBox.Show("Звіт збережено");
        }
    }
}
