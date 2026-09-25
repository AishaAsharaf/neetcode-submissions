public class Solution {
    public bool hasDuplicate(int[] nums) {
        int arrayLenght = nums.Length;
        HashSet<int> hash = new HashSet<int>(nums);
        if(hash.Count == nums.Length) return false;
        return true;

    }
}