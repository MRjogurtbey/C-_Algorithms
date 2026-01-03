public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n= nums.Length;
        int[] ans =new int [2*n];
        Array.Copy(nums,0,ans,0,n);
        Array.Copy(nums,0,ans,n,n);

    return ans;
    }
}