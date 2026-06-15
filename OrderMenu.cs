using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaProjectEnhanced
{
    public partial class OrderMenu : Form
    {
        public OrderMenu()
        {
            InitializeComponent();
        }
        double TotalPricing = 0;
        private double PizzaSizePrice()
        {
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return Convert.ToDouble(rbSmall.Tag) ;
            }else if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return Convert.ToDouble(rbMedium.Tag);
            }
            else
            {
                lblSize.Text = "Large";
                return Convert.ToDouble(rbLarge.Tag);
            }

        }

        private double CrustTypePricing() {
            if (rbThickCrust.Checked)
            {
                
                return Convert.ToDouble(rbThickCrust.Tag);
            }
            else
            {
                return Convert.ToDouble(rbThinCrust.Tag);
            }
        }

        private double ToppingsPricing()
        {
            double MyToppings = 0;
            if (chkChees.Checked)
            {
                MyToppings += Convert.ToDouble(chkChees.Tag);
            }
            if (chkMashrooms.Checked)
            {
                MyToppings += Convert.ToDouble(chkMashrooms.Tag);
            }
            if (chkTomatoes.Checked)
            {
                MyToppings += Convert.ToDouble(chkTomatoes.Tag);
            }
            if (chkOnions.Checked)
            {
                MyToppings += Convert.ToDouble(chkOnions.Tag);
            }
            if (chkOlives.Checked)
            {
                MyToppings += Convert.ToDouble(chkOlives.Tag);
            }
            if (chkGreenPappers.Checked)
            {
                MyToppings += Convert.ToDouble(chkGreenPappers.Tag);
            }
            return MyToppings;
        }
        private void CalculateTotalPrice()
        {
            TotalPricing = ToppingsPricing() + PizzaSizePrice()+CrustTypePricing();
        }


        void LogicOfMenu()
        {
            CalculateTotalPrice();
        }


        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
