namespace Store.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void productsButton_Click(object sender, EventArgs e)
        {
            ProductsForm form = new ProductsForm();
            form.ShowDialog();
        }

        private void deliveryButton_Click(object sender, EventArgs e)
        {
            DeliveryForm form = new DeliveryForm();
            form.ShowDialog();
        }

        private void saleButton_Click(object sender, EventArgs e)
        {
            SaleForm form = new SaleForm();
            form.ShowDialog();
        }

        private void inventoryButton_Click(object sender, EventArgs e)
        {
            InventoryForm form = new InventoryForm();
            form.ShowDialog();
        }
    }
}
