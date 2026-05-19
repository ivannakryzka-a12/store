using Store.Services;

namespace Store.Forms
{
    /// <summary>
    /// Головна форма - меню для переходу між іншими формами.
    /// </summary>
    public partial class MainForm : Form
    {
        private StoreManager _storeManager = new();

        private const string FilePath = "products.json";

        /// <summary>
        /// Конструктор головної форми.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            _storeManager.Products = DataStorage.Load(FilePath);

            this.KeyPreview = true;
            this.KeyDown += MainForm_KeyDown;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Гарячі клавіші системи:\n\n• F1 — Виклик довідки\n• Enter — Підтвердження дії (Згода)\n• Esc — Закриття вікна / Вихід (Відмова)\n• Tab / Shift-Tab — Навігація між полями та кнопками", "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close(); 
            }
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm(_storeManager);
            form.ShowDialog();
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            DeliveryForm form = new DeliveryForm(_storeManager);
            form.ShowDialog();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            SaleForm form = new SaleForm(_storeManager);
            form.ShowDialog();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm form = new InventoryForm(_storeManager);
            form.ShowDialog();
        }
    }
}
