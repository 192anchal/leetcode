public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
          int len = nums.Length;
        int[] left = new int[len];
        int[] right = new int[len];
        int[] result = new int[len];
        left[0] = 1;
        right[len-1] = 1;

        for(int i=1; i<len; i++){
            left[i] = nums[i-1]*left[i-1];
        }

        for(int i=len-2; i>=0; i--){
            right[i] = nums[i+1]*right[i+1];
        }

        for(int i=0; i<len; i++){
            result[i] = left[i]*right[i];
        }

        return result;
        
    }
}