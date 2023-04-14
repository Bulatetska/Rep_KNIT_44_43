class Car:
    model:str
    hex_color:str
    eng_v:float
    def forward(this):
        print("Vrum Vrum")
    
    def backward(this):
        print("murV murV")

class CarButBetter(Car):
    def left(this):
        for c in "Vrum Vrum":
            print(c)

    def right(this):
        for c in "murV murV":
            print(c)
    
class Plane:
    def fly(this):
        print ("fly")

class Thing(CarButBetter, Plane):
    def asd(this):
        print("asd")

car = Car();
bCar = CarButBetter();
plane =  Plane();
shchos = Thing();
print("_____CAR_____");
car.backward();
car.forward();
print("_____BETTER_CAR_____");
bCar.forward()
bCar.left();
bCar.right();
print("_____PLANE_____");
plane.fly();
print("_____THE_THING_____");
shchos.backward();
shchos.forward();
shchos.left();
shchos.right();
shchos.fly();
