namespace Store.Forms
{
    partial class SaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            productsGrid = new DataGridView();
            label2 = new Label();
            checkListBox = new ListBox();
            label3 = new Label();
            quantityTextBox = new TextBox();
            addToCheckButton = new Button();
            label4 = new Label();
            finishSaleButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(70, 40, 40);
            label1.Location = new Point(280, 20);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 0;
            label1.Text = "Оформлення покупки";
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.BackgroundColor = Color.White;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Location = new Point(30, 80);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersVisible = false;
            productsGrid.RowHeadersWidth = 51;
            productsGrid.Size = new Size(519, 250);
            productsGrid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(691, 49);
            label2.Name = "label2";
            label2.Size = new Size(49, 28);
            label2.TabIndex = 2;
            label2.Text = "Чек";
            // 
            // checkListBox
            // 
            checkListBox.FormattingEnabled = true;
            checkListBox.Location = new Point(570, 80);
            checkListBox.Name = "checkListBox";
            checkListBox.Size = new Size(300, 244);
            checkListBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(70, 40, 40);
            label3.Location = new Point(40, 360);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 4;
            label3.Text = "Кількість:";
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(150, 355);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(125, 27);
            quantityTextBox.TabIndex = 5;
            // 
            // addToCheckButton
            // 
            addToCheckButton.BackColor = Color.FromArgb(120, 0, 0);
            addToCheckButton.FlatStyle = FlatStyle.Flat;
            addToCheckButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            addToCheckButton.ForeColor = Color.White;
            addToCheckButton.Location = new Point(120, 420);
            addToCheckButton.Name = "addToCheckButton";
            addToCheckButton.Size = new Size(180, 40);
            addToCheckButton.TabIndex = 6;
            addToCheckButton.Text = "Додати в чек";
            addToCheckButton.UseVisualStyleBackColor = false;
            addToCheckButton.Click += addToCheckButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(550, 360);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 7;
            label4.Text = "Сума: 0 грн";
            // 
            // finishSaleButton
            // 
            finishSaleButton.BackColor = Color.FromArgb(120, 0, 0);
            finishSaleButton.FlatStyle = FlatStyle.Flat;
            finishSaleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            finishSaleButton.ForeColor = Color.White;
            finishSaleButton.Location = new Point(520, 420);
            finishSaleButton.Name = "finishSaleButton";
            finishSaleButton.Size = new Size(220, 45);
            finishSaleButton.TabIndex = 8;
            finishSaleButton.Text = "Завершити покупку";
            finishSaleButton.UseVisualStyleBackColor = false;
            finishSaleButton.Click += finishSaleButton_Click;
            // 
            // SaleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
            ClientSize = new Size(882, 503);
            Controls.Add(finishSaleButton);
            Controls.Add(label4);
            Controls.Add(addToCheckButton);
            Controls.Add(quantityTextBox);
            Controls.Add(label3);
            Controls.Add(checkListBox);
            Controls.Add(label2);
            Controls.Add(productsGrid);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SaleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Продаж";
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView productsGrid;
        private Label label2;
        private ListBox checkListBox;
        private Label label3;
        private TextBox quantityTextBox;
        private Button addToCheckButton;
        private Label label4;
        private Button finishSaleButton;
    }
}