public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int currentCount=0;
        int maxCount=0;
        int[] ans= nums;

        for(int i =0; i<ans.Length;i++){
                
            if(ans[i]==1)
            {
            currentCount++;
            if (currentCount > maxCount) 
            {
                maxCount = currentCount;
            }   
            }
            else
            currentCount=0;
        }
    return maxCount;

    }
}