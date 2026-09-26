public class Solution {
    public int[] TwoSum(int[] nums, int target) {
            
            for (int i = 0; i < nums.Length; i++)
            { 
                    int numToFind = target - nums[i];
                    bool foundNumber = nums.Contains(numToFind);
                    if (foundNumber)
                    {
                        int indexOfNum = Array.IndexOf(nums, numToFind);
                        if (indexOfNum == i)
                        {
                            continue;
                        }
                        else if (indexOfNum > i)
                        {

                            int[] indexs = [i, indexOfNum];
                            return indexs;

                        }
                        else
                        {
                            int[] indexs = [indexOfNum, i];
                            return indexs;
                        }
                    }
                    else
                    {
                        continue;
                    }


                
            }
            return [];
    }
}
