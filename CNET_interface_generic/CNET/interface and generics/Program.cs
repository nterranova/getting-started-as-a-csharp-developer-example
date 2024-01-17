// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Text;

interface IRandomizable
{
    void GetRandomNum(int MaxBound);
}

public class GetRandomNumber : IRandomizable
{
    public void GetRandomNum(int MaxBound)
    {

        Random random = new Random();
        Console.WriteLine( random.NextDouble() * MaxBound);
    }
}


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("enter a upper bound");
        

        GetRandomNumber randomNumber = new GetRandomNumber();
        

            switch (input)
            {
                case null:
                    Console.WriteLine("Input is null.");
                    break;

                case "":
                    Console.WriteLine("Input is empty.");
                    break;

                case "exit":
                    Console.WriteLine("Exiting program.");

                    return;

                default:
                    if (int.TryParse(input, out int intValue))
                    {
                        randomNumber.GetRandomNum(intValue);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Input is not a valid integer. Please enter another input.");
                        break;
                    }
            }
        }

    }
}
