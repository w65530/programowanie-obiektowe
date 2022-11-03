namespace _2022_10_22_WebApplication.Services.Lab3
{
    public class Rectangle : Shape
    {
        public Rectangle(int width, int height)//:base(width, height) <-- Jeżeli Shape miałby swój konstruktor parametrowy
        {
            Width = width;
            Height = height;
        }

        public static int operator +(Rectangle a, Rectangle b)
        {
            var result = new Rectangle(a.Width + b.Width, a.Height + b.Height);
            return result.GetArea();
        }
        public override int GetShorterSide()
        {
            return 456;
        }
    }
}
