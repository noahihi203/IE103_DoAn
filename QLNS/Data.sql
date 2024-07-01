CREATE DATABASE QUANLYNHANSU
GO

USE QUANLYNHANSU
GO

SET DATEFORMAT DMY;
GO

------- Phần Khởi tạo -------

-- Khởi Tạo Bảng Phòng Ban --
CREATE TABLE PHONGBAN
(
	MAPB INT PRIMARY KEY,
	TENPB NVARCHAR(30) NOT NULL
)
GO

-- Khởi Tạo Bảng Chức Vụ --
CREATE TABLE CHUCVU
( 
	MACV INT PRIMARY KEY,
	TENCV NVARCHAR(30) NOT NULL
)
GO

-- Khởi Tạo Bảng Lương -- 
CREATE TABLE LUONG
(
	MALUONG INT PRIMARY KEY,
	LUONGCB FLOAT,
	PHUCAP FLOAT,
	LUONGBS FLOAT,
	MACV INT,
	CONSTRAINT FK_LUONG_CHUCVU FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV)
)
GO

-- Khởi Tạo Bảng Tài Khoản --
CREATE TABLE TAIKHOAN
(
	TENDANGNHAP NVARCHAR(50) PRIMARY KEY, --tên nối với (họ + tên đệm) viết tắt
	MATKHAU NVARCHAR(50) NOT NULL,
	MACV INT,

	CONSTRAINT FK_TAIKHOAN_CHUCVU FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV)
)
GO

-- Khởi Tạo Bảng Nhân Viên --
CREATE TABLE NHANVIEN
(	
	MANV INT PRIMARY KEY,
	HOTEN NVARCHAR(50) NOT NULL,
	GIOITINH NVARCHAR(5) NOT NULL,
	NGAYSINH DATE NOT NULL,
	SDT VARCHAR(11) NOT NULL,
	CCCD VARCHAR(15) NOT NULL,
	DIACHI NVARCHAR(100) NOT NULL,
	MACV INT,
	MAPB INT,
	MALUONG INT,
	NGAYNHANLUONG DATE,
	TENDANGNHAP NVARCHAR(50),
	CONSTRAINT FK_NHANVIEN_PHONGBAN FOREIGN KEY(MAPB) REFERENCES PHONGBAN(MAPB),
	CONSTRAINT FK_NHANVIEN_CHUCVU FOREIGN KEY(MACV) REFERENCES CHUCVU(MACV),
	CONSTRAINT FK_NHANVIEN_LUONG FOREIGN KEY(MALUONG) REFERENCES LUONG(MALUONG),
	CONSTRAINT FK_NHANVIEN_TAIKHOAN FOREIGN KEY(TENDANGNHAP) REFERENCES TAIKHOAN(TENDANGNHAP)
)
GO

-- Khởi Tạo Bảng Hợp Đồng --
CREATE TABLE HOPDONG
(
	MAHD INT PRIMARY KEY,
	NGAYBD DATE NOT NULL,
	NGAYKT DATE NOT NULL,
	NGAYKY DATE NOT NULL,
	NOIDUNG NTEXT NOT NULL,
	THUONGHD FLOAT NOT NULL,
	MANV INT,
	CONSTRAINT FK_HOPDONG_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
GO

-- Khởi Tạo Bảng Bảo Hiểm --
CREATE TABLE BAOHIEM
(
	MABH INT PRIMARY KEY,
	SOBH VARCHAR(10) NOT NULL,
	NGAYCAP DATETIME NOT NULL,
	NOICAP NVARCHAR(100) NOT NULL,
	NOIKHAMBENH NVARCHAR(100) NOT NULL,
	MANV INT,
	CONSTRAINT FK_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
GO

-- Khởi Tạo Bảng Khen Thưởng --
CREATE TABLE KTKL
(
	MAKTKL INT PRIMARY KEY,
	TENKTKL NVARCHAR(20) NOT NULL,
	NOIDUNG TEXT NOT NULL,
	NGAYNHAN DATETIME NOT NULL,
	LYDO NVARCHAR(50) NOT NULL,
	MANV INT,
	CONSTRAINT FK_KHENTHUONG_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV)
)
GO

-- Khởi Tạo Bảng Bảng Công --
CREATE TABLE BANGCONG
(
	MABC INT,
	SONGAYLAM FLOAT NOT NULL,
	SONGAYNGHI FLOAT NOT NULL,
	GHICHU NVARCHAR(100),
	MANV INT,
	THANG INT NOT NULL,
	CONSTRAINT FK_BANGCONG_NHANVIEN FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT PK_BANGCONG PRIMARY KEY (MABC, MANV, THANG)
)
GO



------- Phần Xử lý thông tin (Trigger, Function, Procedure,..) -------

-- Function cho phép ghi dấu --
CREATE FUNCTION dbo.RemoveDiacritics(@input NVARCHAR(MAX))
RETURNS NVARCHAR(MAX)
AS
BEGIN
    DECLARE @output NVARCHAR(MAX)
    SET @output = @input

    SET @output = REPLACE(@output, N'á', 'a')
    SET @output = REPLACE(@output, N'à', 'a')
    SET @output = REPLACE(@output, N'ả', 'a')
    SET @output = REPLACE(@output, N'ã', 'a')
    SET @output = REPLACE(@output, N'ạ', 'a')
    SET @output = REPLACE(@output, N'ă', 'a')
    SET @output = REPLACE(@output, N'ắ', 'a')
    SET @output = REPLACE(@output, N'ằ', 'a')
    SET @output = REPLACE(@output, N'ẳ', 'a')
    SET @output = REPLACE(@output, N'ẵ', 'a')
    SET @output = REPLACE(@output, N'ặ', 'a')
    SET @output = REPLACE(@output, N'â', 'a')
    SET @output = REPLACE(@output, N'ấ', 'a')
    SET @output = REPLACE(@output, N'ầ', 'a')
    SET @output = REPLACE(@output, N'ẩ', 'a')
    SET @output = REPLACE(@output, N'ẫ', 'a')
    SET @output = REPLACE(@output, N'ậ', 'a')
    SET @output = REPLACE(@output, N'é', 'e')
    SET @output = REPLACE(@output, N'è', 'e')
    SET @output = REPLACE(@output, N'ẻ', 'e')
    SET @output = REPLACE(@output, N'ẽ', 'e')
    SET @output = REPLACE(@output, N'ẹ', 'e')
    SET @output = REPLACE(@output, N'ê', 'e')
    SET @output = REPLACE(@output, N'ế', 'e')
    SET @output = REPLACE(@output, N'ề', 'e')
    SET @output = REPLACE(@output, N'ể', 'e')
    SET @output = REPLACE(@output, N'ễ', 'e')
    SET @output = REPLACE(@output, N'ệ', 'e')
    SET @output = REPLACE(@output, N'í', 'i')
    SET @output = REPLACE(@output, N'ì', 'i')
    SET @output = REPLACE(@output, N'ỉ', 'i')
    SET @output = REPLACE(@output, N'ĩ', 'i')
    SET @output = REPLACE(@output, N'ị', 'i')
    SET @output = REPLACE(@output, N'ó', 'o')
    SET @output = REPLACE(@output, N'ò', 'o')
    SET @output = REPLACE(@output, N'ỏ', 'o')
    SET @output = REPLACE(@output, N'õ', 'o')
    SET @output = REPLACE(@output, N'ọ', 'o')
    SET @output = REPLACE(@output, N'ô', 'o')
    SET @output = REPLACE(@output, N'ố', 'o')
    SET @output = REPLACE(@output, N'ồ', 'o')
    SET @output = REPLACE(@output, N'ổ', 'o')
    SET @output = REPLACE(@output, N'ỗ', 'o')
    SET @output = REPLACE(@output, N'ộ', 'o')
    SET @output = REPLACE(@output, N'ơ', 'o')
    SET @output = REPLACE(@output, N'ớ', 'o')
    SET @output = REPLACE(@output, N'ờ', 'o')
    SET @output = REPLACE(@output, N'ở', 'o')
    SET @output = REPLACE(@output, N'ỡ', 'o')
    SET @output = REPLACE(@output, N'ợ', 'o')
    SET @output = REPLACE(@output, N'ú', 'u')
    SET @output = REPLACE(@output, N'ù', 'u')
    SET @output = REPLACE(@output, N'ủ', 'u')
    SET @output = REPLACE(@output, N'ũ', 'u')
    SET @output = REPLACE(@output, N'ụ', 'u')
    SET @output = REPLACE(@output, N'ư', 'u')
    SET @output = REPLACE(@output, N'ứ', 'u')
    SET @output = REPLACE(@output, N'ừ', 'u')
    SET @output = REPLACE(@output, N'ử', 'u')
    SET @output = REPLACE(@output, N'ữ', 'u')
    SET @output = REPLACE(@output, N'ự', 'u')
    SET @output = REPLACE(@output, N'ý', 'y')
    SET @output = REPLACE(@output, N'ỳ', 'y')
    SET @output = REPLACE(@output, N'ỷ', 'y')
    SET @output = REPLACE(@output, N'ỹ', 'y')
    SET @output = REPLACE(@output, N'ỵ', 'y')

    SET @output = REPLACE(@output, N'Á', 'A')
    SET @output = REPLACE(@output, N'À', 'A')
    SET @output = REPLACE(@output, N'Ả', 'A')
    SET @output = REPLACE(@output, N'Ã', 'A')
    SET @output = REPLACE(@output, N'Ạ', 'A')
    SET @output = REPLACE(@output, N'Ă', 'A')
    SET @output = REPLACE(@output, N'Ắ', 'A')
    SET @output = REPLACE(@output, N'Ằ', 'A')
    SET @output = REPLACE(@output, N'Ẳ', 'A')
    SET @output = REPLACE(@output, N'Ẵ', 'A')
    SET @output = REPLACE(@output, N'Ặ', 'A')
    SET @output = REPLACE(@output, N'Â', 'A')
    SET @output = REPLACE(@output, N'Ấ', 'A')
    SET @output = REPLACE(@output, N'Ầ', 'A')
    SET @output = REPLACE(@output, N'Ẩ', 'A')
    SET @output = REPLACE(@output, N'Ẫ', 'A')
    SET @output = REPLACE(@output, N'Ậ', 'A')
    SET @output = REPLACE(@output, N'É', 'E')
    SET @output = REPLACE(@output, N'È', 'E')
    SET @output = REPLACE(@output, N'Ẻ', 'E')
    SET @output = REPLACE(@output, N'Ẽ', 'E')
    SET @output = REPLACE(@output, N'Ẹ', 'E')
    SET @output = REPLACE(@output, N'Ê', 'E')
    SET @output = REPLACE(@output, N'Ế', 'E')
    SET @output = REPLACE(@output, N'Ề', 'E')
    SET @output = REPLACE(@output, N'Ể', 'E')
    SET @output = REPLACE(@output, N'Ễ', 'E')
    SET @output = REPLACE(@output, N'Ệ', 'E')
    SET @output = REPLACE(@output, N'Í', 'I')
    SET @output = REPLACE(@output, N'Ì', 'I')
    SET @output = REPLACE(@output, N'Ỉ', 'I')
    SET @output = REPLACE(@output, N'Ĩ', 'I')
    SET @output = REPLACE(@output, N'Ị', 'I')
    SET @output = REPLACE(@output, N'Ó', 'O')
    SET @output = REPLACE(@output, N'Ò', 'O')
    SET @output = REPLACE(@output, N'Ỏ', 'O')
    SET @output = REPLACE(@output, N'Õ', 'O')
    SET @output = REPLACE(@output, N'Ọ', 'O')
    SET @output = REPLACE(@output, N'Ô', 'O')
    SET @output = REPLACE(@output, N'Ố', 'O')
    SET @output = REPLACE(@output, N'Ồ', 'O')
    SET @output = REPLACE(@output, N'Ổ', 'O')
    SET @output = REPLACE(@output, N'Ỗ', 'O')
    SET @output = REPLACE(@output, N'Ộ', 'O')
    SET @output = REPLACE(@output, N'Ơ', 'O')
    SET @output = REPLACE(@output, N'Ớ', 'O')
    SET @output = REPLACE(@output, N'Ờ', 'O')
    SET @output = REPLACE(@output, N'Ở', 'O')
    SET @output = REPLACE(@output, N'Ỡ', 'O')
    SET @output = REPLACE(@output, N'Ợ', 'O')
    SET @output = REPLACE(@output, N'Ú', 'U')
    SET @output = REPLACE(@output, N'Ù', 'U')
    SET @output = REPLACE(@output, N'Ủ', 'U')
    SET @output = REPLACE(@output, N'Ũ', 'U')
    SET @output = REPLACE(@output, N'Ụ', 'U')
    SET @output = REPLACE(@output, N'Ư', 'U')
    SET @output = REPLACE(@output, N'Ứ', 'U')
    SET @output = REPLACE(@output, N'Ừ', 'U')
    SET @output = REPLACE(@output, N'Ử', 'U')
    SET @output = REPLACE(@output, N'Ữ', 'U')
    SET @output = REPLACE(@output, N'Ự', 'U')
    SET @output = REPLACE(@output, N'Ý', 'Y')
    SET @output = REPLACE(@output, N'Ỳ', 'Y')
    SET @output = REPLACE(@output, N'Ỷ', 'Y')
    SET @output = REPLACE(@output, N'Ỹ', 'Y')
    SET @output = REPLACE(@output, N'Ỵ', 'Y')

    RETURN @output
END
GO



-- Trigger Tạo tài khoản sau khi có dữ liệu nhân viên --
CREATE TRIGGER trg_CreateAccount
ON NHANVIEN
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Biến để giữ tên đăng nhập
    DECLARE @UserName NVARCHAR(100);
    
    -- Lặp qua các bản ghi mới được chèn vào bảng NHANVIEN
    DECLARE @MANV CHAR(8);
    DECLARE @HOTEN NVARCHAR(100);
    DECLARE @NgaySinh DATE;
    DECLARE @MACV INT;

    DECLARE inserted_cursor CURSOR FOR
    SELECT MANV, HOTEN, NgaySinh, MACV
    FROM Inserted;

    OPEN inserted_cursor;
    FETCH NEXT FROM inserted_cursor INTO @MANV, @HOTEN, @NgaySinh, @MACV;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Tạo Username
        SET @UserName = dbo.RemoveDiacritics(REPLACE(LOWER(@HOTEN), ' ', '') + @MANV);

        -- Chèn dữ liệu vào bảng TAIKHOAN
        INSERT INTO TAIKHOAN (TENDANGNHAP, MATKHAU, MACV)
        VALUES (
            @UserName, 
            FORMAT(@NgaySinh, 'ddMMyyyy'), -- Chuyển ngày sinh thành chuỗi định dạng ddMMyyyy
            @MACV
        );

        -- Cập nhật cột TENDANGNHAP trong bảng NHANVIEN
        UPDATE NHANVIEN
        SET TENDANGNHAP = @UserName
        WHERE MANV = @MANV;
			
        FETCH NEXT FROM inserted_cursor INTO @MANV, @HOTEN, @NgaySinh, @MACV;
    END;

    CLOSE inserted_cursor;
    DEALLOCATE inserted_cursor;
END
GO



-- Trigger sửa mật khẩu cho nhân viên --
CREATE TRIGGER trg_HashPassword
ON TAIKHOAN
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE TAIKHOAN
    SET MATKHAU = CONVERT(VARCHAR(40), HASHBYTES('SHA1', CAST(i.MATKHAU AS NVARCHAR(4000))), 2)
    FROM TAIKHOAN t
    INNER JOIN inserted i ON t.TENDANGNHAP = i.TENDANGNHAP;
END
GO



-- Trigger cập nhật ngày nhận lương --
CREATE TRIGGER trg_UpdateNgayNhanLuong
ON NhanVien
AFTER INSERT, UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Cập nhật ngày nhận lương cho các bản ghi có ngày nhận lương < ngày hôm nay
    UPDATE NhanVien
    SET NGAYNHANLUONG = DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()) + 1, 0)
    WHERE NGAYNHANLUONG < GETDATE();
END;
GO



-- Procedure cho nhân viên --
CREATE PROCEDURE InsertEmployee
    @MaNV INT,
    @HoTen NVARCHAR(100),
    @GioiTinh NVARCHAR(10),
    @NgaySinh DATE,
    @SDT NVARCHAR(15),
    @CCCD NVARCHAR(20),
    @DiaChi NVARCHAR(100),
    @MaCV INT,
    @MaPB INT,
    @MaLuong INT,
    @NgayNhanLuong DATE
AS
BEGIN
    INSERT INTO NhanVien (MaNV, HoTen, GioiTinh, NgaySinh, SDT, CCCD, DiaChi, MaCV, MaPB, MaLuong, NgayNhanLuong)
    VALUES (@MaNV, @HoTen, @GioiTinh, @NgaySinh, @SDT, @CCCD, @DiaChi, @MaCV, @MaPB, @MaLuong, @NgayNhanLuong);
END;
GO



-- Trigger xoá tài khoản nhân viên khi dữ liệu nhân viên bị xoá --
CREATE TRIGGER trg_DeleteEmployeeAccount
ON NhanVien
AFTER DELETE
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM TAIKHOAN
    WHERE TENDANGNHAP IN (
        SELECT TENDANGNHAP
        FROM DELETED
    );
END;

GO



-- Trigger kiểm tra trạng thái tồn tại của mã nhân viên --
CREATE TRIGGER CHECK_MaNV
ON NHANVIEN
INSTEAD OF INSERT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM NHANVIEN WHERE MANV IN (SELECT MANV FROM inserted))
    BEGIN
        RAISERROR ('Mã nhân viên này đã tồn tại', 16, 1);
    END
    ELSE
    BEGIN
        INSERT INTO NHANVIEN (MANV, HOTEN, GIOITINH, NGAYSINH, SDT, CCCD, DIACHI, MACV, MAPB, MALUONG, NGAYNHANLUONG)
        SELECT MANV, HOTEN, GIOITINH, NGAYSINH, SDT, CCCD, DIACHI, MACV, MAPB, MALUONG, NGAYNHANLUONG
        FROM inserted;
    END
END;
GO



-- Trigger kiểm tra số lượng giám đốc của phòng ban --
CREATE TRIGGER CHECK_SL_GIAMDOC
ON NHANVIEN
AFTER INSERT, UPDATE
AS
BEGIN
    -- Kiểm tra số lượng giám đốc của từng phòng ban
    DECLARE @MaPB INT;
    DECLARE @CountGiámĐốc INT;

    -- Lấy danh sách các phòng ban khác nhau
    DECLARE PB_Cursor CURSOR FOR
    SELECT DISTINCT MaPB FROM inserted;

    OPEN PB_Cursor;
    FETCH NEXT FROM PB_Cursor INTO @MaPB;

    WHILE @@FETCH_STATUS = 0
    BEGIN
        -- Đếm số lượng giám đốc của phòng ban hiện tại
        SELECT @CountGiámĐốc = COUNT(*)
        FROM NHANVIEN NV
        WHERE NV.MaPB = @MaPB AND NV.MaCV = 1;

        -- Kiểm tra điều kiện số lượng giám đốc
        IF @CountGiámĐốc > 1
        BEGIN
            RAISERROR('Mỗi phòng ban chỉ được có tối đa một giám đốc.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END
        ELSE IF @CountGiámĐốc = 0
        BEGIN
            RAISERROR('Mỗi phòng ban phải có một giám đốc.', 16, 1);
            ROLLBACK TRANSACTION;
            RETURN;
        END;

        FETCH NEXT FROM PB_Cursor INTO @MaPB;
    END;

    CLOSE PB_Cursor;
    DEALLOCATE PB_Cursor;
END;
GO


-- Trigger tự động đổi mã lương khi nhân viên thay đổi chức vụ --
CREATE TRIGGER check_update_MALUONG
ON NHANVIEN
AFTER UPDATE
AS
BEGIN
    -- Nếu thay đổi chức vụ nhân viên
    IF UPDATE(MACV)
    BEGIN
        -- Update MALUONG tương ứng
        UPDATE NHANVIEN
        SET NHANVIEN.MALUONG = i.MACV
        FROM inserted i
        WHERE NHANVIEN.MANV = i.MANV;
    END
END;
GO



------- Phần Truy xuất dữ liệu Database -------

USE QUANLYNHANSU
GO

-- Bảng Data Mẫu Gồm 5 Người Mỗi Phòng Ban --

USE QUANLYNHANSU
GO


INSERT INTO CHUCVU (MaCV, TenCV) 
VALUES (1, N'Giám đốc'), 
       (2, N'Phó giám đốc'), 
	   (3, N'Trưởng phòng'), 
	   (4, N'Nhân viên');
GO


INSERT INTO PHONGBAN (MaPB, TenPB) 
VALUES (1, N'Phòng Nhân sự'), 
	   (2, N'Phòng Kế toán'), 
	   (3, N'Phòng Kinh doanh'), 
	   (4, N'Phòng Kỹ thuật');
GO


INSERT INTO LUONG VALUES
(1, 15000000, 3000000, 2000000, 1),
(2, 12000000, 2500000, 1500000, 2),
(3, 10000000, 2000000, 1000000, 3),
(4, 8000000, 1500000, 500000, 4);
GO


INSERT INTO NhanVien (MANV, HoTen, GioiTinh, NgaySinh, SDT, CCCD, DiaChi, NgayNhanLuong, MaLuong, MaPB, MaCV) 
VALUES 
	    -- Phòng Nhân sự
		(1, N'Nguyễn Văn Dũng', N'Nam', '1980-01-01', '0901234567', '123456789', N'123 Lê Lợi, Quận 1, TP.HCM', '2023-01-01', 1, 1, 1),
		(2, N'Trần Thị Hồng', N'Nữ', '1985-02-02', '0902234567', '223456789', N'456 Nguyễn Huệ, Quận 1, TP.HCM', '2023-01-01', 2, 1, 2),
		(3, N'Lê Văn Nam', N'Nam', '1990-03-03', '0903234567', '323456789', N'789 Đinh Tiên Hoàng, Quận Bình Thạnh, TP.HCM', '2023-01-01', 3, 1, 3),
		(4, N'Phạm Thị Dung', N'Nữ', '1995-04-04', '0904234567', '423456789', N'123 Võ Thị Sáu, Quận 3, TP.HCM', '2023-01-01', 4, 1, 4),
		(5, N'Hoàng Văn Anh', N'Nam', '1992-05-05', '0905234567', '523456789', N'456 Lê Văn Sỹ, Quận Phú Nhuận, TP.HCM', '2023-01-01', 4, 1, 4),
	   
	    -- Phòng Kế toán
		(6, N'Nguyễn Thị Mai', N'Nữ', '1983-06-01', '0906234567', '623456789', N'123 Trần Hưng Đạo, Quận 5, TP.HCM', '2023-01-01', 1, 2, 1),
		(7, N'Trần Văn Bình', N'Nam', '1984-07-02', '0907234567', '723456789', N'456 Hai Bà Trưng, Quận 3, TP.HCM', '2023-01-01', 2, 2, 2),
		(8, N'Lê Thị Hoa', N'Nữ', '1987-08-03', '0908234567', '823456789', N'789 Điện Biên Phủ, Quận Bình Thạnh, TP.HCM', '2023-01-01', 3, 2, 3),
		(9, N'Phạm Văn Hoàng', N'Nam', '1989-09-04', '0909234567', '923456789', N'123 Lý Thái Tổ, Quận 10, TP.HCM', '2023-01-01', 4, 2, 4),
		(10, N'Hoàng Thị Lan', N'Nữ', '1991-10-05', '0910234567', '023456789', N'456 Nguyễn Trãi, Quận 1, TP.HCM', '2023-01-01', 4, 2, 4),

		-- Phòng Kinh doanh
		(11, N'Nguyễn Văn Tú', N'Nam', '1985-11-01', '0911234567', '123456780', N'123 Hùng Vương, Quận 5, TP.HCM', '2023-01-01', 1, 3, 1),
		(12, N'Trần Thị Cúc', N'Nữ', '1986-12-02', '0912234567', '223456780', N'456 Trần Phú, Quận 5, TP.HCM', '2023-01-01', 2, 3, 2),
		(13, N'Lê Văn Tiến', N'Nam', '1988-01-03', '0913234567', '323456780', N'789 Hoàng Sa, Quận 3, TP.HCM', '2023-01-01', 3, 3, 3),
		(14, N'Phạm Thị Tuyết', N'Nữ', '1990-02-04', '0914234567', '423456780', N'123 Phan Xích Long, Quận Phú Nhuận, TP.HCM', '2023-01-01', 4, 3, 4),
		(15, N'Hoàng Văn Bình', N'Nam', '1992-03-05', '0915234567', '523456780', N'456 Cao Thắng, Quận 3, TP.HCM', '2023-01-01', 4, 3, 4),

		-- Phòng Kỹ thuật
		(16, N'Nguyễn Thị Lan', N'Nữ', '1984-04-01', '0916234567', '623456780', N'123 Lê Quang Định, Quận Bình Thạnh, TP.HCM', '2023-01-01', 1, 4, 1),
		(17, N'Trần Văn Hùng', N'Nam', '1986-05-02', '0917234567', '723456780', N'456 Phạm Văn Đồng, Quận Thủ Đức, TP.HCM', '2023-01-01', 2, 4, 2),
		(18, N'Lê Thị Hương', N'Nữ', '1988-06-03', '0918234567', '823456780', N'789 Nguyễn Oanh, Quận Gò Vấp, TP.HCM', '2023-01-01', 3, 4, 3),
		(19, N'Phạm Văn Nam', N'Nam', '1990-07-04', '0919234567', '923456780', N'123 Quang Trung, Quận Gò Vấp, TP.HCM', '2023-01-01', 4, 4, 4),
		(20, N'Hoàng Thị Thu', N'Nữ', '1992-08-05', '0920234567', '023456780', N'456 Lê Đại Hành, Quận 11, TP.HCM', '2023-01-01', 4, 4, 4);


INSERT INTO BaoHiem (MaBH, SoBH, NgayCap, NoiCap, NoiKhamBenh, MaNV) VALUES
		-- Phòng Nhân sự
	   (1, 'BH123', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 1),
	   (2, 'BH124', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 2),
	   (3, 'BH125', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 3),
	   (4, 'BH126', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 4),
	   (5, 'BH127', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 5),
	   -- Phòng Kế toán
		(6, 'BH128', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 6),
		(7, 'BH129', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 7),
		(8, 'BH130', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 8),
		(9, 'BH131', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 9),
		(10, 'BH132', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 10),

		-- Phòng Kinh doanh
		(11, 'BH133', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 11),
		(12, 'BH134', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 12),
		(13, 'BH135', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 13),
		(14, 'BH136', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 14),
		(15, 'BH137', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 15),

		-- Phòng Kỹ thuật
		(16, 'BH138', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 16),
		(17, 'BH139', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 17),
		(18, 'BH140', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 18),
		(19, 'BH141', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 19),
		(20, 'BH142', '2023-01-01', N'TP.HCM', N'Bệnh viện Chợ Rẫy', 20);
GO


-- 1 tháng công ty làm 24 buổi

INSERT INTO BangCong (MaBC, SoNgayLam, SoNgayNghi, GhiChu, MaNV, thang) VALUES
(2024, 20, 4, N'Chăm chỉ', 1, 1),
(2024, 22, 2, N'Chăm chỉ', 1, 2),
(2024, 23, 1, N'Chăm chỉ', 1, 3),
(2024, 23, 1, N'Chăm chỉ', 1, 4),
(2024, 20, 4, N'Chăm chỉ', 1, 5),
(2024, 21, 3, N'Chăm chỉ', 1, 6),
(2024, 19, 5, N'Chăm chỉ', 1, 7),
(2024, 21, 3, N'Chăm chỉ', 1, 8),
(2024, 22, 2, N'Rất chăm chỉ', 1, 9),
(2024, 23, 1, N'Xuất sắc', 1, 10),
(2024, 20, 4, N'Chăm chỉ', 1, 11),
(2024, 22, 2, N'Chăm chỉ', 1, 12),

(2024, 19, 5, N'Cần cố gắng hơn', 2, 1),
(2024, 20, 4, N'Cần cố gắng hơn', 2, 2),
(2024, 21, 3, N'Chăm chỉ', 2, 3),
(2024, 22, 2, N'Rất chăm chỉ', 2, 4),
(2024, 23, 1, N'Xuất sắc', 2, 5),
(2024, 1, 23, N'hư nè', 2, 6),
(2024, 21, 3, N'Chăm chỉ', 2, 7),
(2024, 22, 2, N'Rất chăm chỉ', 2, 8),
(2024, 23, 1, N'Xuất sắc', 2, 9),
(2024, 20, 4, N'Cần cố gắng hơn', 2, 10),
(2024, 21, 3, N'Chăm chỉ', 2, 11),
(2024, 22, 2, N'Rất chăm chỉ', 2, 12),

(2024, 18, 6, N'Cần cố gắng hơn', 3, 1),
(2024, 20, 4, N'Chăm chỉ', 3, 2),
(2024, 21, 3, N'Chăm chỉ', 3, 3),
(2024, 22, 2, N'Rất chăm chỉ', 3, 4),
(2024, 23, 1, N'Xuất sắc', 3, 5),
(2024, 21, 3, N'Chăm chỉ', 3, 6),
(2024, 17, 7, N'Cần cố gắng hơn', 3, 7),
(2024, 19, 5, N'Cần cố gắng hơn', 3, 8),
(2024, 15, 9, N'Chưa đạt', 3, 9),
(2024, 20, 4, N'Chăm chỉ', 3, 10),
(2024, 21, 3, N'Chăm chỉ', 3, 11),
(2024, 22, 2, N'Rất chăm chỉ', 3, 12),

(2024, 17, 7, N'Cần nỗ lực hơn', 4, 1),
(2024, 20, 4, N'Chăm chỉ', 4, 2),
(2024, 21, 3, N'Chăm chỉ', 4, 3),
(2024, 22, 2, N'Rất chăm chỉ', 4, 4),
(2024, 23, 1, N'Xuất sắc', 4, 5),
(2024, 21, 3, N'Chăm chỉ', 4, 6),
(2024, 18, 6, N'Cần cố gắng hơn', 4, 7),
(2024, 19, 5, N'Cần nỗ lực hơn', 4, 8),
(2024, 20, 4, N'Chăm chỉ', 4, 9),
(2024, 18, 6, N'Chưa đạt', 4, 10),
(2024, 21, 3, N'Chăm chỉ', 4, 11),
(2024, 22, 2, N'Rất chăm chỉ', 4, 12),

(2024, 16, 8, N'Cần cải thiện', 5, 1),
(2024, 20, 4, N'Chăm chỉ', 5, 2),
(2024, 21, 3, N'Chăm chỉ', 5, 3),
(2024, 22, 2, N'Rất chăm chỉ', 5, 4),
(2024, 23, 1, N'Xuất sắc', 5, 5),
(2024, 19, 5, N'Cần cố gắng hơn', 5, 6),
(2024, 21, 3, N'Chăm chỉ', 5, 7),
(2024, 22, 2, N'Rất chăm chỉ', 5, 8),
(2024, 23, 1, N'Xuất sắc', 5, 9),
(2024, 20, 4, N'Chăm chỉ', 5, 10),
(2024, 18, 6, N'Cần nỗ lực hơn', 5, 11),
(2024, 22, 2, N'Rất chăm chỉ', 5, 12),

(2024, 19, 5, N'Cần cố gắng hơn', 6, 1),
(2024, 20, 4, N'Cần cố gắng hơn', 6, 2),
(2024, 21, 3, N'Chăm chỉ', 6, 3),
(2024, 22, 2, N'Rất chăm chỉ', 6, 4),
(2024, 23, 1, N'Xuất sắc', 6, 5),
(2024, 1, 23, N'hư nè', 6, 6),
(2024, 21, 3, N'Chăm chỉ', 6, 7),
(2024, 22, 2, N'Rất chăm chỉ', 6, 8),
(2024, 23, 1, N'Xuất sắc', 6, 9),
(2024, 20, 4, N'Cần cố gắng hơn', 6, 10),
(2024, 21, 3, N'Chăm chỉ', 6, 11),
(2024, 22, 2, N'Rất chăm chỉ', 6, 12),

(2024, 18, 6, N'Cần cố gắng hơn', 7, 1),
(2024, 20, 4, N'Chăm chỉ', 7, 2),
(2024, 21, 3, N'Chăm chỉ', 7, 3),
(2024, 22, 2, N'Rất chăm chỉ', 7, 4),
(2024, 23, 1, N'Xuất sắc', 7, 5),
(2024, 21, 3, N'Chăm chỉ', 7, 6),
(2024, 17, 7, N'Cần cố gắng hơn', 7, 7),
(2024, 19, 5, N'Cần cố gắng hơn', 7, 8),
(2024, 15, 9, N'Chưa đạt', 7, 9),
(2024, 20, 4, N'Chăm chỉ', 7, 10),
(2024, 21, 3, N'Chăm chỉ', 7, 11),
(2024, 22, 2, N'Rất chăm chỉ', 7, 12),

(2024, 17, 7, N'Cần nỗ lực hơn', 8, 1),
(2024, 20, 4, N'Chăm chỉ', 8, 2),
(2024, 21, 3, N'Chăm chỉ', 8, 3),
(2024, 22, 2, N'Rất chăm chỉ', 8, 4),
(2024, 23, 1, N'Xuất sắc', 8, 5),
(2024, 21, 3, N'Chăm chỉ', 8, 6),
(2024, 18, 6, N'Cần cố gắng hơn', 8, 7),
(2024, 19, 5, N'Cần nỗ lực hơn', 8, 8),
(2024, 20, 4, N'Chăm chỉ', 8, 9),
(2024, 18, 6, N'Chưa đạt', 8, 10),
(2024, 21, 3, N'Chăm chỉ', 8, 11),
(2024, 22, 2, N'Rất chăm chỉ', 8, 12),

(2024, 16, 8, N'Cần cải thiện', 9, 1),
(2024, 20, 4, N'Chăm chỉ', 9, 2),
(2024, 21, 3, N'Chăm chỉ', 9, 3),
(2024, 22, 2, N'Rất chăm chỉ', 9, 4),
(2024, 23, 1, N'Xuất sắc', 9, 5),
(2024, 19, 5, N'Cần cố gắng hơn', 9, 6),
(2024, 21, 3, N'Chăm chỉ', 9, 7),
(2024, 22, 2, N'Rất chăm chỉ', 9, 8),
(2024, 23, 1, N'Xuất sắc', 9, 9),
(2024, 20, 4, N'Chăm chỉ', 9, 10),
(2024, 18, 6, N'Cần nỗ lực hơn', 9, 11),
(2024, 22, 2, N'Rất chăm chỉ', 9, 12),

(2024, 19, 5, N'Cần cố gắng hơn', 10, 1),
(2024, 20, 4, N'Cần cố gắng hơn', 10, 2),
(2024, 21, 3, N'Chăm chỉ', 10, 3),
(2024, 22, 2, N'Rất chăm chỉ', 10, 4),
(2024, 23, 1, N'Xuất sắc', 10, 5),
(2024, 1, 23, N'hư nè', 10, 6),
(2024, 21, 3, N'Chăm chỉ', 10, 7),
(2024, 22, 2, N'Rất chăm chỉ', 10, 8),
(2024, 23, 1, N'Xuất sắc', 10, 9),
(2024, 20, 4, N'Cần cố gắng hơn', 10, 10),
(2024, 21, 3, N'Chăm chỉ', 10, 11),
(2024, 22, 2, N'Rất chăm chỉ', 10, 12),

(2024, 18, 6, N'Cần cố gắng hơn', 11, 1),
(2024, 20, 4, N'Chăm chỉ', 11, 2),
(2024, 21, 3, N'Chăm chỉ', 11, 3),
(2024, 22, 2, N'Rất chăm chỉ',11, 4),
(2024, 23, 1, N'Xuất sắc', 11, 5),
(2024, 21, 3, N'Chăm chỉ', 11, 6),
(2024, 17, 7, N'Cần cố gắng hơn', 11, 7),
(2024, 19, 5, N'Cần cố gắng hơn', 11, 8),
(2024, 15, 9, N'Chưa đạt', 11, 9),
(2024, 20, 4, N'Chăm chỉ', 11, 10),
(2024, 21, 3, N'Chăm chỉ',11, 11),
(2024, 22, 2, N'Rất chăm chỉ', 11, 12),

(2024, 17, 7, N'Cần nỗ lực hơn', 12, 1),
(2024, 20, 4, N'Chăm chỉ', 12, 2),
(2024, 21, 3, N'Chăm chỉ', 12, 3),
(2024, 22, 2, N'Rất chăm chỉ', 12, 4),
(2024, 23, 1, N'Xuất sắc', 12, 5),
(2024, 21, 3, N'Chăm chỉ', 12, 6),
(2024, 18, 6, N'Cần cố gắng hơn', 12, 7),
(2024, 19, 5, N'Cần nỗ lực hơn', 12, 8),
(2024, 20, 4, N'Chăm chỉ', 12, 9),
(2024, 18, 6, N'Chưa đạt', 12, 10),
(2024, 21, 3, N'Chăm chỉ', 12, 11),
(2024, 22, 2, N'Rất chăm chỉ', 12, 12),

(2024, 16, 8, N'Cần cải thiện', 13, 1),
(2024, 20, 4, N'Chăm chỉ', 13, 2),
(2024, 21, 3, N'Chăm chỉ', 13, 3),
(2024, 22, 2, N'Rất chăm chỉ', 13, 4),
(2024, 23, 1, N'Xuất sắc', 13, 5),
(2024, 19, 5, N'Cần cố gắng hơn', 13, 6),
(2024, 21, 3, N'Chăm chỉ', 13, 7),
(2024, 22, 2, N'Rất chăm chỉ', 13, 8),
(2024, 23, 1, N'Xuất sắc', 13, 9),
(2024, 20, 4, N'Chăm chỉ', 13, 10),
(2024, 18, 6, N'Cần nỗ lực hơn', 13, 11),
(2024, 22, 2, N'Rất chăm chỉ', 13, 12),

(2024, 19, 5, N'Cần cố gắng hơn', 14, 1),
(2024, 20, 4, N'Cần cố gắng hơn', 14, 2),
(2024, 21, 3, N'Chăm chỉ', 14, 3),
(2024, 22, 2, N'Rất chăm chỉ', 14, 4),
(2024, 23, 1, N'Xuất sắc', 14, 5),
(2024, 1, 23, N'hư nè', 14, 6),
(2024, 21, 3, N'Chăm chỉ', 14, 7),
(2024, 22, 2, N'Rất chăm chỉ', 14, 8),
(2024, 23, 1, N'Xuất sắc', 14, 9),
(2024, 20, 4, N'Cần cố gắng hơn', 14, 10),
(2024, 21, 3, N'Chăm chỉ', 14, 11),
(2024, 22, 2, N'Rất chăm chỉ', 14, 12),

(2024, 18, 6, N'Cần cố gắng hơn', 15, 1),
(2024, 20, 4, N'Chăm chỉ', 15, 2),
(2024, 21, 3, N'Chăm chỉ', 15, 3),
(2024, 22, 2, N'Rất chăm chỉ', 15, 4),
(2024, 23, 1, N'Xuất sắc', 15, 5),
(2024, 21, 3, N'Chăm chỉ', 15, 6),
(2024, 17, 7, N'Cần cố gắng hơn', 15, 7),
(2024, 19, 5, N'Cần cố gắng hơn', 15, 8),
(2024, 15, 9, N'Chưa đạt', 15, 9),
(2024, 20, 4, N'Chăm chỉ', 15, 10),
(2024, 21, 3, N'Chăm chỉ', 15, 11),
(2024, 22, 2, N'Rất chăm chỉ', 15, 12),

(2024, 17, 7, N'Cần nỗ lực hơn', 16, 1),
(2024, 20, 4, N'Chăm chỉ', 16, 2),
(2024, 21, 3, N'Chăm chỉ', 16, 3),
(2024, 22, 2, N'Rất chăm chỉ', 16, 4),
(2024, 23, 1, N'Xuất sắc', 16, 5),
(2024, 21, 3, N'Chăm chỉ', 16, 6),
(2024, 18, 6, N'Cần cố gắng hơn', 16, 7),
(2024, 19, 5, N'Cần nỗ lực hơn', 16, 8),
(2024, 20, 4, N'Chăm chỉ', 16, 9),
(2024, 18, 6, N'Chưa đạt', 16, 10),
(2024, 21, 3, N'Chăm chỉ', 16, 11),
(2024, 22, 2, N'Rất chăm chỉ', 16, 12),

(2024, 16, 8, N'Cần cải thiện', 17, 1),
(2024, 20, 4, N'Chăm chỉ', 17, 2),
(2024, 21, 3, N'Chăm chỉ', 17, 3),
(2024, 22, 2, N'Rất chăm chỉ', 17, 4),
(2024, 23, 1, N'Xuất sắc', 17, 5),
(2024, 19, 5, N'Cần cố gắng hơn', 17, 6),
(2024, 21, 3, N'Chăm chỉ', 17, 7),
(2024, 22, 2, N'Rất chăm chỉ', 17, 8),
(2024, 23, 1, N'Xuất sắc', 17, 9),
(2024, 20, 4, N'Chăm chỉ', 17, 10),
(2024, 18, 6, N'Cần nỗ lực hơn', 17, 11),
(2024, 22, 2, N'Rất chăm chỉ', 17, 12),

(2024, 19, 5, N'Cần cố gắng hơn', 18, 1),
(2024, 20, 4, N'Cần cố gắng hơn', 18, 2),
(2024, 21, 3, N'Chăm chỉ', 18, 3),
(2024, 22, 2, N'Rất chăm chỉ', 18, 4),
(2024, 23, 1, N'Xuất sắc', 18, 5),
(2024, 1, 23, N'hư nè', 18, 6),
(2024, 21, 3, N'Chăm chỉ', 18, 7),
(2024, 22, 2, N'Rất chăm chỉ', 18, 8),
(2024, 23, 1, N'Xuất sắc', 18, 9),
(2024, 20, 4, N'Cần cố gắng hơn', 18, 10),
(2024, 21, 3, N'Chăm chỉ', 18, 11),
(2024, 22, 2, N'Rất chăm chỉ', 18, 12),

(2024, 18, 6, N'Cần cố gắng hơn', 19, 1),
(2024, 20, 4, N'Chăm chỉ', 19, 2),
(2024, 21, 3, N'Chăm chỉ', 19, 3),
(2024, 22, 2, N'Rất chăm chỉ', 19, 4),
(2024, 23, 1, N'Xuất sắc', 19, 5),
(2024, 21, 3, N'Chăm chỉ', 19, 6),
(2024, 17, 7, N'Cần cố gắng hơn', 19, 7),
(2024, 19, 5, N'Cần cố gắng hơn', 19, 8),
(2024, 15, 9, N'Chưa đạt', 19, 9),
(2024, 20, 4, N'Chăm chỉ', 19, 10),
(2024, 21, 3, N'Chăm chỉ', 19, 11),
(2024, 22, 2, N'Rất chăm chỉ', 19, 12),

(2024, 17, 7, N'Cần nỗ lực hơn', 20, 1),
(2024, 20, 4, N'Chăm chỉ', 20, 2),
(2024, 21, 3, N'Chăm chỉ', 20, 3),
(2024, 22, 2, N'Rất chăm chỉ', 20, 4),
(2024, 23, 1, N'Xuất sắc', 20, 5),
(2024, 21, 3, N'Chăm chỉ', 20, 6),
(2024, 18, 6, N'Cần cố gắng hơn', 20, 7),
(2024, 19, 5, N'Cần nỗ lực hơn', 20, 8),
(2024, 20, 4, N'Chăm chỉ', 20, 9),
(2024, 18, 6, N'Chưa đạt', 20, 10),
(2024, 21, 3, N'Chăm chỉ', 20, 11),
(2024, 22, 2, N'Rất chăm chỉ', 20, 12)
GO


INSERT INTO HopDong (MaHD, NGAYBD, NGAYKT, NgayKY, NoiDung, ThuongHD, MaNV) VALUES
	(1, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 1),
	(2, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 2),
	(3, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 3),
	(4, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 4),
	(5, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 5),
	(6, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 6),
	(7, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 7),
	(8, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 8),
	(9, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 9),
	(10, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 10),
	(11, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 11),
	(12, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 12),
    (13, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 13),
    (14, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 14),
    (15, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 15),
    (16, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 16),
    (17, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 17),
    (18, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 18),
    (19, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 19),
    (20, '2023-01-01', '2024-01-01', '2023-01-01', N'Hợp đồng lao động 1 năm', 1000000, 20);
GO


INSERT INTO KTKL  VALUES
	(1, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 1),
	(2, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 2),
	(3, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 3),
	(4, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 4),
	(5, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 5),
	(6, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 6),
    (7, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 7),
    (8, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 8),
    (9, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 9),
    (10, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 10),
    (11, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 11),
    (12, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 12),
    (13, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 13),
    (14, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 14),
    (15, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 15),
    (16, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 16),
    (17, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 17),
    (18, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 18),
    (19, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 19),
    (20, N'Khen thưởng', N'Làm việc xuất sắc', '2023-01-01', N'Hoàn thành dự án', 20);
GO