using AlgoExpertSolution.Categories.Arrays;

namespace AlgoExpertSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("==== AlgoExpert Solution Tester ====");
                Console.WriteLine("Choose a Category:");
                Console.WriteLine("1. TwoNumberSum");
                Console.WriteLine("2. ValidateSequence");
                Console.WriteLine("3. SortedSquaredArray");
                Console.WriteLine("4. TournamentWinner");
                Console.WriteLine("5. TransposeMatrix");
                Console.WriteLine("6. NonConstructibleChange");
                Console.WriteLine("7. ThreeNumberSum");
                Console.WriteLine("8. SmallestDifference");

                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                var catChoice = Console.ReadLine();

                switch (catChoice)
                {
                    case "1":
                        RunTwoNumberSumMenu();
                        break;
                    case "2":
                        RunValidateSequenceMenu();
                        break;
                    case "3":
                        RunSortedSquaredArrayMenu();
                        break;
                    case "4":
                        RunTournamentWinnerMenu();
                        break;
                    case "5":
                        RunTransposeMatrixMenu();
                        break;
                    case "6":
                        RunNonConstructibleChangeMenu();
                        break;
                    case "7":
                        RunThreeNumberSum();
                        break;
                    case "8":
                        RunSmallestDifference();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid input. Press Enter to try again.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void RunTwoNumberSumMenu()
        {
            Console.Clear();
            Console.WriteLine("=== TwoNumberSum ===");
            Console.WriteLine("Choose Method:");
            Console.WriteLine("1. Brute Force");
            Console.WriteLine("2. HashSet");
            Console.WriteLine("3. Two Pointers");
            Console.Write("Enter choice: ");
            var methodChoice = Console.ReadLine();

            int[] nums = { 3, 5, -4, 8, 11, 1, -1, 6 };
            int target = 10;

            int[] result = methodChoice switch
            {
                "1" => TwoNumberSum.SolveBruteForce(nums, target),
                "2" => TwoNumberSum.SolveWithHashSet(nums, target),
                "3" => TwoNumberSum.SolveTwoPointers(nums, target),
                _ => new int[] { 0 }
            };

            Console.WriteLine($"Input: [{string.Join(", ", nums)}], Target: {target}");
            Console.WriteLine("Output: [" + string.Join(", ", result) + "]");
            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void RunValidateSequenceMenu()
        {
            Console.Clear();
            Console.WriteLine("=== ValidateSequence ===");
            Console.WriteLine("Choose Method:");
            Console.WriteLine("1. With Seq Index");
            Console.WriteLine("2. With Array Index");
            Console.Write("Enter choice: ");
            var methodChoice = Console.ReadLine();

            List<int> array = new() { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new() { 1, 6, -1, 10 };

            bool result = methodChoice switch
            {
                "1" => ValidateSequence.SolveWithSeqInd(array, sequence),
                "2" => ValidateSequence.SolveWithArrIdx(array, sequence),
                _ => false
            };

            Console.WriteLine($"Array: [{string.Join(", ", array)}]");
            Console.WriteLine($"Sequence: [{string.Join(", ", sequence)}]");
            Console.WriteLine($"Is Valid Subsequence? {result}");
            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void RunSortedSquaredArrayMenu()
        {
            Console.Clear();
            Console.WriteLine("=== SortedSquaredArray ===");
            Console.WriteLine("Choose Method:");
            Console.WriteLine("1. Naive (Square then sort)");
            Console.WriteLine("2. Two Pointers");
            Console.Write("Enter choice: ");
            var methodChoice = Console.ReadLine();

            int[] input = { -7, -3, 1, 9, 22, 30 };

            int[] result = methodChoice switch
            {
                "1" => SortedSquaredArray.SolveNaive(input),
                "2" => SortedSquaredArray.SolveTwoPointers(input),
                _ => new int[] { 0 }
            };

            Console.WriteLine($"Input: [{string.Join(", ", input)}]");
            Console.WriteLine("Output (Sorted Squares): [" + string.Join(", ", result) + "]");
            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void RunTournamentWinnerMenu()
        {
            Console.Clear();
            Console.WriteLine("=== TournamentWinner ===");

            var competitions = new List<List<string>>
            {
                new List<string> { "HTML", "C#" },
                new List<string> { "C#", "Python" },
                new List<string> { "Python", "HTML" }
            };

            var results = new List<int> { 0, 1, 1 };

            string winner = TournamentWinner.Solve(competitions, results);

            Console.WriteLine("Competitions:");
            for (int i = 0; i < competitions.Count; i++)
            {
                Console.WriteLine($"{competitions[i][0]} vs {competitions[i][1]} -> Winner: {(results[i] == 1 ? competitions[i][0] : competitions[i][1])}");
            }

            Console.WriteLine($"\n Tournament Winner: {winner}");
            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void RunTransposeMatrixMenu()
        {
            Console.Clear();
            Console.WriteLine("=== TransposeMatrix ===");

            int[][] matrix =
            {
        new int[] {1, 2},
        new int[] {3, 4},
        new int[] {5, 6}
    };

            Console.WriteLine("Original Matrix:");
            PrintMatrix(matrix);

            int[][] result = TransposeMatrix.Solve(matrix);

            Console.WriteLine("\nTransposed Matrix:");
            PrintMatrix(result);

            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void RunNonConstructibleChangeMenu()
        {
            Console.Clear();
            Console.WriteLine("=== NonConstructibleChange ===");

            int[] coins = { 8, 4, 2, 1 };

            Console.WriteLine("Coins: [" + string.Join(", ", coins) + "]");
            int result = NonConstructibleChange.Solve(coins);
            Console.WriteLine($"Non-Constructible Change: {result}");

            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void RunThreeNumberSum()
        {
            Console.Clear();
            Console.WriteLine("=== ThreeNumberSum ===");

            int[] arr = { 12, 3, 1, 2, -6, 5, -8, 6 };
            int target = 0;

            Console.WriteLine($"Input Array: [{string.Join(", ", arr)}]");
            Console.WriteLine($"Target Sum: {target}");

            var triplets = ThreeNumberSum.Solve(arr, target);

            Console.WriteLine("\nTriplets that sum to target:");
            if (triplets.Count == 0)
            {
                Console.WriteLine("None found.");
            }
            else
            {
                foreach (var triplet in triplets)
                {
                    Console.WriteLine("[" + string.Join(", ", triplet) + "]");
                }
            }

            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
        }

        static void PrintMatrix(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine("[" + string.Join(", ", row) + "]");
            }
        }

        static void RunSmallestDifference()
        {
            Console.Clear();
            Console.WriteLine("=== SmallestDifference ===");

            int[] arrayOne = { -1, 5, 10, 20, 28, 3 };
            int[] arrayTwo = { 26, 134, 135, 15, 17 };

            Console.WriteLine("Array One: [" + string.Join(", ", arrayOne) + "]");
            Console.WriteLine("Array Two: [" + string.Join(", ", arrayTwo) + "]");

            int[] result = SmallestDifference.Solve(arrayOne, arrayTwo);

            Console.WriteLine("\nSmallest Difference Pair:");
            Console.WriteLine("[" + string.Join(", ", result) + "]");

            Console.WriteLine("Press Enter to return to main menu...");
            Console.ReadLine();
            Console.WriteLine("Hello");
        }

    }

}
