namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var car1 = new Car("Mercedes", "E200", "Sedan");
            var car2 = new Car("BMW", "X5", "SUV");

            Console.WriteLine(car1);
            Console.WriteLine(car2);
        }
    }
}