using System;

namespace Crossing_Number_Algorithm
{
    class @polygon:_v
    {
        public _v[] v = new _v[6];
    }
        

    class _v
    {
        public int x = 0;
        public int y = 0;
        public void push(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class _point
    {
        public int x = 0;
        public int y = 0;
        public void push(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class init_polygon
    {
        static void Main()
        {
            //Polygon Point
            @polygon polygon;
            polygon = new @polygon();
            _v v;
            v = new _v();
            v.push(100, 100);
            polygon.v[0] = v;
            v = new _v();
            v.push(200, 500);
            polygon.v[1] = v;
            v = new _v();
            v.push(600, 500);
            polygon.v[2] = v;
            v = new _v();
            v.push(700, 100);
            polygon.v[3] = v;
            v = new _v();
            v.push(400, 300);
            polygon.v[4] = v;
            v = new _v();
            v.push(100, 100);
            polygon.v[5] = v;

            //You want to check point
            _point point;
            point = new _point();
            point.push(500, 800);

            //Judge Even or Odd
            bool b = IsEven(cn(polygon, point));
            if (b == true)
            {
                Console.WriteLine("Line Out");
            }

            if (b == false)
            {
                Console.WriteLine("Line In");
            }

            //Judge Even or Odd
　　　　　　static bool IsEven(int num)
            {
                return (num % 2 == 0);
            }

            //Inside/Outside Judgment for a Polygon
            static int cn(polygon polygon, _point point)
            {
                int cn = 0;
                for (int i = 0; i < polygon.v.Length - 1; i++)
                {
                    // Upward edge. A point P is between the start point and the end point in the y-axis direction. However, the end point is not included. (Rule 1)
                    if (((polygon.v[i].y <= point.y) && (polygon.v[i + 1].y > point.y))
                        // Downward edge. A point P is between the start point and the end point in the y-axis direction. However, the starting point is not included. (Rule 2)
                        || ((polygon.v[i].y > point.y) && (polygon.v[i + 1].y <= point.y)))
                    {
                        // Rule 3 can be also confirmed, when Rule 1 & Rule2 could be confirmed.
                        // The edge is to the right of point p. However, they do not overlap. (Rule 4)
                        // Identify the position where the side is the same height as the point p,
                        // and compare the x value at that time with the x value of the point p.
                        double vt = (point.y - polygon.v[i].y) / (polygon.v[i + 1].y - polygon.v[i].y);
                        if (point.x < (polygon.v[i].x + (vt * (polygon.v[i + 1].x - polygon.v[i].x))))
                        {
                            ++cn;
                        }
                    }
                }
                return cn;
            }
        }
    }
}

