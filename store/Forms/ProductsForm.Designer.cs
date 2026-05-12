namespace Store.Forms
{
    partial class ProductsForm
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
            nameTextBox = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            unitTextBox = new TextBox();
            priceTextBox = new TextBox();
            quantityTextBox = new TextBox();
            addButton = new Button();
            updateButton = new Button();
            deleteButton = new Button();
            discountButton = new Button();
            writeOffButton = new Button();
            ((System.ComponentModel.ISupportInitialize)productsGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(70, 40, 40);
            label1.Location = new Point(330, 20);
            label1.Name = "label1";
            label1.Size = new Size(243, 37);
            label1.TabIndex = 0;
            label1.Text = "Товари магазину";
            // 
            // productsGrid
            // 
            productsGrid.AllowUserToAddRows = false;
            productsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGrid.BackgroundColor = Color.White;
            productsGrid.BorderStyle = BorderStyle.None;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Location = new Point(30, 70);
            productsGrid.MultiSelect = false;
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
            productsGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGrid.Size = new Size(820, 220);
            productsGrid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(70, 330);
            label2.Name = "label2";
            label2.Size = new Size(64, 23);
            label2.TabIndex = 2;
            label2.Text = "Назва:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Segoe UI", 10F);
            nameTextBox.Location = new Point(168, 330);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(180, 30);
            nameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(70, 380);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 4;
            label3.Text = "Одиниця:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(450, 330);
            label4.Name = "label4";
            label4.Size = new Size(53, 23);
            label4.TabIndex = 5;
            label4.Text = "Ціна:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(450, 380);
            label5.Name = "label5";
            label5.Size = new Size(92, 23);
            label5.TabIndex = 6;
            label5.Text = "Кількість:";
            // 
            // unitTextBox
            // 
            unitTextBox.BackColor = Color.White;
            unitTextBox.BorderStyle = BorderStyle.FixedSingle;
            unitTextBox.Font = new Font("Segoe UI", 10F);
            unitTextBox.Location = new Point(168, 376);
            unitTextBox.Name = "unitTextBox";
            unitTextBox.Size = new Size(180, 30);
            unitTextBox.TabIndex = 7;
            // 
            // priceTextBox
            // 
            priceTextBox.BackColor = Color.White;
            priceTextBox.BorderStyle = BorderStyle.FixedSingle;
            priceTextBox.Font = new Font("Segoe UI", 10F);
            priceTextBox.Location = new Point(548, 326);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(180, 30);
            priceTextBox.TabIndex = 8;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BackColor = Color.White;
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            quantityTextBox.Font = new Font("Segoe UI", 10F);
            quantityTextBox.Location = new Point(548, 376);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(180, 30);
            quantityTextBox.TabIndex = 9;
            // 
            // addButton
            // 
            addButton.BackColor = Color.FromArgb(120, 0, 0);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addButton.ForeColor = Color.White;
            addButton.Location = new Point(158, 444);
            addButton.Name = "addButton";
            addButton.Size = new Size(140, 40);
            addButton.TabIndex = 10;
            addButton.Text = "Додати";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(120, 0, 0);
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(330, 444);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(140, 40);
            updateButton.TabIndex = 11;
            updateButton.Text = "Оновити";
            updateButton.UseVisualStyleBackColor = false;
            updateButton.Click += updateButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.FromArgb(120, 0, 0);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            deleteButton.ForeColor = Color.White;
            deleteButton.Location = new Point(510, 444);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(140, 40);
            deleteButton.TabIndex = 12;
            deleteButton.Text = "Видалити";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // discountButton
            // 
            discountButton.BackColor = Color.FromArgb(120, 0, 0);
            discountButton.FlatStyle = FlatStyle.Flat;
            discountButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            discountButton.ForeColor = Color.White;
            discountButton.Location = new Point(240, 501);
            discountButton.Name = "discountButton";
            discountButton.RightToLeft = RightToLeft.No;
            discountButton.Size = new Size(140, 40);
            discountButton.TabIndex = 13;
            discountButton.Text = "Уцінка";
            discountButton.UseVisualStyleBackColor = false;
            discountButton.Click += discountButton_Click;
            // 
            // writeOffButton
            // 
            writeOffButton.BackColor = Color.FromArgb(120, 0, 0);
            writeOffButton.FlatStyle = FlatStyle.Flat;
            writeOffButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            writeOffButton.ForeColor = Color.White;
            writeOffButton.Location = new Point(433, 501);
            writeOffButton.Name = "writeOffButton";
            writeOffButton.Size = new Size(140, 40);
            writeOffButton.TabIndex = 14;
            writeOffButton.Text = "Списати";
            writeOffButton.UseVisualStyleBackColor = false;
            writeOffButton.Click += writeOffButton_Click;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
            ClientSize = new Size(882, 553);
            Controls.Add(writeOffButton);
            Controls.Add(discountButton);
            Controls.Add(deleteButton);
            Controls.Add(updateButton);
            Controls.Add(addButton);
            Controls.Add(quantityTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(unitTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Controls.Add(label2);
            Controls.Add(productsGrid);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ProductsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Товари";
            ((System.ComponentModel.ISupportInitialize)productsGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView productsGrid;
        private Label label2;
        private TextBox nameTextBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox unitTextBox;
        private TextBox priceTextBox;
        private TextBox quantityTextBox;
        private Button addButton;
        private Button updateButton;
        private Button deleteButton;
        private Button discountButton;
        private Button writeOffButton;
    }
}