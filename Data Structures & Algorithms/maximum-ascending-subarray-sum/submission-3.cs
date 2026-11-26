public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int sum = nums[0];
        int max = nums[0];
        for(int i = 1; i < nums.Length ; i++){
            if(nums[i] <= nums[i - 1]){
                sum = 0;
            }
            sum += nums[i];
            max = Math.Max(sum, max);
        }
        return max;
    }
}