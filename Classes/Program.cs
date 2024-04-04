namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cars car1 = new Cars();

            car1.Make = "Tesla";
            car1.Model = "New";
            car1.Year = "2023";

            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);

        }
    }
}
