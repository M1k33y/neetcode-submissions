public class Solution {
    public List<List<int>> ThreeSum(int[] nums) 
    {

     

        for(int i=0;i<nums.Length;i++)
            for(int j=i+1;j<nums.Length;j++)
                if(nums[i]>nums[j])
                (nums[i],nums[j])=(nums[j],nums[i]);
        
        List<List<int>> rez=new List<List<int>>();

        

        for(int i=0;i<nums.Length-1;i++)
        {
            int target=-nums[i];
            int j = i + 1;
            int k = nums.Length - 1;

             if(i > 0 && nums[i] == nums[i - 1])
                continue;

            while(j < k)
            {
                if(nums[j] + nums[k] < target)
                    j++;
                else if(nums[j] + nums[k] > target)
                    k--;
                else
                {
                    rez.Add(new List<int>{nums[i], nums[j], nums[k]});
                     j++;
                     k--;
                    while(j < k && nums[j] == nums[j - 1])
                        j++;

                    while(j < k && nums[k] == nums[k + 1])
                        k--;
                }
            }
        }

        return rez;
    }
}
