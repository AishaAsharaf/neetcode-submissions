public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length ;
        int n = matrix[0].Length ;
        int l = 0;
        int r = m*n - 1;

        while(l<=r){
            int mid = l + (r-l)/2;
            int value = matrix[mid/n][mid%n];

            if(value > target)
            {
                r = mid -1;
            }
            else if(value < target)
            {
                l = mid + 1;
            }
            else if(value == target)
            {
                return true;
            }
        }
        return false;
    }
}
