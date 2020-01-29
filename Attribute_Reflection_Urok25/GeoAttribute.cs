using System;

namespace Attribute_Reflection_Urok25
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Constructor)] // Атрибут в атрибуте
    class GeoAttribute : Attribute
    {
        public int X { get; set; }

        public int Y { get; set; }

        // Конструктор для атрибута без параметров
        public GeoAttribute() { }

        public GeoAttribute (int x, int y)
        {
            // Здесь нужно прописывать проверку входных данных

            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"[{X}; {Y}]";
        }
    }
}
