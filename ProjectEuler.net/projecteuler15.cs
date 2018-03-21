using System;
namespace ProjectEuler.net
{
    public class ProjectEuler15
    {
        public static void ProjectEulerQ15()
        {
            //Did some research into the Multiplication Principals of Probability

            const int gridSize = 20;
            long path = 1;

            for (int i = 0; i < gridSize; i++)
            {
                //this path is mulitplied by the amount of movements for this path.
                path *= (2 * gridSize) - i;
                Console.WriteLine(path);

                path /= i + 1;
                Console.WriteLine(path);

            }
            Console.WriteLine("There are {0} possible paths", path);
        }
    }
}
