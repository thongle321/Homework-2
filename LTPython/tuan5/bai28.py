def GT(n):
    if n == 0:
        return 1
    return GT(n-1)*n
def C(n,k):
    return int(GT(n) / (GT(k) * GT(n-k)))
while True:
    n = input("Nhap n: ")
    if n.isdigit():
        break
n = int(n)
for i in range(n):
    for j in range(n - i + 1):
        print(' ',end = ' ')
    for j in range(i+1):
        print('{:<4}'.format(C(i,j)), end='')
    print('')
