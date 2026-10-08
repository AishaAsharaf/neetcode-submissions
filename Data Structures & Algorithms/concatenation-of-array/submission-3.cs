public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int count = nums.Length;
        int[] newArray = new int[2*count];
        for(int i = 0; i < count ; i++){
           newArray[i] = nums[i];
           newArray[i+count] = nums[i];
        }
        return newArray;
    }
}