CREATE DATABASE QUANLYSANPHAM
USE QUANLYSANPHAM
CREATE TABLE SANPHAM
(
	ID INT PRIMARY KEY,
	tenSP NVARCHAR(60),
	motaSP NVARCHAR(100),
	gia FLOAT,
	sl INT
)
INSERT INTO SANPHAM (ID, tenSP, motaSP, gia, sl)
VALUES 
(1, N'Áo thun', N'Áo thun cotton, thoáng mát', 150000, 100),
(2, N'Quần jean', N'Quần jean nam, màu đen, chất liệu bền', 350000, 50),
(3, N'Giày thể thao', N'Giày thể thao dành cho nam, màu trắng', 700000, 30);
