using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circle.Rect
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
            Brush stift = Brushes.Black;
            Rectangle viereck = new Rectangle((this.ClientSize.Width/2 -50), (this.ClientSize.Height/2 -50), (this.ClientSize.Width * 1), (this.ClientSize.Height * 1));
            graphics.FillRectangle(stift, viereck);

            Brush stiftkreis = Brushes.White;
            Rectangle kreis = new Rectangle((this.ClientSize.Width /2 -25), (this.ClientSize.Height /2 -25), 50, 50);
            graphics.FillEllipse(stiftkreis, kreis);
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_ClientSizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
