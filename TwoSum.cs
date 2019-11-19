/*
Given an array of integers, return indices of the two numbers such that they add up to a specific target.

You may assume that each input would have exactly one solution, and you may not use the same element twice.
*/
public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        for(int i = 0; i < nums.Length; i++){
            for(int j = i; j < nums.Length; j++){
                if (j+1 < nums.Length){
                    if (nums[i] + nums[j+1] == target){
                        return new int[]{i,j+1};
                    }
                }

            }
        }
        
        return null;
        
    }
}
