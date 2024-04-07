public class Solution {
    public bool CheckValidString(string s) {
      // Count of minimum open parentheses needed to balance the string
        int minOpen = 0;
        // Count of maximum open parentheses that can be balanced
        int maxOpen = 0;
        
        // Iterate through each character in the string
        foreach (char c in s) {
            if (c == '(') {
                // Increment both minOpen and maxOpen for '('
                minOpen++;
                maxOpen++;
            } else if (c == ')') {
                // Decrement minOpen, but ensure it doesn't go negative
                minOpen = Math.Max(minOpen - 1, 0);
                // Decrement maxOpen for ')'
                maxOpen--;
                // If maxOpen goes negative, there are more ')' than '(' or '*'
                if (maxOpen < 0) return false;
            } else if (c == '*') {
                // '*' can be either '(', ')' or empty string, so adjust minOpen and maxOpen accordingly
                minOpen = Math.Max(minOpen - 1, 0);
                maxOpen++;
            }
        }
        // If minOpen is 0, the string can be balanced
        return minOpen == 0;  
    }
}