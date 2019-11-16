using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Click(object sender, EventArgs e)
        {
            int value = int.Parse(tb1.Text);
            int value2 = int.Parse(tb2.Text);
            if (Convert.ToInt32(value2) < 0)
            {
                lb2.Text = "Отрицательное число ввели";
                tb2.Text = " ";
            }
            else
            {
                var otv = (value2 / value);
                tb3.Text = Convert.ToString(otv);
            }
        }

    }
}
