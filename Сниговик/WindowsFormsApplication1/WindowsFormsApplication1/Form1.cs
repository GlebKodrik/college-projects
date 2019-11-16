using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(new SolidBrush(Color.Pink), new Rectangle(65, 10, 40, 42));
            e.Graphics.FillEllipse(new SolidBrush(Color.Pink), new Rectangle(55, 45, 60, 65));
            e.Graphics.FillEllipse(new SolidBrush(Color.Pink), new Rectangle(45, 100, 80, 88));
            e.Graphics.FillPolygon(new SolidBrush(Color.Orange), new[] {
                new PointF(90, 25),
                new PointF(120, 30),
                new PointF(90, 35)
            }
            );
            e.Graphics.FillPolygon(new SolidBrush(Color.Black), new[] {
                new PointF(55, 75),
                new PointF(10, 75),
                new PointF(11, 75)
            }
);
        }
    }
}
