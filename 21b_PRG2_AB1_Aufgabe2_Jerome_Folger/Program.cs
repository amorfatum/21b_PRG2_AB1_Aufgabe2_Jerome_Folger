using _21b_PRG2_AB1_Aufgabe2_Jerome_Folger;

internal class Program
{
    private static void Main(string[] args)
    {
        Auto lambo = new Auto("Lamborghini murcielago", 1000, 340, 2);

        lambo.CarLock = "Abc123";

        lambo.InsertKey("abc1234");

        lambo.StartEngine();

        lambo.InsertKey("Abc123");

        lambo.StartEngine();

        lambo.Refuel(100);

        lambo.Refuel(900);

        lambo.Break();

        lambo.Accelerate();

        lambo.StartEngine();

        lambo.Accelerate();

        lambo.Break();

        lambo.StopEngine();

    }
}