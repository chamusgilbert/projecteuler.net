using System;
using System.IO;
using System.Collections.Generic;

namespace ProjectEuler.net
{
    public class projecteuler13
    {
        public projecteuler13()
        {
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
            ListSum(listOfNumbers);

        }
        public double ListSum(List<double> listOfNumbers)
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
