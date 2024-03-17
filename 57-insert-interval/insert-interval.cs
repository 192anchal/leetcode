public class Solution {
    public int[][] Insert(int[][] intervals, int[] newInterval) {
         List<int[]> result = new List<int[]>();
        int i = 0;
        
        // Add all intervals before newInterval
        while (i < intervals.Length && intervals[i][1] < newInterval[0]) {
            result.Add(intervals[i]);
            i++;
        }
        
        // Merge overlapping intervals with newInterval
        while (i < intervals.Length && intervals[i][0] <= newInterval[1]) {
            newInterval[0] = Math.Min(newInterval[0], intervals[i][0]);
            newInterval[1] = Math.Max(newInterval[1], intervals[i][1]);
            i++;
        }
        result.Add(newInterval);
        
        // Add all remaining intervals after newInterval
        while (i < intervals.Length) {
            result.Add(intervals[i]);
            i++;
        }
        
        return result.ToArray();
    }
}