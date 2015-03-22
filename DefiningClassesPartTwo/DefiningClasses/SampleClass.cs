/* Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
   and holds a version in the format major.minor (e.g. 2.11).
   Apply the version attribute to a sample class and display its version at runtime.*/

using System;


namespace DefiningClasses
{
    [Version("1.2")]
    class SampleClass
    {
        #region Properties
        public int Age { get; set; }

        public string Name { get; set; }

        #endregion

        #region Constructor
        public SampleClass(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        #endregion
    }
  
    class AttributeTest
    {
        public static void Main() // To run another Main you need to comment this one
        {                         // and uncomment the one you want to work. There can be only one compiled Main in a programm. 
            var attributes = typeof(SampleClass).GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                var versionAttribute = (VersionAttribute)attribute;
                Console.WriteLine("The version is {0}", versionAttribute.Version);
            }
        }
    }
}
