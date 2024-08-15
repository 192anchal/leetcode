public class Solution {
    public bool LemonadeChange(int[] bills) {
      int[] change = new int[] { 0,0,0 }; // $5, $10, $20
        for (int i = 0; i < bills.Length; i++) {
            int changeNeeded = bills[i] - 5;

            if (changeNeeded != 0) {
                // Count how many bills we use
                int fives = 0;
                int tens = 0;
                int twenties = 0;

                // Greedily try to use the largest bills with this loop
                while (changeNeeded >= 20 && change[2] > 0) {
                    changeNeeded -= 20;
                    twenties++;
                }

                while (changeNeeded >= 10 && change[1] > 0) {
                    changeNeeded -= 10;
                    tens++;
                }

                while (changeNeeded > 0 && change[0] > 0) {
                    changeNeeded -= 5;
                    fives++;
                }

                // We somehow got to a state where there still is change needed (or the change needed is below zero, which shouldn't occur)
                if (changeNeeded != 0) return false;

                // Give the change since we got the changeNeeded to zero.
                change[0] -= fives;
                change[1] -= tens;
                change[2] -= twenties;
            } 

            // Make sure that we did not use more bills than we have
            if (change[0] < 0 || change[1] < 0 || change[2] < 0) {
                return false;
            }

            // We can add the bill we just received after we gave the change and checked we are not in the negative.
            if (bills[i] == 5) change[0]++;
            else if (bills[i] == 10) change[1]++;
            else if (bills[i] == 20) change[2]++;
        }
        return true;  
    }
}