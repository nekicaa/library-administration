USE [master]
GO
/****** Object:  Database [ProSoft-Seminarski]    Script Date: 8/30/2021 12:07:51 PM ******/
CREATE DATABASE [ProSoft-Seminarski]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'ProSoft-Seminarski', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProSoft-Seminarski.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'ProSoft-Seminarski_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\ProSoft-Seminarski_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [ProSoft-Seminarski] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ProSoft-Seminarski].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ProSoft-Seminarski] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET ARITHABORT OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ProSoft-Seminarski] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ProSoft-Seminarski] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ProSoft-Seminarski] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ProSoft-Seminarski] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET RECOVERY FULL 
GO
ALTER DATABASE [ProSoft-Seminarski] SET  MULTI_USER 
GO
ALTER DATABASE [ProSoft-Seminarski] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ProSoft-Seminarski] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ProSoft-Seminarski] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ProSoft-Seminarski] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ProSoft-Seminarski] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ProSoft-Seminarski] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'ProSoft-Seminarski', N'ON'
GO
ALTER DATABASE [ProSoft-Seminarski] SET QUERY_STORE = OFF
GO
USE [ProSoft-Seminarski]
GO
/****** Object:  Table [dbo].[Administrator]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Administrator](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[KorisnickoIme] [varchar](50) NULL,
	[Sifra] [varchar](50) NULL,
 CONSTRAINT [PK_Administrator] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Autor]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Autor](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
 CONSTRAINT [PK_Autor] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clan]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clan](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Ime] [varchar](50) NULL,
	[Prezime] [varchar](50) NULL,
	[DatumRodjenja] [datetime] NULL,
	[Kontakt] [varchar](50) NULL,
 CONSTRAINT [PK_Clan] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Izdanje]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Izdanje](
	[KnjigaId] [int] NOT NULL,
	[AutorId] [int] NOT NULL,
	[RedniBroj] [int] IDENTITY(1,1) NOT NULL,
	[GodinaStampe] [varchar](50) NULL,
	[Izdavac] [varchar](50) NULL,
 CONSTRAINT [PK_Izdanje] PRIMARY KEY CLUSTERED 
(
	[KnjigaId] ASC,
	[AutorId] ASC,
	[RedniBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Iznajmljivanje]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Iznajmljivanje](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DatumIznajmljivanja] [datetime] NULL,
	[RokZaRazduzivanje] [datetime] NULL,
	[ClanId] [int] NULL,
 CONSTRAINT [PK_Iznajmljivanje] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Knjiga]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Knjiga](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Naziv] [varchar](50) NULL,
	[ISBN] [varchar](50) NULL,
	[Zanr] [varchar](50) NULL,
 CONSTRAINT [PK_Knjiga] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StavkaIznajmljivanja]    Script Date: 8/30/2021 12:07:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StavkaIznajmljivanja](
	[IznajmljivanjeId] [int] NOT NULL,
	[RedniBroj] [int] NOT NULL,
	[Kolicina] [int] NULL,
	[KnjigaId] [int] NULL,
 CONSTRAINT [PK_StavkaIznajmljivanj] PRIMARY KEY CLUSTERED 
(
	[IznajmljivanjeId] ASC,
	[RedniBroj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Administrator] ON 

INSERT [dbo].[Administrator] ([Id], [Ime], [Prezime], [KorisnickoIme], [Sifra]) VALUES (1, N'Nevena', N'Krstic', N'nena', N'nena')
INSERT [dbo].[Administrator] ([Id], [Ime], [Prezime], [KorisnickoIme], [Sifra]) VALUES (2, N'Aleksandar', N'Krstic', N'alek', N'alek')
SET IDENTITY_INSERT [dbo].[Administrator] OFF
GO
SET IDENTITY_INSERT [dbo].[Autor] ON 

INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (1, N'Donato', N'Karizi')
INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (2, N'Sidni', N'Seldon')
INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (3, N'Den', N'Braun')
INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (4, N'Fredrik', N'Bakman')
INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (5, N'Haled', N'Hoseini')
INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (7, N'Stiven', N'King')
INSERT [dbo].[Autor] ([Id], [Ime], [Prezime]) VALUES (8, N'Artur', N'Konan Dojl')
SET IDENTITY_INSERT [dbo].[Autor] OFF
GO
SET IDENTITY_INSERT [dbo].[Clan] ON 

INSERT [dbo].[Clan] ([Id], [Ime], [Prezime], [DatumRodjenja], [Kontakt]) VALUES (1, N'Petar', N'Petrovic', CAST(N'1998-08-06T00:00:00.000' AS DateTime), N'06312312312')
INSERT [dbo].[Clan] ([Id], [Ime], [Prezime], [DatumRodjenja], [Kontakt]) VALUES (2, N'Marko', N'Markovic', CAST(N'1995-03-15T00:00:00.000' AS DateTime), N'0648852257')
INSERT [dbo].[Clan] ([Id], [Ime], [Prezime], [DatumRodjenja], [Kontakt]) VALUES (6, N'Aleksandra', N'Markovic', CAST(N'1998-09-20T00:00:00.000' AS DateTime), N'0658723811')
SET IDENTITY_INSERT [dbo].[Clan] OFF
GO
SET IDENTITY_INSERT [dbo].[Izdanje] ON 

INSERT [dbo].[Izdanje] ([KnjigaId], [AutorId], [RedniBroj], [GodinaStampe], [Izdavac]) VALUES (1, 5, 1, N'2017', N'Vulkan')
INSERT [dbo].[Izdanje] ([KnjigaId], [AutorId], [RedniBroj], [GodinaStampe], [Izdavac]) VALUES (2, 1, 2, N'2015', N'Laguna')
INSERT [dbo].[Izdanje] ([KnjigaId], [AutorId], [RedniBroj], [GodinaStampe], [Izdavac]) VALUES (3, 3, 3, N'2012', N'Solaris')
INSERT [dbo].[Izdanje] ([KnjigaId], [AutorId], [RedniBroj], [GodinaStampe], [Izdavac]) VALUES (9, 2, 4, N'2016', N'vulkan')
SET IDENTITY_INSERT [dbo].[Izdanje] OFF
GO
SET IDENTITY_INSERT [dbo].[Iznajmljivanje] ON 

INSERT [dbo].[Iznajmljivanje] ([Id], [DatumIznajmljivanja], [RokZaRazduzivanje], [ClanId]) VALUES (1, CAST(N'2021-08-13T00:00:00.000' AS DateTime), CAST(N'2021-08-27T00:00:00.000' AS DateTime), 2)
SET IDENTITY_INSERT [dbo].[Iznajmljivanje] OFF
GO
SET IDENTITY_INSERT [dbo].[Knjiga] ON 

INSERT [dbo].[Knjiga] ([Id], [Naziv], [ISBN], [Zanr]) VALUES (1, N'Lovac na zmajeve', N'11111111', N'drama')
INSERT [dbo].[Knjiga] ([Id], [Naziv], [ISBN], [Zanr]) VALUES (2, N'Saptac', N'12312312', N'triler')
INSERT [dbo].[Knjiga] ([Id], [Naziv], [ISBN], [Zanr]) VALUES (3, N'DaVincijev Kod', N'12345678', N'misterija')
INSERT [dbo].[Knjiga] ([Id], [Naziv], [ISBN], [Zanr]) VALUES (9, N'Krvna veza', N'7647328398', N'drama')
SET IDENTITY_INSERT [dbo].[Knjiga] OFF
GO
ALTER TABLE [dbo].[Izdanje]  WITH CHECK ADD  CONSTRAINT [FK_Izdanje_Autor] FOREIGN KEY([AutorId])
REFERENCES [dbo].[Autor] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Izdanje] CHECK CONSTRAINT [FK_Izdanje_Autor]
GO
ALTER TABLE [dbo].[Izdanje]  WITH CHECK ADD  CONSTRAINT [FK_Izdanje_Knjiga] FOREIGN KEY([KnjigaId])
REFERENCES [dbo].[Knjiga] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Izdanje] CHECK CONSTRAINT [FK_Izdanje_Knjiga]
GO
ALTER TABLE [dbo].[Iznajmljivanje]  WITH CHECK ADD  CONSTRAINT [FK_Iznajmljivanje_Clan] FOREIGN KEY([ClanId])
REFERENCES [dbo].[Clan] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Iznajmljivanje] CHECK CONSTRAINT [FK_Iznajmljivanje_Clan]
GO
ALTER TABLE [dbo].[StavkaIznajmljivanja]  WITH CHECK ADD  CONSTRAINT [FK_StavkaIznajmljivanja_Iznajmljivanje] FOREIGN KEY([IznajmljivanjeId])
REFERENCES [dbo].[Iznajmljivanje] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[StavkaIznajmljivanja] CHECK CONSTRAINT [FK_StavkaIznajmljivanja_Iznajmljivanje]
GO
ALTER TABLE [dbo].[StavkaIznajmljivanja]  WITH CHECK ADD  CONSTRAINT [FK_StavkaIznajmljivanja_Knjiga] FOREIGN KEY([KnjigaId])
REFERENCES [dbo].[Knjiga] ([Id])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[StavkaIznajmljivanja] CHECK CONSTRAINT [FK_StavkaIznajmljivanja_Knjiga]
GO
USE [master]
GO
ALTER DATABASE [ProSoft-Seminarski] SET  READ_WRITE 
GO
