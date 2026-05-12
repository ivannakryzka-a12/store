namespace Store.Forms
{
    partial class InventoryForm
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
            inventoryGrid = new DataGridView();
            label2 = new Label();
            totalLabel = new Label();
            refreshButton = new Button();
            saveReportButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(70, 40, 40);
            label1.Location = new Point(250, 20);
            label1.Name = "label1";
            label1.Size = new Size(334, 38);
            label1.TabIndex = 0;
            label1.Text = "Інвентаризація товарів";
            // 
            // inventoryGrid
            // 
            inventoryGrid.BackgroundColor = Color.White;
            inventoryGrid.BorderStyle = BorderStyle.None;
            inventoryGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryGrid.Location = new Point(40, 70);
            inventoryGrid.Name = "inventoryGrid";
            inventoryGrid.RowHeadersWidth = 51;
            inventoryGrid.Size = new Size(760, 280);
            inventoryGrid.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(70, 390);
            label2.Name = "label2";
            label2.Size = new Size(242, 25);
            label2.TabIndex = 2;
            label2.Text = "Загальна вартість товарів:";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            totalLabel.ForeColor = Color.FromArgb(120, 0, 0);
            totalLabel.Location = new Point(70, 430);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(70, 31);
            totalLabel.TabIndex = 3;
            totalLabel.Text = "0 грн";
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.FromArgb(120, 0, 0);
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            refreshButton.ForeColor = Color.White;
            refreshButton.Location = new Point(450, 410);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(154, 42);
            refreshButton.TabIndex = 4;
            refreshButton.Text = "Оновити дані";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // saveReportButton
            // 
            saveReportButton.BackColor = Color.FromArgb(120, 0, 0);
            saveReportButton.FlatStyle = FlatStyle.Flat;
            saveReportButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveReportButton.ForeColor = Color.White;
            saveReportButton.Location = new Point(620, 410);
            saveReportButton.Name = "saveReportButton";
            saveReportButton.Size = new Size(133, 42);
            saveReportButton.TabIndex = 5;
            saveReportButton.Text = "Зберегти звіт";
            saveReportButton.UseVisualStyleBackColor = false;
            saveReportButton.Click += saveReportButton_Click;
            // 
            // InventoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
            ClientSize = new Size(832, 503);
            Controls.Add(saveReportButton);
            Controls.Add(refreshButton);
            Controls.Add(totalLabel);
            Controls.Add(label2);
            Controls.Add(inventoryGrid);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InventoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Інвентаризація";
            ((System.ComponentModel.ISupportInitialize)inventoryGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView inventoryGrid;
        private Label label2;
        private Label totalLabel;
        private Button refreshButton;
        private Button saveReportButton;
    }
}