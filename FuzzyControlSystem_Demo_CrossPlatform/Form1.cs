using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FuzzyControlSystem_Demo_CrossPlatform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Map mymap = new Map(constructBorder(), new Rectangle(-6, 0, 12, 2), new Rectangle(18, 37, 12, 2));
            mymap.Width = 400;
            mymap.Height = 400;
            mymap.BackColor = Color.Gray;
            mappanel.Controls.Add(mymap);
        }

        private void mappanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public Point[] constructBorder()
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(-6, 0));
            points.Add(new Point(-6, 22));
            points.Add(new Point(18, 22));
            points.Add(new Point(18, 37));
            points.Add(new Point(30, 37));
            points.Add(new Point(30, 10));
            points.Add(new Point(6, 10));
            points.Add(new Point(6, 0));
            return points.ToArray();
        }

    }
}
