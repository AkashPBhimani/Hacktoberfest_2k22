public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        var closet = 3_000; //maximally the closet is 3 times of element max value.
        Array.Sort(nums);
        for (var i = 0; i <= nums.Length - 3; i++) {
            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right) {
                var value = nums[i] + nums[left] + nums[right];
                if (Closer(value))  closet = value;
                if (value == target) return target;
                if (value > target) right--;
                else left++;
            }
        }
        
        return closet;
        
        bool Closer(int value) => Math.Abs(value - target) <= Math.Abs(closet - target);
    }
}
