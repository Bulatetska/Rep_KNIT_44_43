import unittest
from tkinter import *
from game_logic import check_default_value, sproba, check_bulls_cows

class GameLogicTest(unittest.TestCase):
    def test_check_default_value(self):
        self.assertEqual(check_default_value('1234'), '1234')  # Перевірка, якщо вхідний рядок має довжину 4
        self.assertEqual(check_default_value('12345'), '')  # Перевірка, якщо вхідний рядок має довжину більше 4
        self.assertEqual(check_default_value('12a4'), '')  # Перевірка, якщо вхідний рядок містить нечислові символи
        self.assertEqual(check_default_value('12'), '')  # Перевірка, якщо вхідний рядок має довжину менше 4

    def test_sproba(self):
        num = [0]
        EntryB = Entry()
        sproba(num, EntryB)
        self.assertEqual(num[0], 1)  # Перевірка, чи правильно збільшується значення num

        num = [9]
        sproba(num, EntryB)
        self.assertEqual(num[0], 10)  # Перевірка, чи правильно збільшується значення num при існуючому значенні

        self.assertIn('10', EntryB.get())
        
    def test_check_bulls_cows(self):      # Перевірка на визначення кількості биків і корів
        st0 = '1234'
        st = '5678'
        expected_output = (0, 0)
        self.assertEqual(check_bulls_cows(st0, st), expected_output)

        st = '1256'
        expected_output = (2, 0)
        self.assertEqual(check_bulls_cows(st0, st), expected_output)

        st = '1234'
        expected_output = (4, 0)
        self.assertEqual(check_bulls_cows(st0, st), expected_output)

        st = '4321'
        expected_output = (0, 4)
        self.assertEqual(check_bulls_cows(st0, st), expected_output)

if __name__ == '__main__':
    unittest.main()





