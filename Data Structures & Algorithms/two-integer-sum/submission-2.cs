public class Solution {
    public int[] TwoSum(int[] nums, int target) 
    {
        
        Dictionary<int,int> complement=new Dictionary<int,int>();


        for(int i=0;i<nums.Length;i++)
        {
            int comp=target-nums[i];

           if(complement.ContainsKey(comp))
            return new[]{complement[comp],i};

            complement[nums[i]]=i;
        }

        return new int[]{};

    }
}
