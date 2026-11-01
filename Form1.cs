using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
      


        public Form1()
        {
            InitializeComponent();
        }

        void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + CalculateTotalPrice().ToString() ;
        }
        void UpdateSize()
        {

            UpdateTotalPrice();

            if (rdoSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rdoMeduim.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }

            if (rdoLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gbSize_Enter(object sender, EventArgs e)
        {

        }

        private void rdoSmall_UpdateSizeAndPrice(object sender, EventArgs e)
        {

            
            
 
        }

        private void rdoMeduim_UpdateSizeAndPrice(object sender, EventArgs e)
        {


        }

        private void rdoLarge_UpdateSizeAndPrice(object sender, EventArgs e)
        {
   

        }

        int GetSelectedSizePrice()
        {
            if (rdoSmall.Checked)
            {
                return Convert.ToInt32(rdoSmall.Tag);
            }
            else if (rdoMeduim.Checked)
            {
                return Convert.ToInt32(rdoMeduim.Tag);
            }
            else 
            {
                return Convert.ToInt32(rdoLarge.Tag);
            }

        }

        int CalculateToppingsPrice()
        {
            int ToppingsTotalPrice = 0;

            if (chkExtraChees.Checked)
            {
                ToppingsTotalPrice += Convert.ToInt32(chkExtraChees.Tag);
            }


            if (chkOnion.Checked)
            {
                ToppingsTotalPrice += Convert.ToInt32(chkOnion.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToInt32(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToInt32(chkOlives.Tag);
            }

            if (chkTomatoes.Checked)
            {
                ToppingsTotalPrice += Convert.ToInt32(chkTomatoes.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToInt32(chkGreenPeppers.Tag);
            }



            return ToppingsTotalPrice;
        }

        int GetSelectedCrustPrice()
        {
            if (rdoThin.Checked)
                return Convert.ToInt32(rdoThin.Tag);

            else
                return Convert.ToInt32(rdoThick.Tag);
        }
        int CalculateTotalPrice()
        {
            

            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
            

        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string sToppings = "";

            if (chkExtraChees.Checked)
            {
                sToppings = "Extra Chees";
            }


            if (chkOnion.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }

            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }

            if (chkTomatoes.Checked)
            {
                sToppings += ", Tomatos";
            }

            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppars";
            }

            if (sToppings.StartsWith(","))
            {
                sToppings = sToppings.Substring(1, sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
            {
                sToppings = "No Toppings";
            }

            lblToppings.Text = sToppings;
        }
        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {

            UpdateToppings();
        }

        private void rdoEatIn_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereEat.Text = rdoEatIn.Text;
        }



        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rdoThin.Checked)
            {
                lblCrustType.Text = "Thin";
                return;
            }

            if (rdoThick.Checked)
            {
                lblCrustType.Text = "Thick";
                return;
            }
        }
        private void rdoThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdoThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void gbWhereToEat_Enter(object sender, EventArgs e)
        {
            lblWhereEat.Text = "Eat in";
        }

        private void rdoTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            lblWhereEat.Text = "Take away";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm", "Are u sure? ", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                MessageBox.Show("Success", "Order Placed succusfuly", MessageBoxButtons.OK);

                button1.Enabled = false;
                gbCrust.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;
            }
            else
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            gbCrust.Enabled = true;
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;

            foreach (CheckBox c in gbToppings.Controls)
            {
                c.Checked = false;
                
            }

            rdoMeduim.Checked = true;

            rdoThin.Checked = true;

            rdoEatIn.Checked = true;

            
        }

 
        private void rdoSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();

        }

        private void rdoMeduim_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rdoLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
