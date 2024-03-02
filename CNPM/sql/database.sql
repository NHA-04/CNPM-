create database QUAN_LI_NHAN_VIEN
go
use QUAN_LI_NHAN_VIEN
go

--Quan lý nhân viên và các bộ phận
--------------------------------------------------
create table BO_PHAN(
-- GD DV TC VS AN KT XD
	Ma_Bo_Phan varchar(50), 
	Ten_Bo_Phan nvarchar(250)
)
go

--phát sinh mã tự động cho mã NV từng bộ phận
CREATE FUNCTION ID_CEO()
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @ID VARCHAR(50)
	IF (SELECT COUNT(Ma_Nhan_Vien) FROM Nhan_Vien WHERE Ma_Nhan_Vien like 'GD-00') = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(Ma_Nhan_Vien, 3)) FROM Nhan_Vien
		SELECT @ID = CASE
			WHEN @ID >= 0 THEN 'GD-00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END

go
CREATE FUNCTION ID_DV()
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @MaNV VARCHAR(50);
  SELECT TOP 1 @MaNV = RIGHT(Ma_Nhan_Vien, 2) 
	FROM Nhan_Vien 
	WHERE Ma_Nhan_Vien like 'DV-10%'
	ORDER BY Ma_Nhan_Vien DESC;
  IF @MaNV IS NULL
    SET @MaNV = 'DV-101'
  ELSE
    SET @MaNV = 'DV-10' + RIGHT(CONVERT(VARCHAR(10), CONVERT(INT, @MaNV) + 1), 3);
  RETURN @MaNV;
END;
go
CREATE FUNCTION ID_TC()
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @MaNV VARCHAR(50);
  SELECT TOP 1 @MaNV = RIGHT(Ma_Nhan_Vien, 2) 
	FROM Nhan_Vien 
	WHERE Ma_Nhan_Vien like 'TC-20%'
	ORDER BY Ma_Nhan_Vien DESC;
  IF @MaNV IS NULL
    SET @MaNV = 'TC-201'
  ELSE
    SET @MaNV = 'TC-20' + RIGHT(CONVERT(VARCHAR(10), CONVERT(INT, @MaNV) + 1), 3);
  RETURN @MaNV;
END;
go

CREATE FUNCTION ID_VS()
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @MaNV VARCHAR(50);
  SELECT TOP 1 @MaNV = RIGHT(Ma_Nhan_Vien, 2) 
	FROM Nhan_Vien 
	WHERE Ma_Nhan_Vien like 'VS-30%'
	ORDER BY Ma_Nhan_Vien DESC;
  IF @MaNV IS NULL
    SET @MaNV = 'KT-301'
  ELSE
    SET @MaNV = 'KT-30' + RIGHT(CONVERT(VARCHAR(10), CONVERT(INT, @MaNV) + 1), 3);
  RETURN @MaNV;
END;
go
CREATE FUNCTION ID_AN()
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @MaNV VARCHAR(50);
  SELECT TOP 1 @MaNV = RIGHT(Ma_Nhan_Vien, 2) 
	FROM Nhan_Vien 
	WHERE Ma_Nhan_Vien like 'AN-40%'
	ORDER BY Ma_Nhan_Vien DESC;
  IF @MaNV IS NULL
    SET @MaNV = 'AN-401'
  ELSE
    SET @MaNV = 'AN-40' + RIGHT(CONVERT(VARCHAR(10), CONVERT(INT, @MaNV) + 1), 3);
  RETURN @MaNV;
END;
go
CREATE FUNCTION ID_KT()
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @MaNV VARCHAR(50);
  SELECT TOP 1 @MaNV = RIGHT(Ma_Nhan_Vien, 2) 
	FROM Nhan_Vien 
	WHERE Ma_Nhan_Vien like 'KT-50%'
	ORDER BY Ma_Nhan_Vien DESC;
  IF @MaNV IS NULL
    SET @MaNV = 'KT-501'
  ELSE
    SET @MaNV = 'KT-50' + RIGHT(CONVERT(VARCHAR(10), CONVERT(INT, @MaNV) + 1), 3);
  RETURN @MaNV;
END;
go
CREATE FUNCTION ID_XD()
RETURNS VARCHAR(50)
AS
BEGIN
  DECLARE @MaNV VARCHAR(50);
  SELECT TOP 1 @MaNV = RIGHT(Ma_Nhan_Vien, 2) 
	FROM Nhan_Vien 
	WHERE Ma_Nhan_Vien like 'XD-60%'
	ORDER BY Ma_Nhan_Vien DESC;
  IF @MaNV IS NULL
    SET @MaNV = 'XD-601'
  ELSE
    SET @MaNV = 'XD-60' + RIGHT(CONVERT(VARCHAR(10), CONVERT(INT, @MaNV) + 1), 3);
  RETURN @MaNV;
END;
go
--Hàm bõ dấu tiếng việt
CREATE FUNCTION dbo.RemoveAccents(@s NVARCHAR(MAX))z
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @sAcc NVARCHAR(MAX), @sNoAcc NVARCHAR(MAX), @i INT
    SET @sAcc = N'áàảãạăắặằẳẵâấầẩẫậéèẻẽẹêếềểễệíìỉĩịóòỏõọôốồổỗộơớờởỡợúùủũụưứừửữựýỳỷỹỵđÁÀẢÃẠĂẮẶẰẲẴÂẤẦẨẪẬÉÈẺẼẸÊẾỀỂỄỆÍÌỈĨỊÓÒỎÕỌÔỐỒỔỖỘƠỚỜỞỠỢÚÙỦŨỤƯỨỪỬỮỰÝỲỶỸỴĐ'
    SET @sNoAcc = N'aaaaaaaaaaaaaaaaaeeeeeeeeeeeiiiiiooooooooooooooooouuuuuuuuuuuyyyyydAAAAAAAAAAAAAAAAAEEEEEEEEEEEIIIIIOOOOOOOOOOOOOOOOOOUUUUUUUUUUYYYYYD'
    SET @i = 1
    WHILE @i <= LEN(@sAcc)
    BEGIN
        SET @s = REPLACE(@s, SUBSTRING(@sAcc, @i, 1), SUBSTRING(@sNoAcc, @i, 1))
        SET @i = @i + 1
    END
    RETURN @s
END
go
----------------------------------------------------
create table Nhan_Vien(
	Ma_Nhan_Vien  varchar(250) not null primary key,
	Ten nvarchar(50),
	Ho_dem nvarchar(200), --họ và tên đệm
	So_DT VARCHAR(10),	--Số điện thoại
	Gioi_Tinh nvarchar(5),   --Giới tính (Nam, Nu)
	So_Dinh_Danh VARCHAR(20),	--Số CCCD/CMND/Passport
	Ma_Bo_Phan varchar(50)  foreign key references Bo_Phan(Ma_Bo_Phan),
	Chuc_vu nvarchar(200)
)
go
create table Thong_Tin(
	Ma_Nhan_Vien varchar(250) not null primary key,
	Ngay_Sinh date,
	Email NVARCHAR(50), 	--Email
	Quoc_Tich NVARCHAR(50), --Quốc tịch
	Ngay_Vao_Lam	DATE,	--Ngày vào làm
	So_DT_Nguoi_Than VARCHAR(10),
	Dia_chi nvarchar(250),
)
go
create table NV_Nghi_Viec(
	Ma_Nhan_Vien varchar(250) not null primary key,
	Ma_Bo_Phan varchar(50) foreign key references Bo_Phan(Ma_Bo_Phan),
	Chuc_Vu nvarchar(250),
	Ngay_Nghi date,
	Ho_Ten nvarchar(250),
	Gioi_Tinh char(5),   --Giới tính (Nam, Nu)
	So_Dinh_Danh VARCHAR(20),
	Li_do nvarchar(250)
)

--quản lí thông tin đang nhập
go
CREATE FUNCTION ID_DN(@Ma_nv varchar(7))
RETURNS VARCHAR(250)
AS
BEGIN 
	  DECLARE @id varchar(200); 
	  SELECT @id = NV.Ma_Nhan_Vien +'.'+dbo.RemoveAccents(NV.Ten)+'.'+So_DT
	  FROM Nhan_Vien AS NV
	  WHERE @Ma_nv = NV.Ma_Nhan_Vien;

	  IF (@@ROWCOUNT = 1) -- Check if a record was found
		RETURN @id;
	 RETURN NULL;
END;
go
create table Dang_Nhap(
	Ma_Nhan_Vien varchar(250) not null primary key,
	ID_Dang_NHAP varchar(250),
	Mat_Khau varchar(100) default '8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92',
	Chuc_vu nvarchar(200),
)
go
alter table Dang_Nhap add constraint FK_DN foreign key(Ma_Nhan_Vien) 
references Nhan_Vien(Ma_Nhan_Vien);
go
--Các bảng luong và công việc của nhân viên
create table Luong(
	Ma_Nhan_Vien varchar(250) FOREIGN KEY REFERENCES Nhan_Vien(Ma_Nhan_Vien),
	Luong_Co_Ban int default 0,
	Phu_Cap_Chuc_Vu int default 0, -- phụ cấp chức vụ
	Phu_Cap_Khac int default 0, --phụ cấp khác
	Thue_Thu_Nhap int default 0, --Thuế thu nhập cá nhân
	Tong_Thu_Nhap int default 0,-- tổng thu nhập của nhân viên
	Thang int,
	Nam int,
)
go
create table Danh_sach_cong_viec(
	Ten_Cong_Viec nvarchar(250),
	Ma_Khu_Vuc varchar(50),
	Bo_Phan_Xu_Li varchar(50),-- mã của bộ phận đó vd XD, AN, KT...
	Trinh_Trang nvarchar(250),
	Thoi_Gian_Hoan_Thanh date,
	Ma_Nhan_Vien varchar(250)  FOREIGN KEY REFERENCES Nhan_Vien(Ma_Nhan_Vien), --Nhân Viên đang xử lí
	Ten nvarchar(50), --tên nhân viên
)
go
--trigger tự động cập nhật dữ liệu trong bảng đang nhập khi có thoog tin nhân viên
--mật khẩu mặc định 0000
CREATE TRIGGER Dang_Nhap_Insert
ON [dbo].[Nhan_Vien]
AFTER INSERT
AS
BEGIN
	INSERT INTO Dang_Nhap(
		Ma_Nhan_Vien,
		ID_Dang_NHAP,
		Chuc_vu
	)
	SELECT
		INSERTED.Ma_Nhan_Vien,
		dbo.ID_DN(INSERTED.Ma_Nhan_Vien),
		INSERTED.Chuc_vu
	FROM INSERTED;
END
go
INSERT INTO Nhan_Vien (Ma_Nhan_Vien, Ten, Ho_dem, So_DT, Gioi_Tinh, So_Dinh_Danh, Ma_Bo_Phan, Chuc_vu)
VALUES
(dbo.ID_KT(), N'Hào', N'Trần Thị', N'0987654321', N'Nữ', '987654321', 'KTB', N'Quản lý');
INSERT INTO Nhan_Vien (Ma_Nhan_Vien, Ten, Ho_dem, So_DT, Gioi_Tinh, So_Dinh_Danh, Ma_Bo_Phan, Chuc_vu)
VALUES
(dbo.ID_DV(), N'Ánh', N'Nguyễn Văn', N'0912345678', N'Nam', '123456789', 'AN', N'Nhân viên');
INSERT INTO Nhan_Vien (Ma_Nhan_Vien, Ten, Ho_dem, So_DT, Gioi_Tinh, So_Dinh_Danh, Ma_Bo_Phan, Chuc_vu)
VALUES
(dbo.ID_TC(), N'Có', N'Lê Thị', N'0976543210', N'Nữ', '765432109', 'TK', N'Kế toán');
INSERT INTO Nhan_Vien (Ma_Nhan_Vien, Ten, Ho_dem, So_DT, Gioi_Tinh, So_Dinh_Danh, Ma_Bo_Phan, Chuc_vu)
VALUES
(dbo.ID_KT(), N'Phạm Văn D', N'Phạm Văn', N'0965432109', N'Nam', '654321098', 'KTB', N'Kỹ thuật viên');
INSERT INTO Nhan_Vien (Ma_Nhan_Vien, Ten, Ho_dem, So_DT, Gioi_Tinh, So_Dinh_Danh, Ma_Bo_Phan, Chuc_vu)
VALUES
(dbo.ID_XD(), N'VỸ', N'Vũ Thị', N'0954321098', N'Nữ', '543210987', 'DVCD', N'Chăm sóc khách hàng');
INSERT INTO Nhan_Vien (Ma_Nhan_Vien, Ten, Ho_dem, So_DT, Gioi_Tinh, So_Dinh_Danh, Ma_Bo_Phan, Chuc_vu)
VALUES
(dbo.ID_XD(), N'Đặng', N'Đặng Văn', N'0943210987', N'Nam', '432109876', 'DVCD', N'Bảo vệ');
go
INSERT INTO BO_PHAN (Ma_Bo_Phan, Ten_Bo_Phan) VALUES
('AN', N'An ninh'),
('HCNS', N'Hành chính Nhân sự'),
('DVCD', N'Dịch vụ Cư Dân'),
('TK', N'Tài chính Kế toán'),
('VS', N'Vệ Sinh'),
('KTB', N'Kỹ Thuật Bảo Trì'),
('XD', N'Xây Dựng');
go
INSERT INTO Thong_Tin (Ma_Nhan_Vien, Ngay_Sinh, Email, Quoc_Tich, Ngay_Vao_Lam, So_DT_Nguoi_Than, Dia_chi)
VALUES
('KT-501', '1990-01-01', 'hao@example.com', N'Việt Nam', '2020-01-01', '0987654321', N'123 Đường ABC, Quận 1, TP.HCM'),
-- Thêm dữ liệu cho nhân viên khác bằng cách sử dụng mã nhân viên tương ứng
('DV-101', '1992-02-02', 'anh@example.com', N'Việt Nam', '2021-02-01', '0912345678', N'456 Đường XYZ, Quận 2, TP.HCM'),
-- và tiếp tục cho các nhân viên khác
('TC-201', '1993-03-03', 'co@example.com', N'Việt Nam', '2022-03-01', '0976543210', N'789 Đường DEF, Quận 3, TP.HCM'),
('KT-502', '1994-04-04', 'phamvand@example.com', N'Việt Nam', '2023-04-01', '0965432109', N'101 Đường GHI, Quận 4, TP.HCM'),
('XD-601', '1995-05-05', 'vuthivy@example.com', N'Việt Nam', '2024-05-01', '0954321098', N'102 Đường JKL, Quận 5, TP.HCM'),
('XD-602', '1996-06-06', 'dangvan@example.com', N'Việt Nam', '2025-06-01', '0943210987', N'103 Đường MNO, Quận 6, TP.HCM');

--query

-- lay thong tin tai khoan
--"Select Dang_Nhap.Mat_Khau From Dang_Nhap where Dang_Nhap.ID_Dang_Nhap = @userId"

-- lay thong tin nhan vien
SELECT NV.*, TT.Ngay_Vao_Lam,TT.So_DT_Nguoi_Than,
TT.Dia_chi ,TT.Ngay_Sinh, TT.Email, TT.Quoc_Tich, DN.Chuc_vu,BP.Ten_Bo_Phan FROM Nhan_Vien NV 
INNER JOIN Thong_Tin TT ON TT.Ma_Nhan_Vien = NV.Ma_Nhan_Vien INNER JOIN Dang_Nhap  DN ON  DN.Ma_Nhan_Vien=TT.Ma_Nhan_Vien 
INNER JOIN BO_PHAN BP ON BP.Ma_Bo_Phan=NV.Ma_Bo_Phan WHERE NV.Ma_Nhan_Vien =TT.Ma_Nhan_Vien

-- cap nhat thong tin

--"UPDATE Thong_Tin SET Dia_chi=@diachi, Email=@email, SO_DT_Nguoi_Than = @sdnt where Ma_Nhan_Vien=@manv "
select * from Dang_Nhap