using System.Security;

namespace AlgoExpertSolution.Categories.Arrays
{
    public class SmallestDifference
    {
        public static int[] Solve(int[] a, int[] b)
        {
            Array.Sort(a);
            Array.Sort(b);

            int idxOne = 0;
            int idxTwo = 0;
            int current = 0;
            int smallest = int.MaxValue;
            int[] smallestPair = new int[2];


            while (idxOne < a.Length && idxTwo < b.Length)
            {
                int firstNum = a[idxOne];
                int secondNum = b[idxTwo];

                if (firstNum < secondNum)
                {
                    current = secondNum - firstNum;
                    idxOne++;
                }
                else if (secondNum < firstNum)
                {
                    current = firstNum - secondNum;
                    idxTwo++;
                }
                else
                {
                    return new int[] { firstNum, secondNum };
                }


                if (current < smallest)
                {
                    smallest = current;
                    smallestPair[0] = firstNum;
                    smallestPair[1] = secondNum;
                }

            }
            return smallestPair;
        }
    }
}
