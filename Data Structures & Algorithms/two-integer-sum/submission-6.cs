public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int FirstIndex ;
        int SecondIndex ;
        for(int i = 0;i < nums.Length ;  i++){
            FirstIndex = nums[i];
            for(int j = i+1 ; j < nums.Length ;  j++ )
            {
                SecondIndex = nums[j];
                if(FirstIndex + SecondIndex == target)
                {
                    return [i, j];
                }
                
            }
        }
        return null;
    }
}
