public class Solution {
    public int Trap(int[] height) 
    {
        
        int[] prefix=new int[height.Length];
        int[] suffix=new int[height.Length];
        int maxi=height[0];
        prefix[0]=height[0];
        for(int i=1;i<height.Length;i++)
        {
            if(height[i]>maxi)
                maxi=height[i];
                
            prefix[i]=maxi;
        }
        maxi=0;
        for(int i=height.Length-1;i>=0;i--)
        {
            if(height[i]>maxi)
                maxi=height[i];
            suffix[i]=maxi;
        }
        int rez=0;
        for(int i=0;i<height.Length;i++)
            rez+=Math.Min(prefix[i],suffix[i])-height[i];

        return rez;
    }
}
