using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Закрыть", "Закрыть обоссоное окно?", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < ClientRectangle.Width; i+= Properties.Resources.Без_названия.Width)
            {
                for (int j = 0; j < ClientRectangle.Height; j += Properties.Resources.Без_названия.Height)
                {
                    e.Graphics.DrawImage(Properties.Resources.Без_названия, i, j);
                }
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            var grap = Graphics.FromHwnd(this.Handle);
            grap.DrawImage(Properties.Resources._123, e.X - Properties.Resources._123.Width / 2, e.Y - Properties.Resources._123.Height / 2);
        }
    }
}
