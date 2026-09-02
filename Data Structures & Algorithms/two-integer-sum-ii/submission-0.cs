public class Solution {
    public int[] TwoSum(int[] numbers, int target) 
    {
        
        Dictionary<int,int> complement=new Dictionary<int,int>();

        for(int i=0;i<numbers.Length;i++)
        {
            int comp=target-numbers[i];

            if(complement.ContainsKey(comp))
                return new int[] {complement[comp]+1,i+1};
            complement[numbers[i]]=i;
        }
        return new int[] {};

    }
}
