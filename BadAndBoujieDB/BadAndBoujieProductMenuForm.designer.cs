namespace BadAndBoujieMain
{
    partial class BadAndBoujieProductMenuForm
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
            this.buttonSaveChanges = new System.Windows.Forms.Button();
            this.radioButtonProducts = new System.Windows.Forms.RadioButton();
            this.radioButtonUsers = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonReload = new System.Windows.Forms.Button();
            this.buttonProductInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(12, 53);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.Size = new System.Drawing.Size(622, 228);
            this.dataGridViewProduct.TabIndex = 1;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.Location = new System.Drawing.Point(12, 287);
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.Size = new System.Drawing.Size(103, 22);
            this.buttonSaveChanges.TabIndex = 2;
            this.buttonSaveChanges.Text = "Save Changes";
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            // 
            // radioButtonProducts
            // 
            this.radioButtonProducts.AutoSize = true;
            this.radioButtonProducts.Location = new System.Drawing.Point(11, 30);
            this.radioButtonProducts.Name = "radioButtonProducts";
            this.radioButtonProducts.Size = new System.Drawing.Size(67, 17);
            this.radioButtonProducts.TabIndex = 7;
            this.radioButtonProducts.TabStop = true;
            this.radioButtonProducts.Text = "Products";
            this.radioButtonProducts.UseVisualStyleBackColor = true;
            // 
            // radioButtonUsers
            // 
            this.radioButtonUsers.AutoSize = true;
            this.radioButtonUsers.Location = new System.Drawing.Point(84, 30);
            this.radioButtonUsers.Name = "radioButtonUsers";
            this.radioButtonUsers.Size = new System.Drawing.Size(52, 17);
            this.radioButtonUsers.TabIndex = 8;
            this.radioButtonUsers.TabStop = true;
            this.radioButtonUsers.Text = "Users";
            this.radioButtonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(11, 315);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(103, 22);
            this.buttonCheck.TabIndex = 9;
            this.buttonCheck.Text = "Check Quantity";
            this.buttonCheck.UseVisualStyleBackColor = true;
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(120, 287);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(103, 50);
            this.buttonReload.TabIndex = 10;
            this.buttonReload.Text = "Restock Low Items";
            this.buttonReload.UseVisualStyleBackColor = true;
            // 
            // buttonProductInfo
            // 
            this.buttonProductInfo.Location = new System.Drawing.Point(229, 287);
            this.buttonProductInfo.Name = "buttonProductInfo";
            this.buttonProductInfo.Size = new System.Drawing.Size(103, 50);
            this.buttonProductInfo.TabIndex = 13;
            this.buttonProductInfo.Text = "Check Product Info";
            this.buttonProductInfo.UseVisualStyleBackColor = true;
            // 
            // BadAndBoujieProductMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 343);
            this.Controls.Add(this.buttonProductInfo);
            this.Controls.Add(this.buttonReload);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.radioButtonProducts);
            this.Controls.Add(this.radioButtonUsers);
            this.Controls.Add(this.buttonSaveChanges);
            this.Controls.Add(this.dataGridViewProduct);
            this.Name = "BadAndBoujieProductMenuForm";
            this.Text = "badAndBoujieProductMenuForm";
            this.Controls.SetChildIndex(this.dataGridViewProduct, 0);
            this.Controls.SetChildIndex(this.buttonSaveChanges, 0);
            this.Controls.SetChildIndex(this.radioButtonUsers, 0);
            this.Controls.SetChildIndex(this.radioButtonProducts, 0);
            this.Controls.SetChildIndex(this.buttonCheck, 0);
            this.Controls.SetChildIndex(this.buttonReload, 0);
            this.Controls.SetChildIndex(this.buttonProductInfo, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.Button buttonSaveChanges;
        private System.Windows.Forms.RadioButton radioButtonProducts;
        private System.Windows.Forms.RadioButton radioButtonUsers;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.Button buttonProductInfo;
    }
}