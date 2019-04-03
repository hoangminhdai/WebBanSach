USE [master]
GO
SET IDENTITY_INSERT [dbo].[Chude] ON 

INSERT [dbo].[Chude] ([Macd], [Tenchude]) VALUES (1, N'Tất cả')
INSERT [dbo].[Chude] ([Macd], [Tenchude]) VALUES (2, N'Sách giáo khoa')
INSERT [dbo].[Chude] ([Macd], [Tenchude]) VALUES (3, N'Sách thiếu nhi')
INSERT [dbo].[Chude] ([Macd], [Tenchude]) VALUES (4, N'Sách khoa học')
INSERT [dbo].[Chude] ([Macd], [Tenchude]) VALUES (5, N'Sách khác')
SET IDENTITY_INSERT [dbo].[Chude] OFF
SET IDENTITY_INSERT [dbo].[Nhaxuatban] ON 

INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (1, N'Khang Việt')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (2, N'Minh Long')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (3, N'Nhân Văn')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (4, N'Mc Book')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (5, N'NXB Giáo Dục')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (6, N'NXB Kim Đồng')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (7, N'Thành Nghĩa')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (8, N'Minh Thắng')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (9, N'Kinh Tế')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (10, N'Sách Hoa Hồng')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (11, N'NXB Trẻ')
INSERT [dbo].[Nhaxuatban] ([Manxb], [Tennxb]) VALUES (12, N'ZenBook')
SET IDENTITY_INSERT [dbo].[Nhaxuatban] OFF
SET IDENTITY_INSERT [dbo].[Tacgia] ON 

INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (1, N'Trần Thị Thu Thủy')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (2, N'Nhiều tác giả')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (3, N'Trang Anh')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (4, N'Nguyễn Anh Vũ')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (5, N'Hà Vũ Anh')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (6, N'The Windy')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (7, N'Đại Lợi')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (8, N'Trần Văn Sáu')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (9, N'Nguyễn Tú Phương ')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (10, N'Mai Lan Hương')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (11, N'Bộ Giáo Dục Và Đào Tạo')
INSERT [dbo].[Tacgia] ([Matacgia], [Tentacgia]) VALUES (12, N'Nhóm Sư Phạm')
SET IDENTITY_INSERT [dbo].[Tacgia] OFF
SET IDENTITY_INSERT [dbo].[Sach] ON 

INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1008, N'Toán tiểu học lớp 5', 20000, N'đ', N'Toán lớp 5', N'gk.jpg', 2, 3, CAST(N'2019-04-01 00:00:00' AS SmallDateTime), 3, 12)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1009, N'Hóa học', 21000, N'đ', N'Hóa học', N'gk3.jpg', 2, 3, CAST(N'2019-04-01 00:00:00' AS SmallDateTime), 3, 12)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1010, N'Vật lý', 22000, N'đ', N'Vật lý', N'gk4.jpg', 2, 3, CAST(N'2019-04-01 00:00:00' AS SmallDateTime), 3, 12)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1011, N'Fire and Fury', 50000, N'đ', N'Sách khoa học', N'kkk.jpg', 4, 3, CAST(N'2019-04-01 00:00:00' AS SmallDateTime), 3, 12)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1012, N'Ngữ văn', 50000, N'đ', N'Sách giáo khoa', N'gk5.jpg', 2, 4, CAST(N'2019-04-01 00:00:00' AS SmallDateTime), 1, 20)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1013, N'Thuật tư tưởng', 275000, N'đ', N'Sách khoa học', N'k.jpg', 3, 5, CAST(N'2019-06-01 00:00:00' AS SmallDateTime), 2, 40)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1014, N'Giao lưu nền văn hóa Việt Nam Nhật Bản', 500000, N'đ', N'Khoa học', N'kk.jpg', 4, 5, CAST(N'2019-01-01 00:00:00' AS SmallDateTime), 3, 30)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1015, N'Cooki mẹ tạp dề', 36700, N'đ', N'hhhh', N't.jpg', 3, 1, CAST(N'2019-08-02 00:00:00' AS SmallDateTime), 1, 22)
INSERT [dbo].[Sach] ([Masach], [Tensach], [Dongia], [Donvitinh], [Mota], [Hinhminhhoa], [Macd], [Manxb], [Ngaycapnhat], [Matacgia], [Soluong]) VALUES (1016, N'Hành trình tri thức của ', 42000, N'đ', N'gjfghkgh', N'kkkkk.jpg', 5, 2, CAST(N'2019-02-03 00:00:00' AS SmallDateTime), 3, 10)
SET IDENTITY_INSERT [dbo].[Sach] OFF
