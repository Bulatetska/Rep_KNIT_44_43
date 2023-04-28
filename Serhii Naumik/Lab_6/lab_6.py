class Car:
    def __init__(self, brand, color, engine_size):
        self.brand = brand
        self.color = color
        self.engine_size = engine_size
    
    def forward(self):
        print(self.color, self.brand, "Їде вперед")
    
    def backward(self):
        print(self.color, self.brand, "Їде назад")

Car1 = Car("Audi", "Сіра", '2.0')

Car1.forward()
Car1.backward()

class Car2(Car):
    def left(self):
        print(self.color, self.brand, "Повертає ліворуч")
    
    def right(self):
        print(self.color, self.brand, "Повертає праворуч")

с2 = Car2("BMW", "Червона", '1.8')

с2.forward()
с2.backward()
с2.left()
с2.right()

class Plane:
    def __init__(self, model):
        self.model = model
    
    def fly(self):
        print(self.model, "Злітає!!!")

a1 = Plane('Hunter')
a1.fly()

class Car2_Plane(Car2, Plane):
   def __init__(self, brand, color, engine_size, model):
        Car2.__init__(self, brand, color, engine_size)
        Plane.__init__(self, model)

ac1 = Car2_Plane("Машина", "Зелана", "Big)", "Typhoon")

ac1.forward()
ac1.backward()
ac1.left()
ac1.right()
ac1.fly()
