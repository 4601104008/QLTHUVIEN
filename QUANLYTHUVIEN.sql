CREATE DATABASE QUANLITHUVIENK45
GO
USE QUANLITHUVIENK45
GO


create table SACH
(
    ID NVARCHAR(10) PRIMARY KEY,
	TenSach NVARCHAR(100),
	TacGia NVARCHAR(100), 
	MaSach NVARCHAR(10) ,
	GiaSach NVARCHAR(100),
	SoLuong NVARCHAR(100),
	NXB NVARCHAR(100),
	
)
go
create table KESACH
(
	MaSach NVARCHAR(10) PRIMARY KEY,
	TenTheLoaiSach NVARCHAR(100),
	
)
go

create table PHIEUSACH
(
	ID NVARCHAR(10) PRIMARY KEY,
	MaSach NVARCHAR(10),
	Hoten NVARCHAR(100),
	Diachi NVARCHAR(100), 
	Tensach NVARCHAR(100),
	Tinhtrang NVARCHAR(100),
	Thoigianmuon datetime,
	Thoigiantra  datetime,
	
	
)
go
create table TAIKHOAN
(
	ID  NVARCHAR(10) PRIMARY KEY,
	TenDangNhap  NVARCHAR(100),
	MatKhau  NVARCHAR(100),
)
go
-------NHAP THONG TIN-----


ALTER TABLE dbo.SACH
ADD CONSTRAINT FK_SACH_KESACH
		FOREIGN KEY (MaSach)
		REFERENCES dbo.KESACH(MASACH)
GO

ALTER TABLE dbo.PHIEUSACH
ADD CONSTRAINT FK_KESACH_PHIEU
		FOREIGN KEY (MaSach)
		REFERENCES dbo.KESACH(MaSach)
GO
-------NHAP THONG TIN-----
-- tài khoản
INSERT INTO dbo.TAIKHOAN

VALUES  ( N'01', --MA ID
		N'ADMIN', -- TEN NGƯƠI DÙNG---
		N'123'--MẬT KHẨU--
		   )
GO
INSERT INTO dbo.TAIKHOAN

VALUES  ( N'02', --MA ID
		N'NHOMK45', -- TEN NGƯƠI DÙNG---
		N'123'--MẬT KHẨU--
		   )
GO
-- kệ SÁCH
INSERT INTO dbo.KESACH
VALUES (N'001',--MA SACH
		N'GIÁO KHOA'--MA SACH
		)
GO
INSERT INTO dbo.KESACH
VALUES (N'002',--MA SACH
		N'Tâm Lý - Kỹ Năng Sống'--MA SACH
		)
GO
INSERT INTO dbo.KESACH
VALUES (N'004',--MA SACH
		N'Thể Thao - Nghệ Thuật'--MA SACH
		)
GO
INSERT INTO dbo.KESACH
VALUES (N'005',--MA SACH
		N'Tử Vi - Phong Thủy'--MA SACH
		)
GO
--PHIÊU MƯƠN VÀ TRẢ
INSERT INTO dbo.PHIEUSACH

VALUES  ( N'b01' , -- ID- 
			N'001' , -- THE LOAI- 
		  N'le chu bau' , -- ten gia - 
          N'abcxyz', -- ten tác giả---
		  N'toithayhoavangtrencoxanh' , -- MASACH- 
		  N'ĐÃ TRẢ' , -- MASACH- 
		  24/09/1999, -- thười gian mượn---
		  24/09/1999--thười gian trả
		 
 )
 go
INSERT INTO dbo.PHIEUSACH

VALUES  ( N'b02' , -- ID- 
			N'002' , -- THE LOAI- 
		  N'le chu bau' , -- ten gia - 
          N'abcxyz', -- ten tác giả---
		  N'toithayhoavangtrencoxanh' , -- MASACH- 
		  N'ĐÃ TRẢ' , -- MASACH- 
		  24/09/1999, -- thười gian mượn---
		  24/09/1999--thười gian trả
		 
 )
 go
 INSERT INTO dbo.SACH

VALUES  ( N'ac01' , -- ID- 
		  N'Con chim xanh biec bay ve' , -- ten sach - 
          N'nguyen ngoc ngan', -- ten tác giả---
		  N'001' , -- MASACH- 
		  N'10000000', -- giá---
		  N'100', -- số luognwj
		  N'kim đồng'--nhà xuất bản
		 
 )
 go

-- SACH
INSERT INTO dbo.SACH

VALUES  ( N'ac01' , -- ID- 
		  N'Con chim xanh biec bay ve' , -- ten sach - 
          N'nguyen ngoc ngan', -- ten tác giả---
		  N'001' , -- MASACH- 
		  N'10000000', -- giá---
		  N'100', -- số luognwj
		  N'kim đồng'--nhà xuất bản
		 
 )
 go
 INSERT INTO dbo.SACH

VALUES  ( N'c002' , -- ID- 
		  N'Con chim xanh biec bay ve' , -- ten sach - 
          N'nguyen ngoc ngan', -- ten tác giả---
		  N'002' , -- MASACH- 
		  N'10000000', -- giá---
		  N'100', -- số luognwj
		  N'kim đồng'--nhà xuất bản
		 
 )
 go
  INSERT INTO dbo.SACH

VALUES  ( N'c001' , -- ID- 
		  N'Con chim xanh biec bay ve' , -- ten sach - 
          N'nguyen ngoc ngan', -- ten tác giả---
		  N'002' , -- MASACH- 
		  N'10000000', -- giá---
		  N'100', -- số luognwj
		  N'kim đồng'--nhà xuất bản
		 
 )
 go
  INSERT INTO dbo.SACH

VALUES  ( N'c003' , -- ID- 
		  N'Con chim xanh biec bay ve' , -- ten sach - 
          N'nguyen ngoc ngan', -- ten tác giả---
		  N'002' , -- MASACH- 
		  N'10000000', -- giá---
		  N'100', -- số luognwj
		  N'kim đồng'--nhà xuất bản
		 
 )
 go
	