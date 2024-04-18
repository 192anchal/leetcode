public class Solution {
    public int IslandPerimeter(int[][] grid) {
       int perimeter = 0;
        int rows = grid.Length;
        int cols = grid[0].Length;
        
        // Iterate through each cell in the grid
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                if (grid[i][j] == 1) {
                    perimeter += 4; // Add 4 sides for each land cell
                    
                    // Check neighboring cells and subtract for each adjacent land cell
                    if (i > 0 && grid[i - 1][j] == 1) {
                        perimeter -= 2; // Subtract 2 for adjacent cells on top
                    }
                    if (j > 0 && grid[i][j - 1] == 1) {
                        perimeter -= 2; // Subtract 2 for adjacent cells on the left
                    }
                }
            }
        }
        
        return perimeter;
    }
}