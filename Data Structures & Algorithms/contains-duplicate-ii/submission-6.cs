public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        HashSet<int> newHash = new HashSet<int>();

        for(int i = 0; i < nums.Length; i++){
            if(newHash.Contains(nums[i])) return true;

            newHash.Add(nums[i]);

            if(newHash.Count > k){
                newHash.Remove(nums[Math.Abs(i-k)]);
            }
        
        }
        return false;
    }
}