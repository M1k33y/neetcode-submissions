public class Solution {
    public int Search(int[] nums, int target) 
    {
        
        int st=0,dr=nums.Length-1;
        
        while(st<=dr)
        {
            int mid=(st+dr)/2;

            if(target==nums[mid])
                return mid;

            if(target<nums[mid])
                dr=mid-1;
            else
                st=mid+1;
        }

        return -1;


    }
}
