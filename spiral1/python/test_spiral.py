
import unittest

from spiral import Solution

class TestSolution(unittest.TestCase):
    def test_empty_array(self):

        solution = Solution()

        array = []

        result = solution.spiralOrder(array)
        assert result == []


if __name__ == "__main__":
    unittest.main()
