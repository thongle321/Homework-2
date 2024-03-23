import math
x = 1
i = 1
value = 1 / math.factorial(i)
while (value >= 10**-6):
    x+=value
    i+=1
    value = 1 / math.factorial(i)
print("x la: ",x)

'''cau b'''
i = 1
j = 1
x = int(input("Nhap x: "))
sum = 1
value = 1/math.factorial(i)
while value >= 10**-6:
    for 