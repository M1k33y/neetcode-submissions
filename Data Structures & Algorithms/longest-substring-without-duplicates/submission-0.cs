public class Solution {
    public int LengthOfLongestSubstring(string s) 
    {
            int left=0,right=0,maxi=0;

            HashSet<char> exists= new HashSet<char>();

        for(right=0;right<s.Length;right++)
        {
            while(exists.Contains(s[right]))
            {
                exists.Remove(s[left]);
                left++;
            }

            exists.Add(s[right]);

            maxi = Math.Max(maxi,right-left+1);
        }

        return maxi;
    }
}
