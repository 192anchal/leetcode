public class Solution {
    public int PivotInteger(int n) {
       int frontSum = 0;
        int backSum = (n * (n + 1)) / 2;
        for(int i = 1; i <= n; i++) {
            frontSum += i;
            backSum -= (i - 1);
            if(frontSum == backSum)
                return i;
        }
        return -1;  
    }
}