import random
import string
random_string = ''.join(random.choices(string.ascii_lowercase, k = 25))
with open('random_string.txt', 'w') as f:
    f.write(random_string)