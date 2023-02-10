class Utility
{
    public static int getArea(Rectangle rec)
    {
        int width = rec.width;
        int length = rec.length;
        return length * width;
    }
    public static int getPerimeter(Rectangle rec)
    {
        int width = rec.width;
        int length = rec.length;
        return 2*(length + width);
    }
}