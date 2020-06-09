using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using BadAndBoujieMain.EF_Classes;

namespace BadAndBoujieMain
{
    public partial class BadAndBoujieProductMenuForm : BadAndBoujieParentForm
    {
       BadAndBoujieEntities context;
        public BadAndBoujieProductMenuForm()
        {
            context = new BadAndBoujieEntities();
            InitializeComponent();


            InitializeDataGridView();
            LoadContext();
            SaveChanges();

            buttonSaveChanges.Click += ButtonSaveChanges_Click;
            radioButtonProducts.CheckedChanged += RadioButtonProducts_CheckedChanged;
            radioButtonUsers.CheckedChanged += RadioButtonPeople_CheckedChanged;
            buttonReload.Click += ButtonReload_Click; buttonCheck.Click += ButtonCheck_Click;
            buttonProductInfo.Click += ButtonProductInfo_Click;
            dataGridViewProduct.RowLeave += DataGridViewProduct_RowLeave;
            dataGridViewProduct.RowEnter+= DataGridViewProduct_RowEnter;

        }

 

        private void DataGridViewProduct_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                SaveChanges();}

            
            catch ( Exception a )
            {

                MessageBox.Show(a.Source.ToString());
            }
        }

        private void DataGridViewProduct_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                SaveChanges();
            }



            catch (Exception a)
            {

                MessageBox.Show(a.Source);
            }
        }

        private void ButtonProductInfo_Click(object sender, EventArgs e)
        {
            string findProduct = dataGridViewProduct.SelectedCells[0].Value.ToString();
            string findCategory = dataGridViewProduct.SelectedCells[2].Value.ToString();

            var productInfoQuery = context.products
                .Where(p => p.P_ID == findProduct)
                .ToList();

            var productInfoQuery2 = context.product_name
                .Where(p => p.P_ID == findProduct)
                .ToList();

            var productInfoQuery3 = context.P_cat
                .Where(p => p.P_cat_ID == findCategory)
                .ToList();

                MessageBox.Show(
                                     "Product ID:  " + productInfoQuery[0].P_ID +
                                     "\nProduct Name:  " + productInfoQuery2[0].P_name +
                                     "\nProduct Category:" + productInfoQuery3[0].P_cat_name +
                                     "\nGender:  " + productInfoQuery[0].gender+
                                     "\nProduct Stock:" + productInfoQuery[0].inStock +
                                     "\nProduct Price:  " + productInfoQuery[0].P_price +
                                     "\nProduct Discount:  " + productInfoQuery[0].P_sale
                                     );
            
        
        }

        private void ButtonCheck_Click(object sender, EventArgs e)
        {
            string productId = dataGridViewProduct.SelectedCells[0].Value.ToString();
            var checkQuantityQuery = context.products
                .Select(p => p)
                .Where(p => p.P_ID == productId)
                .Select(p=>p.inStock);
            foreach (var item in checkQuantityQuery)
            {
                MessageBox.Show("You Have " + item);
            }
            
        }

        private void ButtonReload_Click(object sender, EventArgs e)
        {
            var query =context.products.Select(p => p)
                .Where(p => p.inStock < 5)
                .Select(p => p.P_ID).ToList();
            foreach (var item in context.products)
            {
                foreach (var item1 in query)
                {
                    if (item1==item.P_ID)
                    {
                        item.inStock += 50;
                    }
                }
                
            }
            SaveChanges();
        }

        private void RadioButtonPeople_CheckedChanged(object sender, EventArgs e)
        {
            buttonCheck.Click -= ButtonCheck_Click;
            buttonReload.Click -= ButtonReload_Click;
            buttonProductInfo.Click -= ButtonProductInfo_Click;
            InitializeDataGridView();
        }
        private void RadioButtonProducts_CheckedChanged(object sender, EventArgs e)
        {
            buttonCheck.Click -= ButtonCheck_Click;
            buttonReload.Click -= ButtonReload_Click;
            buttonProductInfo.Click -= ButtonProductInfo_Click;
            InitializeDataGridView();
        }

        private void LoadContext()
        {
            context.Database.Log = (s => Debug.Write(s));
            context.products.Load();
            context.people.Load();
            radioButtonProducts.Checked = true;
            InitializeDataGridView();
          
        }





    
            private void InitializeDataGridView()
        {
            SaveChanges();

            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (radioButtonProducts.Checked == true)
            {

                context.product_name.Load();
               

                dataGridViewProduct.DataSource = context.products.Local.ToBindingList();
                dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridViewProduct.Columns[0].HeaderText = "ID";
                dataGridViewProduct.Columns[5].HeaderText = "Price";
                dataGridViewProduct.Columns[6].HeaderText = "Discount";


                dataGridViewProduct.Columns[1].Visible = false;
                dataGridViewProduct.Columns[2].Visible = false;
                dataGridViewProduct.Columns[3].Visible = false;
                dataGridViewProduct.Columns[4].Visible = false;
                dataGridViewProduct.Columns[7].Visible = false;
                dataGridViewProduct.Columns[8].Visible = false;
                dataGridViewProduct.Columns[9].Visible = false;
                dataGridViewProduct.Columns[10].Visible = false;



            }

            else
            {
                dataGridViewProduct.DataSource = context.people.Local.ToBindingList();
                dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.CellSelect;
                dataGridViewProduct.Columns[0].HeaderText = "ID";
                dataGridViewProduct.Columns[1].HeaderText = "First Name";
                dataGridViewProduct.Columns[2].HeaderText = "Last Name";
                dataGridViewProduct.Columns[3].HeaderText = "Phone";
                dataGridViewProduct.Columns[4].HeaderText = "Address";
                dataGridViewProduct.Columns[5].HeaderText = "Username";
                dataGridViewProduct.Columns[6].HeaderText = "Password";
                dataGridViewProduct.Columns[7].HeaderText = "Person Type";



                dataGridViewProduct.Columns[8].Visible = false;
                dataGridViewProduct.Columns[9].Visible = false;
            }
            SaveChanges();


        }

      
    

        /// <summary>
        /// save changes button saves and refreshes changes to database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonSaveChanges_Click(object sender, EventArgs e)
        {
            SaveChanges();
            MessageBox.Show("Saved Changes");


        }

        private void SaveChanges()
        {
            try
            {
                context.SaveChanges();
                dataGridViewProduct.Refresh();
            }
            catch (Exception error)
            {

                MessageBox.Show(error.Source.ToString());
            }
        }
    }
}
