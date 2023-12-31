USE [HOTELDB]
GO
/****** Object:  Table [dbo].[DICHVU]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DICHVU](
	[MADICHVU] [int] IDENTITY(1,1) NOT NULL,
	[MALDV] [int] NOT NULL,
	[TEN] [nvarchar](30) NULL,
	[DONVITINH] [char](30) NULL,
	[THANHTIEN] [float] NULL,
 CONSTRAINT [PK_DICHVU] PRIMARY KEY CLUSTERED 
(
	[MADICHVU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DOANHTHU]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DOANHTHU](
	[MADOANHTHU] [int] IDENTITY(1,1) NOT NULL,
	[TONGTIEN] [float] NULL,
	[NGAY] [datetime] NULL,
 CONSTRAINT [PK_DOANHTHU] PRIMARY KEY CLUSTERED 
(
	[MADOANHTHU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOADON]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOADON](
	[MAHOADON] [int] IDENTITY(1,1) NOT NULL,
	[MADOANHTHU] [int] NOT NULL,
	[MATAIKHOAN] [int] NOT NULL,
	[NGAYIN] [datetime] NULL,
	[GHICHU] [nvarchar](256) NULL,
	[TONG] [float] NULL,
	[TINHTRANGTHANHTOAN] [bit] NULL,
	[DISCOUNT] [float] NULL,
 CONSTRAINT [PK_HOADON] PRIMARY KEY CLUSTERED 
(
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHACH]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHACH](
	[MAKHACH] [int] IDENTITY(1,1) NOT NULL,
	[HOTEN] [nvarchar](30) NULL,
	[SDT] [char](11) NULL,
	[CMND] [char](12) NULL,
	[NGAYSINH] [datetime] NULL,
 CONSTRAINT [PK_KHACH] PRIMARY KEY CLUSTERED 
(
	[MAKHACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIDICHVU]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIDICHVU](
	[MALDV] [int] IDENTITY(1,1) NOT NULL,
	[TEN] [nvarchar](30) NULL,
 CONSTRAINT [PK_LOAIDICHVU] PRIMARY KEY CLUSTERED 
(
	[MALDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAIPHONG]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAIPHONG](
	[MALOAIPHONG] [int] IDENTITY(1,1) NOT NULL,
	[TENLOAI] [nvarchar](50) NULL,
	[MOTA] [nvarchar](256) NULL,
	[SOGIUONG] [int] NULL,
	[TINHTHEOGIO] [float] NULL,
	[TINHTHEONGAY] [float] NULL,
 CONSTRAINT [PK_LOAIPHONG] PRIMARY KEY CLUSTERED 
(
	[MALOAIPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANHANVIEN] [char](10) NOT NULL,
	[MATAIKHOAN] [int] NULL,
	[HOTEN] [nvarchar](30) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[SDT] [char](11) NULL,
	[NGAYSINH] [datetime] NULL,
	[CMND] [char](12) NULL,
	[CHUCVU] [nvarchar](50) NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANHANVIEN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONG]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONG](
	[MAPHONG] [int] IDENTITY(1,1) NOT NULL,
	[MALOAIPHONG] [int] NOT NULL,
	[TEN] [nvarchar](30) NULL,
	[TINHTRANGPHONG] [bit] NULL,
	[TRANGTHAI] [nvarchar](30) NULL,
 CONSTRAINT [PK_PHONG] PRIMARY KEY CLUSTERED 
(
	[MAPHONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SUDUNGDICHVU]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SUDUNGDICHVU](
	[MADICHVU] [int] NOT NULL,
	[MAHOADON] [int] NOT NULL,
	[SOLUONG] [int] NULL,
 CONSTRAINT [PK_SUDUNGDICHVU] PRIMARY KEY CLUSTERED 
(
	[MADICHVU] ASC,
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TAIKHOAN]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TAIKHOAN](
	[MATAIKHOAN] [int] IDENTITY(1,1) NOT NULL,
	[MANHANVIEN] [char](10) NOT NULL,
	[TENDANGNHAP] [char](20) NULL,
	[MATKHAU] [char](20) NULL,
	[PHANQUYEN] [nvarchar](50) NULL,
 CONSTRAINT [PK_TAIKHOAN] PRIMARY KEY CLUSTERED 
(
	[MATAIKHOAN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[THUEPHONG]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[THUEPHONG](
	[MAKHACH] [int] NOT NULL,
	[MAPHONG] [int] NOT NULL,
	[MAHOADON] [int] NOT NULL,
	[CHECK_IN] [datetime] NULL,
	[CHECK_OUT] [datetime] NULL,
	[THANHTOAN] [char](10) NULL,
	[GHICHU] [nvarchar](256) NULL,
 CONSTRAINT [PK_THUEPHONG] PRIMARY KEY CLUSTERED 
(
	[MAKHACH] ASC,
	[MAPHONG] ASC,
	[MAHOADON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DICHVU]  WITH CHECK ADD  CONSTRAINT [FK_DICHVU_THUOCKIEU_LOAIDICH] FOREIGN KEY([MALDV])
REFERENCES [dbo].[LOAIDICHVU] ([MALDV])
GO
ALTER TABLE [dbo].[DICHVU] CHECK CONSTRAINT [FK_DICHVU_THUOCKIEU_LOAIDICH]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_CUA_DOANHTHU] FOREIGN KEY([MADOANHTHU])
REFERENCES [dbo].[DOANHTHU] ([MADOANHTHU])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_CUA_DOANHTHU]
GO
ALTER TABLE [dbo].[HOADON]  WITH CHECK ADD  CONSTRAINT [FK_HOADON_IN_TAIKHOAN] FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[HOADON] CHECK CONSTRAINT [FK_HOADON_IN_TAIKHOAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_SOHUU_TAIKHOAN] FOREIGN KEY([MATAIKHOAN])
REFERENCES [dbo].[TAIKHOAN] ([MATAIKHOAN])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_SOHUU_TAIKHOAN]
GO
ALTER TABLE [dbo].[PHONG]  WITH CHECK ADD  CONSTRAINT [FK_PHONG_THUOCLOAI_LOAIPHON] FOREIGN KEY([MALOAIPHONG])
REFERENCES [dbo].[LOAIPHONG] ([MALOAIPHONG])
GO
ALTER TABLE [dbo].[PHONG] CHECK CONSTRAINT [FK_PHONG_THUOCLOAI_LOAIPHON]
GO
ALTER TABLE [dbo].[SUDUNGDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNGDI_SUDUNGDIC_DICHVU] FOREIGN KEY([MADICHVU])
REFERENCES [dbo].[DICHVU] ([MADICHVU])
GO
ALTER TABLE [dbo].[SUDUNGDICHVU] CHECK CONSTRAINT [FK_SUDUNGDI_SUDUNGDIC_DICHVU]
GO
ALTER TABLE [dbo].[SUDUNGDICHVU]  WITH CHECK ADD  CONSTRAINT [FK_SUDUNGDI_SUDUNGDIC_HOADON] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADON] ([MAHOADON])
GO
ALTER TABLE [dbo].[SUDUNGDICHVU] CHECK CONSTRAINT [FK_SUDUNGDI_SUDUNGDIC_HOADON]
GO
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK ADD  CONSTRAINT [FK_TAIKHOAN_SOHUU2_NHANVIEN] FOREIGN KEY([MANHANVIEN])
REFERENCES [dbo].[NHANVIEN] ([MANHANVIEN])
GO
ALTER TABLE [dbo].[TAIKHOAN] CHECK CONSTRAINT [FK_TAIKHOAN_SOHUU2_NHANVIEN]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUEPHON_THUEPHONG_HOADON] FOREIGN KEY([MAHOADON])
REFERENCES [dbo].[HOADON] ([MAHOADON])
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_THUEPHON_THUEPHONG_HOADON]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUEPHON_THUEPHONG_KHACH] FOREIGN KEY([MAKHACH])
REFERENCES [dbo].[KHACH] ([MAKHACH])
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_THUEPHON_THUEPHONG_KHACH]
GO
ALTER TABLE [dbo].[THUEPHONG]  WITH CHECK ADD  CONSTRAINT [FK_THUEPHON_THUEPHONG_PHONG] FOREIGN KEY([MAPHONG])
REFERENCES [dbo].[PHONG] ([MAPHONG])
GO
ALTER TABLE [dbo].[THUEPHONG] CHECK CONSTRAINT [FK_THUEPHON_THUEPHONG_PHONG]
GO
/****** Object:  StoredProcedure [dbo].[BillReport]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[BillReport](@checkIn DATETIME, @checkOut DATETIME)
AS
BEGIN
    SELECT HOADON.MAHOADON,d.TEN,e.TEN, c.CHECK_IN,c.CHECK_OUT, a.SOLUONG, TONG,NGAYIN
	FROM dbo.SUDUNGDICHVU a JOIN dbo.HOADON ON HOADON.MAHOADON = a.MAHOADON
	JOIN dbo.THUEPHONG c ON c.MAHOADON = HOADON.MAHOADON 
	JOIN dbo.PHONG d ON d.MAPHONG = c.MAPHONG
	JOIN dbo.DICHVU e ON e.MADICHVU = a.MADICHVU
	WHERE c.CHECK_IN >= @checkIn AND c.CHECK_OUT <= @checkOut 
	AND c.CHECK_IN IS NOT NULL AND c.CHECK_OUT IS  NOT NULL AND NGAYIN IS NOT NULL
END
GO
/****** Object:  StoredProcedure [dbo].[CheckOUT]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[CheckOUT](@id INT,@idPhong int)
AS
BEGIN 
UPDATE dbo.THUEPHONG SET CHECK_OUT = GETDATE() WHERE MAHOADON = @id AND MAPHONG = @idPhong
DECLARE @tongtien FLOAT,@tongdv FLOAT,@giamgia FLOAT
SELECT @tongdv = SUM(b.SOLUONG*a.THANHTIEN)
FROM dbo.DICHVU a JOIN dbo.SUDUNGDICHVU b ON b.MADICHVU = a.MADICHVU
WHERE b.MAHOADON = @id
IF(EXISTS (SELECT MAHOADON FROM dbo.SUDUNGDICHVU WHERE MAHOADON = @id ))
BEGIN
    SELECT @tongtien= (c.TINHTHEONGAY*(DATEDIFF(dd,a.CHECK_IN,a.CHECK_OUT)+1)+@tongdv)
	FROM dbo.THUEPHONG a JOIN dbo.PHONG b ON b.MAPHONG = a.MAPHONG
	JOIN dbo.LOAIPHONG c ON c.MALOAIPHONG = b.MALOAIPHONG
	JOIN dbo.SUDUNGDICHVU d ON d.MAHOADON = a.MAHOADON 
	JOIN dbo.DICHVU e ON e.MADICHVU = d.MADICHVU
	WHERE d.MAHOADON = @id
END
ELSE
BEGIN
    SELECT @tongtien= (c.TINHTHEONGAY*(DATEDIFF(dd,a.CHECK_IN,a.CHECK_OUT)+1))
	FROM dbo.THUEPHONG a JOIN dbo.PHONG b ON b.MAPHONG = a.MAPHONG
	JOIN dbo.LOAIPHONG c ON c.MALOAIPHONG = b.MALOAIPHONG
	WHERE a.MAHOADON = @id
END
SELECT @giamgia = ((@tongtien/100)*DISCOUNT) FROM dbo.HOADON WHERE MAHOADON = @id
UPDATE dbo.HOADON SET TONG = @tongtien - @giamgia, TINHTRANGTHANHTOAN = 0 WHERE MAHOADON = @id
END
GO
/****** Object:  StoredProcedure [dbo].[ChuyenPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ChuyenPhong](@idPhong1 INT, @idPhong2 INT)
AS
BEGIN
    DECLARE @MaKhach1 INT,@MaHD1 INT, @CheckIn1 DATETIME,@CheckOut1 DATETIME,@ThanhToan1 CHAR(10),@Note1 NVARCHAR(256)
	
	SELECT @MaKhach1 = MAKHACH,@MaHD1 = MAHOADON,@CheckIn1 = CHECK_IN,@CheckOut1 = CHECK_OUT,@ThanhToan1 = THANHTOAN,@Note1 = GHICHU
	FROM dbo.THUEPHONG WHERE MAPHONG = @idPhong1 AND	 THANHTOAN = 'No'
	DECLARE @MaKhach2 INT,@MaHD2 INT, @CheckIn2 DATETIME,@CheckOut2 DATETIME,@ThanhToan2 CHAR(10),@Note2 NVARCHAR(256)
	
	SELECT @MaKhach2 = MAKHACH,@MaHD2 = MAHOADON,@CheckIn2 = CHECK_IN,@CheckOut2 = CHECK_OUT,@ThanhToan2 = THANHTOAN,@Note2 = GHICHU
	FROM dbo.THUEPHONG WHERE MAPHONG = @idPhong2  AND THANHTOAN = 'No'
	
	DECLARE @TrangThai1 NVARCHAR(10), @TrangThai2 NVARCHAR(10)
	SELECT @TrangThai1 = TRANGTHAI FROM dbo.PHONG WHERE MAPHONG = @idPhong1

	SELECT @TrangThai2 = TRANGTHAI FROM dbo.PHONG WHERE MAPHONG = @idPhong2



	IF(NOT EXISTS (SELECT * FROM dbo.THUEPHONG WHERE MAPHONG = @idPhong2))
	BEGIN
		insert into dbo.THUEPHONG
		(
		    MAKHACH,
		    MAPHONG,
		    MAHOADON,
		    CHECK_IN,
		    CHECK_OUT,
		    THANHTOAN,
		    GHICHU
		)
		VALUES
		(   @MaKhach1,    -- MAKHACH - int
		    @idPhong2,    -- MAPHONG - int
		    @MaHD1,    -- MAHOADON - int
		    @CheckIn1, -- CHECK_IN - datetime
		    @CheckOut1, -- CHECK_OUT - datetime
		    @ThanhToan1, -- THANHTOAN - char(10)
		    @Note1  -- GHICHU - nvarchar(256)
		    )
	UPDATE dbo.PHONG SET TRANGTHAI = 'Co' WHERE MAPHONG = @idPhong2
	UPDATE dbo.PHONG SET TRANGTHAI = 'Trong' WHERE MAPHONG = @idPhong1
	delete dbo.THUEPHONG where MAPHONG = @idPhong1 AND THANHTOAN = 'No'
	END
	ELSE
	BEGIN
	    UPDATE dbo.THUEPHONG SET MAPHONG = @idPhong2 WHERE MAPHONG = @idPhong1 AND THANHTOAN = 'No'

		UPDATE dbo.PHONG SET TRANGTHAI = @TrangThai2 WHERE MAPHONG = @idPhong1

		UPDATE dbo.PHONG SET TRANGTHAI = @TrangThai1 WHERE MAPHONG = @idPhong2
	END
END
GO
/****** Object:  StoredProcedure [dbo].[DoiPass]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[DoiPass] @tenDN NVARCHAR(10),@matKhau NVARCHAR(10)
AS
BEGIN
    UPDATE dbo.TAIKHOAN SET MATKHAU = @matKhau WHERE TENDANGNHAP = @tenDN
END
GO
/****** Object:  StoredProcedure [dbo].[GetBillByID]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetBillByID](@i int)
AS
BEGIN
     SELECT a.MAHOADON,a.MADOANHTHU,b.MAPHONG,b.MAKHACH,b.CHECK_IN,b.CHECK_OUT,a.TONG,a.GHICHU,a.TINHTRANGTHANHTOAN,a.DISCOUNT FROM dbo.HOADON a JOIN dbo.THUEPHONG b ON b.MAHOADON = a.MAHOADON
JOIN dbo.PHONG c ON c.MAPHONG = b.MAPHONG 
WHERE a.MAHOADON = @i AND a.TINHTRANGTHANHTOAN = 0
END
GO
/****** Object:  StoredProcedure [dbo].[GetBillID]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[GetBillID](@id INT)
AS
BEGIN
SELECT MAHOADON AS N'Mã hoá đơn', MADOANHTHU AS N'Mã doanh thu', MATAIKHOAN AS N'Mã tài khoản', NGAYIN AS N'Ngày in', GHICHU AS N'Ghi chú',
	TONG AS N'Tổng tiền', TINHTRANGTHANHTOAN AS N'Tình trạng thanh toán', DISCOUNT AS N'Giảm giá' 
	FROM dbo.HOADON WHERE MAHOADON = @id
END
GO
/****** Object:  StoredProcedure [dbo].[getThue]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[getThue](@id int)
AS
BEGIN
    SELECT a.MAHOADON AS N'Mã hoá đơn',a.MAPHONG AS N'Mã phòng',a.MAKHACH AS N'Mã khách',
	b.TEN AS N'Tên phòng',c.HOTEN AS N'Tên khách',a.CHECK_IN AS N'Giờ vào',a.CHECK_OUT AS N'Giờ ra',a.THANHTOAN AS N'Tinh trạng thanh toán',a.GHICHU AS N'Ghi chú'
	FROM dbo.THUEPHONG a JOIN dbo.PHONG b ON b.MAPHONG = a.MAPHONG
	JOIN dbo.KHACH c ON c.MAKHACH = a.MAKHACH
	WHERE a.MAPHONG = @id AND (a.THANHTOAN = 'No' OR a.THANHTOAN = 'Coc')
END
GO
/****** Object:  StoredProcedure [dbo].[HienPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[HienPhong]
AS
BEGIN
    SELECT * FROM dbo.PHONG WHERE TINHTRANGPHONG = 1
END
GO
/****** Object:  StoredProcedure [dbo].[InsertAutoDT]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[InsertAutoDT]
AS
BEGIN
    INSERT INTO dbo.DOANHTHU
    (
        TONGTIEN,
        NGAY
    )
    VALUES
    (   0, -- TONGTIEN - float
        GETDATE()  -- NGAY - datetime
        )
END
GO
/****** Object:  StoredProcedure [dbo].[LoadStatusPay]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadStatusPay](@idPhong int,@pay nvarchar(30))
AS
BEGIN
    SELECT THANHTOAN FROM dbo.THUEPHONG WHERE MAPHONG = @idPhong
END
GO
/****** Object:  StoredProcedure [dbo].[LoadStatusRoom]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[LoadStatusRoom]
AS
BEGIN
    SELECT DISTINCT TRANGTHAI FROM dbo.PHONG
END
GO
/****** Object:  StoredProcedure [dbo].[RentByIDRoom]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RentByIDRoom](@ten nvarchar(20))
AS
BEGIN
    SELECT a.MAHOADON, c.HOTEN AS N'Họ tên khách',b.TEN AS N'Tên phòng' ,a.CHECK_IN AS N'Giờ vào',
	a.CHECK_OUT AS N'Giờ ra',a.THANHTOAN AS N'Tình trạng thanh toán',a.GHICHU AS N'Ghi chú' FROM dbo.THUEPHONG a JOIN dbo.PHONG b
	ON b.MAPHONG = a.MAPHONG
	JOIN dbo.KHACH c ON c.MAKHACH = a.MAKHACH
	WHERE  b.TEN LIKE '%' + @ten + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[RentByNameRoom]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[RentByNameRoom](@ten nvarchar(20))
AS
BEGIN
    SELECT a.MAHOADON, c.HOTEN AS N'Họ tên khách',b.TEN AS N'Tên phòng' ,a.CHECK_IN AS N'Giờ vào',
	a.CHECK_OUT AS N'Giờ ra',a.THANHTOAN AS N'Tình trạng thanh toán',a.GHICHU AS N'Ghi chú' FROM dbo.THUEPHONG a JOIN dbo.PHONG b
	ON b.MAPHONG = a.MAPHONG
	JOIN dbo.KHACH c ON c.MAKHACH = a.MAKHACH
	WHERE  b.TEN LIKE '%' + @ten + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SuaDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaDichVu] (@MLDV INT, @Ten NVARCHAR(50), @DonVi NVARCHAR(30),@Tien FLOAT,@Ma INT)
AS
BEGIN
    UPDATE dbo.DICHVU SET MALDV = @MLDV,TEN = @Ten, DONVITINH = @DonVi, THANHTIEN = @Tien WHERE MADICHVU = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[SuaKhach]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaKhach] (@HoTen NVARCHAR(50),@SoDienThoai CHAR(10),@CMND CHAR(12),@NS DATETIME,@Ma int)
AS
BEGIN
    UPDATE dbo.KHACH SET HOTEN = @HoTen,SDT = @SoDienThoai, CMND = @CMND,NGAYSINH = CAST(@NS AS DATE) WHERE MAKHACH = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaLoaiDichVu] (@Ten NVARCHAR(50),@Ma INT )
AS
BEGIN
    UPDATE dbo.LOAIDICHVU SET TEN = @Ten WHERE MALDV = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[SuaLoaiPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaLoaiPhong](@TenLoai NVARCHAR(50),@MoTa NVARCHAR(100),@SoGiuong INT,@TienTheoGio FLOAT,@TienTheoNgay FLOAT,@Ma int)
AS
BEGIN
    UPDATE dbo.LOAIPHONG SET TENLOAI =@TenLoai, MOTA = @MoTa,SOGIUONG = @SoGiuong, TINHTHEOGIO = @TienTheoGio, TINHTHEONGAY = @TienTheoNgay
	WHERE MALOAIPHONG = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[SuaNhanVien]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaNhanVien](@MaNV CHAR(20),@MaTK INT,@HT NVARCHAR(50),@dc NVARCHAR(30),@sdt CHAR(10),@ns DATETIME, @cmnd CHAR(12),@cv NVARCHAR(20))
AS
BEGIN
    UPDATE dbo.NHANVIEN SET MATAIKHOAN = @MaTK,HOTEN = @HT,DIACHI = @dc,SDT = @sdt,NGAYSINH = CAST(@ns AS DATE),CMND = @cmnd,CHUCVU = @cv WHERE MANHANVIEN = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[SuaPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaPhong] (@MaLoai INT, @Ten NVARCHAR(50), @TrangThai NVARCHAR(30),@Ma INT,@TTP BIT)
AS
 BEGIN
     UPDATE dbo.PHONG SET MALOAIPHONG = @MaLoai, TEN = @Ten, TRANGTHAI = @TrangThai, TINHTRANGPHONG = @TTP WHERE MAPHONG = @Ma
 END
GO
/****** Object:  StoredProcedure [dbo].[SuaTaiKhoan]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[SuaTaiKhoan](@MaNV CHAR(10),@TenDN NCHAR(50),@MK NCHAR(50),@PQ NVARCHAR(30),@MaTK int)
AS
BEGIN
    UPDATE dbo.TAIKHOAN SET MANHANVIEN = @MaNV,TENDANGNHAP = @TenDN,MATKHAU = @MK,PHANQUYEN = @PQ WHERE MATAIKHOAN = @MaTK
END
GO
/****** Object:  StoredProcedure [dbo].[ThanhToan]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThanhToan](@idPhong int, @idHoaDon int)
AS
BEGIN
DECLARE @tong FLOAT
    UPDATE dbo.HOADON SET TINHTRANGTHANHTOAN = 1,NGAYIN = GETDATE() WHERE MAHOADON = @idHoaDon
	UPDATE dbo.THUEPHONG SET THANHTOAN = 'Yes' WHERE MAHOADON = @idHoaDon AND MAPHONG = @idPhong
	UPDATE dbo.PHONG SET TRANGTHAI = 'Trong' WHERE MAPHONG = @idPhong
	DECLARE @iddt INT
	SELECT @iddt = MADOANHTHU,@tong = TONG FROM dbo.HOADON WHERE MAHOADON = @idHoaDon
    UPDATE dbo.HOADON SET TONG = @tong WHERE MAHOADON = @idHoaDon
	UPDATE dbo.DOANHTHU
    SET TONGTIEN = (SELECT SUM(TONG) FROM dbo.HOADON WHERE MADOANHTHU = @iddt)
    WHERE MADOANHTHU = @iddt
END
GO
/****** Object:  StoredProcedure [dbo].[ThemDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemDichVu] (@MLDV INT, @Ten NVARCHAR(50), @DonVi NVARCHAR(30),@Tien FLOAT)
AS
BEGIN
    INSERT INTO dbo.DICHVU
    (
        MALDV,
        TEN,
        DONVITINH,
        THANHTIEN
    )
    VALUES
    (   @MLDV,    -- MALDV - int
        @Ten, -- TEN - char(30)
        @DonVi, -- DONVITINH - char(30)
        @Tien  -- THANHTIEN - float
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemKhach]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemKhach](@HoTen NVARCHAR(50),@SoDienThoai CHAR(10),@CMND CHAR(12),@NS DATETIME)
AS
BEGIN
    INSERT INTO dbo.KHACH
    (
        HOTEN,
        SDT,
        CMND,
        NGAYSINH
    )
    VALUES
    (   @HoTen, -- HOTEN - char(30)
        @SoDienThoai, -- SDT - char(11)
        @CMND, -- CMND - char(12)
        CAST(@NS AS DATE)  -- NGAYSINH - datetime
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLoaiDichVu](@Ten NVARCHAR(50))
AS
BEGIN
    INSERT INTO dbo.LOAIDICHVU
    (
        TEN
    )
    VALUES
    (@Ten -- TEN - char(30)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemLoaiPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemLoaiPhong](@TenLoai NVARCHAR(50),@MoTa NVARCHAR(100),@SoGiuong INT,@TienTheoGio FLOAT,@TienTheoNgay FLOAT)
AS
BEGIN
    INSERT INTO dbo.LOAIPHONG
    (
        TENLOAI,
        MOTA,
        SOGIUONG,
        TINHTHEOGIO,
        TINHTHEONGAY
    )
    VALUES
    (   @TenLoai, -- TENLOAI - char(50)
        @MoTa, -- MOTA - char(256)
        @SoGiuong, -- SOGIUONG - int
        @TienTheoGio, -- TINHTHEOGIO - float
        @TienTheoNgay  -- TINHTHEONGAY - float
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemNhanVien]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemNhanVien](@MaNV CHAR(20),@HT NVARCHAR(50),@dc NVARCHAR(30),@sdt CHAR(10),@ns DATETIME, @cmnd CHAR(12),@cv NVARCHAR(20))
AS
BEGIN
    INSERT INTO dbo.NHANVIEN
    (
        MANHANVIEN,
        HOTEN,
        DIACHI,
        SDT,
        NGAYSINH,
        CMND,
        CHUCVU
    )
    VALUES
    (   @MaNV,   -- MANHANVIEN - char(10)
        @HT, -- HOTEN - char(30)
        @dc, -- DIACHI - char(50)
        @sdt, -- SDT - char(11)
        CAST(@ns AS DATE), -- NGAYSINH - datetime
        @cmnd, -- CMND - char(12)
        @cv  -- CHUCVU - char(50)
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemPhong](@MaLoai INT, @Ten NVARCHAR(50), @TrangThai NVARCHAR(30), @TTP BIT)
AS
BEGIN
    INSERT INTO dbo.PHONG
    (
        MALOAIPHONG,
        TEN,
		TRANGTHAI,
        TINHTRANGPHONG
    )
    VALUES
    (   @MaLoai,    -- MALOAIPHONG - int
        @Ten, -- TEN - char(30)
        @TrangThai,  -- TRANGTHAI - char(100)
		@TTP
        )
END
GO
/****** Object:  StoredProcedure [dbo].[ThemSDDV]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemSDDV](@idBill INT, @idDV INT, @sl int)
AS
BEGIN
	DECLARE @maDV INT;
    DECLARE @cout INT = 1;

    -- Kiểm tra xem dịch vụ đã tồn tại trong bảng SUDUNGDICHVU hay chưa
    SELECT @maDV = MADICHVU, @cout = SOLUONG FROM dbo.SUDUNGDICHVU WHERE MAHOADON = @idBill AND MADICHVU = @idDV;

    IF(@maDV IS NOT NULL)
    BEGIN
        -- Dịch vụ đã tồn tại, cập nhật số lượng
        DECLARE @newcount INT = @cout + @sl;
        IF (@newcount > 0)
            UPDATE dbo.SUDUNGDICHVU SET SOLUONG = @newcount WHERE MADICHVU = @idDV
        ELSE
            DELETE FROM dbo.SUDUNGDICHVU WHERE MAHOADON = @idBill AND MADICHVU = @idDV;
    END
    ELSE
    BEGIN
        -- Dịch vụ chưa tồn tại, thêm mới
        -- Kiểm tra xem khóa chính đã tồn tại hay chưa trước khi thêm mới
        IF NOT EXISTS (SELECT 1 FROM dbo.SUDUNGDICHVU WHERE MAHOADON = @idBill AND MADICHVU = @idDV)
        BEGIN
            INSERT INTO dbo.SUDUNGDICHVU (MADICHVU, MAHOADON, SOLUONG)
            VALUES (@idDV, @idBill, @sl);
		END
END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemTaiKhoan]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemTaiKhoan] (@MaNV CHAR(10),@TenDN NCHAR(50),@MK NCHAR(50),@PQ NVARCHAR(30))
AS
BEGIN
IF(EXISTS (SELECT * FROM dbo.TAIKHOAN WHERE MANHANVIEN = @MaNV))
BEGIN
    PRINT N'Nhân viên đã có tài khoản'
END
ELSE
BEGIN
       INSERT INTO dbo.TAIKHOAN
	(
		MANHANVIEN,
		TENDANGNHAP,
		MATKHAU,
		PHANQUYEN
	)
	VALUES
	(  @MaNV,   -- MANHANVIEN - char(10)
		@TenDN, -- TENDANGNHAP - char(20)
		@MK, -- MATKHAU - char(20)
		@PQ  -- PHANQUYEN - char(50)
		)
		DECLARE @MaTK INT
		SET @MaTK = SCOPE_IDENTITY()
		UPDATE dbo.NHANVIEN SET MATAIKHOAN = @MaTK WHERE MANHANVIEN= @MaNV
END
END
GO
/****** Object:  StoredProcedure [dbo].[ThemThuePhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThemThuePhong](@maKhach int,@maPhong INT, @ci datetime, @co datetime, @tt CHAR(10), @note nvarchar(100))
AS
BEGIN
DECLARE @maDT INT
SELECT @maDT = MADOANHTHU FROM dbo.DOANHTHU WHERE CONVERT(DATE, NGAY) = CAST(GETDATE() AS DATE)
IF(NOT EXISTS (SELECT * FROM dbo.THUEPHONG WHERE MAPHONG = @maPhong AND THANHTOAN = 'No'))
BEGIN
    INSERT INTO dbo.HOADON
	(
	    MADOANHTHU,
	    MATAIKHOAN,
	    NGAYIN,
	    GHICHU,
	    TONG,
	    TINHTRANGTHANHTOAN,
		DISCOUNT
	)
	VALUES
	(   @maDT,    -- MADOANHTHU - int
	    1,    -- MATAIKHOAN - int
	    NULL, -- NGAYIN - datetime
	    NULL, -- GHICHU - nvarchar(256)
	    NULL, -- TONG - float
	    0,  -- TINHTRANGTHANHTOAN - bit
		0
	    )

		DECLARE @MaHD INT
		SET @MaHD = SCOPE_IDENTITY()
    INSERT INTO dbo.THUEPHONG
    (
        MAKHACH,
        MAPHONG,
        MAHOADON,
        CHECK_IN,
        CHECK_OUT,
        THANHTOAN,
        GHICHU
    )
    VALUES
    (   @maKhach,    -- MAKHACH - int
		@maPhong,    -- MAPHONG - int
        @MaHD,    -- MAHOADON - int
        @ci, -- CHECK_IN - datetime
        @co, -- CHECK_OUT - datetime
        @tt, -- THANHTOAN - char(10)
        @note  -- GHICHU - nvarchar(256)
        )

		UPDATE dbo.PHONG SET TRANGTHAI = 'Co' WHERE MAPHONG = @maPhong
END

END
GO
/****** Object:  StoredProcedure [dbo].[ThongKeTheoNgayAdenB]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[ThongKeTheoNgayAdenB](@ci datetime, @co datetime)
AS
BEGIN
    SELECT *
	FROM dbo.DOANHTHU
	WHERE  NGAY >= @ci AND NGAY <= @co
END
GO
/****** Object:  StoredProcedure [dbo].[timBillInfoIDBill]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[timBillInfoIDBill](@id INT)
AS
BEGIN
    SELECT a.MAHOADON, b.TEN,a.SOLUONG,b.DONVITINH,b.THANHTIEN,b.THANHTIEN* a.SOLUONG AS TongTien
FROM dbo.SUDUNGDICHVU a JOIN dbo.DICHVU b ON b.MADICHVU = a.MADICHVU
JOIN dbo.HOADON ON HOADON.MAHOADON = a.MAHOADON
WHERE a.MAHOADON = @id AND dbo.HOADON.TINHTRANGTHANHTOAN = 0
END
GO
/****** Object:  StoredProcedure [dbo].[TimDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimDichVu](@Ten NVARCHAR(50))
AS
BEGIN
    SELECT a.MADICHVU AS N'Mã dịch vụ',a.TEN AS N'Tên dịch vụ',a.MALDV AS N'Mã loại dịch vụ',b.TEN AS N'Tên loại dịch vụ',
	a.DONVITINH AS N'Đơn vị tính',a.THANHTIEN AS N'Thành tiền' FROM dbo.DICHVU a JOIN dbo.LOAIDICHVU b ON b.MALDV = a.MALDV
	WHERE a.TEN LIKE N'%' +@Ten + N'%'
END
GO
/****** Object:  StoredProcedure [dbo].[TimKhach]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimKhach](@Ten NVARCHAR(50))
AS
BEGIN
	SELECT MAKHACH AS N'Mã khách', HOTEN AS N'Họ tên khách hàng', SDT AS N'Số điện thoại',CMND AS N'Chứng minh nhân dân', NGAYSINH AS N'Ngày sinh' FROM dbo.KHACH
     WHERE HOTEN LIKE N'%'+@Ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[TimNhanVien]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimNhanVien](@Ten nvarchar(50))
AS
BEGIN
   SELECT MANHANVIEN AS N'Mã nhân viên', MATAIKHOAN AS N'Mã tài khoản', HOTEN AS N'Họ tên nhân viên', SDT AS 'Số điện thoại',
	NGAYSINH AS N'Ngày sinh',CMND AS N'Chứng minh nhân dân', CHUCVU AS N'Chức vụ' FROM dbo.NHANVIEN WHERE HOTEN LIKE N'%'+@Ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[TimPhongTheoTen]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimPhongTheoTen] (@Ten NVARCHAR(50))
AS
BEGIN
	 SELECT MAPHONG AS N'Mã phòng',MALOAIPHONG AS N'Mã loại phòng',TEN AS N'Tên phòng', TINHTRANGPHONG AS N'Tình trạng sử dụng', TRANGTHAI AS N'Trạng thái phòng' FROM dbo.PHONG 
	 WHERE TEN LIKE N'%' +@Ten + N'%'
END
GO
/****** Object:  StoredProcedure [dbo].[TimPhongTheoTT]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimPhongTheoTT](@TT NVARCHAR(10))
AS
BEGIN
    IF (@TT IN (SELECT TRANGTHAI FROM dbo.PHONG WHERE TRANGTHAI = @TT))
	BEGIN
	    SELECT * FROM dbo.PHONG WHERE TRANGTHAI = @TT
	END
	ELSE
	BEGIN
	    SELECT * FROM dbo.PHONG
	END
END
GO
/****** Object:  StoredProcedure [dbo].[TimSDDV]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimSDDV](@id int)
AS
BEGIN
    SELECT * FROM dbo.SUDUNGDICHVU WHERE	 MAHOADON = @id
END
GO
/****** Object:  StoredProcedure [dbo].[TimTaiKhoan]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimTaiKhoan] (@Ten NVARCHAR(30))
AS
BEGIN
   SELECT MATAIKHOAN AS N'Mã tài khoản ',MANHANVIEN AS N'Mã nhân viên', TENDANGNHAP AS N'Tên đăng nhập', MATKHAU AS N'Mật khẩu', PHANQUYEN AS N'Phân quyền' FROM dbo.TAIKHOAN WHERE TENDANGNHAP  LIKE '%' + @Ten + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[TimTheoTrangThai]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[TimTheoTrangThai](@TrangThai NVARCHAR(30))
AS
BEGIN
	    IF(@TrangThai = N'Co')
		BEGIN
		    SELECT * FROM dbo.PHONG WHERE TRANGTHAI = N'Co'
		END
		ELSE IF (@TrangThai = N'Book')
		BEGIN
		    SELECT * FROM dbo.PHONG WHERE TRANGTHAI = N'Book'
		END
		ELSE IF (@TrangThai = N'Trong')
		BEGIN
		    SELECT * FROM dbo.PHONG WHERE TRANGTHAI = N'Trong'
		END
		ELSE 
			PRINT N'Trạng thái không tồn tại!'
END
GO
/****** Object:  StoredProcedure [dbo].[UOSByID]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UOSByID](@ten nvarchar(50))
AS
BEGIN
    SELECT a.MAHOADON,c.TEN,a.SOLUONG,c.DONVITINH,c.THANHTIEN, (a.SOLUONG * c.THANHTIEN) AS N'Tổng'
FROM dbo.SUDUNGDICHVU a JOIN dbo.HOADON b ON b.MAHOADON = a.MAHOADON
JOIN dbo.DICHVU c ON c.MADICHVU = a.MADICHVU
WHERE c.TEN LIKE '%' + @ten + '%'
ORDER BY a.MAHOADON ASC
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateDis]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[UpdateDis](@id INT,@discount FLOAT)
AS
BEGIN
    UPDATE dbo.HOADON SET DISCOUNT = @discount WHERE MAHOADON = @id 
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetAccList]
AS
BEGIN
    SELECT MATAIKHOAN AS N'Mã tài khoản ',MANHANVIEN AS N'Mã nhân viên', TENDANGNHAP AS N'Tên đăng nhập', MATKHAU AS N'Mật khẩu', PHANQUYEN AS N'Phân quyền' FROM dbo.TAIKHOAN
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetBillList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetBillList]
AS
BEGIN
    SELECT MAHOADON AS N'Mã hoá đơn', MADOANHTHU AS N'Mã doanh thu', MATAIKHOAN AS N'Mã tài khoản', NGAYIN AS N'Ngày in', GHICHU AS N'Ghi chú',
	TONG AS N'Tổng tiền', TINHTRANGTHANHTOAN AS N'Tình trạng thanh toán', DISCOUNT AS N'Giảm giá' 
	FROM dbo.HOADON 
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetCusList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetCusList]
AS
BEGIN
    SELECT MAKHACH AS N'Mã khách', HOTEN AS N'Họ tên khách hàng', SDT AS N'Số điện thoại',CMND AS N'Chứng minh nhân dân', NGAYSINH AS N'Ngày sinh' FROM dbo.KHACH
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetKindOfRoomList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetKindOfRoomList]
AS
BEGIN
    SELECT MALOAIPHONG AS N'Mã loại phòng', TENLOAI AS N'Tên loại', MOTA AS N'Mô tả', SOGIUONG AS N'Số giường', TINHTHEOGIO AS N'Tiền 1 giờ', TINHTHEONGAY AS N'Tiền 1 ngày'  FROM dbo.LOAIPHONG
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetKindOfServiceList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetKindOfServiceList]
AS
BEGIN
    SELECT MALDV AS N'Mã loại dịch vụ', TEN AS N'Tên loại dịch vụ' FROM dbo.LOAIDICHVU
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetRentList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetRentList]
AS
BEGIN
    SELECT a.MAHOADON, c.HOTEN AS N'Họ tên khách',b.TEN AS N'Tên phòng' ,a.CHECK_IN AS N'Giờ vào',
	a.CHECK_OUT AS N'Giờ ra',a.THANHTOAN AS N'Tình trạng thanh toán',a.GHICHU AS N'Ghi chú' FROM dbo.THUEPHONG a JOIN dbo.PHONG b
	ON b.MAPHONG = a.MAPHONG
	JOIN dbo.KHACH c ON c.MAKHACH = a.MAKHACH

END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetRoomList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetRoomList]
AS
BEGIN
    SELECT MAPHONG AS N'Mã phòng',MALOAIPHONG AS N'Mã loại phòng',TEN AS N'Tên phòng', TINHTRANGPHONG AS N'Tình trạng sử dụng', TRANGTHAI AS N'Trạng thái phòng' FROM dbo.PHONG
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetSalesList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetSalesList]
AS
BEGIN
    SELECT MADOANHTHU AS N'Mã doanh thu', TONGTIEN AS N'Tổng tiền doanh thu', NGAY AS N'Ngày doanh thu' FROM dbo.DOANHTHU
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetServiceList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetServiceList]
AS
BEGIN
    SELECT a.MADICHVU AS N'Mã dịch vụ',a.TEN AS N'Tên dịch vụ',a.MALDV AS N'Mã loại dịch vụ',b.TEN AS N'Tên loại dịch vụ',
	a.DONVITINH AS N'Đơn vị tính',a.THANHTIEN AS N'Thành tiền' FROM dbo.DICHVU a JOIN dbo.LOAIDICHVU b
	ON b.MALDV = a.MALDV
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetStaffList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetStaffList]
AS
BEGIN
    SELECT MANHANVIEN AS N'Mã nhân viên', MATAIKHOAN AS N'Mã tài khoản', HOTEN AS N'Họ tên nhân viên', SDT AS 'Số điện thoại',
	NGAYSINH AS N'Ngày sinh',CMND AS N'Chứng minh nhân dân', CHUCVU AS N'Chức vụ'  FROM dbo.NHANVIEN
END
GO
/****** Object:  StoredProcedure [dbo].[USP_GetUOServiceList]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[USP_GetUOServiceList]
AS
BEGIN
    SELECT a.MAHOADON AS N'Mã hoá đơn',c.TEN AS N'Tên dịch vụ',a.SOLUONG AS N'Số lượng',c.DONVITINH AS N'Đơn vị tính',
	c.THANHTIEN AS N'Đơn giá', (a.SOLUONG * c.THANHTIEN) AS N'Tổng'
FROM dbo.SUDUNGDICHVU a JOIN dbo.HOADON b ON b.MAHOADON = a.MAHOADON
JOIN dbo.DICHVU c ON c.MADICHVU = a.MADICHVU
ORDER BY a.MAHOADON ASC
END
GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[USP_Login](@acc CHAR(10),@pass CHAR(10))
AS
BEGIN
    SELECT * FROM dbo.TAIKHOAN
	WHERE TENDANGNHAP = @acc AND MATKHAU = @pass
END
GO
/****** Object:  StoredProcedure [dbo].[XemDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemDichVu] (@Ten NVARCHAR(30))
AS
BEGIN
    IF(@Ten IS NULL)
		SELECT * FROM dbo.DICHVU
	ELSE 
		BEGIN
		    SELECT * FROM dbo.DICHVU WHERE @TEN LIKE N'%'+@Ten+'%'
		END
END
GO
/****** Object:  StoredProcedure [dbo].[XemLoaiDV]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemLoaiDV] (@Ten NVARCHAR(30))
AS
BEGIN
	SELECT MALDV AS N'Mã loại dịch vụ', TEN AS N'Tên loại dịch vụ' FROM dbo.LOAIDICHVU WHERE TEN LIKE N'%'+@Ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[XemLoaiPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XemLoaiPhong] (@Ten NVARCHAR(30))
AS
BEGIN
    SELECT MALOAIPHONG AS N'Mã loại phòng', TENLOAI AS N'Tên loại', MOTA AS N'Mô tả', SOGIUONG AS N'Số giường', TINHTHEOGIO AS N'Tiền 1 giờ', TINHTHEONGAY AS N'Tiền 1 ngày'  FROM dbo.LOAIPHONG
     WHERE TENLOAI LIKE N'%'+@Ten+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[XoaDichVu]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaDichVu](@Ma INT)
AS
BEGIN
    DELETE FROM dbo.SUDUNGDICHVU WHERE MADICHVU = @Ma
	DELETE FROM dbo.DICHVU WHERE MADICHVU = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[XoaHoaDon]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHoaDon](@id int)
AS
BEGIN
    DECLARE @tongtien FLOAT, @dt INT
	SELECT @tongtien = TONG,@dt = MADOANHTHU FROM dbo.HOADON WHERE MAHOADON = @id
	DELETE FROM dbo.THUEPHONG WHERE MAHOADON = @id
	DELETE dbo.SUDUNGDICHVU WHERE MAHOADON = @id
	DELETE FROM dbo.HOADON WHERE MAHOADON = @id
	UPDATE dbo.DOANHTHU
SET TONGTIEN = TONGTIEN - @tongtien
WHERE MADOANHTHU = @dt
END
GO
/****** Object:  StoredProcedure [dbo].[XoaKhach]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaKhach] (@Ma INT)
AS
BEGIN
    DELETE FROM dbo.THUEPHONG WHERE MAKHACH = @Ma
	DELETE FROM dbo.KHACH WHERE MAKHACH = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[XoaLoaiPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaLoaiPhong](@MaLoai int)
AS
BEGIN
	DECLARE @maPhong INT

	-- Lấy danh sách các MAPHONG thuộc MALOAIPHONG = @MaLoai
	DECLARE @MaPhongList TABLE (MAPHONG INT)

	INSERT INTO @MaPhongList (MAPHONG)
	SELECT MAPHONG FROM dbo.PHONG WHERE MALOAIPHONG = @MaLoai

	-- Duyệt qua danh sách và xóa từng phòng
	WHILE EXISTS (SELECT 1 FROM @MaPhongList)
	BEGIN
	    SELECT TOP 1 @maPhong = MAPHONG FROM @MaPhongList

	    -- Xóa phòng
	    EXEC dbo.XoaPhong @maPhong

	    -- Xóa phòng khỏi danh sách
	    DELETE FROM @MaPhongList WHERE MAPHONG = @maPhong
	END

	-- Xóa loại phòng
	DELETE FROM dbo.LOAIPHONG WHERE MALOAIPHONG = @MaLoai
END
GO
/****** Object:  StoredProcedure [dbo].[XoaNhanVien]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaNhanVien](@MaNV CHAR(10))
AS
BEGIN
	DECLARE @maTK INT

	-- Lấy danh sách các MAPHONG thuộc MALOAIPHONG = @MaLoai
	DECLARE @MaTKList TABLE (MATAIKHOAN INT)

	INSERT INTO @MaTKList(MATAIKHOAN)
	SELECT MATAIKHOAN FROM dbo.TAIKHOAN WHERE MANHANVIEN = @MaNV

	-- Duyệt qua danh sách và xóa từng phòng
	WHILE EXISTS (SELECT 1 FROM @MaTKList)
	BEGIN
	    SELECT TOP 1 @maTK = MATAIKHOAN FROM @MaTKList

	    -- Xóa phòng
	    EXEC dbo.XoaTaiKhoa @maTK -- int
	    

	    -- Xóa phòng khỏi danh sách
	    DELETE FROM @MaTKList WHERE MATAIKHOAN = @maTK
	END

	-- Xóa loại phòng
   DELETE FROM dbo.NHANVIEN WHERE MANHANVIEN = @MaNV
END
GO
/****** Object:  StoredProcedure [dbo].[XoaPhong]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaPhong](@Ma int)
AS
BEGIN
	DELETE FROM dbo.THUEPHONG WHERE MAPHONG = @Ma
	DELETE FROM dbo.PHONG WHERE MAPHONG = @Ma
END
GO
/****** Object:  StoredProcedure [dbo].[XoaTaiKhoa]    Script Date: 10/24/2023 6:25:03 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaTaiKhoa](@MaTK int)
AS
BEGIN
    UPDATE dbo.NHANVIEN SET MATAIKHOAN = NULL WHERE MATAIKHOAN = @MaTK
	DELETE FROM dbo.HOADON WHERE MATAIKHOAN = @MaTK
	DELETE FROM dbo.TAIKHOAN WHERE MATAIKHOAN = @MaTK
END
GO
