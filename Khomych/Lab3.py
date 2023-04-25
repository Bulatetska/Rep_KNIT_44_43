def del_dup(l):
    return list(dict.fromkeys(l))

def sq_l(l):
    return [el**2 for el in l]

l = [5, 10, -2, 11, 5, 5, 22, 150, -330, 5, 11, 3, 151]

print(del_dup(l))
print(sq_l(l))
print(max(l))