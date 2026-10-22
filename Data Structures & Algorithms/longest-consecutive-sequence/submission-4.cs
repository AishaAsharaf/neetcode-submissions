public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length ==0) return 0;
        int seq = 1;
        int maxseq = 1;
        List<int> sort = nums.ToList();
        sort.Sort();

        for(int i=1; i<sort.Count;i++){
            if(sort[i] == sort[i-1]){
                continue;
            }

            if(sort[i] - sort[i-1] == 1){
                seq++;
            }
            else{
                seq = 1;
            }
           maxseq = Math.Max(maxseq, seq);
        }
        return maxseq;
    }
}
