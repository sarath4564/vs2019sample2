using System;
using System.Drawing;
namespace vs2019_sample2
{
    // here am sharing some common code and data
    // data: colour,thickness of any
    public abstract class shapes
    {
        protected int colour { get; set; }
        protected int thickness { get; set; }
        protected int dark{ get; set; }
       // public abstract Draw();
       protected void GetDC()
        {
            // create a device context object
            //device context object =windows...
        }
        public abstract void Draw();
    }
    class Line : shapes
    {
        public Point LeftTop { get; set; }
        public Point Middle{ get; set; }
        public Point Centre{ get; set; }
        public Point RightBottom{ get; set; }
        public Line(Point lefttop,Point middle,Point centre,Point rightbottom)
        {
            this.colour = 0;
            this.thickness = 1;
            this.dark = 5;
            GetDC();
            LeftTop = lefttop;
            Middle = middle;
            Centre = centre;
            RightBottom = rightbottom;
        }
        public override void Draw()
        {
            Console.WriteLine("Draw Line ");
        }
    }
    class Rectangle : shapes
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Rectangle");
        }
    }
    class Program
    {
        static void Main()
        {
            Point lefttop = new Point(50, 40);
            Point middle = new Point(60, 30);
            Point centre = new Point(70, 20);
            Point rightbottom = new Point(100, 90);
            Line line = new Line(lefttop, middle, centre, rightbottom);
            // here reading the device context objects is abstracted
            line.Draw();
        }
    }
}
