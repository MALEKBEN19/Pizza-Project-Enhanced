using PizzaProjectEnhanced.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        void SetImagePizza(string MyPath)
        {
            var MyPic=Image.FromFile(MyPath);
            pbPizzaPic.Image?.Dispose();
            pbPizzaPic.Image = MyPic;
        }
 
        private double PizzaSizePrice()
        {
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                SetImagePizza(@"D:\ProgrammingAdvicesPath\Icons&Backgrounds\SmallPizza.png");
                return Convert.ToDouble(rbSmall.Tag) ;
            }
            if(rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                SetImagePizza(@"D:\ProgrammingAdvicesPath\Icons&Backgrounds\PizzaMedium.png");
                return Convert.ToDouble(rbMedium.Tag);
            }
            else
            {
                SetImagePizza(@"D:\ProgrammingAdvicesPath\Icons&Backgrounds\LargePizza.png");
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
                MyText += "Chees ,";
            }
            if (chkTomatoes.Checked)
            {
                MyText += "Tomatoes ,";
            }
            if (chkOnions.Checked)
            {
                MyText += "Onions ,";
            }
            if (chkMashrooms.Checked)
            {
                MyText += "Mashrooms ,";
            }
            if (chkOlives.Checked)
            {
                MyText += "Olives ,";
            }
            if (chkGreenPappers.Checked)
            {
                MyText += "GreenPappers ,";
            }
            MyText=MyText.Trim(' ',',');
           
            if (MyText.Length == 0)
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
           
            rbEatIn.Checked = true;
            rbSmall.Checked = true;
            rbThinCrust.Checked = true;
            chkChees.Checked = false;
            chkMashrooms.Checked = false;
            chkTomatoes.Checked = false;
            chkOnions.Checked = false;
            chkOlives.Checked = false;
            chkGreenPappers.Checked = false;
           
        }


        private void OrderMenu_Load(object sender, EventArgs e)
        {
            StartTheMenu();
        }
        void LockedBtn(bool LockedMyButtons=true)
        {
            bool Locked=!LockedMyButtons;
            btnOrder.Enabled = Locked;
            plSize.Enabled = Locked;
            plToppings.Enabled = Locked;
            plWhereToEat.Enabled = Locked;
            plCrustType.Enabled = Locked;
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            DialogResult MyDialog = MessageBox.Show("Do You Want To Confirm This Order?","Confirmation",MessageBoxButtons.OKCancel,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2);
            if(MyDialog == DialogResult.OK)
            {
                MessageBox.Show("Enjoy It :-)","(-_-)");
                LockedBtn();
            }
            else
            {
                MessageBox.Show("Did you Make A Mistake?", "",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            LockedBtn(false);
            StartTheMenu();
        }
    }
}
