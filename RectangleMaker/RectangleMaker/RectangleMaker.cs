class RectangleMaker
{
    private static int min = 0;
    private static int max = 0;
    private static int width = 0;
    private static int length = 0;

    public static void Main(string[] args)
    {
        Console.Write("Please enter the minimum value (insclusive): ");
        min = Int32.Parse(Console.ReadLine());
        Console.Write("Please enter the maximum value (insclusive): ");
        max = Int32.Parse(Console.ReadLine());

        Console.WriteLine();
        makeRectangle(min, max, out width, out length);
        Rectangle rectangle = new Rectangle(width, length);
        Console.WriteLine("Length: " + length);
        Console.WriteLine("Width: " + width);
        Console.WriteLine("Area " + Utility.getArea(rectangle));
        Console.WriteLine("Perimeter " + Utility.getPerimeter(rectangle));
    }

    public static void makeRectangle(int min, int max, out int width, out int length)
    {
        Random getRandom = new Random();
        width = getRandom.Next(min, max + 1);
        length = getRandom.Next(min, max + 1);
    }
}