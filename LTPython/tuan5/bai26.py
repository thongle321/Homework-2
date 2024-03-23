while True:
    n = input("Nhap so dong: ")
    if n.isdigit():
        break
n = int(n)
for i in range(n+1,0,-1):
    for j in range(1,i):
        print("*", end=' ')
    print()