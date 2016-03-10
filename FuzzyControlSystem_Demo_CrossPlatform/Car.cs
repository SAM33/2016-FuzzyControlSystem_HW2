using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace FuzzyControlSystem_Demo_CrossPlatform
{
    abstract class Car
    {
        double _x, _y;
        double _theta;
        double _end_x, _end_y;
        const double radius = 3.0;
        public Car(double start_x, double start_y, double start_theta, double end_x, double end_y)
        {

        }
        public abstract void draw(Graphics g);
        public abstract double decide(double x, double y, double theta, double f_dis, double r45_dis, double l45_dis);
        public abstract void gameover();

    }
}
