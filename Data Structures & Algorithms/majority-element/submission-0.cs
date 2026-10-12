public class Solution {
    public int MajorityElement(int[] nums) {
        int count = 0;
        int candidate = 0;

        for(int i =0; i< nums.Length;i++){
           if(candidate != nums[i] && count == 0){
            candidate = nums[i];
           }
           if(candidate == nums[i])
           {
             count++;
           }
           else if(candidate != nums[i])
           {
            count--;
           }
        }
        return candidate;
    }
}