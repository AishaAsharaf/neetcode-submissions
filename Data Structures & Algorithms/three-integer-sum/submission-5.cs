public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> newlist = new List<List<int>>();
        Array.Sort(nums);
        
        for(int i = 0; i < nums.Length ;i++){
           if(nums[i] > 0) break;
           if (i > 0 && nums[i] == nums[i - 1]) continue;
           int l= i+1;
           int r = nums.Length -1;
           while(l<r){
            if(nums[i]+nums[r]+nums[l] < 0)
            {
                l++;
            }
            else if(nums[i]+nums[r]+nums[l] > 0)
            {
                r--;
            }
            else
            {
                    newlist.Add(new List<int>{nums[i],nums[r],nums[l]});
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) {
                        l++;
                    }
            }
           }
        }
       return newlist;
    }
}
