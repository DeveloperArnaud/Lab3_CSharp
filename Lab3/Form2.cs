using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        double totalPrice = 0;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            List<string> classList = new List<string>();
            classList.Add("First Class");
            classList.Add("Second Class");
            lb_typeTicket.DataSource = classList;

            List<string> sales = new List<string>();
            sales.Add("");
            sales.Add("Youth Card");
            sales.Add("Adult Card");
            sales.Add("Family Card");
            reduction_cb.DataSource = sales;
            reduction_cb.SelectedIndex = 0;

            txt_tva.Text = "20%";
            txt_tva.Enabled = false;
            txt_priceHT.Enabled = false;
            txt_priceTTC.Enabled = false;
        }

        private void calculateBtn_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txt_basePrice.Text))
            {
                string selectedClass = lb_typeTicket.GetItemText(lb_typeTicket.SelectedItem);
                double basicPrice = Convert.ToDouble(txt_basePrice.Text);
                if(selectedClass.Equals("First Class"))
                {
                    totalPrice += basicPrice + (basicPrice * 0.20);
                } else
                {
                    totalPrice += basicPrice;
                }
                string selectedReduc = reduction_cb.GetItemText(reduction_cb.SelectedItem);

                switch(selectedReduc)
                {
                    case "Youth Card":
                        totalPrice *= 0.40;
                        break;
                    case "Adult Card":
                        totalPrice *= 0.30;
                        break;
                    case "Family Card":
                        totalPrice *= 0.50;
                        break;
                }

                txt_priceHT.Text = Convert.ToString(totalPrice);

                double prixTTC = totalPrice + (totalPrice * 0.20);
                txt_priceTTC.Text = Convert.ToString(prixTTC);

                if(!String.IsNullOrEmpty(txt_priceTTC.Text))
                {
                    calculateBtn.Enabled = false;
                }


            }
            else
            {
                MessageBox.Show("Tous les champs doivent êtres remplis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            txt_priceHT.Text = "";
            txt_priceTTC.Text = "";
            totalPrice = 0;
            txt_basePrice.Text = "";

            if(String.IsNullOrEmpty(txt_priceTTC.Text))
            {
                calculateBtn.Enabled = true;
                reduction_cb.SelectedIndex = 0;
                lb_typeTicket.SelectedIndex = 0;

            }

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
