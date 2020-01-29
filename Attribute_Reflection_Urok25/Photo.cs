using System;

namespace Attribute_Reflection_Urok25
{
    // [Geo(10, 20)] - если прописать здесь то будет относиться ко всему классу.
    public class Photo
    {
        [Geo(10, 20)] // если здесь прописать то будет относиться только к свойству класса.
        public string Name { get; set; }
        
        public string Path { get; set; }

        public Photo (string name)
        {
            // Здесь нужно прописывать проверку входных данных

            Name = name;
        }
    }
}
