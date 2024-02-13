using DecoratorPattern.Decorator;
using DecoratorPattern.Decorator.CarDecorators;

internal class Program
{
    private static void Main(string[] args)
    {
        Car car = new Lamborgini();
        Print(car);

        car = new HotWheelsCarDecorator(car);
        Print(car);

        car = new Benz();
        car = new HotWheelsCarDecorator(car);
        car = new HotWheelsCarDecorator(car);
        Print(car);
    }

    private static void Print(Car car)
    {
        Console.WriteLine($"Description: {car.Description()}, Cost: {car.Cost()}, Speed: {car.Speed()}");
    }
}