namespace AlgoExpertSolution.Categories.Arrays
{
    public class TwoNumberSum
    {
        public static int[] SolveBruteForce(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 1 + i; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        return new int[] { nums[i], nums[j] };
                    }
                }
            }
            return new int[] { 0 };
        }


        public static int[] SolveWithHashSet(int[] nums, int target)
        {
            var seen = new HashSet<int>();

            foreach (var num in nums)
            {
                int potentialMatch = target - num;

                if (seen.Contains(potentialMatch))
                {
                    return new int[] { potentialMatch, num };
                }
                seen.Add(num);
            }
            return new int[] { 0 };
        }


        public static int[] SolveTwoPointers(int[] nums, int target)
        {
            Array.Sort(nums);
            int left = 0;
            int right = nums.Length - 1;

            foreach (var num in nums)
            {
                int currentSum = nums[left] + nums[right];
                if (currentSum == target)
                {
                    return new int[] { nums[left], nums[right] };
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

            return new int[] { 0 };
        }
    }
}
