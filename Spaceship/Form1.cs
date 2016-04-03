using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spaceship
{
    public partial class Form1 : Form
    {
        List<PointF> arr = new List<PointF>();
        Pen pen = new Pen(Color.Red);
        Pen pen1 = new Pen(Color.Blue);
        Pen pen2 = new Pen(Color.Green);
       
        public Form1()
        {
            InitializeComponent();
            arr.Add(new PointF(0, 800));
        }

        private void paint(object sender, PaintEventArgs e)
        {
            Point p1 = new Point(80, 160);
            Point p2 = new Point(160, 110);
            Point p3 = new Point(240, 160);
            Point p4 = new Point(240, 230);
            Point p5 = new Point(160, 280);
            Point p6 = new Point(80, 230);
            e.Graphics.DrawLine(pen, p1, p2);
            e.Graphics.DrawLine(pen, p2, p3);
            e.Graphics.DrawLine(pen, p3, p4);
            e.Graphics.DrawLine(pen, p4, p5);
            e.Graphics.DrawLine(pen, p5, p6);
            e.Graphics.DrawLine(pen, p6, p1);

            SolidBrush brush = new SolidBrush(Color.Blue);
            Point[] myPointArray = { new Point(100, 180), new Point(160, 140), new Point(220, 180), new Point(190,180), new Point(190,240), new Point(130,240), new Point(130,180) };
            e.Graphics.FillPolygon(brush, myPointArray);

            SolidBrush brush1 = new SolidBrush(Color.Green);
            e.Graphics.FillEllipse(brush1, 20, 20, 30, 30);
            e.Graphics.FillEllipse(brush1, 240, 240, 30, 30);
            e.Graphics.FillEllipse(brush1, 300, 120, 30, 30);
            e.Graphics.FillEllipse(brush1, 400, 50, 30, 30);

            SolidBrush brush2 = new SolidBrush(Color.Yellow);
            Point[] Pointarr = { new Point(80, 30), new Point(90, 60), new Point(110,60), new Point(95, 70), new Point(100, 90), new Point(80, 70), new Point(60, 90), new Point(65, 70), new Point(50, 60), new Point(70,60) };
            e.Graphics.FillPolygon(brush2, Pointarr);
            Point[] Pointarr2 = { new Point(300, 270), new Point(310, 300), new Point(330, 300), new Point(315, 310), new Point(320, 330), new Point(300, 310), new Point(280, 330), new Point(285, 310), new Point(270, 300), new Point(290, 300) };
            e.Graphics.FillPolygon(brush2, Pointarr2);
            Point[] Pointarr3 = { new Point(420, 380), new Point(430, 410), new Point(450, 410), new Point(435, 420), new Point(440, 440), new Point(420, 420), new Point(400, 440), new Point(405, 420), new Point(390, 410), new Point(410, 410) };
            e.Graphics.FillPolygon(brush2, Pointarr3);
        }

    }
}
