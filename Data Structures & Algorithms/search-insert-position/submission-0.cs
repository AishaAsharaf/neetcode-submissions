public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int l = 0;
        int m = 0;
        List<int> list = nums.ToList();
        if(!list.Contains(target)){
            list.Add(target);
            list.Sort();
        }
        int r = list.Count - 1;
        while( l <= r){
            m = l + ((r-l)/2);
            if(list[m]>target){
                r = m -1;
            }
            else if(list[m] < target){
                l = m +1;
            }
            else{
                return m;
            }
        }
        return m;
    }
}