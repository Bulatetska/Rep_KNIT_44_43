list = ["first", "2", 2, 4, "red", "black", "red"]
dictionary = {} 
for i in list:
    if i in dictionary:
        dictionary[i] = dictionary[i] + 1
    else:
        dictionary[i] = 1
print(dictionary)
