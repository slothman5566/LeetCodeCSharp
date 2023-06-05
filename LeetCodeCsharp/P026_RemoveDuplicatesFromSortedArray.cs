namespace LeetCodeCSharp.P026_RemoveDuplicatesFromSortedArray

{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 1)
            {
                return nums.Length;
            }
            var i = 0;

            for (var j = 1; j < nums.Length; j++)
            {
                if (nums[j] > nums[i])
                {
                    i++;
                    nums[i] = nums[j];
                }
            }
            return i + 1;
        }
    }
}
