/* Write a static class with a static method to calculate the distance between two points in the 3D space. */


using System;


namespace DefiningClasses
{
    public static class Distance
    {
        public static double CountDistance(Point3D point, Point3D anotherPoint) // Counting the distance
        {
            double distance = 0;
            distance = Math.Sqrt((double)(Distance.Power(point.X - anotherPoint.X, 2) + 
                Distance.Power(point.Y - anotherPoint.Y, 2) + 
                Distance.Power(point.Z - anotherPoint.Z, 2)));
            return distance;
        }

        public static decimal Power(decimal number, int pow) // Custom method for powering
        {
            for (int i = 0; i < pow; i++)
            {
                number *= number;
            }
            return number;
        }
    }
}
