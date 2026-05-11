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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
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
            productsGrid.BackgroundColor = Color.White;
            productsGrid.BorderStyle = BorderStyle.None;
            productsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGrid.Location = new Point(30, 70);
            productsGrid.Name = "productsGrid";
            productsGrid.RowHeadersWidth = 51;
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
            label3.Click += label3_Click;
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
            label5.Click += label5_Click;
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
            // button1
            // 
            button1.BackColor = Color.FromArgb(120, 0, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(158, 444);
            button1.Name = "button1";
            button1.Size = new Size(140, 40);
            button1.TabIndex = 10;
            button1.Text = "Додати";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(120, 0, 0);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(330, 444);
            button2.Name = "button2";
            button2.Size = new Size(140, 40);
            button2.TabIndex = 11;
            button2.Text = "Оновити";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(120, 0, 0);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(510, 444);
            button3.Name = "button3";
            button3.Size = new Size(140, 40);
            button3.TabIndex = 12;
            button3.Text = "Видалити";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(120, 0, 0);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button4.ForeColor = Color.White;
            button4.Location = new Point(240, 501);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(140, 40);
            button4.TabIndex = 13;
            button4.Text = "Уцінка";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(120, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button5.ForeColor = Color.White;
            button5.Location = new Point(433, 501);
            button5.Name = "button5";
            button5.Size = new Size(140, 40);
            button5.TabIndex = 14;
            button5.Text = "Списати";
            button5.UseVisualStyleBackColor = false;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
            ClientSize = new Size(882, 553);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}