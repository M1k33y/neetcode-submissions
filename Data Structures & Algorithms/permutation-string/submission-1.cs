public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        
        if(s1.Length>s2.Length)
            return false;

        int left=0;

        Dictionary<char,int> freq1=new Dictionary<char,int>();
        

        for(int i=0;i<s1.Length;i++)
        {
            if(!freq1.ContainsKey(s1[i]))
                freq1[s1[i]]=0;

            freq1[s1[i]]++;
        }

        for(int right=s1.Length;right<=s2.Length;right++)
        {
            
            Dictionary<char,int> freq2=new Dictionary<char,int>();
            for(int i=left;i<right;i++)
            {
                if(!freq2.ContainsKey(s2[i]))
                    freq2[s2[i]]=0;

                freq2[s2[i]]++;
            }

            if (SameDictionary(freq1, freq2))
                return true;

            left++;
        }
        return false;

    }


     private bool SameDictionary(
        Dictionary<char, int> d1,
        Dictionary<char, int> d2)
    {
        if (d1.Count != d2.Count)
            return false;

        foreach (var pair in d1)
        {
            if (!d2.ContainsKey(pair.Key))
                return false;

            if (d2[pair.Key] != pair.Value)
                return false;
        }

        return true;
    }


}

  