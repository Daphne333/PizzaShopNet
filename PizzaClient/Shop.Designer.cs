namespace PizzaClient
{
    partial class Shop
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
            this.Inventory = new System.Windows.Forms.Label();
            this.PizzaLijstInventory = new System.Windows.Forms.ListBox();
            this.Products = new System.Windows.Forms.Label();
            this.PizzaLijstProducts = new System.Windows.Forms.ListBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.MoneyLeftStore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.AutoSize = true;
            this.Inventory.Location = new System.Drawing.Point(40, 30);
            this.Inventory.Name = "Inventory";
            this.Inventory.Size = new System.Drawing.Size(66, 17);
            this.Inventory.TabIndex = 0;
            this.Inventory.Text = "Inventory";
            this.Inventory.Click += new System.EventHandler(this.Inventory_Click);
            // 
            // PizzaLijstInventory
            // 
            this.PizzaLijstInventory.FormattingEnabled = true;
            this.PizzaLijstInventory.ItemHeight = 16;
            this.PizzaLijstInventory.Location = new System.Drawing.Point(40, 65);
            this.PizzaLijstInventory.Name = "PizzaLijstInventory";
            this.PizzaLijstInventory.Size = new System.Drawing.Size(270, 180);
            this.PizzaLijstInventory.TabIndex = 1;
            // 
            // Products
            // 
            this.Products.AutoSize = true;
            this.Products.Location = new System.Drawing.Point(385, 30);
            this.Products.Name = "Products";
            this.Products.Size = new System.Drawing.Size(64, 17);
            this.Products.TabIndex = 2;
            this.Products.Text = "Products";
            // 
            // PizzaLijstProducts
            // 
            this.PizzaLijstProducts.FormattingEnabled = true;
            this.PizzaLijstProducts.ItemHeight = 16;
            this.PizzaLijstProducts.Location = new System.Drawing.Point(385, 65);
            this.PizzaLijstProducts.Name = "PizzaLijstProducts";
            this.PizzaLijstProducts.Size = new System.Drawing.Size(270, 180);
            this.PizzaLijstProducts.TabIndex = 3;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(562, 266);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(93, 32);
            this.Refresh.TabIndex = 4;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(385, 266);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(93, 32);
            this.BuyButton.TabIndex = 5;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            // 
            // MoneyLeftStore
            // 
            this.MoneyLeftStore.AutoSize = true;
            this.MoneyLeftStore.Location = new System.Drawing.Point(40, 248);
            this.MoneyLeftStore.Name = "MoneyLeftStore";
            this.MoneyLeftStore.Size = new System.Drawing.Size(16, 17);
            this.MoneyLeftStore.TabIndex = 6;
            this.MoneyLeftStore.Text = "..";
            // 
            // Shop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(702, 324);
            this.Controls.Add(this.MoneyLeftStore);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.PizzaLijstProducts);
            this.Controls.Add(this.Products);
            this.Controls.Add(this.PizzaLijstInventory);
            this.Controls.Add(this.Inventory);
            this.Name = "Shop";
            this.Text = "Store";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Inventory;
        private System.Windows.Forms.ListBox PizzaLijstInventory;
        private System.Windows.Forms.Label Products;
        private System.Windows.Forms.ListBox PizzaLijstProducts;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Label MoneyLeftStore;
    }
}