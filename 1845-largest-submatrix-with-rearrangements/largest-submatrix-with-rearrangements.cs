public class Solution {
    public int LargestSubmatrix(int[][] matrix) {
        int rows = matrix.Length;    
        int cols = matrix[0].Length;

        for (int c = 0; c < cols; c++)        
            for (int r = 1; r < rows; r++)
                matrix[r][c] = matrix[r][c] == 0 ? 0 : matrix[r - 1][c] + 1;

        int ans = 0;  
        for (int r = 0; r < rows; r++)
        {
            Array.Sort(matrix[r], (a, b) => b.CompareTo(a));            
            for (int c = 0; c < cols; c++)
                ans = Math.Max(ans, (c + 1) * matrix[r][c]);
        }
        return ans;
    }
}