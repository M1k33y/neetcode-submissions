public class Solution {
    public int MaxProfit(int[] prices) 
    {
        int[] prefix=new int[prices.Length];
        
        int mini=prices[0],maxi=0;
        for(int i=0;i<prices.Length;i++)
        {
            
            if(prices[i]<mini)
                mini=prices[i];

            prefix[i]=mini;

        }

        for(int i=0;i<prices.Length;i++)
            if(prices[i]-prefix[i]>maxi)
                maxi=prices[i]-prefix[i];
        
       // Console.WriteLine(string.Join(", ", prefix));
        return maxi;


    }
}
