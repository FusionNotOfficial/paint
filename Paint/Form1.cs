using System;
using System.Drawing;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Boolean cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;
        Button previousClick;
        int brushSize = 7;

        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, brushSize);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }

        private void black_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
            ColorUse.BackColor = cursorPen.Color;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;
        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.FlatAppearance.BorderColor = Color.Gray;
            if(previousClick != null && previousClick != button)
            {
                previousClick.FlatAppearance.BorderColor = Color.White;
            }
            switch(button.Name)
            {
                case "btn1":
                    brushSize = 1;
                    break;
                case "btn2":
                    brushSize = 3;
                    break;
                case "btn3":
                    brushSize = 5;
                    break;
                case "btn4":
                    brushSize = 8;
                    break;
                case "btn5":
                    brushSize = 10;
                    break;
                case "btn6":
                    brushSize = 12;
                    break;
                case "btn7":
                    brushSize = 14;
                    break;
                case "btn8":
                    brushSize = 16;
                    break;
            }
            cursorPen = new Pen(Color.Black, brushSize);
            cursorPen.Color = ColorUse.BackColor;
            previousClick = button;
        }
    }
}
