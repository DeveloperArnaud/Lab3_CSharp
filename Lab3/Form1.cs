using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radio_dhToEuro.Checked = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            labelEuro.Text = "dh =";
            labelDh.Text = "euro";
        }

        private void convertBtn_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textConvert.Text))
            {
                MessageBox.Show("Error: Input cannot be empty", "Convert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            } else if(!radio_euroToDh.Checked && !radio_dhToEuro.Checked)
            {
                MessageBox.Show("Error: Please check a option", "Convert Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(radio_dhToEuro.Checked)
                {
                    amountText.Text = Convert.ToString(Convert.ToDouble(textConvert.Text) * 10.64);

                } else if(radio_euroToDh.Checked)
                {

                    amountText.Text = Convert.ToString(Convert.ToDouble(textConvert.Text) * 0.094);
                }

            }

        }

        private void radioGroup_Enter(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            amountText.Text = "";
            textConvert.Text = "";
            
        }

        private void radio_euroToDh_CheckedChanged(object sender, EventArgs e)
        {
            labelEuro.Text = "euro =";
            labelDh.Text = "dh";
        }
    }

}
