public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexes = new Dictionary<int, int>();

        for(int i=0; i<nums.Length; i++)
        {
            int comp = target - nums[i];
            if(indexes.ContainsKey(comp))
            {
                return new int[] {indexes[comp], i};
            }

            indexes.TryAdd(nums[i], i);            
        }
        return new int[0];
    }
}
