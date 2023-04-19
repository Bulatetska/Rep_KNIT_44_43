my_dict = {
  "apple": 1,
  "banana": 2,
  "orange": 3,
  "kiwi": 4
}

keys_to_delete = []

for key in my_dict:
    if key.startswith('a'):
      keys_to_delete.append(key);
      
for key in keys_to_delete:
    my_dict.pop(key)
    
print(my_dict)
