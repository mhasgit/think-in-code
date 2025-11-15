namespace AlgoExpertSolution.Categories.Arrays
{
    public class NonConstructibleChange
    {
        public static int Solve(int[] coins)
        {
            Array.Sort(coins);

            int currentChangeCreated = 0;


            foreach (var coin in coins)
            {
                if (coin > currentChangeCreated + 1)
                {
                    return currentChangeCreated + 1;
                }

                currentChangeCreated += coin;
            }

            return currentChangeCreated + 1;
        }
    }
}
