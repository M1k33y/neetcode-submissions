public class Solution {
    public bool hasDuplicate(int[] nums) 
    {
        HashSet<int> nr= new HashSet<int>();

        for(int i=0;i<nums.Length;i++)
            if(nr.Contains(nums[i]))
                return true;
            else
                nr.Add(nums[i]);

        return false;
    }
}