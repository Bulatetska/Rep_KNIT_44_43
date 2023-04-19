print("1.")
class Car:
    def __init__(self, brand, color, engine_size):
        self.brand = brand
        self.color = color
        self.engine_size = engine_size
    
    def forward(self):
        print(self.color, self.brand, "Drive forward")
    
    def backward(self):
        print(self.color, self.brand, "Drive backward")

c1 = Car("Reno", "Black", '1.0')

c1.forward()
c1.backward()

print("2.")
class Car2(Car):
    def left(self):
        print(self.color, self.brand, "Turn left")
    
    def right(self):
        print(self.color, self.brand, "Turn right")

с2 = Car2("Mazda", "Blue", '1.8')

с2.forward()
с2.backward()
с2.left()
с2.right()

print("3.")
class Plane:
    def __init__(self, model):
        self.model = model
    
    def fly(self):
        print(self.model, "Fly")

a1 = Plane('Antonov')

a1.fly()

print("4.")
class Car2_Plane(Car2, Plane):
   def __init__(self, brand, color, engine_size, model):
        Car2.__init__(self, brand, color, engine_size)
        Plane.__init__(self, model)

ac1 = Car2_Plane("Car", "White", "Big)", "FlyingCar")

ac1.forward()
ac1.backward()
ac1.left()
ac1.right()
ac1.fly()
