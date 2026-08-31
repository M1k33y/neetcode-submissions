public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) 
    {
        
        Dictionary<string,List<string>> types=new Dictionary<string,List<string>>();

        foreach(var word in strs)
            {
                int[] freq=new int [26];

                foreach(char c in word)
                    freq[c-'a']++;
                
                string key= string.Join(' ',freq);

                if(!types.ContainsKey(key))
                    types[key]=new List<string>();
                types[key].Add(word);
            }

        return types.Values.ToList();


    }
}
