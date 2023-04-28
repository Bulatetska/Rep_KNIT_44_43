from abc import ABC, ABCMeta, abstractmethod
import math

class Point():
    
    def __init__(self) -> None:
        self._coords = []
        
    def __init__(self, coords:tuple) -> None:
        self._coords = coords

    def distance_to(self, p2):
        if(type(self) != type(p2)):
            raise TypeError
        distance = 0
        for coord in zip(self.__coords, p2.__coords):
            distance += coord[0] - coord[1]
        return math.sqrt(distance)

# class Point1(Point):
#     def __init__(self) -> None:
#         self.x = 0.0
#     def _coords_tuple(self) -> tuple:
#         return (self.x)

# class Point2(Point1):
#     def __init__(self) -> None:
#         self.x = 0.0
#         self.y = 0.0
#     def _coords_tuple(self) -> tuple:
#         return (self.x, self.y)

# class Point3(Point1):
#     def __init__(self) -> None:
#         self.x = 0.0
#         self.y = 0.0
#         self.z = 0.0
#     def _coords_tuple(self) -> tuple:
#         return (self.x, self.y, self.z)
