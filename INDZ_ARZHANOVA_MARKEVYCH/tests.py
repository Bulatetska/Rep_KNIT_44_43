import unittest
from equation import solve_linear_equation
from seidel import seidel
from jacobi import jacobi

class LinearEquationTest(unittest.TestCase):
    def test_solve_linear_equation(self):
        a = 2
        b = -3
        expected_solution = 1.5
        actual_solution = solve_linear_equation(a, b)
        self.assertAlmostEqual(actual_solution, expected_solution, places=3)
        print("Результат тесту:", actual_solution)

    def test_seidel(self):
        A = [[4, -1, 1],
             [4, -8, 1],
             [-2, 1, 5]]
        b = [7, -21, 15]
        x0 = [0, 0, 0]
        tolerance = 1e-6
        max_iterations = 100
        expected_solution = [1.75, 3.5, 3.0]

        actual_solution = seidel(A, b, x0, tolerance, max_iterations)

        self.assertEqual(actual_solution, expected_solution)
        print("Результат тесту:", actual_solution)

    def test_jacobi(self):
        A = [[4, -1, 1],
             [4, -8, 1],
             [-2, 1, 5]]
        b = [7, -21, 15]
        x0 = [0, 0, 0]
        tolerance = 1e-6
        max_iterations = 100
        expected_solution = [1.75, 2.625, 3.0]

        actual_solution = jacobi(A, b, x0, tolerance, max_iterations)

        self.assertEqual(actual_solution, expected_solution)
        print("Результат тесту:", actual_solution)



if __name__ == '__main__':
    unittest.main(verbosity=2)