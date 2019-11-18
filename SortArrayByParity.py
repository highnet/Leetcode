/*
Given an array A of non-negative integers, return an array consisting of all the even elements of A, followed by all the odd elements of A.

You may return any answer array that satisfies this condition.
/*
class Solution(object):
    def sortArrayByParity(self, A):
        """
        :type A: List[int]
        :rtype: List[int]
        """
        arr = []
        end = []
        for i in range(len(A)):
            case = A[i]
            if (case % 2 == 0):
                arr.append(case)
            else:
                end.append(case)
        return arr + end
            
        
