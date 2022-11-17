namespace WebApiProject.Services.Lab3
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int GetArea()
        {
            int Area = Width * Height;
            return Area;
        }
        public int GetArea(int x)
        {
            int Area = Width * Height * x;
            return Area;
        }
        public int GetArea(double x)
        {
            int Area = Width * Height * (int)x;
            return Area;
        }
        public virtual int GetShorterSide()
        {
            return Width > Height ? Height : Width;
            //return new List<int>() { Width, Height }.Min();
        }
    }
}
