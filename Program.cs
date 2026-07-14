using System.ComponentModel.Design;

class ThermoAnalyzer
{
    static void Main()
    {
        //Choose a temperature
        Console.WriteLine("Enter a temperature in American/Fahrenheit:");

        // Read the input from the user and parse into a double
        if (double.TryParse(Console.ReadLine(), out double temperature))
        {
            //Evaluate the temperature and provide feedback
            if (temperature >= 0 && temperature <= 10)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temperature >= 11 && temperature <= 20)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (temperature >= 21 && temperature <= 35)
            {
                Console.WriteLine("Cold weather");
            }
            else if (temperature >= 36 && temperature <= 50)
            {
                Console.WriteLine("Normal in Weather");
            }
            else if (temperature >= 51 && temperature <= 65)
            {
                Console.WriteLine("Its Hot");
            }
            else if (temperature >= 66 && temperature <= 80)
            {
                Console.WriteLine("Its Very Hot");
            }
            else if (temperature >= 81 && temperature <= 100)
            {
                Console.WriteLine("Its Extremely Hot");
            }
            else if (temperature >= 101 && temperature <= 110)
            {
                Console.WriteLine("Its Time to Leave Florida");
            }
            else if (temperature >= 110 && temperature <= 500)
            {
                Console.WriteLine("Going through Mordor, are we?");
            }
            else
            {
                Console.WriteLine("Temperature is out of range.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
    }
}