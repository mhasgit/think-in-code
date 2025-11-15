namespace AlgoExpertSolution.Categories.Arrays
{
    public class ValidateSequence
    {
        public static bool SolveWithSeqInd(List<int> array, List<int> sequence)
        {
            int seqIdx = 0;

            foreach (var value in array)
            {
                if (seqIdx == sequence.Count())
                    break;

                if (sequence[seqIdx] == value)
                    seqIdx++;
            }

            return seqIdx == sequence.Count();
        }


        public static bool SolveWithArrIdx(List<int> array, List<int> sequence)
        {
            int seqIdx = 0;
            int arrIdx = 0;

            while (arrIdx < array.Count && seqIdx < sequence.Count())
            {
                if (array[arrIdx] == sequence[seqIdx])
                {
                    seqIdx++;
                }
                arrIdx++;
            }
            return seqIdx == sequence.Count();
        }
    }
}
