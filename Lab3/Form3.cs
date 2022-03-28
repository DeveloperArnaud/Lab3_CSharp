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
    public partial class Form3 : Form
    {
        List<string> leftListL;
        List<string> rightListL;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            leftListL = new List<string>();
            leftListL.Add("Language C");
            leftListL.Add("Language C#");
            leftListL.Add("Language Java");
            leftListL.Add("HTML");
            leftListL.Add("CSS");
            leftListL.Add("JavaScript");
            leftListL.Add("Python");
            leftListLang.Items.AddRange(leftListL.ToArray());
            rightListL = new List<string>();

        }

        private void btn_ToRight_Click(object sender, EventArgs e)
        {
            int index = leftListLang.SelectedIndex;
            Console.WriteLine(index);
            rightListLang.Items.Add(leftListL.ElementAt(index));
            leftListL.RemoveAt(index);
            leftListLang.Items.RemoveAt(index);

        }
    }
}
