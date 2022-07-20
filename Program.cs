using InputUtilitys;
namespace Ex_2022_Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box.box=new Box(
                InputUtility.InputFloat("幅"),
                InputUtility.InputFloat("高さ"),
                InputUtility.InputFloat("奥行"));
            Console.WriteLine($"Boxの表面積={Box.GetSurface()}boxの体積{Box.GetVolume()}");
        }
        {
            var name = InputUtility.Input("Name:");
            var age = InputUtility.InputNumber("Age:", 120);
            Console.WriteLine($"Hello {name}! \n U are {age} yeaes old.");
        }
    }
    class Box
    {
        private float width;
        private float height;
        private float depth;

        public Box(float width,float height,float depth)
        {
            this.width = width;
            this.height = height;
            this.depth = depth;
        }
        public float GetSurface()
        {
            return (width*height+depth*height+width*depth)*2;
        }
        public float GetVolume()
    {
        return width*height*depth;
    }
    }
}