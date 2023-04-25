class Car:
    def __init__(self, brand, color, engine_volume):
        self.brand = brand
        self.color = color
        self.engine_volume = engine_volume
    
    def drive_forward(self):
        print("Drive forward")
    
    def drive_backward(self):
        print("Drive backward")
        
class CarTurn(Car):
    def turn_left(self):
        print("Turn left")
    
    def turn_right(self):
        print("Turn right")

class Airplane:
    def __init__(self, model):
        self.model = model
    
    def take_off(self):
        print("Take off")

class FlyingCar(CarTurn, Airplane):
    pass

my_flying_car = FlyingCar("Tesla Air", "red", "30")
my_flying_car.drive_forward() 
my_flying_car.turn_left()
my_flying_car.take_off()