/*
You are given two arrays (without duplicates) nums1 and nums2 where nums1’s elements are subset of nums2. Find all the next greater numbers for nums1's elements in the corresponding places of nums2.

The Next Greater Number of a number x in nums1 is the first greater number to its right in nums2. If it does not exist, output -1 for this number.

Example 1:
Input: nums1 = [4,1,2], nums2 = [1,3,4,2].
Output: [-1,3,-1]
Explanation:
    For number 4 in the first array, you cannot find the next greater number for it in the second array, so output -1.
    For number 1 in the first array, the next greater number for it in the second array is 3.
    For number 2 in the first array, there is no next greater number for it in the second array, so output -1.
    /*
    
    public class Solution {
    public int[] NextGreaterElement(int[] nums1, int[] nums2) {
        List<int> elements = new List<int>(); // list of integers for final answer
        for(int i = 0; i < nums1.Length; i++){ // for every element in the first array...
                bool ready = false; // flag to determine if we found the number from the first array in the second array
                bool passed = false; // flag to determine if we found a greater element in the second array
            for(int j = 0; j < nums2.Length; j++){ // ...iterate through every element in the second array
                if (nums2[j] == nums1[i]){ // check if we found the number from the first array in the second array
                    ready = true; // if so, set ready to true
                }  
                if (ready && !passed){ // check if ready and not passed
                    if (nums2[j] > nums1[i]){ // check if find a greater element
                        elements.Add(nums2[j]); // if so, add it to the answer
                        passed = true; // if so, set passed to true
                    }
                }
            }
            if (!passed){ // check if we passed the greater element test yet
                elements.Add(-1); // if not, add -1 instead.
            }
        }
        return elements.ToArray(); // return the answer as an int[]
    }
}
