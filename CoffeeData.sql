USE [master]
GO
/****** Object:  Database [ManageCoffeeDA]    Script Date: 10/22/2023 10:50:31 PM ******/
CREATE DATABASE [ManageCoffeeDA]
 GO
USE [ManageCoffeeDA]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[UserName] [varchar](100) NOT NULL,
	[DisplayName] [nvarchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
	[IDAccount] [int] NOT NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccountName]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccountName](
	[IDAccount] [int] IDENTITY(1,1) NOT NULL,
	[NameAccount] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_AccountName] PRIMARY KEY CLUSTERED 
(
	[IDAccount] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Ban]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ban](
	[IDTable] [int] IDENTITY(1,1) NOT NULL,
	[NameTable] [nvarchar](50) NULL,
 CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED 
(
	[IDTable] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChiTietBill]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietBill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdHoaDon] [int] NOT NULL,
	[IdMon] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
 CONSTRAINT [PK_ChiTietBill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[IdDanhMuc] [int] IDENTITY(1,1) NOT NULL,
	[TenDanhMuc] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_FoodTag] PRIMARY KEY CLUSTERED 
(
	[IdDanhMuc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[IdHoaDon] [int] IDENTITY(1,1) NOT NULL,
	[ThoiGian] [datetime] NOT NULL,
	[IdBan] [int] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[TongTien] [float] NOT NULL,
	[ThanhToan] [float] NOT NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[IdHoaDon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mon]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mon](
	[IdMon] [int] IDENTITY(1,1) NOT NULL,
	[TenMon] [nvarchar](100) NOT NULL,
	[Gia] [float] NOT NULL,
	[IdDanhMuc] [int] NOT NULL,
 CONSTRAINT [PK_FoodName] PRIMARY KEY CLUSTERED 
(
	[IdMon] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TheThanhVien]    Script Date: 10/22/2023 10:50:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TheThanhVien](
	[SoDT] [nvarchar](100) NOT NULL,
	[TenKH] [nvarchar](100) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[KMLoai] [nvarchar](50) NOT NULL,
	[Diem] [int] NOT NULL,
 CONSTRAINT [PK_TheThanhVien] PRIMARY KEY CLUSTERED 
(
	[SoDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [IDAccount]) VALUES (N'admin', N'Admin', N'admin', 1)
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [IDAccount]) VALUES (N'an', N'An', N'an', 1)
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [IDAccount]) VALUES (N'kimvu', N'Hoàng Kim Vũ', N'123456', 2)
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [IDAccount]) VALUES (N'nhatvu', N'Trần Nhật Vũ', N'123456', 2)
GO
INSERT [dbo].[Account] ([UserName], [DisplayName], [Password], [IDAccount]) VALUES (N'phamtuyen', N'Nguyễn Phạm Tuyên', N'123456', 2)
GO
SET IDENTITY_INSERT [dbo].[AccountName] ON 
GO
INSERT [dbo].[AccountName] ([IDAccount], [NameAccount]) VALUES (1, N'Quản Lý')
GO
INSERT [dbo].[AccountName] ([IDAccount], [NameAccount]) VALUES (2, N'Nhân Viên')
GO
SET IDENTITY_INSERT [dbo].[AccountName] OFF
GO
SET IDENTITY_INSERT [dbo].[Ban] ON 
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (1, N'1')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (2, N'2')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (3, N'3')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (4, N'4')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (5, N'5')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (6, N'6')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (7, N'7')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (8, N'8')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (9, N'9')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (10, N'10')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (11, N'11')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (12, N'12')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (13, N'13')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (14, N'14')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (15, N'15')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (16, N'16')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (17, N'17')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (18, N'18')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (19, N'19')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (20, N'20')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (21, N'21')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (22, N'22')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (23, N'23')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (24, N'24')
GO
INSERT [dbo].[Ban] ([IDTable], [NameTable]) VALUES (25, N'25')
GO
SET IDENTITY_INSERT [dbo].[Ban] OFF
GO
SET IDENTITY_INSERT [dbo].[ChiTietBill] ON 
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (50, 24, 4, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (51, 24, 3, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (52, 24, 13, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (53, 25, 1, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (54, 25, 16, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (55, 25, 18, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (56, 25, 17, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (57, 26, 3, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (58, 26, 10, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (59, 26, 13, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (60, 27, 1, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (61, 27, 2, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (62, 28, 4, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (63, 28, 3, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (64, 29, 3, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (65, 30, 3, 2)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (66, 30, 2, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (67, 31, 16, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (68, 31, 7, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (69, 31, 2, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (70, 32, 17, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (71, 32, 7, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (72, 33, 4, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (73, 33, 3, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (74, 34, 4, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (75, 34, 3, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (76, 34, 2, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (77, 34, 5, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (78, 35, 17, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (79, 35, 16, 1)
GO
INSERT [dbo].[ChiTietBill] ([Id], [IdHoaDon], [IdMon], [SoLuong]) VALUES (80, 35, 15, 1)
GO
SET IDENTITY_INSERT [dbo].[ChiTietBill] OFF
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] ON 
GO
INSERT [dbo].[DanhMuc] ([IdDanhMuc], [TenDanhMuc]) VALUES (1, N'Cà Phê')
GO
INSERT [dbo].[DanhMuc] ([IdDanhMuc], [TenDanhMuc]) VALUES (2, N'Đá Xay')
GO
INSERT [dbo].[DanhMuc] ([IdDanhMuc], [TenDanhMuc]) VALUES (3, N'Trà')
GO
INSERT [dbo].[DanhMuc] ([IdDanhMuc], [TenDanhMuc]) VALUES (4, N'Bánh Ngọt')
GO
SET IDENTITY_INSERT [dbo].[DanhMuc] OFF
GO
SET IDENTITY_INSERT [dbo].[HoaDon] ON 
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (24, CAST(N'2023-10-22T00:00:00.000' AS DateTime), 13, N'Tai Quan', 110000, 100000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (25, CAST(N'2023-10-22T00:00:00.000' AS DateTime), 1, N'Giao Hang', 98000, 108000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (26, CAST(N'2023-10-22T00:00:00.000' AS DateTime), 6, N'Mang Ve', 105000, 105000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (27, CAST(N'2023-10-22T00:00:00.000' AS DateTime), 17, N'Mang Ve', 38000, 38000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (28, CAST(N'2023-10-22T00:00:00.000' AS DateTime), 9, N'Tai Quan', 60000, 60000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (29, CAST(N'2023-10-22T00:00:00.000' AS DateTime), 15, N'Tai Quan', 20000, 20000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (30, CAST(N'2023-10-22T19:12:03.000' AS DateTime), 15, N'Tai Quan', 60000, 60000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (31, CAST(N'2023-10-22T21:38:48.000' AS DateTime), 16, N'Tai Quan', 75000, 60000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (32, CAST(N'2023-10-22T21:45:26.000' AS DateTime), 16, N'Tai Quan', 60000, 55000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (33, CAST(N'2023-10-22T22:14:18.000' AS DateTime), 16, N'Tai Quan', 60000, 50000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (34, CAST(N'2023-10-22T22:28:05.000' AS DateTime), 25, N'Tai Quan', 120000, 120000)
GO
INSERT [dbo].[HoaDon] ([IdHoaDon], [ThoiGian], [IdBan], [Status], [TongTien], [ThanhToan]) VALUES (35, CAST(N'2023-10-22T22:28:40.000' AS DateTime), 15, N'Tai Quan', 70000, 70000)
GO
SET IDENTITY_INSERT [dbo].[HoaDon] OFF
GO
SET IDENTITY_INSERT [dbo].[Mon] ON 
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (1, N'Cà Phê Đá', 18000, 1)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (2, N'Cà Phê Sữa', 20000, 1)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (3, N'Bạc Xĩu', 20000, 1)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (4, N'Latte', 40000, 1)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (5, N'Capuccnino', 40000, 1)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (6, N'Matcha Đá Xay', 50000, 2)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (7, N'Cookie Đá Xay', 35000, 2)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (8, N'Socola Đá Xay', 40000, 2)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (9, N'Caramel Đá Xay', 45000, 2)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (10, N'Trà Đào', 35000, 3)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (11, N'Trà Tắc Xí Muội', 35000, 3)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (12, N'Trà Vải', 40000, 3)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (13, N'Trà Nhiệt Đới', 50000, 3)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (14, N'Bánh Sừng Bò', 29000, 4)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (15, N'Bánh Socola', 25000, 4)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (16, N'Bánh mì thịt', 20000, 4)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (17, N'Bánh mặn', 25000, 4)
GO
INSERT [dbo].[Mon] ([IdMon], [TenMon], [Gia], [IdDanhMuc]) VALUES (18, N'Bánh Kem', 35000, 4)
GO
SET IDENTITY_INSERT [dbo].[Mon] OFF
GO
INSERT [dbo].[TheThanhVien] ([SoDT], [TenKH], [DiaChi], [Email], [KMLoai], [Diem]) VALUES (N'0345010203', N'Hoàng Kim Vũ', N'Ai Cập', N'congchuabongbong@gmai.com', N'Sliver', 499)
GO
INSERT [dbo].[TheThanhVien] ([SoDT], [TenKH], [DiaChi], [Email], [KMLoai], [Diem]) VALUES (N'0909080706', N'Trần Nhật Vũ', N'Bắc Băng Dương', N'hoangtumua@pikachu.edu.vn', N'Sliver', 500)
GO
INSERT [dbo].[TheThanhVien] ([SoDT], [TenKH], [DiaChi], [Email], [KMLoai], [Diem]) VALUES (N'0943948066', N'Nguyễn Phạm Tuyên', N'Bà Rịa Vũng Tàu ', N'phamtuyen121314@gmail.com', N'Platium', 1000)
GO
INSERT [dbo].[TheThanhVien] ([SoDT], [TenKH], [DiaChi], [Email], [KMLoai], [Diem]) VALUES (N'1', N'Nguyễn Như Hạch', N'Đại Dương', N'hachnhu@meomeo.vn', N'Bronze', 160)
GO
ALTER TABLE [dbo].[Account]  WITH CHECK ADD  CONSTRAINT [FK_Account_AccountName] FOREIGN KEY([IDAccount])
REFERENCES [dbo].[AccountName] ([IDAccount])
GO
ALTER TABLE [dbo].[Account] CHECK CONSTRAINT [FK_Account_AccountName]
GO
ALTER TABLE [dbo].[ChiTietBill]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBill_HoaDon] FOREIGN KEY([IdHoaDon])
REFERENCES [dbo].[HoaDon] ([IdHoaDon])
GO
ALTER TABLE [dbo].[ChiTietBill] CHECK CONSTRAINT [FK_ChiTietBill_HoaDon]
GO
ALTER TABLE [dbo].[ChiTietBill]  WITH CHECK ADD  CONSTRAINT [FK_ChiTietBill_Mon] FOREIGN KEY([IdMon])
REFERENCES [dbo].[Mon] ([IdMon])
GO
ALTER TABLE [dbo].[ChiTietBill] CHECK CONSTRAINT [FK_ChiTietBill_Mon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_Ban] FOREIGN KEY([IdBan])
REFERENCES [dbo].[Ban] ([IDTable])
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_Ban]
GO
ALTER TABLE [dbo].[Mon]  WITH CHECK ADD  CONSTRAINT [FK_Mon_DanhMuc] FOREIGN KEY([IdDanhMuc])
REFERENCES [dbo].[DanhMuc] ([IdDanhMuc])
GO
ALTER TABLE [dbo].[Mon] CHECK CONSTRAINT [FK_Mon_DanhMuc]
GO
USE [master]
GO
ALTER DATABASE [ManageCoffeeDA] SET  READ_WRITE 
GO
