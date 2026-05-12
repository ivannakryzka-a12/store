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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeliveryForm));
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
            resources.ApplyResources(label1, "label1");
            label1.ForeColor = Color.FromArgb(70, 40, 40);
            label1.Name = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.ForeColor = Color.FromArgb(70, 40, 40);
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.ForeColor = Color.FromArgb(70, 40, 40);
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.ForeColor = Color.FromArgb(70, 40, 40);
            label4.Name = "label4";
            // 
            // productNameTextBox
            // 
            resources.ApplyResources(productNameTextBox, "productNameTextBox");
            productNameTextBox.BorderStyle = BorderStyle.FixedSingle;
            productNameTextBox.Name = "productNameTextBox";
            // 
            // quantityTextBox
            // 
            resources.ApplyResources(quantityTextBox, "quantityTextBox");
            quantityTextBox.BorderStyle = BorderStyle.FixedSingle;
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.TextChanged += quantityTextBox_TextChanged;
            // 
            // deliveryDatePicker
            // 
            resources.ApplyResources(deliveryDatePicker, "deliveryDatePicker");
            deliveryDatePicker.Format = DateTimePickerFormat.Custom;
            deliveryDatePicker.Name = "deliveryDatePicker";
            deliveryDatePicker.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // addDeliveryButton
            // 
            resources.ApplyResources(addDeliveryButton, "addDeliveryButton");
            addDeliveryButton.BackColor = Color.FromArgb(120, 0, 0);
            addDeliveryButton.ForeColor = Color.White;
            addDeliveryButton.Name = "addDeliveryButton";
            addDeliveryButton.UseVisualStyleBackColor = false;
            addDeliveryButton.Click += addDeliveryButton_Click;
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.ForeColor = Color.FromArgb(70, 40, 40);
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.ForeColor = Color.FromArgb(70, 40, 40);
            label6.Name = "label6";
            label6.Click += label6_Click;
            // 
            // DeliveryForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 240, 235);
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