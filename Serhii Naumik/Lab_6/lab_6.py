class Car:
    def __init__(self, brand, color, engine_capacity):
        self.brand = brand
        self.color = color
        self.engine_capacity = engine_capacity
    
    def drive_forward(self):
        print("Drive forward.")
    
    def drive_backward(self):
        print("Drive backward.")

class CarWithTurn(Car):
    def turn_left(self):
        print("Turn left.")
    
    def turn_right(self):
        print("Turn right.")

class Airplane:
    def __init__(self, model):
        self.model = model
    
    def takeoff(self):
        print("Takeoff.")

class FlyingCar(CarWithTurn, Airplane):
    def __init__(self, brand, color, model):
        Car.__init__(self, brand, color, engine_capacity=None)
        Airplane.__init__(self, model)

my_flying_car = FlyingCar("Toyota", "red", "Airplane 1")
my_flying_car.drive_forward()  # виведе "Drive forward."
my_flying_car.turn_left()      # виведе "Turn left."
my_flying_car.takeoff()   
my_flying_car.turn_right()     # виведе "Takeoff."
