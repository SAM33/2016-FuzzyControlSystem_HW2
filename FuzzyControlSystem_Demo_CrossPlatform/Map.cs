using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace FuzzyControlSystem_Demo_CrossPlatform
{
    class Map : PictureBox
    {
        int scale = 5;
        Point[] _borderpoints;
        Rectangle _startarea;
        Rectangle _endarea;

        public Map(Point[] BorderPoints, Rectangle StartArea, Rectangle EndArea)
        {
            _borderpoints = BorderPoints;
            _startarea = StartArea;
            _endarea = EndArea;
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            Graphics g = pe.Graphics;

            // Rectangle rect = new Rectangle(-6, 0, 30, 37);
            //g.DrawEllipse(Pens.Black, rect);
            //g.DrawRectangle(Pens.Black, rect);
            g.ScaleTransform(scale, scale);
            if (_borderpoints.Length >= 2)
            {
                Point p = _borderpoints[0];
                for (int i = 1; i < _borderpoints.Length; i++)
                {
                    g.DrawLine(Pens.Black, mapPoint(p), mapPoint(_borderpoints[i]));
                    p = _borderpoints[i];
                }
                g.DrawLine(Pens.Black, mapPoint(_borderpoints[0]), mapPoint(p));
            }
            g.DrawRectangle(Pens.Red, mapRectangle(_endarea));
            g.DrawRectangle(Pens.Blue, mapRectangle(_startarea));




        }

        protected Point mapPoint(Point p)
        {
            return mapPoint(p.X, p.Y);
        }
        protected Point mapPoint(int x, int y)
        {
            Point r = new Point(x + this.Width / scale / 2, this.Height / scale - y - this.Height / scale / 2);
            return r;
        }
        protected Rectangle mapRectangle(Rectangle rect)
        {
            return mapRectangle(rect.X, rect.Y, rect.Width, rect.Height);
        }

        protected Rectangle mapRectangle(int x, int y, int width, int height)
        {
            Point p = mapPoint(x, y);
            Rectangle r = new Rectangle(p.X, p.Y, width, height);
            return r;

        }

    }

    class MapEventArgs : EventArgs
    {

    }
}
