import unittest
from calculator import Calculator

class TestCalculator(unittest.TestCase):
    def setUp(self):
        self.calculator = Calculator()

    def test_addition(self):
        self.assertEqual(self.calculator.add(2, 3), 5)
        self.assertEqual(self.calculator.add(0, 0), 0)
        self.assertEqual(self.calculator.add(-2, 3), 1)

    def test_subtraction(self):
        self.assertEqual(self.calculator.subtract(5, 3), 2)
        self.assertEqual(self.calculator.subtract(0, 0), 0)
        self.assertEqual(self.calculator.subtract(-2, 3), -5)

    def test_multiplication(self):
        self.assertEqual(self.calculator.multiply(2, 3), 6)
        self.assertEqual(self.calculator.multiply(0, 0), 0)
        self.assertEqual(self.calculator.multiply(-2, 3), -6)

    def test_division(self):
        self.assertEqual(self.calculator.divide(6, 3), 2)
        self.assertEqual(self.calculator.divide(0, 5), 0)
        self.assertEqual(self.calculator.divide(-6, 3), -2)
        with self.assertRaises(ValueError):
            self.calculator.divide(6, 0)

if __name__ == '__main__':
    unittest.main()