using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Animation_J.M
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);
            Graphics graphics = e.Graphics;
            Pen rectaglePen = Pens.Black;
            Rectangle rectangle = new Rectangle(10, 20, 10, 10);
            //graphics.DrawRectangle(rectaglePen, rectangle);
            graphics.DrawRectangle(rectaglePen, (this.ClientSize.Width / 2 - 50), (this.ClientSize.Height / 2 - 50), 10, 10);
        }
    }
}
