public class Solution {
    public bool IsPalindrome(string s) 
    {
        string clean="";
        foreach(char c in s)
            if( char.IsLetterOrDigit(c) )
                clean+=char.ToLower(c);
        

        for(int i=0;i<clean.Length/2;i++)
            if(clean[i]!=clean[clean.Length-1-i])
                return false;
        return true;
    }
}
