using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFAssignment1_PROG2070
{
    public class Circle
    {
        private int radius;

        // defaut constructor
        public Circle()
        {
            radius = 1;
        }
        //constructor
        public Circle(int radius)
        {            
            this.radius = radius;
        }
        //methods
        public int GetRadius()
        {
            return radius;
        }

        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public double GetCircumference()
        {
            return Math.Round(2 * Math.PI * radius, 3);
        }
        public double GetArea()
        {
            return Math.Round(Math.PI * radius * radius, 3);
        }
    }
}
