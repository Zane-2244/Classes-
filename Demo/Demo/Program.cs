using Demo.Math; 


namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zane = new Person( );
            zane.FirstName = "Zane";
            zane.LastName = "Bridle";
            zane.Introduce();


            Calculator calculator = new Calculator();
            var result = calculator.add(3, 4);
            System.Console.WriteLine(result);
        }
    }
}
