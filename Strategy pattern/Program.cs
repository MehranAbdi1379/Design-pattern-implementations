using Strategy_pattern.Classes;

internal class Program
{
    private static void Main(string[] args)
    {
        var imageStorage = new ImageStorage(new HighContrastFilter() , new PNGCompressor());
    }
}