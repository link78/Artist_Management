USE [master]
GO
/****** Object:  Database [EFData]    Script Date: 8/10/2020 8:24:54 PM ******/
CREATE DATABASE [EFData]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EFData', FILENAME = N'C:\Users\koand\EFData.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EFData_log', FILENAME = N'C:\Users\koand\EFData_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EFData] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EFData].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EFData] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EFData] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EFData] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EFData] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EFData] SET ARITHABORT OFF 
GO
ALTER DATABASE [EFData] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [EFData] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EFData] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EFData] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EFData] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EFData] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EFData] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EFData] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EFData] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EFData] SET  ENABLE_BROKER 
GO
ALTER DATABASE [EFData] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EFData] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EFData] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EFData] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EFData] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EFData] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [EFData] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EFData] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [EFData] SET  MULTI_USER 
GO
ALTER DATABASE [EFData] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EFData] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EFData] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EFData] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EFData] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [EFData] SET QUERY_STORE = OFF
GO
USE [EFData]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [EFData]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 8/10/2020 8:24:54 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Artists]    Script Date: 8/10/2020 8:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Artists](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[Country] [nvarchar](50) NOT NULL,
	[CreatedDate] [datetime2](7) NOT NULL,
	[Provence] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[WebSite] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArtistSkill]    Script Date: 8/10/2020 8:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArtistSkill](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtistId] [int] NOT NULL,
	[Details] [nvarchar](255) NULL,
	[SkillLevel] [int] NOT NULL,
	[Styles] [nvarchar](255) NULL,
	[TalentName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ArtistSkill] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 8/10/2020 8:24:55 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ArtistId] [int] NOT NULL,
	[Body] [nvarchar](max) NULL,
	[Rating] [int] NOT NULL,
	[ReviewName] [nvarchar](max) NULL,
 CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_ArtistSkill_ArtistId]    Script Date: 8/10/2020 8:24:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_ArtistSkill_ArtistId] ON [dbo].[ArtistSkill]
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Review_ArtistId]    Script Date: 8/10/2020 8:24:55 PM ******/
CREATE NONCLUSTERED INDEX [IX_Review_ArtistId] ON [dbo].[Review]
(
	[ArtistId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ArtistSkill]  WITH CHECK ADD  CONSTRAINT [FK_ArtistSkill_Artists_ArtistId] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artists] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ArtistSkill] CHECK CONSTRAINT [FK_ArtistSkill_Artists_ArtistId]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_Review_Artists_ArtistId] FOREIGN KEY([ArtistId])
REFERENCES [dbo].[Artists] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_Review_Artists_ArtistId]
GO
USE [master]
GO
ALTER DATABASE [EFData] SET  READ_WRITE 
GO
