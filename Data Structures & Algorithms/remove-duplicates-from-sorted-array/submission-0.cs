public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int maxNumber = 101;
        int numberOfReplace = 0;
        int k = 0;
        for(int i = 1; i < nums.Length; i++){
            if(nums[k] == nums[i]){
                nums[k] = maxNumber;
                maxNumber ++;
                numberOfReplace ++;
            }
            k++;
        }
        Array.Sort(nums);
        HashSet<int> newHash = new HashSet<int>(nums);
        return newHash.Count - numberOfReplace;
    }
}