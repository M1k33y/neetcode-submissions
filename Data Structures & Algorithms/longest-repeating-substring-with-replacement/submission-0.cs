public class Solution {
    public int CharacterReplacement(string s, int k) 
    {
        
        Dictionary<char,int> freq= new Dictionary<char,int>();

        int left=0,maxi=0,rez=0;

        for(int right=0;right<s.Length;right++)
        {
            char current=s[right];

            if(!freq.ContainsKey(current))
                freq[current]=0;

            freq[current]++;

            maxi=Math.Max(maxi,freq[current]);

            while ((right - left + 1) - maxi > k)
            {
                freq[s[left]]--;
                left++;
            }

            rez=Math.Max(rez,right-left+1);

        }

        return rez;

    }
}
