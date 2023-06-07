def eat(self):
    head_x = self.body[-1]['x']
    head_y = self.body[-1]['y']
    eat = 0
    if ((head_x
         + self.CONST.SNAKE_THICKNESS.value // 2 > (self.food.x
                                                    - self.CONST.FOOD_THICKNESS.value // 2))
            and (head_x
                 - self.CONST.SNAKE_THICKNESS.value // 2 < (self.food.x
                                                            + self.CONST.FOOD_THICKNESS.value // 2))
            and (head_y
                 + self.CONST.SNAKE_THICKNESS.value // 2 > (self.food.y
                                                            - self.CONST.FOOD_THICKNESS.value // 2))
            and (head_y
                 - self.CONST.SNAKE_THICKNESS.value // 2 < (self.food.y
                                                            + self.CONST.FOOD_THICKNESS.value // 2))):
        self.canv.delete(self.food.id)
        self.food.add(self)
        eat = 1
    return eat