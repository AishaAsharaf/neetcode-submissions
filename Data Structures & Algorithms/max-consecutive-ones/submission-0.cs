public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int res = 0;
        int max = 0;
        for(int i = 0;i<nums.Length;i++){
           if(nums[i] != 1){
            res=0;
           }
           else
           {
           res++;
           }
           max = Math.Max(max,res);
        }
        return max;
    }
}