a = "a14b6fh"
def unique(a):
    for i in range(0, len(a)):
        for j in range(i + 1, len(a)):
            if(a[i] == a[j]):
                return False;
    return True;
    
if(unique(a)):
    print(a, " unique");
