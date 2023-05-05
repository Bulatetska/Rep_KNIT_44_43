import unittest
from calc import SimpleCalculator
class MyTestCase(unittest.TestCase):
    def setUp(self) -> None:
        self.calculator = SimpleCalculator()

    def tearDown(self) -> None:
        print("Test is done. Result:")
    
    def test_add(self):
        self.assertEqual(self.calculator.add(1, 2), 3)
        self.assertEqual(self.calculator.add(1, -2), -1)
        self.assertEqual(self.calculator.add(1, 0), 1)
    
    def test_subtract(self):
        self.assertEqual(self.calculator.subtract(1, 2), -1)
        self.assertEqual(self.calculator.subtract(1, -2), 3)
        self.assertEqual(self.calculator.subtract(1, 0), 1)
    
    def test_multiply(self):
        self.assertEqual(self.calculator.multiply(1, 2), 2)
        self.assertEqual(self.calculator.multiply(1, -2), -2)
        self.assertEqual(self.calculator.multiply(1, 0), 0)
    
    def test_divide(self):
        self.assertEqual(self.calculator.divide(1, 2), 0.5)
        self.assertEqual(self.calculator.divide(1, -2), -0.5)
        self.assertEqual(self.calculator.divide(1, -2), -0.5)
    
    def test_divide_by_zero(self):
        with self.assertRaises(ZeroDivisionError):
            self.assertEqual(self.calculator.divide(1, 0), "ERROR")
        
    def test_add_int_to_string(self):
        with self.assertRaises(TypeError):
            self.assertEqual(self.calculator.add(1, "2"), "ERROR")

if __name__ == '__main__':
    unittest.main()