# Клас автомобіля
class Car:
    def __init__(self, brand, color, engine_volume):
        self.brand = brand
        self.color = color
        self.engine_volume = engine_volume

    def drive_forward(self):
        print("Drive forward")

    def drive_backward(self):
        print("Drive backward")


# Клас автомобіля, успадкований від класу Car
class CarWithTurning(Car):
    def turn_left(self):
        print("Turn left")

    def turn_right(self):
        print("Turn right")


# Клас літака
class Airplane:
    def __init__(self, model):
        self.model = model

    def take_off(self):
        print("Take off")


# Клас, успадкований від класів CarWithTurning та Airplane
class FlyingCar(CarWithTurning, Airplane):
    pass


# Приклад використання класу FlyingCar
my_car = FlyingCar("Honda", "Blue", 3.0)
print("Brand:", my_car.brand)
print("Color:", my_car.color)
print("Engine volume:", my_car.engine_volume)

my_car.drive_forward()
my_car.drive_backward()
my_car.turn_left()
my_car.turn_right()
my_car.take_off()