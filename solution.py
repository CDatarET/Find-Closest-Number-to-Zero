class Solution:
    def findClosestNumber(self, nums):
        ret = nums[0]
        for i in range(len(nums)):
            if abs(nums[i]) <= abs(ret):
                if abs(nums[i]) == abs(ret):
                    ret = max(nums[i], ret)
                else:
                    ret = nums[i]
        
        return ret
