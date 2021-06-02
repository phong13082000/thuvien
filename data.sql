USE [master]
GO
/****** Object:  Database [QLTV1]    Script Date: 5/22/2021 4:51:06 PM ******/
CREATE DATABASE [QLTV1]
 CONTAINMENT = NONE

GO
ALTER DATABASE [QLTV1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLTV1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QLTV1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QLTV1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QLTV1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QLTV1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QLTV1] SET ARITHABORT OFF 
GO
ALTER DATABASE [QLTV1] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QLTV1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QLTV1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QLTV1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QLTV1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QLTV1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QLTV1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QLTV1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QLTV1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QLTV1] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QLTV1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QLTV1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QLTV1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QLTV1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QLTV1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QLTV1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QLTV1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QLTV1] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QLTV1] SET  MULTI_USER 
GO
ALTER DATABASE [QLTV1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QLTV1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QLTV1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QLTV1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QLTV1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QLTV1]
GO
/****** Object:  Table [dbo].[TableAccount]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableAccount](
	[displayname] [nvarchar](100) NOT NULL DEFAULT (N'NhatQuang'),
	[username] [nvarchar](100) NOT NULL,
	[password] [nvarchar](100) NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableBook]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableBook](
	[idbook] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idcategory] [int] NOT NULL,
	[language] [nvarchar](100) NOT NULL,
	[author] [nvarchar](100) NOT NULL,
	[translator] [nvarchar](100) NULL,
	[company] [nvarchar](100) NOT NULL,
	[count] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[idbook] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableBookCategory]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableBookCategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableBorrow]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableBorrow](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idBook] [int] NOT NULL,
	[idReader] [int] NOT NULL,
	[dateBorrow] [date] NOT NULL,
	[dateReturn] [date] NOT NULL,
	[countBorrow] [int] NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TableReader]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TableReader](
	[idreader] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
	[idcard] [int] NOT NULL,
	[address] [nvarchar](100) NULL,
	[email] [nvarchar](100) NULL,
	[phone] [int] NOT NULL,
	[cardissuedate] [date] NOT NULL,
	[expirationdate] [date] NOT NULL,
	[typecard] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idreader] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[TableAccount] ([displayname], [username], [password]) VALUES (N'NhatQuang', N'nhatquang', N'20182737')
INSERT [dbo].[TableAccount] ([displayname], [username], [password]) VALUES (N'PhuongMai', N'phgmaii', N'03062004')
INSERT [dbo].[TableAccount] ([displayname], [username], [password]) VALUES (N'TienPhong', N'tphong', N'20182720')
SET IDENTITY_INSERT [dbo].[TableBook] ON 

INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (1, N'Những người khốn khổ', 1, N'Tiếng Việt', N'Victor Hugo', N'Nhóm dịch', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (2, N'Tiếng chim hót trong bụi mận gai', 1, N'Tiếng Việt', N'Colleen McCulough', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (3, N'Bắt trẻ đồng xanh', 2, N'Tiếng Việt', N'J.D.Salinger', N'Phùng Khánh', N'Nhã nam', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (4, N'Cuốn theo chiều gió', 1, N'Tiếng Việt', N'Margaret Mitchell', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (5, N'Ông già và biển cả', 1, N'Tiếng Việt', N'Emest Hemingway', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (6, N'Đồi gió hú', 1, N'Tiếng Việt', N'Emily Bronte', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (7, N'Ba gã cùng thuyền', 1, N'Tiếng Việt', N'Jerome K.Jerome', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (8, N'Trăm năm cô đơn', 1, N'Tiếng Việt', N'Gabriel Garcia Marquez', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (9, N'Tắt đèn', 2, N'Tiếng Việt', N'Ngô Tất Tố', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (10, N'Đôi lứa xứng đôi', 2, N'Tiếng Việt', N'Nam Cao', N'', N'Nhã nam', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (11, N'Số đỏ', 2, N'Tiếng Việt', N'Vũ Trọng Phụng', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (12, N'Bước đường cùng', 2, N'Tiếng Việt', N'Nguyễn Công Hoan', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (13, N'Tuổi thơ dữ dội', 1, N'Tiếng Việt', N'Phùng Quán', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (14, N'Những ngày thơ ấu', 1, N'Tiếng Việt', N'Nguyên Hồng', N'', N'Văn hóa thông tin', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (15, N'Don Quixote', 1, N'Tiếng Việt', N'Miguel de Cervantes Saavedra', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (16, N'Nhà giả kim', 1, N'Tiếng Việt', N'Paulo Coelho', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (17, N'Giết con chim nhại', 1, N'Tiếng Việt', N'Harper Lee', N'', N'Văn học', 20)
INSERT [dbo].[TableBook] ([idbook], [name], [idcategory], [language], [author], [translator], [company], [count]) VALUES (18, N'Thằng gù ở nhà thờ đức bà', 1, N'Tiếng Việt', N'Victor Huygo', N'', N'Văn học', 20)
SET IDENTITY_INSERT [dbo].[TableBook] OFF
SET IDENTITY_INSERT [dbo].[TableBookCategory] ON 

INSERT [dbo].[TableBookCategory] ([id], [name]) VALUES (1, N'Tiểu thuyết ')
INSERT [dbo].[TableBookCategory] ([id], [name]) VALUES (2, N'Truyện ngắn')
INSERT [dbo].[TableBookCategory] ([id], [name]) VALUES (3, N'Thơ')
SET IDENTITY_INSERT [dbo].[TableBookCategory] OFF
SET IDENTITY_INSERT [dbo].[TableBorrow] ON 

INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (1, 1, 1, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (2, 1, 2, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (3, 2, 1, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (4, 4, 3, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (5, 7, 6, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (6, 11, 4, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (7, 6, 9, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (8, 8, 7, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (9, 11, 11, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (10, 1, 8, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (11, 13, 10, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (12, 18, 6, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
INSERT [dbo].[TableBorrow] ([id], [idBook], [idReader], [dateBorrow], [dateReturn], [countBorrow]) VALUES (13, 15, 9, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), 1)
SET IDENTITY_INSERT [dbo].[TableBorrow] OFF
SET IDENTITY_INSERT [dbo].[TableReader] ON 

INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (1, N'Quang', 20182737, N'Trần Quý Cáp', N'kw16082000@gmail.com', 111111111, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (2, N'Mai', 20182737, N'Đông Thiên', N'', 222222222, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (3, N'Phong', 20182737, N'An Dương Vương', N'august13082000@gmail.com', 333333333, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (4, N'Tiến', 20182737, N'Linh Đàm', N'', 444444444, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (5, N'Vũ', 20182737, N'Hoàng Mai', N'', 555555555, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (6, N'Đức', 20182737, N'Bạch Mai', N'', 666666666, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (7, N'Tiến Anh', 20182737, N'Giáp Tứ', N'', 777777777, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (8, N'Duy Anh', 20182737, N'', N'', 888888888, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (9, N'Quân', 20182737, N'Kim Ngưu', N'', 999999999, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (10, N'Lộc', 20182737, N'Hoàng Mai', N'', 101010101, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (11, N'Tuấn', 20182737, N'', N'', 110110110, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (12, N'Huy', 20182737, N'', N'', 120120120, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
INSERT [dbo].[TableReader] ([idreader], [name], [idcard], [address], [email], [phone], [cardissuedate], [expirationdate], [typecard]) VALUES (13, N'Hiếu', 20182737, N'', N'', 130130130, CAST(N'2021-05-11' AS Date), CAST(N'2021-05-11' AS Date), N'vip')
SET IDENTITY_INSERT [dbo].[TableReader] OFF
ALTER TABLE [dbo].[TableBook]  WITH CHECK ADD FOREIGN KEY([idcategory])
REFERENCES [dbo].[TableBookCategory] ([id])
GO
ALTER TABLE [dbo].[TableBorrow]  WITH CHECK ADD FOREIGN KEY([idBook])
REFERENCES [dbo].[TableBook] ([idbook])
GO
ALTER TABLE [dbo].[TableBorrow]  WITH CHECK ADD FOREIGN KEY([idReader])
REFERENCES [dbo].[TableReader] ([idreader])
GO
/****** Object:  StoredProcedure [dbo].[USP_GetAccountByUserName]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_GetAccountByUserName]
@username nvarchar(100)
as
begin
select * from dbo.TableAccount where UserName = @username
end

GO
/****** Object:  StoredProcedure [dbo].[USP_Login]    Script Date: 5/22/2021 4:51:06 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[USP_Login]
@username nvarchar(100), @password nvarchar(100)
as
begin
select * from dbo.TableAccount where UserName = @username and PassWord = @password
end

GO
USE [master]
GO
ALTER DATABASE [QLTV1] SET  READ_WRITE 
GO
