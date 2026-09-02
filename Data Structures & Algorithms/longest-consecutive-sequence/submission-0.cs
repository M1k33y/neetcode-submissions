public class Solution 
{
    public int LongestConsecutive(int[] nums) 
    {
        HashSet<int> exists=new HashSet<int>(nums);

        int longest=0;

        for(int i=0;i<nums.Length;i++)
        {
            if(!exists.Contains(nums[i]-1))
                {
                    int current=nums[i];
                    int length=1;

                    while(exists.Contains(current+1))
                    {
                        current++;
                        length++;
                    }

                    if(length>longest)
                    longest=length;
                }
        }

        return longest;
    }
}
