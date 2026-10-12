public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0;
        for(int i=0; i < nums.Length ; i++){
            if(nums[i] == val){
                //in the constraints, they have mentioned values will not be over 50
                  nums[i] = 51;
            }
            else{
                 k++;
            }
        }
        Array.Sort(nums);
        return k;
    }
}