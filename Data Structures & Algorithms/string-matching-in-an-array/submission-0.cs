public class Solution {
    public List<string> StringMatching(string[] words) {
        List<string> list = new List<string>();
        for(int i = 0; i < words.Length;i++){
            for(int j = 0 ; j < words.Length;j++){
                if(words[i].Contains(words[j]) && i != j){
                    if(!list.Contains(words[j])){
                       list.Add(words[j]);
                    }
                   
                }
                else if(words[j].Contains(words[i]) && i != j){
                   if(!list.Contains(words[i])){
                       list.Add(words[i]);
                    }
                }
            }
        }
        return list;
    }
}