namespace Store.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            productsButton = new Button();
            deliveryButton = new Button();
            saleButton = new Button();
            inventoryButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(70, 40, 40);
            label1.Location = new Point(230, 50);
            label1.Name = "label1";
            label1.Size = new Size(221, 41);
            label1.TabIndex = 0;
            label1.Text = "Облік товарів";
            // 
            // productsButton
            // 
            productsButton.BackColor = Color.FromArgb(120, 0, 0);
            productsButton.FlatStyle = FlatStyle.Flat;
            productsButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            productsButton.ForeColor = Color.White;
            productsButton.Location = new Point(230, 130);
            productsButton.Name = "productsButton";
            productsButton.Size = new Size(220, 45);
            productsButton.TabIndex = 1;
            productsButton.Text = "Товари";
            productsButton.UseVisualStyleBackColor = false;
            productsButton.Click += productsButton_Click;
            // 
            // deliveryButton
            // 
            deliveryButton.BackColor = Color.FromArgb(120, 0, 0);
            deliveryButton.FlatStyle = FlatStyle.Flat;
            deliveryButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            deliveryButton.ForeColor = Color.White;
            deliveryButton.Location = new Point(230, 190);
            deliveryButton.Name = "deliveryButton";
            deliveryButton.Size = new Size(220, 45);
            deliveryButton.TabIndex = 2;
            deliveryButton.Text = "Надходження";
            deliveryButton.UseVisualStyleBackColor = false;
            deliveryButton.Click += deliveryButton_Click;
            // 
            // saleButton
            // 
            saleButton.BackColor = Color.FromArgb(120, 0, 0);
            saleButton.FlatStyle = FlatStyle.Flat;
            saleButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            saleButton.ForeColor = Color.White;
            saleButton.Location = new Point(230, 250);
            saleButton.Name = "saleButton";
            saleButton.Size = new Size(220, 45);
            saleButton.TabIndex = 3;
            saleButton.Text = "Продаж";
            saleButton.UseVisualStyleBackColor = false;
            saleButton.Click += saleButton_Click;
            // 
            // inventoryButton
            // 
            inventoryButton.BackColor = Color.FromArgb(120, 0, 0);
            inventoryButton.FlatStyle = FlatStyle.Flat;
            inventoryButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            inventoryButton.ForeColor = Color.White;
            inventoryButton.Location = new Point(230, 310);
            inventoryButton.Name = "inventoryButton";
            inventoryButton.Size = new Size(220, 45);
            inventoryButton.TabIndex = 4;
            inventoryButton.Text = "Інвентаризація";
            inventoryButton.UseVisualStyleBackColor = false;
            inventoryButton.Click += inventoryButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
            ClientSize = new Size(682, 453);
            Controls.Add(inventoryButton);
            Controls.Add(saleButton);
            Controls.Add(deliveryButton);
            Controls.Add(productsButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Головне меню";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button productsButton;
        private Button deliveryButton;
        private Button saleButton;
        private Button inventoryButton;
    }
}
