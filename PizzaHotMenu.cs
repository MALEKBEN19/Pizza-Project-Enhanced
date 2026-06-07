using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectEnhanced
{
    public partial class PizzaHotMenu : Form
    {
        public PizzaHotMenu()
        {
            InitializeComponent();
            btnMenu.Enabled = false;
            btnOrder.Enabled = true;
            btnContact.Enabled = true;
        }
        OrderMenu MyOrderMenu = null;
        frmContact MyContact = null;
        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            if (MyOrderMenu == null || MyOrderMenu.IsDisposed)
            {
                btnMenu.Enabled = true;
                btnOrder.Enabled = false;
                MyOrderMenu=new OrderMenu();
                MyOrderMenu.Show();
                MyOrderMenu.BringToFront();
                if (MyContact!=null&&!MyContact.IsDisposed)
                {
                    MyContact.Close();
                }

            }
            else
            {
                
                    MyOrderMenu.BringToFront();
              
                
            }



        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
             btnMenu.Enabled=false;
            btnOrder.Enabled = true;
            btnContact.Enabled=true;
            if (MyContact != null && !MyContact.IsDisposed)
            {
                MyContact.Close();
            }
            if (MyOrderMenu != null && !MyOrderMenu.IsDisposed)
            {
                MyOrderMenu.Close();
            }
           
           
            
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            if (MyContact == null || MyContact.IsDisposed)
            {
                btnContact.Enabled = false;
                btnMenu.Enabled = true;
                btnOrder.Enabled = true;
                MyContact = new frmContact();
                MyContact.Show();
                MyContact.BringToFront();
                if (MyOrderMenu != null&&!MyOrderMenu.IsDisposed)
                {
                    MyOrderMenu.Close();
                }

            }
            else
            {
                MyContact.BringToFront();
            }
        }
    }
}
