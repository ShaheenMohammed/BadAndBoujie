using BadAndBoujieMain.EF_Classes;
using System;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace BadAndBoujieMain
{
    public partial class BadAndBoujieShoppingCartForm : BadAndBoujieParentForm
    {
        BadAndBoujieEntities context;
        int cartID = 0;

        #region Main Form
        /// <summary>
        /// Main form
        /// </summary>
        public BadAndBoujieShoppingCartForm()
        {
            InitializeComponent();
            context = new BadAndBoujieEntities();

            #region Event Listeners
            buttonAdd.Click += ButtonAdd_Click;
            buttonRemove.Click += ButtonRemove_Click;
            buttonCheckout.Click += ButtonCheckout_Click;
            #endregion
            //do not allow editing of db directly or of cart directly without button click & verification

            //Initialize Database
            context.Database.Log = (s => Debug.Write(s));

            //New shopping cart
            cartID = context.shopping_basket.Count() + 1;

            LoadProductsTable();
            LoadCartTable();
        }
        #endregion

        #region Reload Tables Methods
        /// <summary>
        /// Load products table data
        /// </summary>
        private void LoadProductsTable()
        {
            context.SaveChanges();

            context.products.Load();
            dataGridViewProduct.DataSource = context.products.Local.ToBindingList();
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.MultiSelect = false;

            var dataProduct = context.products.Select
                (p => new { p.product_name.P_name, p.P_cat.P_cat_name, p.P_price, p.gender, p.inStock });
            dataGridViewProduct.DataSource = dataProduct.ToList();

            dataGridViewProduct.Columns[0].HeaderText = "Name";
            dataGridViewProduct.Columns[1].HeaderText = "Category";
            dataGridViewProduct.Columns[2].HeaderText = "Price";
            dataGridViewProduct.Columns[3].HeaderText = "Gender";
            dataGridViewProduct.Columns[4].HeaderText = "Quantity";

            dataGridViewProduct.Refresh();

            context.SaveChanges();
        }

        private void LoadCartTable()
        {
            context.SaveChanges();

            context.basket_contents_line.Load();
            dataGridViewCart.DataSource = context.basket_contents_line.Local.ToBindingList();
            dataGridViewCart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCart.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCart.MultiSelect = false;

            /*
            var dataCart = (from basket_contents_line in context.basket_contents_line
                            join shopping_basket in context.shopping_basket
                                on basket_contents_line.basket_contents_line_ID equals shopping_basket.basket_contents_line_ID
                            where  shopping_basket.shopping_basket_ID == cartID
                            select new
                            {
                                basket_contents_line.product.product_name.P_name,
                                basket_contents_line.quantity,
                                basket_contents_line.product.P_price
                            });
            */
            var dataCart = (from basket_contents_line in context.basket_contents_line
                            select new
                            {
                                basket_contents_line.product.product_name.P_name,
                                basket_contents_line.quantity,
                                basket_contents_line.product.P_price
                            });

            dataGridViewCart.DataSource = dataCart.ToList();
            
            dataGridViewCart.Columns[0].HeaderText = "Product";
            dataGridViewCart.Columns[1].HeaderText = "Quantity";
            dataGridViewCart.Columns[2].HeaderText = "Price";

            dataGridViewCart.Refresh();

            context.SaveChanges();
        }
        #endregion

        #region Text Box Clearing
        /// <summary>
        /// Clear text boxes
        /// </summary>
        private void ClearTextBoxes()
        {
            textBoxAddAmount.Clear();
            textBoxRemoveAmount.Clear();
        }
        #endregion

        #region Update Costs
        //Update total costs in labels
        private void UpdateCost()
        {
            double subtotal = 0, tax = 0, total = 0;
            /*
            var cartItemsQuery = (from shopping_basket in context.shopping_basket
                                  join basket_contents_line in context.basket_contents_line
                                    on shopping_basket.basket_contents_line_ID equals basket_contents_line.basket_contents_line_ID
                                  where shopping_basket.shopping_basket_ID == cartID
                                  select basket_contents_line.product.P_price);
            */
            var cartItemsQuery = (from basket_contents_line in context.basket_contents_line
                                  select new
                                  {
                                      basket_contents_line.quantity,
                                      basket_contents_line.product.P_price
                                  });

            foreach (var item in cartItemsQuery)
                subtotal += ((double)item.quantity * double.Parse(item.P_price));

            tax = 0.12 * subtotal;
            total = tax + subtotal;

            labelDisplayCost.Text = subtotal.ToString("C");
            labelDisplayTax.Text = tax.ToString("C");
            labelDisplayTotal.Text = total.ToString("C");
        }
        #endregion

        /// <summary>
        /// Accept cart items and procede to checkout
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCheckout_Click(object sender, EventArgs e)
        {
            //Check items added to cart
            //Amounts in labels are automatically updated every time something is added to the cart

            //add new rows to shopping basket 
            //NEW TABLE IS NEEDED b/c many to many realtionship with sbID and bclID
            //get customer ID & date
        }

        #region Remove from Cart
        /// <summary>
        /// Remove selected item(s) from the shopping cart 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            //check for selected value in cart dgv
            var selectedRowCart = dataGridViewCart.SelectedRows[0].Index;
            var selectedCartItem = dataGridViewCart.Rows[selectedRowCart].Cells[0].Value.ToString();

            //an item is selected by default don't have to check
            //check if the amount entered is an integer
            try
            {
                int removeAmount = int.Parse(textBoxRemoveAmount.Text.Trim());

                //check if rem-quantity > quantity
                //get quantity
                int selectedItemQuantity = int.Parse(dataGridViewCart.Rows[selectedRowCart].Cells[1].Value.ToString());

                //get product ID
                var PIDQuery = (from product_name in context.product_name
                                where product_name.P_name == selectedCartItem
                                select product_name.P_ID);

                string productID = "";
                foreach (var item in PIDQuery.ToList())
                    productID = item;

                //compare stock and quantity
                if (removeAmount > selectedItemQuantity)
                {
                    MessageBox.Show("There is not enough in your cart, please choose a smaller amount to remove");
                }
                else if (removeAmount <= 0)
                {
                    MessageBox.Show("Please choose an amount larger than ZERO");
                }
                else
                {
                    //remove from cart
                    foreach(var cartItem in context.basket_contents_line)
                    {
                        foreach (var c in PIDQuery)
                        {
                            if (c == cartItem.P_ID)
                                cartItem.quantity -= removeAmount;
                        }
                    }

                    //add to products
                    foreach (var productItem in context.products)
                    {
                        foreach (var p in PIDQuery)
                        {
                            if (p == productItem.P_ID)
                                productItem.inStock += removeAmount;
                        }
                    }

                    LoadCartTable();
                    LoadProductsTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount");
            }

            ClearTextBoxes();
            UpdateCost();

            //check for entered amount to add
            //check for amount validity (number, amount is available to add, etc)
            //add to cart, remove from products dgv
            //refresh & stuff
            //check for selected value in cart dgv
            //check for an entered amount to remove
            //remove from cart & refresh & save changes (idk)
        }
        #endregion

        #region Add to Cart
        /// <summary>
        /// Add item(s) to the shopping cart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //check for selected value in products dgv
            var selectedRow = dataGridViewProduct.SelectedRows[0].Index;
            var selectedProduct = dataGridViewProduct.Rows[selectedRow].Cells[0].Value.ToString();

            //an item is selected by default don't have to check
            //check if the amount entered is an integer
            try
            {

                int addAmount = int.Parse(textBoxAddAmount.Text.Trim());

                //check if quantity > stock
                //get stock
                var stockQuery = (from product in context.products
                                  where product.product_name.P_name == selectedProduct
                                  select product.inStock);

                int amountInStock = -1;
                foreach (var item in stockQuery.ToList())
                    amountInStock = item;

                //get product ID
                var PIDQuery = (from product_name in context.product_name
                                where product_name.P_name == selectedProduct
                                select product_name.P_ID);

                string productID = "";
                foreach (var item in PIDQuery.ToList())
                    productID = item;

                //compare stock and quantity
                if (addAmount > amountInStock)
                {
                    MessageBox.Show("There is not enough in stock, please choose smaller amount");
                }
                else if (addAmount <= 0)
                {
                    MessageBox.Show("Please choose an amount larger than ZERO");
                }
                else
                {
                    //find how many rows are in the table
                    int numCartRows = dataGridViewCart.Rows.Count;

                    //add to cart
                    basket_contents_line newRow = new basket_contents_line
                    {
                        basket_contents_line_ID = context.basket_contents_line.Count(),
                        P_ID = productID,
                        quantity = addAmount

                    };

                    context.basket_contents_line.Add(newRow);
                    LoadCartTable();

                    //remove from stock
                    foreach (var item in context.products)
                    {
                        foreach (var i in PIDQuery)
                        {
                            if (i == item.P_ID)
                                item.inStock -= addAmount;
                        }
                    }

                    LoadProductsTable();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid amount");
            }

            ClearTextBoxes();
            UpdateCost();

            //check for entered amount to add
            //check for amount validity (number, amount is available to add, etc)
            //add to cart, remove from products dgv
            //refresh & stuff
        }
        #endregion
    }
}
