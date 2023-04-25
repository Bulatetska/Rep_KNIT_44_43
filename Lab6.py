class Car:
    def __init__(self, model, color, engine_vol):
        self.model = model
        self.color = color
        self.engine_vol = engine_vol
    
    def forward(self):
        print("W")
    
    def backward(self):
        print("S")

class RealCar(Car):
    def left(self):
        print("A")
    
    def right(self):
        print("D")

class Plane:
    def __init__(self, model):
        self.model = model
    
    def fly(self):
        print("-")

class Hybrid(RealCar, Plane):
    pass

rc = RealCar("Quadra Turbo R V-Tech", "black", 4.4)
p = Plane("Ospreys")

h = Hybrid(rc.model, rc.color, rc.engine_vol)

h.fly()
h.left()