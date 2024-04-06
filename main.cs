using System;

class Program
{
    static int GetValidFanSpeed()
    {
        while (true)
        {
            Console.Write("Enter fan speed (1, 2, or 3): ");
            string speed = Console.ReadLine();
            if (speed == "1" || speed == "2" || speed == "3")
            {
                return int.Parse(speed);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 1, 2, or 3.");
            }
        }
    }

    static char GetValidOscillateOption()
    {
        while (true)
        {
            Console.Write("Oscillate Fan? (Y/N): ");
            char option = char.ToUpper(Console.ReadKey().KeyChar);
            if (option == 'Y' || option == 'N')
            {
                return option;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter Y or N.");
            }
        }
    }

    static int CalculateFanPower(int fanSpeed)
    {
        int baseFanPower = 10;
        int fanPowerOutput = baseFanPower * fanSpeed;
        return fanPowerOutput;
    }

    static string OscillateOutput(int power)
    {
        return new string('~', power);
    }

    static string SteadyOutput(int power)
    {
        return new string('~', power);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            int fanSpeed = GetValidFanSpeed();
            char oscillateOption = GetValidOscillateOption();

            int fanPowerOutput = CalculateFanPower(fanSpeed);

            if (oscillateOption == 'Y')
            {
                Console.WriteLine("Oscillate output:");
                for (int i = 1; i <= fanPowerOutput; i++)
                {
                    Console.WriteLine(OscillateOutput(i));
                }
                for (int i = fanPowerOutput - 1; i > 0; i--)
                {
                    Console.WriteLine(OscillateOutput(i));
                }
            }
            else
            {
                Console.WriteLine("Steady output:");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(SteadyOutput(fanPowerOutput));
                }
            }

            Console.WriteLine("Fan power output: " + fanPowerOutput + " ~");
            Console.Write("Would you like to try again? (Y/N): ");
            char again = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
            if (again != 'Y')
            {
                break;
            }
        }
    }
}