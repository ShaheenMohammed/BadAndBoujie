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
    public partial class BadAndBoujieLoginForm : BadAndBoujieParentForm
    {
        BadAndBoujieEntities context;
        public BadAndBoujieLoginForm()
        {
            context = new BadAndBoujieEntities();
            InitializeComponent();
            HideMenuItemsLoginForm();
            buttonLogin.Click += ButtonLogin_Click;
                
        }

        /// <summary>
        /// Purpose: method checks for valid username and password pairs by crosschecking the database for valid pairs
        /// invalid pairs prompts user to enter valid pairs and erases texts from both textboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            context.people.Load();

            var login = context.people.SingleOrDefault(p=>p.Per_usrn==textBoxLoginFormUserName.Text).Per_usrn.ToString();
           
            var password = context.people.SingleOrDefault(p => p.Per_PW == textBoxLoginFormPassword.Text).Per_PW.ToString();
            if (textBoxLoginFormUserName.Text == login && textBoxLoginFormPassword.Text == password)
            {
                BadAndBoujieShoppingCartForm shoppingCart = new BadAndBoujieShoppingCartForm();
                this.Visible = false;
                shoppingCart.Visible = true;
              
            }
            else
            {
                MessageBox.Show("invalid username and password");
                textBoxLoginFormPassword.Text = "";
                textBoxLoginFormPassword.Text = "";

            }
        }

     
    }
}
