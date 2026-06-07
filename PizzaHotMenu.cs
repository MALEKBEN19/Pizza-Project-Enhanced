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
        
        private void btnOrder_Click(object sender, EventArgs e)
        {
            
            if (MyOrderMenu == null || MyOrderMenu.IsDisposed)
            {
                btnMenu.Enabled = true;
                btnOrder.Enabled = false;
                MyOrderMenu=new OrderMenu();
                MyOrderMenu.Show();
                MyOrderMenu.BringToFront();
                
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
            MyOrderMenu.Close(); 
           
            
        }


    }
}
