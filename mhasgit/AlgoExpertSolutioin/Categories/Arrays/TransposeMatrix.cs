namespace AlgoExpertSolution.Categories.Arrays
{
    public class TransposeMatrix
    {
        public static int[][] Solve(int[][] matrix)
        {
            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int[][] transposed = new int[cols][];

            for (int col = 0; col < cols; col++)
            {
                transposed[col] = new int[rows];

                for (int row = 0; row < rows; row++)
                {
                    transposed[col][row] = matrix[row][col];
                }
            }

            return transposed;
        }
    }
}
