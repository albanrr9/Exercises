using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace Drawing_with_a_Turtle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            for (int i = 0; i < 6; i++)
            {
                Turtle.Forward(100);
                Turtle.Rotate(60);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            Turtle.PenColor = Color.Green;
            for (int i = 0; i < 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            var step = 10;
            for (int i = 0; i < 20; i++)
            {
                Turtle.Forward(step);
                Turtle.Rotate(60);
                step += 10;
            }
        }

        private void buttonSun_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            Turtle.PenColor = Color.Orange;
            Turtle.Forward(125);
            Turtle.Rotate(170);
            for (int i = 0; i < 35; i++)
            {
                Turtle.Forward(250);
                Turtle.Rotate(170);
            }
            Turtle.Forward(125);
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 50;
            Turtle.PenColor = Color.Red;
            var j = 0;
            var step = 10;
            while (j < 3) {
                for (int i = 0; i < 21; i++)
                {
                    Turtle.Forward(step);
                    Turtle.Rotate(120);
                    step += 10;
                }
                step = 10;
                Turtle.Rotate(120);
                j++;
            }
        }
    }
}
