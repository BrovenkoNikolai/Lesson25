using System;
using System.Linq;

namespace Attribute_Reflection_Urok25
{
    class Program
    {
        static void Main(string[] args)
        {
            var photo = new Photo("hello.png")
            {
                Path = @"C:\hello.png"
            };

            var type = typeof(Photo);
            var attributes = type.GetCustomAttributes(false);
            foreach (var attribute in attributes)
            {
                Console.WriteLine(attribute);  // Будет показывать на консоль, если раз комментировать в классе "Photo" = [Geo(10, 20)]
            }

            var properties = type.GetProperties();
            foreach (var prop in properties)
            {
                var attrs = prop.GetCustomAttributes(false);

                if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
                {
                    Console.WriteLine(prop.PropertyType + " " + prop.Name);
                }

                var attr = prop.GetCustomAttributes(false);

                foreach (var a in attr)
                {
                    Console.WriteLine(a);
                }
            }

            Console.ReadLine();
        }
    }
}
