USE [THUVIEN]
GO
/****** Object:  Table [dbo].[LoaiSach]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiSach] [nchar](10) NOT NULL,
	[TenLoaiSach] [nvarchar](200) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
 CONSTRAINT [PK_LoaiSach_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NXB]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NXB](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaNXB] [nchar](10) NOT NULL,
	[TenNXB] [nvarchar](150) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[DiaChi] [nvarchar](150) NULL,
 CONSTRAINT [PK_NXB_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuMuon]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuMuon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaMuon] [nchar](10) NOT NULL,
	[NguoiMuon] [int] NULL,
	[NgayMuon] [datetime] NULL,
	[NgayTra] [datetime] NULL,
	[HinhThuc] [nvarchar](150) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[SoNgayMuon] [int] NULL,
 CONSTRAINT [PK_PhieuMuon_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sach]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sach](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaSach] [nchar](10) NOT NULL,
	[TenSach] [nvarchar](150) NULL,
	[LoaiSach] [int] NULL,
	[NamXB] [nchar](10) NULL,
	[NXB] [int] NULL,
	[TacGia] [int] NULL,
	[ViTri] [int] NULL,
	[SoLuong] [int] NULL,
	[Muon] [int] NULL,
	[NgonNgu] [nvarchar](150) NULL,
	[TimeCreate] [datetime] NULL,
	[TimeUpdate] [datetime] NULL,
 CONSTRAINT [PK_Sach_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SinhVien]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SinhVien](
	[ID] [int] NOT NULL,
	[MaSV] [nchar](10) NOT NULL,
	[Lop] [nvarchar](150) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[HoTen] [nvarchar](150) NULL,
 CONSTRAINT [PK_SinhVien_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TacGia]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TacGia](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaTacGia] [nchar](10) NOT NULL,
	[TenTacGia] [nvarchar](150) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[DiaChi] [nvarchar](250) NULL,
 CONSTRAINT [PK_TacGia_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](150) NULL,
	[Email] [nvarchar](150) NULL,
	[Username] [varchar](50) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ViTri]    Script Date: 4/9/2024 3:11:12 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ViTri](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[MaViTri] [nchar](10) NOT NULL,
	[Ngan] [nvarchar](150) NULL,
	[Ke] [nvarchar](150) NULL,
	[TimeUpdate] [datetime] NULL,
	[TimeCreate] [datetime] NULL,
	[Khu] [nvarchar](150) NULL,
 CONSTRAINT [PK_ViTri_1] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[LoaiSach] ON 

INSERT [dbo].[LoaiSach] ([ID], [MaLoaiSach], [TenLoaiSach], [TimeUpdate], [TimeCreate]) VALUES (10, N'1         ', N'Tình Cảm', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime))
INSERT [dbo].[LoaiSach] ([ID], [MaLoaiSach], [TenLoaiSach], [TimeUpdate], [TimeCreate]) VALUES (11, N'2         ', N'Học Đường', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[LoaiSach] OFF
GO
SET IDENTITY_INSERT [dbo].[NXB] ON 

INSERT [dbo].[NXB] ([ID], [MaNXB], [TenNXB], [TimeUpdate], [TimeCreate], [DiaChi]) VALUES (4, N'1         ', N'Nguyễn Ngạn', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'Hutech')
SET IDENTITY_INSERT [dbo].[NXB] OFF
GO
SET IDENTITY_INSERT [dbo].[PhieuMuon] ON 

INSERT [dbo].[PhieuMuon] ([ID], [MaMuon], [NguoiMuon], [NgayMuon], [NgayTra], [HinhThuc], [TimeUpdate], [TimeCreate], [SoNgayMuon]) VALUES (4, N'1         ', 1, CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-10T00:00:00.000' AS DateTime), N'Offline', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), 3)
INSERT [dbo].[PhieuMuon] ([ID], [MaMuon], [NguoiMuon], [NgayMuon], [NgayTra], [HinhThuc], [TimeUpdate], [TimeCreate], [SoNgayMuon]) VALUES (5, N'2         ', 2, CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-12T00:00:00.000' AS DateTime), N'Offline', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), 5)
SET IDENTITY_INSERT [dbo].[PhieuMuon] OFF
GO
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([ID], [MaSach], [TenSach], [LoaiSach], [NamXB], [NXB], [TacGia], [ViTri], [SoLuong], [Muon], [NgonNgu], [TimeCreate], [TimeUpdate]) VALUES (4, N'1         ', N'Giải quyết đồ án', 11, N'2024      ', 4, 4, 3, 50, 4, N'Tiếng Việt', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Sach] OFF
GO
INSERT [dbo].[SinhVien] ([ID], [MaSV], [Lop], [TimeUpdate], [TimeCreate], [HoTen]) VALUES (1, N'2180607460', N'21DTHE2', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'Lê Trung Kiên')
INSERT [dbo].[SinhVien] ([ID], [MaSV], [Lop], [TimeUpdate], [TimeCreate], [HoTen]) VALUES (2, N'2180607461', N'21DTHE2', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'Lữ Thành Ý')
GO
SET IDENTITY_INSERT [dbo].[TacGia] ON 

INSERT [dbo].[TacGia] ([ID], [MaTacGia], [TenTacGia], [TimeUpdate], [TimeCreate], [DiaChi]) VALUES (4, N'1         ', N'Hoàng Hà', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'Hutech')
INSERT [dbo].[TacGia] ([ID], [MaTacGia], [TenTacGia], [TimeUpdate], [TimeCreate], [DiaChi]) VALUES (5, N'2         ', N'Như Quỳnh', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'Hutech')
INSERT [dbo].[TacGia] ([ID], [MaTacGia], [TenTacGia], [TimeUpdate], [TimeCreate], [DiaChi]) VALUES (6, N'3         ', N'Nguyên Thư', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'Hutech')
SET IDENTITY_INSERT [dbo].[TacGia] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([ID], [Name], [Email], [Username], [TimeUpdate], [TimeCreate], [Password]) VALUES (7, N'HoangHa', N'hoangha', N'hoangha', NULL, NULL, N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[User] ([ID], [Name], [Email], [Username], [TimeUpdate], [TimeCreate], [Password]) VALUES (8, N'Như Quỳnh', N'nhuquynh@gmail.com', N'nhuquynh', NULL, NULL, N'202cb962ac59075b964b07152d234b70')
INSERT [dbo].[User] ([ID], [Name], [Email], [Username], [TimeUpdate], [TimeCreate], [Password]) VALUES (9, N'Thư', N'Thu@gmail.com', N'nguyenthu', NULL, NULL, N'202cb962ac59075b964b07152d234b70')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET IDENTITY_INSERT [dbo].[ViTri] ON 

INSERT [dbo].[ViTri] ([ID], [MaViTri], [Ngan], [Ke], [TimeUpdate], [TimeCreate], [Khu]) VALUES (3, N'1         ', N'1', N'1A', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'E')
INSERT [dbo].[ViTri] ([ID], [MaViTri], [Ngan], [Ke], [TimeUpdate], [TimeCreate], [Khu]) VALUES (4, N'1         ', N'1', N'1B', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'E')
INSERT [dbo].[ViTri] ([ID], [MaViTri], [Ngan], [Ke], [TimeUpdate], [TimeCreate], [Khu]) VALUES (5, N'1         ', N'1', N'1C', CAST(N'2024-04-07T00:00:00.000' AS DateTime), CAST(N'2024-04-07T00:00:00.000' AS DateTime), N'E')
SET IDENTITY_INSERT [dbo].[ViTri] OFF
GO
ALTER TABLE [dbo].[LoaiSach] ADD  CONSTRAINT [DF_LoaiSach_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[NXB] ADD  CONSTRAINT [DF_NXB_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[PhieuMuon] ADD  CONSTRAINT [DF_PhieuMuon_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_SoLuong]  DEFAULT ((0)) FOR [SoLuong]
GO
ALTER TABLE [dbo].[Sach] ADD  CONSTRAINT [DF_Sach_NgayTao]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[SinhVien] ADD  CONSTRAINT [DF_SinhVien_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[TacGia] ADD  CONSTRAINT [DF_TacGia_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[User] ADD  CONSTRAINT [DF_User_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[ViTri] ADD  CONSTRAINT [DF_ViTri_TimeUpdate]  DEFAULT (getdate()) FOR [TimeUpdate]
GO
ALTER TABLE [dbo].[PhieuMuon]  WITH CHECK ADD  CONSTRAINT [FK_PhieuMuon_SinhVien] FOREIGN KEY([NguoiMuon])
REFERENCES [dbo].[SinhVien] ([ID])
GO
ALTER TABLE [dbo].[PhieuMuon] CHECK CONSTRAINT [FK_PhieuMuon_SinhVien]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_LoaiSach] FOREIGN KEY([LoaiSach])
REFERENCES [dbo].[LoaiSach] ([ID])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_LoaiSach]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_NXB] FOREIGN KEY([NXB])
REFERENCES [dbo].[NXB] ([ID])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_NXB]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_PhieuMuon] FOREIGN KEY([Muon])
REFERENCES [dbo].[PhieuMuon] ([ID])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_PhieuMuon]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_TacGia] FOREIGN KEY([TacGia])
REFERENCES [dbo].[TacGia] ([ID])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_TacGia]
GO
ALTER TABLE [dbo].[Sach]  WITH CHECK ADD  CONSTRAINT [FK_Sach_ViTri] FOREIGN KEY([ViTri])
REFERENCES [dbo].[ViTri] ([ID])
GO
ALTER TABLE [dbo].[Sach] CHECK CONSTRAINT [FK_Sach_ViTri]
GO
