public class Solution {
    public int MaxArea(int[] heights) 
    {
        int maxi=0;
        int i=0,j=heights.Length-1;
       
       while(i<j)
       {

         int current=Math.Min(heights[i],heights[j])*(j-i);

        if(current>maxi)
            maxi=current;

        if(heights[i]<heights[j])
            i++;
        else
            j--;


       }

        return maxi;


    }
}
