public class Solution {
    public List<int> FindDisappearedNumbers(int[] nums) {
    
    int[] array = new int[nums.Length + 1];
    List<int> res = new List<int>();

    for(int i = 0; i < array.Length ; i++){
        array[i] = i;
    }

    for(int i = 0; i < nums.Length ; i++){
        if(array[nums[i]] == nums[i]){
            array[nums[i]] = -1;
        }
    }

    for(int i = 1; i < array.Length ; i++){
        if(array[i] != -1){
            res.Add(array[i]);
        }
    }

    return res;

    }
}