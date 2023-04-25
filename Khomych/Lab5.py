def max(l):
    for i in range(len(l) - 1):
        if l[i+1] > l[i]:
            l[0] = l[i+1]
    return f'{l[0]} < 0' if l[0] < 0 else l[0]

l = [5, 10, -2, 11, 5, 5, 22, 150, -330, 5, 11, 3, 151]
lwl = [-2, -1, -5555]
print(max(l))
print(max(lwl))

def len(w):
    if not w: 
      return 0
    return len(w[1:]) + 1

w = "hkgwg"
print(len(w))

def exp(n, e):
    return n**e if e >= 0 else None

print(exp(5, 22))

def seq(n):
    return [el for el in range(1, n)]

print(seq(5))


def rec_area(h, w):
    return h*w if h > 0 and w > 0 else 0

print(rec_area(5, 10))