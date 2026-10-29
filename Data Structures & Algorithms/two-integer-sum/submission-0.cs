public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int size = nums.Length;
        List<int> indexes = new List<int>();

        for(int i=0;i<size-1;i++)
        {
            for(int j=i+1;j<size;j++)
            {
                if(nums[i]+nums[j] == target)
                {
                    indexes.Add(i);
                    indexes.Add(j);
                }
            }
        }
        return indexes.ToArray();
    }
}
