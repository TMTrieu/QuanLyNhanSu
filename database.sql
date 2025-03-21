USE [master]
GO
/****** Object:  Database [Quan Ly Nhan Su]    Script Date: 21/3/2025 2:02:18 PM ******/
CREATE DATABASE [Quan Ly Nhan Su]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quan Ly Nhan Su', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Quan Ly Nhan Su.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Quan Ly Nhan Su_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Quan Ly Nhan Su_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Quan Ly Nhan Su] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quan Ly Nhan Su].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET RECOVERY FULL 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET  MULTI_USER 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quan Ly Nhan Su] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quan Ly Nhan Su] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quan Ly Nhan Su', N'ON'
GO
ALTER DATABASE [Quan Ly Nhan Su] SET QUERY_STORE = ON
GO
ALTER DATABASE [Quan Ly Nhan Su] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Quan Ly Nhan Su]
GO
/****** Object:  Table [dbo].[BANGCONG]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BANGCONG](
	[MABC] [int] NOT NULL,
	[NAM] [int] NULL,
	[THANG] [int] NULL,
	[NGAY] [int] NULL,
	[GIOBAO] [int] NULL,
	[PHUTVAO] [int] NULL,
	[GIORA] [int] NULL,
	[PHUTRA] [int] NULL,
	[MANV] [int] NULL,
	[IDLOAICONG] [int] NULL,
 CONSTRAINT [PK_BANGCONG] PRIMARY KEY CLUSTERED 
(
	[MABC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BAOHIEM]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BAOHIEM](
	[IDBH] [int] NOT NULL,
	[SOBH] [nvarchar](50) NULL,
	[NGAYCAP] [datetime] NULL,
	[NOICAP] [nvarchar](50) NULL,
	[NOIKHAMBENH] [nvarchar](50) NULL,
	[MANV] [int] NULL,
 CONSTRAINT [PK_BAOHIEM] PRIMARY KEY CLUSTERED 
(
	[IDBH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BOPHAN]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BOPHAN](
	[IDBP] [int] NOT NULL,
	[TENBP] [nvarchar](50) NULL,
 CONSTRAINT [PK_BOPHAN] PRIMARY KEY CLUSTERED 
(
	[IDBP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CHUCVU]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CHUCVU](
	[IDCV] [int] NOT NULL,
	[TENCV] [nvarchar](50) NULL,
 CONSTRAINT [PK_CHUCVU] PRIMARY KEY CLUSTERED 
(
	[IDCV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DANTOC]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DANTOC](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENDT] [nvarchar](20) NULL,
 CONSTRAINT [PK_DANTOC] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOPDONG]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOPDONG](
	[SOHD] [int] NOT NULL,
	[NGAYBATDAU] [datetime] NULL,
	[NGAYKETTHUC] [datetime] NULL,
	[NGAYKY] [datetime] NULL,
	[NOIDUNG] [nvarchar](max) NULL,
	[LANKY] [int] NULL,
	[THOIHAN] [nvarchar](50) NULL,
	[HESOLUONG] [float] NULL,
	[MANV] [int] NULL,
 CONSTRAINT [PK_HOPDONG] PRIMARY KEY CLUSTERED 
(
	[SOHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KHENTHUONG_KYLUAT]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KHENTHUONG_KYLUAT](
	[ID] [int] NOT NULL,
	[SOKTKL] [int] NULL,
	[NOIDUNG] [nvarchar](max) NULL,
	[NGAY] [datetime] NULL,
	[MANV] [int] NULL,
	[LOAI] [int] NULL,
 CONSTRAINT [PK_KHENTHUONG_KYLUAT] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAICA]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAICA](
	[IDLOAICA] [int] NOT NULL,
	[TENLOAICA] [nvarchar](50) NULL,
	[HESO] [float] NULL,
 CONSTRAINT [PK_LOAICA] PRIMARY KEY CLUSTERED 
(
	[IDLOAICA] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LOAICONG]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LOAICONG](
	[IDLOAICONG] [int] NOT NULL,
	[TENLC] [nvarchar](50) NULL,
	[HESO] [float] NULL,
 CONSTRAINT [PK_LOAICONG] PRIMARY KEY CLUSTERED 
(
	[IDLOAICONG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN](
	[MANV] [int] NOT NULL,
	[HOTEN] [nvarchar](50) NULL,
	[GIOITINH] [bit] NULL,
	[NGAYSINH] [datetime] NULL,
	[DIENTHOAI] [nvarchar](50) NULL,
	[CCCD] [nvarchar](50) NULL,
	[DIACHI] [nvarchar](50) NULL,
	[HINHANH] [varbinary](max) NULL,
	[IDPB] [int] NULL,
	[IDBP] [int] NULL,
	[IDCV] [int] NULL,
	[IDTD] [int] NULL,
	[IDDT] [int] NULL,
	[IDTG] [int] NULL,
 CONSTRAINT [PK_NHANVIEN] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NHANVIEN_PHUCAP]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NHANVIEN_PHUCAP](
	[MANV] [int] NOT NULL,
	[IDPC] [int] NULL,
	[NGAY] [datetime] NULL,
	[NOIDUNG] [nvarchar](50) NULL,
	[SOTIEN] [float] NULL,
 CONSTRAINT [PK_NHANVIEN_PHUCAP] PRIMARY KEY CLUSTERED 
(
	[MANV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHONGBAN]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHONGBAN](
	[IDPB] [int] NOT NULL,
	[TENPB] [nvarchar](50) NULL,
 CONSTRAINT [PK_PHONGBAN] PRIMARY KEY CLUSTERED 
(
	[IDPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PHUCAP]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PHUCAP](
	[IDPC] [int] NOT NULL,
	[TENPC] [nvarchar](50) NULL,
	[SOTIEN] [float] NULL,
 CONSTRAINT [PK_PHUCAP] PRIMARY KEY CLUSTERED 
(
	[IDPC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TANGCA]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TANGCA](
	[ID] [int] NOT NULL,
	[NAM] [int] NULL,
	[THANG] [int] NULL,
	[NGAY] [int] NULL,
	[SOGIO] [float] NULL,
	[MANV] [int] NULL,
	[IDLOAICA] [int] NULL,
 CONSTRAINT [PK_TANGCA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TONGIAO]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TONGIAO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TENTG] [nvarchar](20) NULL,
 CONSTRAINT [PK_TONGIAO] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TRINH DO]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TRINH DO](
	[IDTD] [int] NOT NULL,
	[TENTD] [nvarchar](50) NULL,
 CONSTRAINT [PK_TRINH DO] PRIMARY KEY CLUSTERED 
(
	[IDTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UNGLUONG]    Script Date: 21/3/2025 2:02:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UNGLUONG](
	[ID] [int] NOT NULL,
	[NAM] [int] NULL,
	[THANG] [int] NULL,
	[NGAY] [int] NULL,
	[SOTIEN] [float] NULL,
	[TRANGTHAI] [bit] NULL,
	[MANV] [int] NULL,
 CONSTRAINT [PK_UNGLUONG] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BANGCONG]  WITH CHECK ADD  CONSTRAINT [FK_BANGCONG_LOAICONG] FOREIGN KEY([IDLOAICONG])
REFERENCES [dbo].[LOAICONG] ([IDLOAICONG])
GO
ALTER TABLE [dbo].[BANGCONG] CHECK CONSTRAINT [FK_BANGCONG_LOAICONG]
GO
ALTER TABLE [dbo].[BANGCONG]  WITH CHECK ADD  CONSTRAINT [FK_BANGCONG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[BANGCONG] CHECK CONSTRAINT [FK_BANGCONG_NHANVIEN]
GO
ALTER TABLE [dbo].[BAOHIEM]  WITH CHECK ADD  CONSTRAINT [FK_BAOHIEM_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[BAOHIEM] CHECK CONSTRAINT [FK_BAOHIEM_NHANVIEN]
GO
ALTER TABLE [dbo].[HOPDONG]  WITH CHECK ADD  CONSTRAINT [FK_HOPDONG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[HOPDONG] CHECK CONSTRAINT [FK_HOPDONG_NHANVIEN]
GO
ALTER TABLE [dbo].[KHENTHUONG_KYLUAT]  WITH CHECK ADD  CONSTRAINT [FK_KHENTHUONG_KYLUAT_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[KHENTHUONG_KYLUAT] CHECK CONSTRAINT [FK_KHENTHUONG_KYLUAT_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_BOPHAN] FOREIGN KEY([IDBP])
REFERENCES [dbo].[BOPHAN] ([IDBP])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_BOPHAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_CHUCVU] FOREIGN KEY([IDCV])
REFERENCES [dbo].[CHUCVU] ([IDCV])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_CHUCVU]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHONGBAN] FOREIGN KEY([IDPB])
REFERENCES [dbo].[PHONGBAN] ([IDPB])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_PHONGBAN]
GO
ALTER TABLE [dbo].[NHANVIEN]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_TRINH DO] FOREIGN KEY([IDTD])
REFERENCES [dbo].[TRINH DO] ([IDTD])
GO
ALTER TABLE [dbo].[NHANVIEN] CHECK CONSTRAINT [FK_NHANVIEN_TRINH DO]
GO
ALTER TABLE [dbo].[NHANVIEN_PHUCAP]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHUCAP_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[NHANVIEN_PHUCAP] CHECK CONSTRAINT [FK_NHANVIEN_PHUCAP_NHANVIEN]
GO
ALTER TABLE [dbo].[NHANVIEN_PHUCAP]  WITH CHECK ADD  CONSTRAINT [FK_NHANVIEN_PHUCAP_PHUCAP] FOREIGN KEY([IDPC])
REFERENCES [dbo].[PHUCAP] ([IDPC])
GO
ALTER TABLE [dbo].[NHANVIEN_PHUCAP] CHECK CONSTRAINT [FK_NHANVIEN_PHUCAP_PHUCAP]
GO
ALTER TABLE [dbo].[TANGCA]  WITH CHECK ADD  CONSTRAINT [FK_TANGCA_LOAICA] FOREIGN KEY([IDLOAICA])
REFERENCES [dbo].[LOAICA] ([IDLOAICA])
GO
ALTER TABLE [dbo].[TANGCA] CHECK CONSTRAINT [FK_TANGCA_LOAICA]
GO
ALTER TABLE [dbo].[TANGCA]  WITH CHECK ADD  CONSTRAINT [FK_TANGCA_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[TANGCA] CHECK CONSTRAINT [FK_TANGCA_NHANVIEN]
GO
ALTER TABLE [dbo].[UNGLUONG]  WITH CHECK ADD  CONSTRAINT [FK_UNGLUONG_NHANVIEN] FOREIGN KEY([MANV])
REFERENCES [dbo].[NHANVIEN] ([MANV])
GO
ALTER TABLE [dbo].[UNGLUONG] CHECK CONSTRAINT [FK_UNGLUONG_NHANVIEN]
GO
USE [master]
GO
ALTER DATABASE [Quan Ly Nhan Su] SET  READ_WRITE 
GO
