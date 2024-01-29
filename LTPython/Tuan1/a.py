# print("Chuong trinh kiem tra kieu du lieu nhap!")
# number = input("Nhap so: ")
# string = input("Nhap chuoi: ")
# print("\n")
# print("Kieu du lieu nhap vao la: ")
# print("Number", type(number))
# print("String", type(string))
#Cách 1: Chuyển đổi thành int hoặc float để kiểm tra input là số hay chuỗi.
# print ("Chuong trinh kiem tra kieu du lieu nhap!")
# user_input = input("Nhap mot so: ")
# print("\n")
# try:
#     val = int(user_input)
#     print("Du lieu nhap vao la int = ", val)
# except ValueError:
#     try:
#         val = float(user_input)
#         print("Du lieu vua nhap la float = ", val)
#     except ValueError:
#         print("Du lieu nhap vao khong phai la number!")
#Cách 2: Sử dụng hàm isdigit để kiểm tra là number hay string.
# print("Chuong trinh kiem tra du lieu nhap!")
# num = input("Nhap so: ")
# print("\n")
# if num.isdigit():
#     print("Du lieu nhap vao la so!")
# else:
#     print("Du lieu nhap vao la chuoi!")
#Viết chương trình nhập vào một số bằng Python
# while True:
#     number = input("Nhap vao mot so: ")
#     try:
#         value = int(number)
#         print("Du lieu vua nhap la so nguyen!")
#         print("Gia tri cua no la: ",value,type(value))
#         break;
#     except ValueError:
#         try:
#             value = float(number)
#             print("Du lieu vua nhap la so thuc!")
#             print("Gia tri cua no la ",value,type(value))
#             break;
#         except ValueError:
#             print("Du lieu vua nhap khong phai la so!, nhap lai")
#Tính tổng S(n) = 1 + 2 + 3 + … + n bằng Python dung for
# tong = 0
# n = 1
# #Nhap du lieu
# print("Hay nhap vao so n: ")
# 4
# n = int(input())

# #Tinh tong
# for i in range(0, n+1):
#     tong += i

# #In ket qua
# print("Tong la: ", tong)
#Tính tổng S(n) = 1 + 2 + 3 + … + n bằng Python dung while
# tong = 0
# n = 1
# i = 1
# print("Tính tổng S(n) = 1 + 2 + 3 + … + n")
# #Nhap du lieu
# n = int(input("Hay nhap vao so n: "))
# #Tinh tong
# while i <= n:
#     tong += i
#     i += 1
# #In ket qua
# print("Tong la: ", tong)
#Tính tổng S(n) = 1^2 + 2^2 + … + n^2 bằng Python dung for
# tong = 0
# n = 0
# n = int(input("Nhap vao so n: "))

# #Tinh tong so mu
# for i in range(1, n+1):
#     tong += i**2
# #In ra ket qua
# print("Tong la: ", tong)
#Tính tổng S(n) = 1 + ½ + 1/3 + … + 1/n bằng Python