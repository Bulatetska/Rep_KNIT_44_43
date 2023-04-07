import random
A = {3, 5, 11, 7, 4, -3}
B = {11, 5, 8, 1, 10, 7}
alphabet = ['a','b','c','d','e','f']

def first():
    print(list(filter(lambda x: x not in B, A)))

def second():
    print(list(filter(lambda x: x in B, A)))

def third():
    print(A.union(B))

def fourth():
    a = "“a14b6fh"
    f = True
    for x in a:
        if list(a).count(x) > 1:
            f = False
            break
    return f

def fifth():
    ls = [random.randint(0, 5) for i in range(100)]
    print(ls)
    values = {}
    for x in ls:
        values[x] = values.get(x, 0) + 1
    values = {i: values[i] for i in sorted(list(values.keys()))}
    print(values)

def sixth():
    dict = {i:random.randint(0, 100) for i in range(10)}
    print(dict)
    print(dict)

    for k, v in dict.items():
        if k%2 == 0:
            print(f"[{k}] = {v}")

def randname(n:int):
    return ''.join([random.choice(alphabet) for i in range(n)])

def seventh():
    values = {randname(5):i for i in range(10)}
    print(values)
    for k in list(values.keys()):
        if k[0] == 'a':
            values.pop(k)
    print(values)

first()
second()
third()
print(fourth())
fifth()
sixth()
seventh()