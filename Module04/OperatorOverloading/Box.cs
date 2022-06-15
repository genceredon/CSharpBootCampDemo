using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module04.OperatorOverloading
{
    public class Box
    {
        private double length;   // Length of a box
        private double width;  // width of a box
        private double height;   // Height of a box
        public double getVolume()
        {
            return length * width * height;
        }
        public void setLength(double len)
        {
            length = len;
        }
        public void setWidth(double wid)
        {
            width = wid;
        }
        public void setHeight(double hei)
        {
            height = hei;
        }

        // Overload + operator to add two Box objects.
        public static Box operator +(Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = b.height + c.height;
            return box;
        }

        public static bool operator ==(Box b, Box c)
        {
            bool isEqual = b.width == c.width && b.height == c.height 
                && b.length == c.length;
     
            return isEqual;
        }

        public static bool operator !=(Box b, Box c)
        {
            bool isNotEqual = b.width != c.width || b.height != c.height
                || b.length != c.length;

            return isNotEqual;
        }
    }
}
