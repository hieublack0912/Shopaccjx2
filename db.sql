USE [Shopaccjx2]
GO
/****** Object:  Table [dbo].[Danhmuc]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Danhmuc](
	[Ma_danhmuc] [int] IDENTITY(1,1) NOT NULL,
	[Tendanhmuc] [nvarchar](50) NULL,
	[Ghichu] [text] NULL,
 CONSTRAINT [PK_Danhmuc] PRIMARY KEY CLUSTERED 
(
	[Ma_danhmuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Donhang]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Donhang](
	[Ma_donhang] [int] IDENTITY(1,1) NOT NULL,
	[Vatpham] [nvarchar](50) NULL,
	[soluong] [int] NULL,
	[Nhanvat] [nvarchar](50) NULL,
	[Tongtien] [decimal](9, 3) NULL,
	[Id_taikhoan] [int] NULL,
 CONSTRAINT [PK_Donhang] PRIMARY KEY CLUSTERED 
(
	[Ma_donhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lichsugiaodich]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lichsugiaodich](
	[Ma_lichsugiaodich] [int] IDENTITY(1,1) NOT NULL,
	[Noidunggiaodich] [nvarchar](50) NULL,
	[Dongtien] [int] NULL,
	[Sodubandau] [decimal](9, 3) NULL,
	[Sodusau] [decimal](9, 3) NULL,
	[Ma_taikhoan] [int] NULL,
 CONSTRAINT [PK_Lichsugiaodich] PRIMARY KEY CLUSTERED 
(
	[Ma_lichsugiaodich] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaiphai]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaiphai](
	[Ma_phai] [int] IDENTITY(1,1) NOT NULL,
	[Tenphai] [nvarchar](50) NULL,
	[Mota] [text] NULL,
 CONSTRAINT [PK_Loaiphai] PRIMARY KEY CLUSTERED 
(
	[Ma_phai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loaitaikhoan]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loaitaikhoan](
	[Ma_loaitaikhoan] [int] IDENTITY(1,1) NOT NULL,
	[Loaitaikhoan] [nvarchar](50) NULL,
	[Ghichu] [text] NULL,
 CONSTRAINT [PK_Loaitaikhoan] PRIMARY KEY CLUSTERED 
(
	[Ma_loaitaikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nganhang]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nganhang](
	[Ma_nganhang] [int] IDENTITY(1,1) NOT NULL,
	[Tennganhang] [nvarchar](50) NULL,
	[Ghichu] [text] NULL,
 CONSTRAINT [PK_Nganhang] PRIMARY KEY CLUSTERED 
(
	[Ma_nganhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nhanvat]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhanvat](
	[Ma_nhanvat] [int] IDENTITY(1,1) NOT NULL,
	[Kieuhinhnhanvat] [nvarchar](50) NULL,
	[Capchuyensinh] [int] NULL,
	[Huongchuyensinh] [nvarchar](50) NULL,
	[Capdo] [int] NULL,
	[Giaban] [decimal](9, 3) NULL,
	[Anhf3] [nvarchar](max) NULL,
	[Anhthongtin] [nvarchar](max) NULL,
	[Anhchankhi] [nvarchar](max) NULL,
	[Anhnon] [nvarchar](max) NULL,
	[Anhao] [nvarchar](max) NULL,
	[Anhquan] [nvarchar](max) NULL,
	[Anhngoc] [nvarchar](max) NULL,
	[Anhvukhi] [nvarchar](max) NULL,
	[Anhtinvat] [nvarchar](max) NULL,
	[Anhaochoang] [nvarchar](max) NULL,
	[Anhhuychuong] [nvarchar](max) NULL,
	[Anhgiay] [nvarchar](max) NULL,
	[Anhmattich] [nvarchar](max) NULL,
	[taikhoannv] [nvarchar](50) NULL,
	[matkhaunv] [nvarchar](50) NULL,
	[Ghichu] [nvarchar](max) NULL,
	[trangthai] [bit] NULL,
	[Ma_phai] [int] NULL,
	[Ma_taikhoan] [int] NULL,
	[thoigiantao] [date] NULL,
 CONSTRAINT [PK_Nhanvat] PRIMARY KEY CLUSTERED 
(
	[Ma_nhanvat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Phanhoi]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Phanhoi](
	[Ma_phanhoi] [int] IDENTITY(1,1) NOT NULL,
	[Noidungphanhoi] [nvarchar](max) NULL,
	[Id_taikhoan] [int] NULL,
	[Trangthai] [bit] NULL,
 CONSTRAINT [PK_Phanhoi] PRIMARY KEY CLUSTERED 
(
	[Ma_phanhoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sodutaikhoan]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sodutaikhoan](
	[Ma_sdtk] [int] NOT NULL,
	[Ma_taikhoan] [int] NULL,
	[Sodutaikhoan] [int] NULL,
 CONSTRAINT [PK_Sodutaikhoan] PRIMARY KEY CLUSTERED 
(
	[Ma_sdtk] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoan]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoan](
	[Ma_taikhoan] [int] IDENTITY(1,1) NOT NULL,
	[Tentaikhoan] [nvarchar](50) NULL,
	[Matkhau] [nvarchar](50) NULL,
	[Maukhau2] [nvarchar](50) NULL,
	[Tennguoidung] [nvarchar](100) NULL,
	[ngaysinh] [date] NULL,
	[Diachi] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[Sodutaikhoan] [decimal](9, 3) NULL,
	[Trangthai] [bit] NULL,
	[Ma_loaitaikhoan] [int] NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY CLUSTERED 
(
	[Ma_taikhoan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Taikhoannganhang]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Taikhoannganhang](
	[Ma_Taikhoannganhang] [int] IDENTITY(1,1) NOT NULL,
	[Sotaikhoan] [int] NULL,
	[Tenchutaikhoan] [varchar](100) NULL,
	[Ma_Taikhoan] [int] NULL,
	[Ma_nganhang] [int] NULL,
 CONSTRAINT [PK_Taikhoannganhang] PRIMARY KEY CLUSTERED 
(
	[Ma_Taikhoannganhang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Vatpham]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Vatpham](
	[Ma_vatpham] [int] IDENTITY(1,1) NOT NULL,
	[Tenvatpham] [nvarchar](50) NULL,
	[Giaban] [decimal](9, 3) NULL,
	[Mota] [nvarchar](max) NULL,
	[Anhvatpham] [nvarchar](max) NULL,
	[Trangthai] [bit] NULL,
	[Ma_danhmuc] [int] NULL,
 CONSTRAINT [PK_Vatpham] PRIMARY KEY CLUSTERED 
(
	[Ma_vatpham] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Layallvp]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Layallvp] AS
BEGIN

	SELECT vp.Ma_vatpham, vp.Tenvatpham, vp.Giaban, vp.Mota, vp.Anhvatpham, vp.Trangthai, dm.Tendanhmuc as 'Tendanhmuc'
	 FROM dbo.Vatpham  as vp, dbo.Danhmuc as dm
		WHERE vp.Ma_danhmuc = dm.Ma_danhmuc
END
GO
/****** Object:  StoredProcedure [dbo].[Layvptheoid]    Script Date: 3/8/2021 4:05:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[Layvptheoid](@id int) AS
BEGIN

	SELECT * FROM dbo.Vatpham
		WHERE Ma_vatpham = @id--liệu có thể trả về đối tượng theo cách khác k???

END
GO
