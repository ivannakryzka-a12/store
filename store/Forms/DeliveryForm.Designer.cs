namespace Store.Forms
{
    partial class DeliveryForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            productNameTextBox = new TextBox();
            quantityTextBox = new TextBox();
            deliveryDatePicker = new DateTimePicker();
            addDeliveryButton = new Button();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(70, 40, 40);
            label1.Location = new Point(220, 30);
            label1.Name = "label1";
            label1.Size = new Size(305, 37);
            label1.TabIndex = 0;
            label1.Text = "Надходження товару";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(70, 40, 40);
            label2.Location = new Point(120, 108);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 1;
            label2.Text = "Назва товару:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(70, 40, 40);
            label3.Location = new Point(120, 163);
            label3.Name = "label3";
            label3.Size = new Size(92, 23);
            label3.TabIndex = 2;
            label3.Text = "Кількість:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(70, 40, 40);
            label4.Location = new Point(120, 220);
            label4.Name = "label4";
            label4.Size = new Size(54, 23);
            label4.TabIndex = 3;
            label4.Text = "Дата:";
            // 
            // productNameTextBox
            // 
            productNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            productNameTextBox.Font = new Font("Segoe UI", 10F);
            productNameTextBox.Location = new Point(279, 108);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(180, 30);
            productNameTextBox.TabIndex = 4;
            // 
            // quantityTextBox
            // 
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            quantityTextBox.Font = new Font("Segoe UI", 10F);
            quantityTextBox.Location = new Point(279, 163);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(180, 30);
            quantityTextBox.TabIndex = 5;
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // deliveryDatePicker
            // 
            deliveryDatePicker.CustomFormat = "dd.MM.yyyy";
            deliveryDatePicker.Format = DateTimePickerFormat.Custom;
            deliveryDatePicker.Location = new Point(279, 216);
            deliveryDatePicker.Name = "deliveryDatePicker";
            deliveryDatePicker.Size = new Size(250, 27);
            deliveryDatePicker.TabIndex = 6;
            deliveryDatePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // addDeliveryButton
            // 
            addDeliveryButton.BackColor = Color.FromArgb(120, 0, 0);
            addDeliveryButton.FlatStyle = FlatStyle.Flat;
            addDeliveryButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            addDeliveryButton.ForeColor = Color.White;
            addDeliveryButton.Location = new Point(220, 260);
            addDeliveryButton.Name = "addDeliveryButton";
            addDeliveryButton.Size = new Size(220, 45);
            addDeliveryButton.TabIndex = 7;
            addDeliveryButton.Text = "Додати поставку";
            addDeliveryButton.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(70, 40, 40);
            label5.Location = new Point(120, 326);
            label5.Name = "label5";
            label5.Size = new Size(199, 23);
            label5.TabIndex = 8;
            label5.Text = "Останнє надходження:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(70, 40, 40);
            label6.Location = new Point(120, 362);
            label6.Name = "label6";
            label6.Size = new Size(17, 23);
            label6.TabIndex = 9;
            label6.Text = "-";
            label6.Click += label6_Click;
            // 
            // DeliveryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
            ClientSize = new Size(682, 403);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(addDeliveryButton);
            Controls.Add(deliveryDatePicker);
            Controls.Add(quantityTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DeliveryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Надходження";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox productNameTextBox;
        private TextBox quantityTextBox;
        private DateTimePicker deliveryDatePicker;
        private Button addDeliveryButton;
        private Label label5;
        private Label label6;
    }
}