public class Solution {
    public int[] TwoSum(int[] nums, int target) {
       Dictionary<int,int> dict = new Dictionary<int,int>();

       for(int i = 0; i < nums.Length ; i++){
              dict[nums[i]] = i;
       }


       for(int i = 0; i < nums.Length ; i++){
              int res = target - nums[i];
              if(dict.ContainsKey(res) && dict[res] != i){
                return new int[]{i,dict[res]};
              }
       }

       return new int[0];
    }
}
