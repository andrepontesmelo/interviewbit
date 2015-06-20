import unittest

from prime import Prime

class MathPrimeTest(unittest.TestCase):
    def test_isPrime1(self):
        assert(Prime().isPrime(1)) == 0

    def test_isPrime2(self):
        assert(Prime().isPrime(2)) == 1

    def test_isPrime3(self):
        assert(Prime().isPrime(3)) == 1

    def test_isPrime4(self):
        assert(Prime().isPrime(4)) == 0

