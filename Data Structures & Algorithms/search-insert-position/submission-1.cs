public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0;
        int m = 0;
        int res = nums.Length;
        int r = nums.Length - 1;
        while( l <= r){
            m = l + ((r-l)/2);
            if(nums[m]>target){
                r = m -1;
                res = m;
            }
            else if(nums[m] < target){
                l = m +1;
            }
            else{
                return m;
            }
        }
        return res;
    }
}