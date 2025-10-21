class Solution {
    public int findClosestNumber(int[] nums) {
        int ret = nums[0];
        for(int i = 1; i < nums.length; i++){
            if(Math.abs(nums[i]) <= Math.abs(ret)){
                if(Math.abs(nums[i]) == Math.abs(ret)){
                    ret = Math.max(nums[i], ret);
                }
                else{
                    ret = nums[i];
                } 
            }
        }

        return(ret);
    }
}
