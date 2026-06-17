using PizzaProjectEnhanced.Properties;
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


        void ChoosePicSize(byte Num)
        {
            if (Num == 1)
            {

                pbPizzaPic.Image = Resources.PizzaMedium;
                
            }
            if (Num == 2)
            {
                pbPizzaPic.Image = Resources.SmallPizza;
            }
            if (Num == 3) {
                pbPizzaPic.Image = Resources.LargePizza;
            }
        }
        private double PizzaSizePrice()
        {
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                ChoosePicSize(1);
                return Convert.ToDouble(rbSmall.Tag) ;
            }else if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                ChoosePicSize(2);
                return Convert.ToDouble(rbMedium.Tag);
            }
            else
            {
                ChoosePicSize(3);
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


        void UpdateSize()
        {
            CalculateTotalPrice();
            lblPrice.Text = "$ "+TotalPricing.ToString();
        }



        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
            }
            else
            {
                lblWhereToEat.Text = "Eat Out";
            }
        }

        void UpdateCrustType()
        {
            CalculateTotalPrice();
            if (rbThinCrust.Checked)
            {
                LblCrustType.Text = "Thin Crust";
            }
            else
            {
                LblCrustType.Text = "Thick Crust";
            }
        }

        void UpdateToppings()
        {
            string MyText = "";
            
            if (chkChees.Checked)
            {
                MyText += "Chees , ";
            }
            if (chkTomatoes.Checked)
            {
                MyText += "Tomatoes ,";
            }
            if (chkOnions.Checked)
            {
                MyText += "Onions , ";
            }
            if (chkMashrooms.Checked)
            {
                MyText += "Mashrooms , ";
            }
            if (chkOlives.Checked)
            {
                MyText += "Olives , ";
            }
            if (chkGreenPappers.Checked)
            {
                MyText += "GreenPappers ,";
            }
            MyText=MyText.Trim(' ',',');
           
            if (MyText.Length < 0)
            {
                lblToppings.Text = "Nothing";
            }
            else
            {
                lblToppings.Text = MyText;
            }
            CalculateTotalPrice();

        }

                void LogicOfMenu()
                {
                    UpdateSize();
                    UpdateWhereToEat();
                    UpdateCrustType();
                    UpdateToppings();

                }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }
            
        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void chkMashrooms_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }

        private void chkGreenPappers_CheckedChanged(object sender, EventArgs e)
        {
            LogicOfMenu();
        }


        void StartTheMenu()
        {
            CalculateTotalPrice();
            rbEatIn.Checked = true;
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            
        }


        private void OrderMenu_Load(object sender, EventArgs e)
        {
            StartTheMenu();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult MyDialog = MessageBox.Show("Do You Want To Confirm This Order?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(MyDialog == DialogResult.OK)
            {
                MessageBox.Show("Enjoy It :-)","(-_-)");
                
            }
            else
            {
                MessageBox.Show("Did you Make A Mistake?", "",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
    }
}
