public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int j = 0;
        for (int i = 0; i<nums.Length; i++){
           if (nums[i] != val) {
            nums[j++] = nums[i];
            }
        }
        return j;
    }
}

// First, we initialize the variable j and set it equal to 0.
// The code uses a for loop to iterate through each element of the nums array using the index i.
// Inside the loop:
// It checks whether the current element nums[i] is not equal (!==) to the specified val.
// If nums[i] is not equal to val, it means that this element should be kept in the modified array. So, it assigns the value of nums[i] to the position nums[k], where k is the index for the new array without the specified val.
// After assigning the value, it increments k by 1 to indicate that a valid element has been placed in the new array.
// 4. After the loop completes, all occurrences of val have been removed from the array, and k now represents the new length of the modified array.

// 5. The function returns the value of k, which is the new length of the array with val removed. This is because all elements from index 0 to j-1 in the nums array are the valid elements after removal.