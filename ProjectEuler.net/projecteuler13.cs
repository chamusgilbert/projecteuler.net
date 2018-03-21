using System;
using System.IO;
using System.Collections.Generic;

namespace ProjectEuler.net
{
    public class ProjectEuler13
    {
        public static void ProjectEulerQ13()
        {
            double sum;
            List<double> listOfNumbers = new List<double>();
            string numberString;
            StreamReader projectEulerNumber = new StreamReader(@"/Users/FamousChamus/Projects/ProjectEuler.net/ProjectEuler.net/projecteuler13.txt");
            while (true)
            {
                numberString = projectEulerNumber.ReadLine();
                if (numberString == null)
                {
                    break;
                }
                listOfNumbers.Add(double.Parse(numberString));
            }
            sum = ListSum(listOfNumbers);
            numberString = sum.ToString("0." + new string('#', 339)).Substring(0, 10);
            Console.WriteLine(numberString);
        }

        private static double ListSum(List<double> listOfNumbers)
        {
            double sum = 0;
            foreach (var item in listOfNumbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}
