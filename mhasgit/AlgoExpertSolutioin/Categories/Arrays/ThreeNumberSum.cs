using System.ComponentModel.Design;
using System.Security;

namespace AlgoExpertSolution.Categories.Arrays
{
    public class ThreeNumberSum
    {
        public static List<int[]> Solve(int[] arr, int target)
        {
            Array.Sort(arr);

            var triplets = new List<int[]>();

            for (int i = 0; i < arr.Length - 2; i++)
            {
                int left = 0;
                int right = arr.Length - 1;

                left = i + 1;

                while (left < right)
                {
                    int currentSum = arr[i] + arr[left] + arr[right];
                    if (currentSum == target)
                    {
                        triplets.Add(new int[] { arr[i], arr[left], arr[right] });
                        left++;
                        right--;
                    }
                    else if (currentSum < target)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }

            return triplets;
        }
    }
}
