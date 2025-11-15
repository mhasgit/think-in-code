using System.Runtime.InteropServices.Marshalling;

namespace AlgoExpertSolution.Categories.Arrays
{
    public class SortedSquaredArray
    {
        public static int[] SolveNaive(int[] arr)
        {
            int[] sortedSquared = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                sortedSquared[i] = arr[i] * arr[i];
            }
            Array.Sort(sortedSquared);

            return sortedSquared;
        }


        public static int[] SolveTwoPointers(int[] arr)
        {
            int[] sortedSquared = new int[arr.Length];

            int left = 0;
            int right = arr.Length - 1;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int leftValue = arr[left];
                int rightValue = arr[right];

                if (Math.Abs(leftValue) > Math.Abs(rightValue))
                {
                    sortedSquared[i] = arr[left] * arr[left];
                    left++;
                }
                else
                {
                    sortedSquared[i] = arr[right] * arr[right];
                    right--;
                }
            }
            return sortedSquared;
        }
    }
}
