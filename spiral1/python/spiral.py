class Solution:
    # @param A : tuple of list of integers
    # @return a list of integers
    def spiralOrder(self, A):
        result = []

        if A == []:
            return []

        top = 0
        left = 0
        right = len(A) - 1
        bottom = len(A[0]) - 1

        dire = 0

        if dire == 0:
            for x in range(left, right):
                result.append(x)

        return result
