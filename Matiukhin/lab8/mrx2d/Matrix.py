from abc import abstractmethod, ABC
import warnings
import multiprocessing as mulproc


class MatrixObservator(ABC):
    @abstractmethod
    def update(self, point: tuple) -> None:
        pass

    # @abstractmethod
    # def update(self) -> None:
    #     pass


class ObservableMatrix:
    def __init__(self, dimensions=2, data={}) -> None:
        super().__init__()
        self.__lock = mulproc.Lock()
        self._data = data
        self.__subs = []
        self.__dim = (
            list(data.keys())[0].__len__()
            if data.values().__len__() > 0
            else dimensions
        )

    def __iter__(self):
        return self._data.__iter__()

    @staticmethod
    def __dig_matrix(matrix_data: dict, coords: tuple):
        result = {}
        keys = list(
            filter(
                (None).__ne__,
                map(
                    lambda x: None
                    if any(coord != x[idx] for idx, coord in enumerate(coords))
                    else x,
                    matrix_data.keys(),
                ),
            )
        )
        begin = list(matrix_data.keys())[0].__len__() - coords.__len__()
        for key in keys:
            result[key[begin - 1:]] = matrix_data[key]
        return ObservableMatrix(data=result)

    def set_data(self, data):
        if self.__dim == list(data.keys())[0].__len__():
            self._data = data
            self.__notify(None)

    def __setitem__(self, idx: tuple, value):
        if idx.__len__() != self.__dim:
            raise TypeError("Provided " + idx.__len__().__str__() + 
            "D coordinates for " + self.__dim.__str__() + "D matrix")
        self._data[idx] = value
        self.__notify(idx)

    def __getitem__(self, idx: tuple):
        if idx.__len__() == self.__dim:
            return self._data[idx]
        else:
            return ObservableMatrix.__dig_matrix(self._data, idx)

    def subscribe(self, subscriber: MatrixObservator):
        self.__subs.append(subscriber)

    def __next__(self):
        return self._data.__next__()

    def __notify(self, point: tuple):
        for sub in self.__subs:
            sub.update(point)
