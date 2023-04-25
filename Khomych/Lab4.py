A = {3, 5, 11, 7, 4, -3}
B = {11, 5, 8, 1, 10, 7}

print(A-B)
print(A&B)
print(A|B)

a = "a14b6fh"
print(len(set(a)) == len(a))

l = [5, 10, -2, 11, 5, 5, 22, 150, -330, 5, 11, 3, 151]
print(len(l) - len(dict.fromkeys(l)))

print([dict(zip([i for i in range(0, len(l))],l))[key] for key in dict(zip([i for i in range(0, len(l))],l)).keys() if not key & 1])

d = {"abc": 120, "bc": 11, "yg": 58, "ld": -8, "ah": 10}
print({key:d[key] for key in d if not key.startswith('a')})