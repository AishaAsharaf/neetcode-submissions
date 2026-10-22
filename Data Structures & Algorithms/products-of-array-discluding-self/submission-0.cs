public class Solution {
    
    public int[] ProductExceptSelf(int[] nums)
    {
        int product = 1;
        int zeroCount = nums.Count(x => x == 0);

        foreach (int num in nums)
        {
            if (num != 0)
                product *= num;
        }

        int[] res = new int[nums.Length];

        if (zeroCount >= 2)
            return res; // all zeros

        if (zeroCount == 1)
        {
            res[Array.IndexOf(nums, 0)] = product;
            return res;
        }

        for (int i = 0; i < nums.Length; i++)
            res[i] = product / nums[i];

        return res;
    }

}
