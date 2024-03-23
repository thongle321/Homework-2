while True:
    n = input("Nhap n: ")
    if n.isdigit():
        break
n = int(n)
k = 1
for i in range(1, n + 1):
    for j in range(1, i + 1):
        print('{:<2}'.format(k), end=" ")
        k = k + 1
    print()