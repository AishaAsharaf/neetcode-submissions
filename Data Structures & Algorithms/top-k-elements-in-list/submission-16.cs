public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        if(k == 0){
            return [];
        }
        var freq = new Dictionary<int,int>();
       
        foreach(var u in nums){
            if(!freq.ContainsKey(u))
            {
                freq[u] = 1;
            }
            else
            {
                freq[u]++;
            }
        }
        
        var keys1 = freq.Where(x => x.Value > 1)
                    .OrderByDescending(x => x.Value)
                    .Select(x=>x.Key)
                    .ToList();
        var keys2 = freq.Where(x => x.Value == 1)
                    .Select(x => x.Key)
                    .ToList();
        var candidates = keys1.Concat(keys2).Take(k).ToArray();

        return candidates;
        
    }
}
