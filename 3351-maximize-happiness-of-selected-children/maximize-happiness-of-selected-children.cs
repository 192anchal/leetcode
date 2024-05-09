public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k) {
         Array.Sort(happiness);
        long sum = 0;
        for (int i = 0; i < k; i++) {
            if (happiness[happiness.Length - 1 - i] - i > 0) {
                sum += happiness[happiness.Length - 1 - i] - i;
            }
        }
        return sum;
    }
}