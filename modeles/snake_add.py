class element_square:
    def __init__(self, self_glob, x, y, d, color):
        self.self_glob = self_glob
        self.x = x
        self.y = y
        self.d = d
        self.color = color
        if (self.d % 2) == 0:
            self.d += 1  # сторону квадрата делаю нечётной


    def draw(self):
        x = self.x - (self.d // 2)  # координата левой грани квадрата
        y = self.y - (self.d // 2)  # координата верхней грани квадрата
        return self.self_glob.canv.create_rectangle(x, y, x + self.d,
                                                    y + self.d,
                                                    fill=self.color,
                                                    width=2)