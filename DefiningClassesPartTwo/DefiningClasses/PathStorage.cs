/* Create a static class PathStorage with static methods to save and load paths from a text file.
   Use a file format of your choice.*/


using System;
using System.Collections.Generic;
using System.IO;

namespace DefiningClasses
{
    public static class PathStorage
    {
        public static void Write(Point3D point) // Write all the points from the path List on the fail.
        {
            StreamWriter writer = new StreamWriter("some tekst");
            using (writer)
            {
                foreach (Point3D p in Path.path)
                {
                    writer.WriteLine(p.ToString());
                }             
            }
        }
        public static void Read() // Read all the points from a fail and adds them to the path List. 
        {
            StreamReader reader = new StreamReader("some tekst");
            using (reader)
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    String[] coordinates = line.Split(' '); 
                    Point3D point = new Point3D(Decimal.Parse(coordinates[0]),Decimal.Parse(coordinates[1]), Decimal.Parse(coordinates[2]));
                    Path.path.Add(point);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
