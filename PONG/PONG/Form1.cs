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
          private System.Timers.Timer aTimer;
        PongGame g;

        public Form1()
        {
            InitializeComponent();
            g = new PongGame((Size)this.ClientSize);

            // Create a timer with a two second interval.
            aTimer = new System.Timers.Timer();
            aTimer.Interval = 10;
            
            aTimer.Elapsed += OnTimedEvent; // Add event handler
            aTimer.Enabled = true; // Start the timer
        }

        private void OnTimedEvent(Object source, System.Timers.ElapsedEventArgs e)
        {
            if (g.stopGame > 0)
            {
                // Start game again
                g.stopGame = 0;
                aTimer.Interval = 10;
                g.resetBall();
            }

            g.update_pos(); // Update player and ball positions

            if (g.stopGame > 0)
            {
                // Stop the game and display the score
                aTimer.Enabled = false;
                aTimer.Interval = 2000;
                aTimer.Enabled = true;
            }

            this.Invalidate();
        }

        private void PongForm_KeyDown(object sender, KeyEventArgs e)
        {
            g.update_key(e, true);
        }

        private void PongForm_KeyUp(object sender, KeyEventArgs e)
        {
            g.update_key(e, false);
        }

        private void PongForm_Paint(object sender, PaintEventArgs e)
        {
            g.paint(e);
            scoreLabel.Text = String.Format("Player 1 v Player 2\r\n       {0} - {1}", g.player1Score, g.player2Score);
            scoreLabel.Visible = (g.stopGame > 0);
        }
    }
    }

    

        
        
