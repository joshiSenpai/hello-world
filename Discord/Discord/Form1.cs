using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Discord
{
    public partial class Form1 : Form
    {
        Timer myTimer;
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 1000;
            myTimer.Start();
        }

        private void TimerEventProcessor(Object myobject, EventArgs myEventArgs)
        {
            //bewegung pro 10 tick nach rechts
            i = i + 10; 
            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            
            base.OnPaint(e);

            Graphics grafic = e.Graphics;
            Pen stiftv = Pens.Black;
            Rectangle viereck = new Rectangle((this.ClientSize.Width/2 - 50 + i),(this.ClientSize.Height/2 -50), 100, 100);
            grafic.DrawRectangle(stiftv, viereck);


            Brush stiftk = Brushes.Red;
            Rectangle kreis = new Rectangle((this.ClientSize.Width / 2 - 25 + i), (this.ClientSize.Height / 2 - 25), 50, 50);
            grafic.FillEllipse(stiftk, kreis);
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
