namespace Module04
{
    public class InheritanceSampleCode
    {
        public void InheritanceDemo()
        {
            Rectangle Rect = new Rectangle();
            Rect.DispInfo();
            Rect.setHeight(5);
            Rect.setWidth(7);

            Square squareObj = new Square();
            squareObj.DispInfo();
            squareObj.setHeight(10);
            squareObj.setWidth(7);

            // Print the area of the object.
            Console.WriteLine("Total area: {0}", Rect.getArea());
            Console.WriteLine("Total area: {0}, Rectangle Area: {1}", squareObj.GetArea(), Rect.getArea());
            Console.WriteLine($"Total area: {squareObj.GetArea()}, Rectangle Area: {Rect.getArea()}");
            Console.WriteLine();
            Console.WriteLine("\n=====================================");
            Console.WriteLine("End of program...");
            Console.ReadKey();
        }
    }

    //Base Class
    public class Shape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }

        public void setHeight(int h)
        {
            height = h;
        }

        public virtual void DispInfo()
        {
            Console.WriteLine("Base Class Shape");
        }
    }

    // Derived class
    public class Rectangle : Shape
    {
        public int getArea()
        {
            return (width * height);
        }

        public override void DispInfo()
        {
            Console.WriteLine("Derived Class Rectangle");
        }
    }

    public class Square : Shape
    {
        public double GetArea() 
        { 
            return (Math.Pow(height,2)); 
        }

        public override void DispInfo()
        {
            Console.WriteLine("Derived Class Square");
        }

    }
}