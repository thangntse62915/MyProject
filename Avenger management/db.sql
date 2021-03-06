USE [master]
GO
/****** Object:  Database [Avenger]    Script Date: 12/17/2018 9:16:35 PM ******/
CREATE DATABASE [Avenger]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Avenger', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Avenger.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Avenger_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Avenger_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Avenger] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Avenger].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Avenger] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Avenger] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Avenger] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Avenger] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Avenger] SET ARITHABORT OFF 
GO
ALTER DATABASE [Avenger] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Avenger] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Avenger] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Avenger] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Avenger] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Avenger] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Avenger] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Avenger] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Avenger] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Avenger] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Avenger] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Avenger] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Avenger] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Avenger] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Avenger] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Avenger] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Avenger] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Avenger] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Avenger] SET  MULTI_USER 
GO
ALTER DATABASE [Avenger] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Avenger] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Avenger] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Avenger] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [Avenger] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Avenger] SET QUERY_STORE = OFF
GO
USE [Avenger]
GO
ALTER DATABASE SCOPED CONFIGURATION SET IDENTITY_CACHE = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Avenger]
GO
/****** Object:  Table [dbo].[Member]    Script Date: 12/17/2018 9:16:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Member](
	[id] [varchar](10) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NULL,
	[fullname] [varchar](50) NULL,
	[image] [varchar](250) NULL,
	[birthday] [varchar](50) NULL,
	[gender] [varchar](50) NULL,
	[address] [varchar](50) NULL,
	[description] [varchar](250) NULL,
	[enrolldate] [datetime] NULL,
	[unenrolldate] [datetime] NULL,
	[status] [varchar](10) NULL,
	[idAction] [varchar](10) NULL,
 CONSTRAINT [PK_Member] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mission]    Script Date: 12/17/2018 9:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mission](
	[id] [varchar](10) NOT NULL,
	[name] [varchar](10) NOT NULL,
	[location] [varchar](50) NOT NULL,
	[startDate] [date] NOT NULL,
	[endDate] [date] NOT NULL,
	[level] [varchar](50) NOT NULL,
	[description] [varchar](500) NOT NULL,
	[idAdmin] [varchar](10) NOT NULL,
	[status] [varchar](15) NOT NULL,
	[finishDate] [date] NULL,
	[finishFile] [varchar](50) NULL,
 CONSTRAINT [PK_Mission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MissionDetail]    Script Date: 12/17/2018 9:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MissionDetail](
	[id] [varchar](50) NOT NULL,
	[idMis] [varchar](10) NOT NULL,
	[idMem] [varchar](50) NOT NULL,
	[idWeapon] [varchar](10) NULL,
	[isLeader] [bit] NOT NULL,
 CONSTRAINT [PK_MissionDetail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 12/17/2018 9:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[id] [varchar](10) NOT NULL,
	[username] [varchar](50) NULL,
	[password] [varchar](50) NOT NULL,
	[fullname] [varchar](10) NOT NULL,
	[role] [varchar](10) NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC,
	[role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Weapon]    Script Date: 12/17/2018 9:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Weapon](
	[id] [varchar](10) NOT NULL,
	[name] [varchar](50) NULL,
	[power] [varchar](250) NULL,
	[designer] [varchar](50) NULL,
	[color] [varchar](50) NULL,
	[image] [varchar](250) NULL,
	[idMem] [varchar](50) NULL,
	[status] [varchar](10) NULL,
 CONSTRAINT [PK_Weapon] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[WeaponForAll]    Script Date: 12/17/2018 9:16:36 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeaponForAll](
	[id] [varchar](10) NOT NULL,
	[idWeapon] [varchar](10) NULL,
	[idMission] [varchar](10) NULL,
 CONSTRAINT [PK_WeaponForAll] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'1', N'1', N'1', N'n', N'1', N'', NULL, NULL, NULL, NULL, NULL, N'Ready', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'2', N'2', N'2', N'nn', N'2', NULL, NULL, NULL, NULL, NULL, NULL, N'Ready', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'3', N'3', N'3', N'nnn', N'3', NULL, NULL, NULL, NULL, NULL, NULL, N'Ready', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'4', N'4', N'4', N'nnnn', N'4', NULL, NULL, NULL, NULL, NULL, NULL, N'Ready', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'AV0001', N'AV0001', N'AV0001', N'Hulk', N'image\AV0001sipderman.jpg', N'1992-4-8', N'Male', N'qwe', N'none', CAST(N'2018-07-20T00:00:00.000' AS DateTime), CAST(N'2018-07-20T00:00:00.000' AS DateTime), N'Action', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'AV0002', N'AV0002', N'AV0002', N'Ant-Men', NULL, N'1992-4-4', N'Male', N'none', N'none', CAST(N'2018-07-20T00:00:00.000' AS DateTime), CAST(N'2018-08-19T00:00:00.000' AS DateTime), N'Ready', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'AV9999', N'testavenger', N'testavenger', N'testavenger', N'image\AV9999kisspng-iron-man-captain-america-logo-marvel-cinematic-uni-avengers-5abf62fa5d9e88.5694336615224921543835.png', N'1998-8-8', N'Male', N'q', N'q', CAST(N'2018-07-23T00:00:00.000' AS DateTime), NULL, N'Ready', N'admin')
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'ME0001', N'admin', N'admin', N'JARVIS', NULL, NULL, NULL, N'USA', NULL, NULL, NULL, N'', NULL)
INSERT [dbo].[Member] ([id], [username], [password], [fullname], [image], [birthday], [gender], [address], [description], [enrolldate], [unenrolldate], [status], [idAction]) VALUES (N'ME0002', N'ironman', N'ironman', N'IRONMAN', N'image\ironman39141028_2110274899236847_6456410322151407616_n.jpg', N'1992-4-8', N'Male', N'USA', N'ko', NULL, NULL, N'Ready', NULL)
INSERT [dbo].[Mission] ([id], [name], [location], [startDate], [endDate], [level], [description], [idAdmin], [status], [finishDate], [finishFile]) VALUES (N'MS0003', N'MS0003', N'MS0003', CAST(N'2018-07-03' AS Date), CAST(N'2018-07-12' AS Date), N'SSS', N'\image\mission\MS0003.rar', N'admin', N'Finish', CAST(N'2018-07-20' AS Date), N'finish\MS0003web.rar')
INSERT [dbo].[Mission] ([id], [name], [location], [startDate], [endDate], [level], [description], [idAdmin], [status], [finishDate], [finishFile]) VALUES (N'MS0043', N'MS0043', N'MS0043', CAST(N'2018-08-08' AS Date), CAST(N'2018-08-25' AS Date), N'SSS', N'\image\mission\MS0043.rar', N'ironman', N'Finish', CAST(N'2018-08-19' AS Date), N'finish\MS0043practical test.rar')
INSERT [dbo].[Mission] ([id], [name], [location], [startDate], [endDate], [level], [description], [idAdmin], [status], [finishDate], [finishFile]) VALUES (N'MS0099', N'MS0099', N'b', CAST(N'2018-08-14' AS Date), CAST(N'2018-08-25' AS Date), N'SS', N'\image\mission\MS0099.rar', N'admin', N'Create', NULL, NULL)
INSERT [dbo].[Mission] ([id], [name], [location], [startDate], [endDate], [level], [description], [idAdmin], [status], [finishDate], [finishFile]) VALUES (N'MS1344', N'4', N'4', CAST(N'2018-07-04' AS Date), CAST(N'2018-07-20' AS Date), N'SS', N'\image\mission\MS1344.rar', N'admin', N'Miss', NULL, NULL)
INSERT [dbo].[MissionDetail] ([id], [idMis], [idMem], [idWeapon], [isLeader]) VALUES (N'MS0003AV0001', N'MS0003', N'AV0001', N'WE0005', 0)
INSERT [dbo].[MissionDetail] ([id], [idMis], [idMem], [idWeapon], [isLeader]) VALUES (N'MS0003ironman', N'MS0003', N'ironman', N'WE0001', 1)
INSERT [dbo].[MissionDetail] ([id], [idMis], [idMem], [idWeapon], [isLeader]) VALUES (N'MS0043ironman', N'MS0043', N'ironman', N'WE7656', 1)
INSERT [dbo].[MissionDetail] ([id], [idMis], [idMem], [idWeapon], [isLeader]) VALUES (N'MS1344AV0001', N'MS1344', N'AV0001', N'WE0008', 1)
INSERT [dbo].[Registration] ([id], [username], [password], [fullname], [role]) VALUES (N'AV0001', N'AV0001', N'AV0001', N'Hulk', N'Member')
INSERT [dbo].[Registration] ([id], [username], [password], [fullname], [role]) VALUES (N'AV0002', N'AV0002', N'AV0002', N'Ant-Men', N'Member')
INSERT [dbo].[Registration] ([id], [username], [password], [fullname], [role]) VALUES (N'ME0001', N'admin', N'admin', N'JARVIS', N'Admin')
INSERT [dbo].[Registration] ([id], [username], [password], [fullname], [role]) VALUES (N'ME0002', N'ironman', N'ironman', N'IRONMAN', N'Admin')
INSERT [dbo].[Registration] ([id], [username], [password], [fullname], [role]) VALUES (N'ME0002', N'ironman', N'ironman', N'IRONMAN', N'Member')
INSERT [dbo].[Weapon] ([id], [name], [power], [designer], [color], [image], [idMem], [status]) VALUES (N'WE0001', N'an', N'ap', N'ad', N'ac', N'\image\weapon\WE0001Untitled.png', N'ironman', N'Ready')
INSERT [dbo].[Weapon] ([id], [name], [power], [designer], [color], [image], [idMem], [status]) VALUES (N'WE0002', N'bn', N'bp', N'bd', N'bc', N'\image\weapon\WE000233826527_1809453399098037_934130896976478208_n.png', N'ironman', N'Ready')
INSERT [dbo].[Weapon] ([id], [name], [power], [designer], [color], [image], [idMem], [status]) VALUES (N'WE0005', N'weapon1', N'none', N'black', N'black', N'image\weapon\WE0005logo.png', N'AV0001', N'Ready')
INSERT [dbo].[Weapon] ([id], [name], [power], [designer], [color], [image], [idMem], [status]) VALUES (N'WE0008', N'weapon2', N'2', N'2', N'2', N'image\weapon\WE0008download (1).jpg', N'AV0001', N'Using')
INSERT [dbo].[Weapon] ([id], [name], [power], [designer], [color], [image], [idMem], [status]) VALUES (N'WE1234', N'weapon1', N'1', N'1', N'1', N'image\weapon\WE1234download (1).jpg', N'AV0001', N'Ready')
INSERT [dbo].[Weapon] ([id], [name], [power], [designer], [color], [image], [idMem], [status]) VALUES (N'WE7656', N'WE7656', N'WE7656', N'WE7656', N'WE7656', N'image\weapon\WE7656soijpg.jpg', N'ironman', N'Ready')
SET ANSI_PADDING ON
GO
/****** Object:  Index [Uni]    Script Date: 12/17/2018 9:16:37 PM ******/
ALTER TABLE [dbo].[Member] ADD  CONSTRAINT [Uni] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MissionDetail]  WITH CHECK ADD  CONSTRAINT [FK_MissionDetail_Member] FOREIGN KEY([idMem])
REFERENCES [dbo].[Member] ([username])
GO
ALTER TABLE [dbo].[MissionDetail] CHECK CONSTRAINT [FK_MissionDetail_Member]
GO
ALTER TABLE [dbo].[MissionDetail]  WITH CHECK ADD  CONSTRAINT [FK_MissionDetail_Mission] FOREIGN KEY([idMis])
REFERENCES [dbo].[Mission] ([id])
GO
ALTER TABLE [dbo].[MissionDetail] CHECK CONSTRAINT [FK_MissionDetail_Mission]
GO
ALTER TABLE [dbo].[MissionDetail]  WITH CHECK ADD  CONSTRAINT [FK_MissionDetail_Weapon] FOREIGN KEY([idWeapon])
REFERENCES [dbo].[Weapon] ([id])
GO
ALTER TABLE [dbo].[MissionDetail] CHECK CONSTRAINT [FK_MissionDetail_Weapon]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Member] FOREIGN KEY([id])
REFERENCES [dbo].[Member] ([id])
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Member]
GO
ALTER TABLE [dbo].[Weapon]  WITH CHECK ADD  CONSTRAINT [FK_Weapon_Member] FOREIGN KEY([idMem])
REFERENCES [dbo].[Member] ([username])
GO
ALTER TABLE [dbo].[Weapon] CHECK CONSTRAINT [FK_Weapon_Member]
GO
ALTER TABLE [dbo].[WeaponForAll]  WITH CHECK ADD  CONSTRAINT [FK_WeaponForAll_Mission] FOREIGN KEY([idMission])
REFERENCES [dbo].[Mission] ([id])
GO
ALTER TABLE [dbo].[WeaponForAll] CHECK CONSTRAINT [FK_WeaponForAll_Mission]
GO
ALTER TABLE [dbo].[WeaponForAll]  WITH CHECK ADD  CONSTRAINT [FK_WeaponForAll_Weapon] FOREIGN KEY([idWeapon])
REFERENCES [dbo].[Weapon] ([id])
GO
ALTER TABLE [dbo].[WeaponForAll] CHECK CONSTRAINT [FK_WeaponForAll_Weapon]
GO
USE [master]
GO
ALTER DATABASE [Avenger] SET  READ_WRITE 
GO
