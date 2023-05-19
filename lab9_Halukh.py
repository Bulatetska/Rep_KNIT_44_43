import unittest


class SimpleCalculator:
    def sum(self, a, b):
        return a + b

    def subtract(self, a, b):
        return a - b

    def multiply(self, a, b):
        return a * b

    def divide(self, a, b):
        if b == 0:
            return "ERROR: Division by zero"
        return a / b


class MyTestCase(unittest.TestCase):
    def setUp(self):
        self.calculator = SimpleCalculator()

    def tearDown(self):
        print("\ntearDown executing after the case. Result:")

    def test_addition_two_integers(self):
        result = self.calculator.sum(5, 6)
        self.assertEqual(result, 11)

    def test_addition_integer_string(self):
        result = self.calculator.sum(5, "6")
        self.assertEqual(result, "ERROR")

    def test_addition_negative_integers(self):
        result = self.calculator.sum(-5, -6)
        self.assertEqual(result, -11)
        self.assertNotEqual(result, 11)

    def test_subtraction_two_integers(self):
        result = self.calculator.subtract(10, 5)
        self.assertEqual(result, 5)

    def test_multiplication_two_integers(self):
        result = self.calculator.multiply(3, 4)
        self.assertEqual(result, 12)

    def test_division_two_integers(self):
        result = self.calculator.divide(10, 2)
        self.assertEqual(result, 5)

    def test_division_by_zero(self):
        result = self.calculator.divide(5, 0)
        self.assertEqual(result, "ERROR: Division by zero")


if __name__ == '__main__':
    unittest.main()