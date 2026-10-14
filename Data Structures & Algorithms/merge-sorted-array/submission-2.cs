public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        if(m==0)
        {
            for(int i = 0; i< nums1.Length; i++)
            {
                nums1[i] = nums2[i];
            }
            return;
        }
        int k = 0;
        for(int i = 0; i< nums1.Length; i++)
        {
           if(nums1[i] == 0 && i>=m){
               nums1[i] = nums2[k];
               k++;
           }
        }
        Array.Sort(nums1);
    }
}