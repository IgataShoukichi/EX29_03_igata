using System;
namespace Ex29_03_Igatashoukichi
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("直方体");
            Console.WriteLine("表面積" + Box.GetSurface(InputFloat("幅"), InputFloat("高さ"), InputFloat("奥行")));
            Console.WriteLine("体積" + Box.GetVolume(InputFloat("幅"), InputFloat("高さ"), InputFloat("奥行")));

            Console.WriteLine("\n円柱");
            Console.WriteLine("表面積" + Cylinder.GetSurface(InputFloat("底面の半径"), InputFloat("高さ")));
            Console.WriteLine("体積" + Cylinder.GetVolume(InputFloat("底面の半径"), InputFloat("高さ")));

            Console.WriteLine("\n球");
            Console.WriteLine("表面積" + Sphere.GetSurface(InputFloat("半径")));
            Console.WriteLine("体積" + Sphere.GetVolume(InputFloat("半径")));

            Console.WriteLine("\n三角柱");
            Console.WriteLine("表面積" + TriangularPrism.GetSurface(InputFloat("底面の底辺"), InputFloat("底面の高さ"), InputFloat("高さ")));
            Console.WriteLine("体積" + TriangularPrism.GetVolume(InputFloat("底面の底辺"), InputFloat("底面の高さ"), InputFloat("高さ")));
        }

        static float InputFloat(string outputstring)
        {
            float input;
            while (true)
            {
                Console.WriteLine(outputstring);
                if (float.TryParse(Console.ReadLine(), out input))
                {
                    return input;
                    Console.WriteLine("エラー");
                }
            }
        }
    }
    static class Box
    {
        public static float GetSurface(float width, float height, float depth)
        {
            return (width * height + depth * height + width * depth) * 2;
        }
        public static float GetVolume(float width, float height, float depth)
        {
            return width * height * depth;
        }
    }
    static class Cylinder
    {
        static public float GetSurface(float bottom, float height)
        {
            return bottom * 2.0f * MathF.PI * height + bottom * bottom * MathF.PI * 2.0f;
        }
        static public float GetVolume(float bottom, float height)
        {
            return bottom * bottom * MathF.PI * height;
        }
    }
    static class Sphere
    {
        static public float GetSurface(float radius)
        {
            return 4.0f * MathF.PI * radius * radius;
        }
        static public float GetVolume(float radius)
        {
            return (4.0f / 3.0f) * MathF.PI * radius * radius * radius;
        }
    }
    static class TriangularPrism
    {
        static public double GetSurface(float bottom, float bottomheight, float height)
        {
            return bottom * bottomheight + (bottom + bottomheight + Math.Sqrt(bottom * bottom + bottomheight * bottomheight)) * height;
        }
        static public float GetVolume(float bottom, float bottomheight, float height)
        {
            return bottom * bottomheight / 2.0f * height;
        }
    }
}