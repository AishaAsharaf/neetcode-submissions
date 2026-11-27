public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
    
    List<int> res = new List<int>();

    for(int i = 0; i < nums.Length ; i++){
        int index = Math.Abs(nums[i]) - 1;
        if(nums[index] > 0){
            nums[index] = -nums[index];
        }
    }

    for(int i = 0; i < nums.Length ; i++){
        if(nums[i] > 0){
            res.Add(i+1);
        }
        
    }

    return res;

    }
}