import re
import random
def clean_text(text):

    cleaned_text = re.sub('[^A-Za-z0-9\s]+', '', text)

    # Випадково замінюємо деякі символи на emoji
    modified_text = ''
    for char in cleaned_text:
        if random.random() < 0.1:  # ймовірність заміни символу на emoji - 10%
            modified_text += random_emoji()
        else:
            modified_text += char
    
    return modified_text

def random_emoji():

    # Функція для отримання випадкового emoji.

    emojis = ['😀', '😎', '🐼', '🌟', '🍕', '🎉', '🌈']
    return random.choice(emojis)


def count_words(text):

    # Функція для підрахунку кількості слів у тексті.

    cleaned_text = clean_text(text)
    words = cleaned_text.split()
    word_count = len(words)
    return word_count

def reverse_text(text):

    # Функція для обертання тексту задом наперед.

    reversed_text = text[::-1]
    return reversed_text

def capitalize_text(text):

    # Функція для перетворення всіх літер кожного слова у тексті на великі.

    capitalized_text = text.upper()
    return capitalized_text
