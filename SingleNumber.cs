public class Solution
{
    public int SingleNumber(int[] nums)
    {
        HashSet<int> mySet = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!mySet.Contains(nums[i])) mySet.Add(nums[i]);
            else mySet.Remove(nums[i]);
        }

        return mySet.First();
    }
}