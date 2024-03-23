import math
j = float(input("Nhap j: "))
x = 0
for i in range(2,7):
    x += pow(i,j)
x = pow(x,1/j)
print("X =", x)