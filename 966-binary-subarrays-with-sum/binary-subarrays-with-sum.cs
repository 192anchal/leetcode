public class Solution {
    public int NumSubarraysWithSum(int[] nums, int goal) {
        var prefixSum = 0;
        var result = 0;
        var count = new int[nums.Length + 1];
        count[0] = 1;
        foreach (var num in nums)
        {
            prefixSum += num;
            if (prefixSum >= goal)
            {
                result += count[prefixSum - goal];
            }
            count[prefixSum]++;
        }
        return result;
    }
}