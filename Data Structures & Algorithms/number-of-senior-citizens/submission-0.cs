public class Solution {
    public int CountSeniors(string[] details) {
        int res = 0;
        for(int i = 0; i < details.Length ; i++){
            string person = details[i];
            int age = int.Parse(person.Substring(11,2));
            if(age > 60){
                res++;
            }
        }
        return res;
    }
}