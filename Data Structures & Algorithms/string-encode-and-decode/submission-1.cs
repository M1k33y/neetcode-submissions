public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder rez= new StringBuilder();

        foreach(string word in strs)
        {
            rez.Append(word.Length);
            rez.Append("#");
            rez.Append(word);
        }

        return rez.ToString();
    }

    public List<string> Decode(string s) 
    {
        int i=0;
        
        List<string> rez= new List<string>();

        while(i<s.Length)
        {
            string nr="";
            int length = 0;
            while (s[i] != '#')
                length = length * 10 + (s[i++] - '0');
            
            i++;

            string word=s.Substring(i,length);
            rez.Add(word);
            i+=length;
            
        }

        return rez;

    }
}
