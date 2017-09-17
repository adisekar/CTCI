using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTCI._1._Arrays_and_Strings
{
    public class DistanceFromPoint
    {
        public static List<Point> GetPointsWithinDistance(List<Point> list, Point point, double distance)
        {
            List<Point> withinDistance = new List<Point>();
            foreach (Point p in list)
            {
                if (p.IsWithinDistance(point, distance))
                {
                    withinDistance.Add(p);
                }
            }
            return withinDistance;
        }
    }


    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double GetDistance(Point otherPoint)
        {
            return Math.Sqrt(Math.Pow(otherPoint.x - this.x, 2) + Math.Pow(otherPoint.y - y, 2));
        }

        public bool IsWithinDistance(Point otherPoint, double distance)
        {
            if (Math.Abs(otherPoint.x - x) > distance || (otherPoint.y - y) > distance)
            {
                return false;
            }
            return GetDistance(otherPoint) <= distance;
        }
    }
}
