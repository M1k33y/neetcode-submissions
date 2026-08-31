public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {

     Dictionary<int,int> freq=new Dictionary<int,int>();

     for(int i=0;i<nums.Length;i++)
        if(!freq.ContainsKey(nums[i]))
            freq[nums[i]]=1;
        else
            freq[nums[i]]++;
    

      var sorted= freq.OrderByDescending(x => x.Value).ToList();

        int[] rez= new int[k];

        for(int i=0;i<k;i++)
            rez[i]=sorted[i].Key;

        return rez;

    }
}
