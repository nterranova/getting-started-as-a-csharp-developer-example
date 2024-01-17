using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace GenChallengeSolution
{
    public class ClassicCar
    {
        public string m_Make;
        public string m_Model;
        public int m_Year;
        public int m_Value;

        public ClassicCar(string make, string model, int year, int val)
        {
            m_Make = make;
            m_Model = model;
            m_Year = year;
            m_Value = val;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<ClassicCar> carList = new List<ClassicCar>();
            populateData(carList);

            Console.WriteLine("How many cars are in the collection?");

            Console.WriteLine(carList.Count());

            Console.WriteLine("How many Fords are there?");
            var Ford = from car in carList
                       where car.m_Make == "Ford"
                       select car;

            

            Console.WriteLine("What is the most valuable car?");

            var Most_valuable_car = from car in carList
                                    orderby car.m_Value descending
                                    select car;
            Console.WriteLine(Most_valuable_car.First().m_Model);


            Console.WriteLine("What is the entire collection worth?");

            int total_worth = carList.Sum(car => car.m_Value);
            Console.WriteLine(total_worth);

            Console.WriteLine("How many unique manufacturers are there?");
            var Car_manufacturer = from car in carList
                                   group car by car.m_Make into make
                                   select make.Key;

            Console.WriteLine(String.Join("\n", Car_manufacturer));

            Console.WriteLine("What is the entire collection worth?");



            Console.WriteLine("\nHit Enter key to continue...");
            Console.ReadLine();
        }

        static void populateData(List<ClassicCar> theList)
        {
            theList.Add(new ClassicCar("Alfa Romeo", "Spider Veloce", 1965, 15000));
            theList.Add(new ClassicCar("Alfa Romeo", "1750 Berlina", 1970, 20000));
            theList.Add(new ClassicCar("Alfa Romeo", "Giuletta", 1978, 45000));

            theList.Add(new ClassicCar("Ford", "Thunderbird", 1971, 35000));
            theList.Add(new ClassicCar("Ford", "Mustang", 1976, 29800));
            theList.Add(new ClassicCar("Ford", "Corsair", 1970, 17900));
            theList.Add(new ClassicCar("Ford", "LTD", 1969, 12000));

            theList.Add(new ClassicCar("Chevrolet", "Camaro", 1979, 7000));
            theList.Add(new ClassicCar("Chevrolet", "Corvette Stringray", 1966, 21000));
            theList.Add(new ClassicCar("Chevrolet", "Monte Carlo", 1984, 10000));

            theList.Add(new ClassicCar("Mercedes", "300SL Roadster", 1957, 19800));
            theList.Add(new ClassicCar("Mercedes", "SSKL", 1930, 14300));
            theList.Add(new ClassicCar("Mercedes", "130H", 1936, 18400));
            theList.Add(new ClassicCar("Mercedes", "250SL", 1968, 13200));
        }
    }
}
