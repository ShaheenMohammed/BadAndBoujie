using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadAndBoujieMain
{
    public partial class BadAndBoujieParentForm : Form
    {
        public BadAndBoujieParentForm()
        {
            InitializeComponent();
            logOffToolStripMenuItem.Click += LogOffToolStripMenuItem_Click;
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            productMenuToolStripMenuItem.Click += ProductMenuToolStripMenuItem_Click;
            shoppingCartToolStripMenuItem.Click += ShoppingCartToolStripMenuItem_Click;
            
        }

  

        private void ShoppingCartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BadAndBoujieShoppingCartForm shoppingCart = new BadAndBoujieShoppingCartForm();
            shoppingCart.Visible = true;
        }

        private void ProductMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BadAndBoujieProductMenuForm productMenu = new BadAndBoujieProductMenuForm();
            if (this.Name == productMenu.Name)
            {
                MessageBox.Show("Your delusional ass needs to stop pressing that button.....");


            }
            else
            {
                this.Visible = false;
                productMenu.Visible = true;

            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LogOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            BadAndBoujieLoginForm login = new BadAndBoujieLoginForm();
            login.Visible = true;
        }

        public void HideMenuItemsLoginForm()
        {
            shoppingCartToolStripMenuItem.Visible=false;
            logOffToolStripMenuItem.Visible=false;
            productMenuToolStripMenuItem.Visible=false;

        }


    }
}
