/* Create a [Version] attribute that can be applied to structures, classes, interfaces, enumerations and methods 
   and holds a version in the format major.minor (e.g. 2.11).
   Apply the version attribute to a sample class and display its version at runtime.*/


using System;


namespace DefiningClasses
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    class VersionAttribute : Attribute
    {
        public string Version { get; set; }
        public VersionAttribute(string version)
        {
            this.Version = version;
        }
    }
}
