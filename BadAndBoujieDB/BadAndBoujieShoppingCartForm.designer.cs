namespace BadAndBoujieMain
{
    partial class BadAndBoujieShoppingCartForm
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
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.dataGridViewCart = new System.Windows.Forms.DataGridView();
            this.labelCost = new System.Windows.Forms.Label();
            this.labelTax = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.textBoxAddAmount = new System.Windows.Forms.TextBox();
            this.labelDisplayCost = new System.Windows.Forms.Label();
            this.labelDisplayTax = new System.Windows.Forms.Label();
            this.labelDisplayTotal = new System.Windows.Forms.Label();
            this.textBoxRemoveAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 52);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(335, 385);
            this.dataGridViewProduct.TabIndex = 1;
            // 
            // dataGridViewCart
            // 
            this.dataGridViewCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCart.Location = new System.Drawing.Point(367, 52);
            this.dataGridViewCart.Name = "dataGridViewCart";
            this.dataGridViewCart.Size = new System.Drawing.Size(267, 235);
            this.dataGridViewCart.TabIndex = 2;
            // 
            // labelCost
            // 
            this.labelCost.AutoSize = true;
            this.labelCost.Location = new System.Drawing.Point(445, 377);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(28, 13);
            this.labelCost.TabIndex = 3;
            this.labelCost.Text = "Cost";
            // 
            // labelTax
            // 
            this.labelTax.AutoSize = true;
            this.labelTax.Location = new System.Drawing.Point(445, 406);
            this.labelTax.Name = "labelTax";
            this.labelTax.Size = new System.Drawing.Size(54, 13);
            this.labelTax.TabIndex = 4;
            this.labelTax.Text = "Tax (12%)";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(445, 433);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(31, 13);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total";
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Location = new System.Drawing.Point(455, 468);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.Size = new System.Drawing.Size(75, 23);
            this.buttonCheckout.TabIndex = 6;
            this.buttonCheckout.Text = "Checkout";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(201, 463);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 7;
            this.buttonAdd.Text = "Add to cart";
            this.buttonAdd.UseVisualStyleBackColor = true;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(508, 307);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(102, 23);
            this.buttonRemove.TabIndex = 8;
            this.buttonRemove.Text = "Remove from cart";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // textBoxAddAmount
            // 
            this.textBoxAddAmount.Location = new System.Drawing.Point(106, 465);
            this.textBoxAddAmount.Name = "textBoxAddAmount";
            this.textBoxAddAmount.Size = new System.Drawing.Size(75, 20);
            this.textBoxAddAmount.TabIndex = 9;
            // 
            // labelDisplayCost
            // 
            this.labelDisplayCost.AutoSize = true;
            this.labelDisplayCost.Location = new System.Drawing.Point(505, 377);
            this.labelDisplayCost.Name = "labelDisplayCost";
            this.labelDisplayCost.Size = new System.Drawing.Size(13, 13);
            this.labelDisplayCost.TabIndex = 10;
            this.labelDisplayCost.Text = "$";
            // 
            // labelDisplayTax
            // 
            this.labelDisplayTax.AutoSize = true;
            this.labelDisplayTax.Location = new System.Drawing.Point(505, 406);
            this.labelDisplayTax.Name = "labelDisplayTax";
            this.labelDisplayTax.Size = new System.Drawing.Size(13, 13);
            this.labelDisplayTax.TabIndex = 11;
            this.labelDisplayTax.Text = "$";
            // 
            // labelDisplayTotal
            // 
            this.labelDisplayTotal.AutoSize = true;
            this.labelDisplayTotal.Location = new System.Drawing.Point(505, 433);
            this.labelDisplayTotal.Name = "labelDisplayTotal";
            this.labelDisplayTotal.Size = new System.Drawing.Size(13, 13);
            this.labelDisplayTotal.TabIndex = 12;
            this.labelDisplayTotal.Text = "$";
            // 
            // textBoxRemoveAmount
            // 
            this.textBoxRemoveAmount.Location = new System.Drawing.Point(405, 307);
            this.textBoxRemoveAmount.Name = "textBoxRemoveAmount";
            this.textBoxRemoveAmount.Size = new System.Drawing.Size(75, 20);
            this.textBoxRemoveAmount.TabIndex = 13;
            // 
            // BadAndBoujieShoppingCartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 503);
            this.Controls.Add(this.textBoxRemoveAmount);
            this.Controls.Add(this.labelDisplayTotal);
            this.Controls.Add(this.labelDisplayTax);
            this.Controls.Add(this.labelDisplayCost);
            this.Controls.Add(this.textBoxAddAmount);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCheckout);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelTax);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.dataGridViewCart);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "BadAndBoujieShoppingCartForm";
            this.Text = "badAndBoujieShoppingCartForm";
            this.Controls.SetChildIndex(this.dataGridViewProduct, 0);
            this.Controls.SetChildIndex(this.dataGridViewCart, 0);
            this.Controls.SetChildIndex(this.labelCost, 0);
            this.Controls.SetChildIndex(this.labelTax, 0);
            this.Controls.SetChildIndex(this.labelTotal, 0);
            this.Controls.SetChildIndex(this.buttonCheckout, 0);
            this.Controls.SetChildIndex(this.buttonAdd, 0);
            this.Controls.SetChildIndex(this.buttonRemove, 0);
            this.Controls.SetChildIndex(this.textBoxAddAmount, 0);
            this.Controls.SetChildIndex(this.labelDisplayCost, 0);
            this.Controls.SetChildIndex(this.labelDisplayTax, 0);
            this.Controls.SetChildIndex(this.labelDisplayTotal, 0);
            this.Controls.SetChildIndex(this.textBoxRemoveAmount, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.DataGridView dataGridViewCart;
        private System.Windows.Forms.Label labelCost;
        private System.Windows.Forms.Label labelTax;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.TextBox textBoxAddAmount;
        private System.Windows.Forms.Label labelDisplayCost;
        private System.Windows.Forms.Label labelDisplayTax;
        private System.Windows.Forms.Label labelDisplayTotal;
        private System.Windows.Forms.TextBox textBoxRemoveAmount;
    }
}