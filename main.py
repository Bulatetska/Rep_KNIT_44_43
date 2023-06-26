import math

class Circle:
    def Set(self, x, y, radius):
        self.x = x
        self.y = y
        self.radius = radius

    def Get(self):
        return [self.x, self.y, self.radius]

    def Print(self):
        print('x =', self.x, ', y =', self.y, ', radius =', self.radius)

    def Area(self):
        return 3.1415 * self.radius * self.radius

    def calculate_circumference(self):
        return 2 * math.pi * self.radius

    
    def intersect(self, other_circle):
        distance = math.sqrt((self.x - other_circle.x)**2 + (self.y - other_circle.y)**2)
        if distance <= self.radius + other_circle.radius:
            return True
        else:
            return False

circle1 = Circle()
circle2 = Circle()

circle1.Set(4, 2, 5)
circle2.Set(5, 8, 9)


circle1 = Circle()
circle2 = Circle()

circle1.Set(4, 2, 5)
circle2.Set(7, 2, 3)

import unittest

import math

class CircleTestCase(unittest.TestCase):
    def setUp(self):
        self.circle1 = Circle()
        self.circle2 = Circle()

    def test_Set(self):
        self.circle1.Set(4, 2, 5)
        self.assertEqual(self.circle1.Get(), [4, 2, 5])

    def test_Area(self):
        self.circle1.Set(4, 2, 5)
        self.assertAlmostEqual(self.circle1.Area(), 78.5367, places=4)

    def test_calculate_circumference(self):
        self.circle1.Set(4, 2, 5)
        self.assertAlmostEqual(self.circle1.calculate_circumference(), 31.4159, places=4)

    def test_intersect(self):
        self.circle1.Set(4, 2, 5)
        self.circle2.Set(7, 2, 3)
        self.assertTrue(self.circle1.intersect(self.circle2))


    
if __name__ == '__main__':
    unittest.main()