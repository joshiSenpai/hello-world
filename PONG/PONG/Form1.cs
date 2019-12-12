using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace PONG
{
    public partial class Form1 : Form
    {
        PongGame p;
        public Form1()
        {
            InitializeComponent();
            p = new PongGame((Size)this.ClientSize);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.FillRectangle(Brushes.BlueViolet, p2.r);
            e.Graphics.FillRectangle(Brushes.BlueViolet, p1.r);
        }
    }
    }

    

        
        
