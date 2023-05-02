import unittest

class SimpleCalculator:
    def add(self, x, y):
        return x + y

    def subtract(self, x, y):
        return x - y

    def multiply(self, x, y):
        return x * y

    def divide(self, x, y):
        if y == 0:
            raise ValueError('Cannot divide by zero')
        return x / y


class TestSimpleCalculator(unittest.TestCase):
    def test_addition(self):
        calculator = SimpleCalculator()
        self.assertEqual(calculator.add(2, 3), 5)

    def test_subtraction(self):
        calculator = SimpleCalculator()
        self.assertEqual(calculator.subtract(2, 3), -1)

    def test_multiplication(self):
        calculator = SimpleCalculator()
        self.assertEqual(calculator.multiply(2, 3), 6)

    def test_division(self):
        calculator = SimpleCalculator()
        self.assertEqual(calculator.divide(6, 3), 2)

    unittest.main()