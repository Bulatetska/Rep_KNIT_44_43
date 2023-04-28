from abc import ABC, ABCMeta, abstractmethod
from mrx2d.Matrix import ObservableMatrix as Matrix, MatrixObservator as Observator
from multiprocessing import Process


def colored(r, g, b, text):
    return "\033[38;2;{};{};{}m{} \033[38;2;255;255;255m".format(r, g, b, text)


class Tile:
    pass


class Drawer(Observator, metaclass=ABCMeta):  # ADD START/STOP METHODS
    def __init__(self, matrix: Matrix) -> None:
        super().__init__()
        self._data = matrix
        self._data.subscribe(self)

    @abstractmethod
    def drawAll(self) -> None:
        pass

    def update(self, point: tuple) -> None:
        # Process(target=self.drawAll).start()
        self.drawAll()  # Change to drawing a specific one by a point
        # ADD MULTITHREADING


class ConsoleDrawer(Drawer):
    def __init__(self, matrix: Matrix) -> None:
        super().__init__(matrix)

    def drawAll(self) -> None:
        print(flush=True)
        m = n = 255  # WRITE MAX ELEMENT FINDER
        matrix = self._data._data
        out_str = ""
        for x in [(a, b) for a in range(0, n, 5) for b in range(0, m, 5)]:
            out_str += matrix[x]
            if x[1] == 0:
                out_str += "\n"
        print(out_str)
