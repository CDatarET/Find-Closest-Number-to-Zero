public class Solution {
    public int FindClosestNumber(int[] nums) {
        int ret = nums[0];
        for(int i = 1; i < nums.Length; i++){
            if(Math.Abs(nums[i]) <= Math.Abs(ret)){
                if(Math.Abs(nums[i]) == Math.Abs(ret)){
                    ret = Math.Max(nums[i], ret);
                }
                else{
                    ret = nums[i];
                } 
            }
        }

        return(ret);
    }
}
