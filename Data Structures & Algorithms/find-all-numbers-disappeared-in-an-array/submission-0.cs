public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
        int n = nums.Length;
        List<int> newlist = new List<int>();
        List<int> res = new List<int>();
        for(int i = 1; i <= n ; i++){
           newlist.Add(i);
        }

        for(int i = 0; i < n ; i++){
           if(!nums.Contains(newlist[i])){
            res.Add(newlist[i]);
           }
        }

        return res;
    }
}