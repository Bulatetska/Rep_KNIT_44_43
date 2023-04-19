dictionary = {
  1: "apple",
  2: "banana",
  3: "orange",
  4: "kiwi"
}

for key in dictionary.keys():
    if key % 2 == 0:
        print(dictionary[key])
