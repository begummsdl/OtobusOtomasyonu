USE [master]
GO
/****** Object:  Database [OtobusOtomasyon]    Script Date: 30.12.2021 21:16:35 ******/
CREATE DATABASE [OtobusOtomasyon]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'OtobusOtomasyon', FILENAME = N'C:\Users\b-mus\OtobusOtomasyon.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'OtobusOtomasyon_log', FILENAME = N'C:\Users\b-mus\OtobusOtomasyon_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [OtobusOtomasyon] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [OtobusOtomasyon].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [OtobusOtomasyon] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET ARITHABORT OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [OtobusOtomasyon] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [OtobusOtomasyon] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET  DISABLE_BROKER 
GO
ALTER DATABASE [OtobusOtomasyon] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [OtobusOtomasyon] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [OtobusOtomasyon] SET  MULTI_USER 
GO
ALTER DATABASE [OtobusOtomasyon] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [OtobusOtomasyon] SET DB_CHAINING OFF 
GO
ALTER DATABASE [OtobusOtomasyon] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [OtobusOtomasyon] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [OtobusOtomasyon] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [OtobusOtomasyon] SET QUERY_STORE = OFF
GO
USE [OtobusOtomasyon]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [OtobusOtomasyon]
GO
/****** Object:  UserDefinedFunction [dbo].[SeferBasinaToplamYolcu]    Script Date: 30.12.2021 21:16:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[SeferBasinaToplamYolcu] (
@SeferId int
)
returns int begin
Declare @Sonuc int
Select @Sonuc = Count(SeferId) From Biletler Where SeferId = @SeferId

return @Sonuc end
GO
/****** Object:  Table [dbo].[Ayarlar]    Script Date: 30.12.2021 21:16:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Ayarlar](
	[AyarID] [int] IDENTITY(1,1) NOT NULL,
	[Anahtar] [varchar](50) NOT NULL,
	[Deger] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Ayarlar] PRIMARY KEY CLUSTERED 
(
	[AyarID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Biletler]    Script Date: 30.12.2021 21:16:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Biletler](
	[IslemYapanPersonelID] [int] NOT NULL,
	[YolcuID] [int] NULL,
	[SeferID] [int] NOT NULL,
	[IslemZamani] [datetime] NULL,
	[SatismiRezervasyonMu] [bit] NOT NULL,
	[KoltukNo] [tinyint] NOT NULL,
	[YolcuCinsiyet] [bit] NOT NULL,
	[Yolcuad] [varchar](50) NOT NULL,
	[YolcuSoyad] [varchar](50) NOT NULL,
	[SatisTip] [bit] NOT NULL,
	[Ucret] [money] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calisanlar]    Script Date: 30.12.2021 21:16:35 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calisanlar](
	[PersonelID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[Email] [varchar](60) NOT NULL,
	[Telefon] [char](10) NOT NULL,
	[SubeID] [int] NOT NULL,
	[EvAdresi] [varchar](200) NOT NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[CalisanTipID] [int] NOT NULL,
	[Yoneticimi] [bit] NOT NULL,
	[Sifre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Calisanlar] PRIMARY KEY CLUSTERED 
(
	[PersonelID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CalisanTipleri]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalisanTipleri](
	[CalisanTipID] [int] IDENTITY(1,1) NOT NULL,
	[CalisanTipAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_CalisanTipleri] PRIMARY KEY CLUSTERED 
(
	[CalisanTipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hatalar]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hatalar](
	[HataID] [int] IDENTITY(1,1) NOT NULL,
	[Numara] [varchar](6) NOT NULL,
	[Mesaj] [varchar](1000) NOT NULL,
	[Zamani] [datetime] NOT NULL,
	[Procedure] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Hatalar] PRIMARY KEY CLUSTERED 
(
	[HataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Markalar]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Markalar](
	[MarkaID] [int] IDENTITY(1,1) NOT NULL,
	[MarkaAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Markalar] PRIMARY KEY CLUSTERED 
(
	[MarkaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MasrafTipleri]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasrafTipleri](
	[MasrafTipID] [int] IDENTITY(1,1) NOT NULL,
	[MasrafTipAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_MasrafTipleri] PRIMARY KEY CLUSTERED 
(
	[MasrafTipID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Musteriler]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Musteriler](
	[MusteriID] [int] IDENTITY(1,1) NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[Email] [varchar](60) NOT NULL,
	[Telefon] [char](10) NOT NULL,
	[Cinsiyet] [bit] NOT NULL,
	[DogumTarihi] [datetime] NOT NULL,
	[SehirID] [int] NOT NULL,
	[Adres] [varchar](200) NOT NULL,
	[KartNumarasi] [char](16) NOT NULL,
	[KartTeslimDurumu] [bit] NOT NULL,
	[MevcutPara] [money] NOT NULL,
 CONSTRAINT [PK_Musteriler] PRIMARY KEY CLUSTERED 
(
	[MusteriID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Otobusler]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Otobusler](
	[OtobusID] [int] IDENTITY(1,1) NOT NULL,
	[Plaka] [varchar](10) NOT NULL,
	[KoltukSayisi] [tinyint] NOT NULL,
	[MarkaID] [int] NOT NULL,
	[AktifMi] [bit] NOT NULL,
 CONSTRAINT [PK_Otobusler] PRIMARY KEY CLUSTERED 
(
	[OtobusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OtobusMasraflar]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OtobusMasraflar](
	[OtobusMasrafID] [int] IDENTITY(1,1) NOT NULL,
	[OtobusID] [int] NOT NULL,
	[MasrafTipID] [int] NOT NULL,
	[Tutar] [money] NOT NULL,
	[MasrafYapanPersonelID] [int] NOT NULL,
	[SeferID] [int] NOT NULL,
 CONSTRAINT [PK_OtobusMasraflar] PRIMARY KEY CLUSTERED 
(
	[OtobusMasrafID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonelGirisCikis]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonelGirisCikis](
	[PersonelIslemID] [int] IDENTITY(1,1) NOT NULL,
	[PersonelID] [int] NOT NULL,
	[IslemZamani] [datetime] NULL,
	[IslemTipi] [bit] NOT NULL,
 CONSTRAINT [PK_PersonelGirisCikis] PRIMARY KEY CLUSTERED 
(
	[PersonelIslemID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Seferler]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Seferler](
	[SeferID] [int] IDENTITY(1,1) NOT NULL,
	[KalkisSehirID] [int] NOT NULL,
	[VarisSehirID] [int] NOT NULL,
	[OtobusID] [int] NOT NULL,
	[SoforID] [int] NOT NULL,
	[MuavinID] [int] NOT NULL,
	[KalkisZamani] [datetime] NOT NULL,
	[VarisZamani] [datetime] NULL,
	[TahminiSure] [tinyint] NOT NULL,
	[BiletTutari] [money] NOT NULL,
 CONSTRAINT [PK_Seferler] PRIMARY KEY CLUSTERED 
(
	[SeferID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sehirler]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sehirler](
	[SehirID] [int] IDENTITY(1,1) NOT NULL,
	[SehirAdi] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Sehirler] PRIMARY KEY CLUSTERED 
(
	[SehirID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SilinmisCalisanlarKayitlari]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SilinmisCalisanlarKayitlari](
	[PersonelID] [int] NOT NULL,
	[Ad] [varchar](50) NOT NULL,
	[Soyad] [varchar](50) NOT NULL,
	[Email] [varchar](60) NOT NULL,
	[Telefon] [char](10) NOT NULL,
	[SubeID] [int] NOT NULL,
	[EvAdresi] [varchar](200) NOT NULL,
	[KullaniciAdi] [varchar](50) NOT NULL,
	[CalisanTipID] [int] NOT NULL,
	[Yoneticimi] [bit] NOT NULL,
	[Sifre] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Subeler]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Subeler](
	[SubeID] [int] IDENTITY(1,1) NOT NULL,
	[SehirID] [int] NOT NULL,
	[SubeAdi] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Subeler] PRIMARY KEY CLUSTERED 
(
	[SubeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Ayarlar] ON 

INSERT [dbo].[Ayarlar] ([AyarID], [Anahtar], [Deger]) VALUES (1, N'BiletGeriOdemeOrani', N'0.1')
SET IDENTITY_INSERT [dbo].[Ayarlar] OFF
GO
INSERT [dbo].[Biletler] ([IslemYapanPersonelID], [YolcuID], [SeferID], [IslemZamani], [SatismiRezervasyonMu], [KoltukNo], [YolcuCinsiyet], [Yolcuad], [YolcuSoyad], [SatisTip], [Ucret]) VALUES (1005, 9999999, 1, CAST(N'2021-12-29T16:49:17.407' AS DateTime), 0, 1, 1, N'melis', N'güven', 1, 90.0000)
GO
SET IDENTITY_INSERT [dbo].[Calisanlar] ON 

INSERT [dbo].[Calisanlar] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (2, N'Begüm', N'Musdal', N'begum@hotmail.com', N'5303565334', 1, N'düzce', N'begummsdl', 1, 1, N'123123')
INSERT [dbo].[Calisanlar] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1004, N'melike', N'oz', N'dvsdbvsbsf', N'5556663332', 3, N'ascaca', N'melikeoz', 4, 0, N'1254')
INSERT [dbo].[Calisanlar] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1005, N'Begüm', N'Unal', N'abcd', N'4444444444', 1, N'acfaefa', N'Admin', 1, 1, N'123456')
INSERT [dbo].[Calisanlar] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1010, N'sfcasfa', N'sgsgsdg', N'sdsfdgsfg', N'1234567891', 1, N'xgxgbdhsd', N'asd', 1, 0, N'123456')
INSERT [dbo].[Calisanlar] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1011, N'Ahmet', N'Ak', N'ahmet@hotmail.com', N'1234567891', 1, N'düzce', N'ahmetak', 3, 0, N'123456789')
SET IDENTITY_INSERT [dbo].[Calisanlar] OFF
GO
SET IDENTITY_INSERT [dbo].[CalisanTipleri] ON 

INSERT [dbo].[CalisanTipleri] ([CalisanTipID], [CalisanTipAdi]) VALUES (1, N'Yönetici')
INSERT [dbo].[CalisanTipleri] ([CalisanTipID], [CalisanTipAdi]) VALUES (2, N'Vezne')
INSERT [dbo].[CalisanTipleri] ([CalisanTipID], [CalisanTipAdi]) VALUES (3, N'Soför')
INSERT [dbo].[CalisanTipleri] ([CalisanTipID], [CalisanTipAdi]) VALUES (4, N'Muavin')
INSERT [dbo].[CalisanTipleri] ([CalisanTipID], [CalisanTipAdi]) VALUES (5, N'Cayci')
SET IDENTITY_INSERT [dbo].[CalisanTipleri] OFF
GO
SET IDENTITY_INSERT [dbo].[Markalar] ON 

INSERT [dbo].[Markalar] ([MarkaID], [MarkaAdi]) VALUES (1, N'Mercedes')
INSERT [dbo].[Markalar] ([MarkaID], [MarkaAdi]) VALUES (2, N'Ford')
INSERT [dbo].[Markalar] ([MarkaID], [MarkaAdi]) VALUES (3, N'BMW')
INSERT [dbo].[Markalar] ([MarkaID], [MarkaAdi]) VALUES (4, N'Togg')
INSERT [dbo].[Markalar] ([MarkaID], [MarkaAdi]) VALUES (5, N'MITSUBISHI')
INSERT [dbo].[Markalar] ([MarkaID], [MarkaAdi]) VALUES (6, N'VOLVO')
SET IDENTITY_INSERT [dbo].[Markalar] OFF
GO
SET IDENTITY_INSERT [dbo].[Musteriler] ON 

INSERT [dbo].[Musteriler] ([MusteriID], [Ad], [Soyad], [Email], [Telefon], [Cinsiyet], [DogumTarihi], [SehirID], [Adres], [KartNumarasi], [KartTeslimDurumu], [MevcutPara]) VALUES (1, N'melis', N'gülen', N'melis@hotmail.com', N'1234567891', 1, CAST(N'2021-12-07T16:25:08.000' AS DateTime), 5, N'sndbarejkçrej', N'0903110644      ', 1, 150.0000)
SET IDENTITY_INSERT [dbo].[Musteriler] OFF
GO
SET IDENTITY_INSERT [dbo].[Otobusler] ON 

INSERT [dbo].[Otobusler] ([OtobusID], [Plaka], [KoltukSayisi], [MarkaID], [AktifMi]) VALUES (1, N'14ABC57', 48, 1, 1)
INSERT [dbo].[Otobusler] ([OtobusID], [Plaka], [KoltukSayisi], [MarkaID], [AktifMi]) VALUES (2, N'123ASD123', 54, 4, 1)
INSERT [dbo].[Otobusler] ([OtobusID], [Plaka], [KoltukSayisi], [MarkaID], [AktifMi]) VALUES (3, N'14AB14', 41, 6, 1)
SET IDENTITY_INSERT [dbo].[Otobusler] OFF
GO
SET IDENTITY_INSERT [dbo].[Seferler] ON 

INSERT [dbo].[Seferler] ([SeferID], [KalkisSehirID], [VarisSehirID], [OtobusID], [SoforID], [MuavinID], [KalkisZamani], [VarisZamani], [TahminiSure], [BiletTutari]) VALUES (1, 3, 5, 1, 1011, 1004, CAST(N'2021-12-30T00:00:00.000' AS DateTime), CAST(N'2021-12-30T00:00:00.000' AS DateTime), 150, 90.0000)
INSERT [dbo].[Seferler] ([SeferID], [KalkisSehirID], [VarisSehirID], [OtobusID], [SoforID], [MuavinID], [KalkisZamani], [VarisZamani], [TahminiSure], [BiletTutari]) VALUES (2, 6, 7, 3, 1011, 1004, CAST(N'2021-12-30T00:00:00.000' AS DateTime), CAST(N'2021-12-30T00:00:00.000' AS DateTime), 50, 70.0000)
SET IDENTITY_INSERT [dbo].[Seferler] OFF
GO
SET IDENTITY_INSERT [dbo].[Sehirler] ON 

INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (1, N'Düzce                                             ')
INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (2, N'İstanbul                                          ')
INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (3, N'Ankara                                            ')
INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (4, N'Tekirdağ                                          ')
INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (5, N'Kocaeli                                           ')
INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (6, N'Sakarya                                           ')
INSERT [dbo].[Sehirler] ([SehirID], [SehirAdi]) VALUES (7, N'Bolu                                              ')
SET IDENTITY_INSERT [dbo].[Sehirler] OFF
GO
INSERT [dbo].[SilinmisCalisanlarKayitlari] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (3, N'melike', N'oz', N'melike@hotmail.com', N'5535814185', 3, N'dsdvdfvgsd', N'melikeoz', 3, 0, N'121212')
INSERT [dbo].[SilinmisCalisanlarKayitlari] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1004, N'melike', N'oz', N'dvsdbvsbsf', N'5556663332', 3, N'ascaca', N'melikeoz', 4, 0, N'1254')
INSERT [dbo].[SilinmisCalisanlarKayitlari] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1007, N'<scas<c', N'zxvzsvz', N'zvzz', N'4444444444', 3, N'<zc<cs<c', N'admin', 1, 1, N'asd')
INSERT [dbo].[SilinmisCalisanlarKayitlari] ([PersonelID], [Ad], [Soyad], [Email], [Telefon], [SubeID], [EvAdresi], [KullaniciAdi], [CalisanTipID], [Yoneticimi], [Sifre]) VALUES (1006, N'<scas<c', N'zxvzsvz', N'zvzz', N'4444444444', 3, N'<zc<cs<c', N'ascasca', 1, 1, N'asd')
GO
SET IDENTITY_INSERT [dbo].[Subeler] ON 

INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (1, 1, N'Düzce Güven')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (2, 2, N'Kadiköy')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (3, 2, N'Ümraniye')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (5, 2, N'Esenler')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (6, 3, N'Asti')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (7, 4, N'Çerkezköy')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (8, 5, N'Izmit')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (9, 6, N'Serdivan')
INSERT [dbo].[Subeler] ([SubeID], [SehirID], [SubeAdi]) VALUES (10, 7, N'Merkez')
SET IDENTITY_INSERT [dbo].[Subeler] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UK_KullaniciAdi]    Script Date: 30.12.2021 21:16:36 ******/
ALTER TABLE [dbo].[Calisanlar] ADD  CONSTRAINT [UK_KullaniciAdi] UNIQUE NONCLUSTERED 
(
	[KullaniciAdi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Hatalar] ADD  CONSTRAINT [DF_Hatalar_Zamani]  DEFAULT (getdate()) FOR [Zamani]
GO
ALTER TABLE [dbo].[PersonelGirisCikis] ADD  CONSTRAINT [DF_PersonelGirisCikis_IslemZamani]  DEFAULT (getdate()) FOR [IslemZamani]
GO
ALTER TABLE [dbo].[Biletler]  WITH CHECK ADD  CONSTRAINT [FK_Biletler_Calisanlar] FOREIGN KEY([IslemYapanPersonelID])
REFERENCES [dbo].[Calisanlar] ([PersonelID])
GO
ALTER TABLE [dbo].[Biletler] CHECK CONSTRAINT [FK_Biletler_Calisanlar]
GO
ALTER TABLE [dbo].[Biletler]  WITH CHECK ADD  CONSTRAINT [FK_Biletler_Calisanlar1] FOREIGN KEY([IslemYapanPersonelID])
REFERENCES [dbo].[Calisanlar] ([PersonelID])
GO
ALTER TABLE [dbo].[Biletler] CHECK CONSTRAINT [FK_Biletler_Calisanlar1]
GO
ALTER TABLE [dbo].[Biletler]  WITH NOCHECK ADD  CONSTRAINT [FK_Biletler_Musteriler] FOREIGN KEY([YolcuID])
REFERENCES [dbo].[Musteriler] ([MusteriID])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[Biletler] NOCHECK CONSTRAINT [FK_Biletler_Musteriler]
GO
ALTER TABLE [dbo].[Biletler]  WITH CHECK ADD  CONSTRAINT [FK_Biletler_Seferler] FOREIGN KEY([SeferID])
REFERENCES [dbo].[Seferler] ([SeferID])
GO
ALTER TABLE [dbo].[Biletler] CHECK CONSTRAINT [FK_Biletler_Seferler]
GO
ALTER TABLE [dbo].[Calisanlar]  WITH CHECK ADD  CONSTRAINT [FK_Calisanlar_CalisanTipleri] FOREIGN KEY([CalisanTipID])
REFERENCES [dbo].[CalisanTipleri] ([CalisanTipID])
GO
ALTER TABLE [dbo].[Calisanlar] CHECK CONSTRAINT [FK_Calisanlar_CalisanTipleri]
GO
ALTER TABLE [dbo].[Calisanlar]  WITH CHECK ADD  CONSTRAINT [FK_Calisanlar_Subeler] FOREIGN KEY([SubeID])
REFERENCES [dbo].[Subeler] ([SubeID])
GO
ALTER TABLE [dbo].[Calisanlar] CHECK CONSTRAINT [FK_Calisanlar_Subeler]
GO
ALTER TABLE [dbo].[Musteriler]  WITH CHECK ADD  CONSTRAINT [FK_Musteriler_Sehirler] FOREIGN KEY([SehirID])
REFERENCES [dbo].[Sehirler] ([SehirID])
GO
ALTER TABLE [dbo].[Musteriler] CHECK CONSTRAINT [FK_Musteriler_Sehirler]
GO
ALTER TABLE [dbo].[Otobusler]  WITH CHECK ADD  CONSTRAINT [FK_Otobusler_Markalar] FOREIGN KEY([MarkaID])
REFERENCES [dbo].[Markalar] ([MarkaID])
GO
ALTER TABLE [dbo].[Otobusler] CHECK CONSTRAINT [FK_Otobusler_Markalar]
GO
ALTER TABLE [dbo].[OtobusMasraflar]  WITH CHECK ADD  CONSTRAINT [FK_OtobusMasraflar_MasrafTipleri] FOREIGN KEY([MasrafTipID])
REFERENCES [dbo].[MasrafTipleri] ([MasrafTipID])
GO
ALTER TABLE [dbo].[OtobusMasraflar] CHECK CONSTRAINT [FK_OtobusMasraflar_MasrafTipleri]
GO
ALTER TABLE [dbo].[OtobusMasraflar]  WITH CHECK ADD  CONSTRAINT [FK_OtobusMasraflar_Otobusler] FOREIGN KEY([OtobusID])
REFERENCES [dbo].[Otobusler] ([OtobusID])
GO
ALTER TABLE [dbo].[OtobusMasraflar] CHECK CONSTRAINT [FK_OtobusMasraflar_Otobusler]
GO
ALTER TABLE [dbo].[OtobusMasraflar]  WITH CHECK ADD  CONSTRAINT [FK_OtobusMasraflar_Seferler] FOREIGN KEY([SeferID])
REFERENCES [dbo].[Seferler] ([SeferID])
GO
ALTER TABLE [dbo].[OtobusMasraflar] CHECK CONSTRAINT [FK_OtobusMasraflar_Seferler]
GO
ALTER TABLE [dbo].[PersonelGirisCikis]  WITH CHECK ADD  CONSTRAINT [FK_PersonelGirisCikis_Calisanlar] FOREIGN KEY([PersonelID])
REFERENCES [dbo].[Calisanlar] ([PersonelID])
GO
ALTER TABLE [dbo].[PersonelGirisCikis] CHECK CONSTRAINT [FK_PersonelGirisCikis_Calisanlar]
GO
ALTER TABLE [dbo].[Seferler]  WITH CHECK ADD  CONSTRAINT [FK_Seferler_Calisanlar] FOREIGN KEY([SoforID])
REFERENCES [dbo].[Calisanlar] ([PersonelID])
GO
ALTER TABLE [dbo].[Seferler] CHECK CONSTRAINT [FK_Seferler_Calisanlar]
GO
ALTER TABLE [dbo].[Seferler]  WITH CHECK ADD  CONSTRAINT [FK_Seferler_Calisanlar1] FOREIGN KEY([MuavinID])
REFERENCES [dbo].[Calisanlar] ([PersonelID])
GO
ALTER TABLE [dbo].[Seferler] CHECK CONSTRAINT [FK_Seferler_Calisanlar1]
GO
ALTER TABLE [dbo].[Seferler]  WITH CHECK ADD  CONSTRAINT [FK_Seferler_Otobusler] FOREIGN KEY([OtobusID])
REFERENCES [dbo].[Otobusler] ([OtobusID])
GO
ALTER TABLE [dbo].[Seferler] CHECK CONSTRAINT [FK_Seferler_Otobusler]
GO
ALTER TABLE [dbo].[Seferler]  WITH CHECK ADD  CONSTRAINT [FK_Seferler_Sehirler] FOREIGN KEY([KalkisSehirID])
REFERENCES [dbo].[Sehirler] ([SehirID])
GO
ALTER TABLE [dbo].[Seferler] CHECK CONSTRAINT [FK_Seferler_Sehirler]
GO
ALTER TABLE [dbo].[Seferler]  WITH CHECK ADD  CONSTRAINT [FK_Seferler_Sehirler1] FOREIGN KEY([VarisSehirID])
REFERENCES [dbo].[Sehirler] ([SehirID])
GO
ALTER TABLE [dbo].[Seferler] CHECK CONSTRAINT [FK_Seferler_Sehirler1]
GO
ALTER TABLE [dbo].[Subeler]  WITH CHECK ADD  CONSTRAINT [FK_Subeler_Sehirler] FOREIGN KEY([SehirID])
REFERENCES [dbo].[Sehirler] ([SehirID])
GO
ALTER TABLE [dbo].[Subeler] CHECK CONSTRAINT [FK_Subeler_Sehirler]
GO
/****** Object:  StoredProcedure [dbo].[BiletCikis]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BiletCikis]
(@Yolcuad varchar(50))
as 
begin 
Select 
b.Yolcuad,
e.SehirAdi as KalkisSehri,
h.SehirAdi as VarisSehri,
c.Yolcuad+' '+c.YolcuSoyad as YolcuAdiSoyadi,
case 
when 
s.VarisZamani is null
then 'Belirtilmedi'
else
Convert (varchar(20), s.VarisZamani,104) end as VarisZamani,
Convert (varchar(20), s.KalkisZamani,104) as KalkisZamani,
s.BiletTutari, Count(b.SeferID) as SatisiYapilanBiletSayisi
from Seferler s 
inner join Biletler c on c.SeferID=s.SeferID
inner join Sehirler e on e.SehirID=s.KalkisSehirID 
inner join Sehirler h on h.SehirID=s.VarisSehirID
inner join Biletler b on b.SeferID=s.SeferID
Group by 
b.Yolcuad,
s.SeferID,
c.Yolcuad+' '+c.YolcuSoyad,
e.SehirAdi,
h.SehirAdi,
s.KalkisZamani,
s.VarisZamani,
s.BiletTutari
having b.Yolcuad=@Yolcuad
end
GO
/****** Object:  StoredProcedure [dbo].[BiletDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BiletDetay]
(
@SeferID int,
@KoltukNo tinyint
)
as
begin
Select * from Biletler 
where SeferID=@SeferID and KoltukNo=@KoltukNo
end
GO
/****** Object:  StoredProcedure [dbo].[BiletEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BiletEkle]
(
@IslemYapanPersonelID int,
@YolcuID int,
@SeferID int,
@IslemZamani datetime,
@SatismiRezervasyonMu bit,
@KoltukNo tinyint,
@YolcuCinsiyet bit,
@Yolcuad varchar(50),
@YolcuSoyad varchar(50),
@SatisTip bit,
@Ucret money
)
as
begin
Insert Into Biletler 
(IslemYapanPersonelID,
YolcuID, 
SeferID, 
IslemZamani, 
SatismiRezervasyonMu,
KoltukNo,
YolcuCinsiyet,
Yolcuad,
YolcuSoyad,
SatisTip,
Ucret) 
values (
@IslemYapanPersonelID,
@YolcuID, 
@SeferID, 
@IslemZamani, 
@SatismiRezervasyonMu,
@KoltukNo,
@YolcuCinsiyet,
@Yolcuad,
@YolcuSoyad,
@SatisTip,
@Ucret)
end
GO
/****** Object:  StoredProcedure [dbo].[BiletGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BiletGuncelle]
(
@IslemYapanPersonelID int,
@YolcuID int,
@SeferID int,
@IslemZamani datetime,
@SatismiRezervasyonMu bit,
@KoltukNo tinyint,
@YolcuCinsiyet bit,
@Yolcuad varchar(50),
@YolcuSoyad varchar(50),
@SatisTip bit,
@Ucret money
)
as
begin
Update Biletler 
set
IslemYapanPersonelID=@IslemYapanPersonelID, 
IslemZamani=@IslemZamani, 
SatismiRezervasyonMu=@SatismiRezervasyonMu,
YolcuCinsiyet=@YolcuCinsiyet,
Yolcuad=@Yolcuad,
YolcuSoyad=@YolcuSoyad,
SatisTip=@SatisTip,
Ucret=@Ucret 
where YolcuID=@YolcuID and SeferID=@SeferID and KoltukNo=@KoltukNo
end
GO
/****** Object:  StoredProcedure [dbo].[BiletListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BiletListesi]
as
begin
Select * from Biletler 
end
GO
/****** Object:  StoredProcedure [dbo].[BiletSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[BiletSil]
(
@YolcuID int,
@SeferID int,
@KoltukNo tinyint
)
as
begin
Delete from Biletler 
where YolcuID=@YolcuID and SeferID=@SeferID and KoltukNo=@KoltukNo
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanDetay]
(@PersonelID int)
as
begin
Select * from Calisanlar 
where PersonelID=@PersonelID
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CalisanEkle]
(
@Ad varchar(50),
@Soyad varchar(50),
@Email varchar(60),
@Telefon char(10),
@SubeID int,
@EvAdresi varchar(200),
@KullaniciAdi varchar(50),
@CalisanTipID int,
@Yoneticimi bit,
@Sifre varchar(50)
)
as
begin
Insert Into Calisanlar (Ad,Soyad,Email,Telefon,SubeID,EvAdresi,KullaniciAdi,CalisanTipID,Yoneticimi,Sifre) 
values (@Ad,@Soyad,@Email,@Telefon,@SubeID,@EvAdresi,@KullaniciAdi,@CalisanTipID,@Yoneticimi,@Sifre)
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanGiris]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[CalisanGiris]
(
@KullaniciAdi varchar(15),
@Sifre varchar(20)
)
as
Select PersonelID,Yoneticimi,KullaniciAdi,SubeID,CalisanTipID
from Calisanlar
where KullaniciAdi=@KullaniciAdi and Sifre=@Sifre
GO
/****** Object:  StoredProcedure [dbo].[CalisanGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanGuncelle]
(
@PersonelID int,
@Ad varchar(50),
@Soyad varchar(50),
@Email varchar(60),
@Telefon char(10),
@SubeID int,
@EvAdresi varchar(200),
@KullaniciAdi varchar(50),
@CalisanTipID int,
@Yoneticimi bit,
@Sifre varchar(50)
)
as
begin
Update Calisanlar set 
Ad=@Ad,
Soyad=@Soyad,
Email=@Email,
Telefon=@Telefon,
SubeID=@SubeID,
EvAdresi=@EvAdresi,
KullaniciAdi=@KullaniciAdi,
CalisanTipID=@CalisanTipID,
Yoneticimi=@Yoneticimi,
Sifre= @Sifre
where PersonelID=@PersonelID
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanListesi]
as
begin
Select * from Calisanlar 
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create proc [dbo].[CalisanSil]
(@PersonelID int)
as
begin
Delete from Calisanlar 
where PersonelID=@PersonelID
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanTipDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanTipDetay]
(@CalisanTipID int)
as
begin
Select * from CalisanTipleri where CalisanTipID=@CalisanTipID
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanTipEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanTipEkle]
(@CalisanTipAdi varchar(50))
as
begin
Insert Into CalisanTipleri (CalisanTipAdi) values (@CalisanTipAdi)
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanTipGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanTipGuncelle]
(@CalisanTipID int,@CalisanTipAdi varchar(50))
as
begin
Update CalisanTipleri set CalisanTipAdi=@CalisanTipAdi where CalisanTipID=@CalisanTipID
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanTipListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanTipListesi]
as
begin
Select * from CalisanTipleri
end
GO
/****** Object:  StoredProcedure [dbo].[CalisanTipSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CalisanTipSil]
(@CalisanTipID int)
as
begin
Delete from CalisanTipleri where CalisanTipID=@CalisanTipID
end
GO
/****** Object:  StoredProcedure [dbo].[HataEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[HataEkle]
(
@Numara varchar(6),
@Mesaj varchar(1000),
@Zamani datetime,
@Procedure varchar(100)
)
as
begin
Insert Into Hatalar (Numara,Mesaj,Zamani,[Procedure]) values (@Numara,@Mesaj,@Zamani,@Procedure)
end
GO
/****** Object:  StoredProcedure [dbo].[KartNoyaGoreMusteriBilgi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[KartNoyaGoreMusteriBilgi]
(
@KartNumarasi nvarchar(16)
)
as
begin 
Select MusteriID,Ad,SoyAd,Cinsiyet,MevcutPara from Musteriler where KartNumarasi=@KartNumarasi
end
GO
/****** Object:  StoredProcedure [dbo].[MarkaDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MarkaDetay]
(@MarkaID int)
as
begin
Select * from Markalar where MarkaID=@MarkaID
end
GO
/****** Object:  StoredProcedure [dbo].[MarkaEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MarkaEkle]
(@MarkaAdi varchar(50))
as
begin
Insert Into Markalar (MarkaAdi) values (@MarkaAdi)
end
GO
/****** Object:  StoredProcedure [dbo].[MarkaGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MarkaGuncelle]
(@MarkaID int,@MarkaAdi varchar(50))
as
begin
Update Markalar set MarkaAdi=@MarkaAdi where MarkaID=@MarkaID
end
GO
/****** Object:  StoredProcedure [dbo].[MarkaListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MarkaListesi]
as
begin
Select * from Markalar 
end
GO
/****** Object:  StoredProcedure [dbo].[MarkaSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MarkaSil]
(@MarkaID int)
as
begin
Delete from Markalar where MarkaID=@MarkaID
end
GO
/****** Object:  StoredProcedure [dbo].[MasrafTipDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MasrafTipDetay]
(@MAsrafTipID int)
as
begin
Select * from MasrafTipleri where MasrafTipID=@MAsrafTipID
end
GO
/****** Object:  StoredProcedure [dbo].[MasrafTipEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MasrafTipEkle]
(@MasrafTipAdi varchar(50))
as
begin
Insert Into MasrafTipleri (MasrafTipAdi) values(@MasrafTipAdi)
end
GO
/****** Object:  StoredProcedure [dbo].[MasrafTipGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MasrafTipGuncelle]
(@MAsrafTipID int,@MasrafTipAdi varchar(50))
as
begin
Update MasrafTipleri set MasrafTipAdi=@MasrafTipAdi where MasrafTipID=@MAsrafTipID
end
GO
/****** Object:  StoredProcedure [dbo].[MasrafTipListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MasrafTipListesi]
as
begin
Select * from MasrafTipleri
end
GO
/****** Object:  StoredProcedure [dbo].[MasrafTipSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MasrafTipSil]
(@MAsrafTipID int)
as
begin
Delete from MasrafTipleri where MasrafTipID=@MAsrafTipID
end
GO
/****** Object:  StoredProcedure [dbo].[MevcutSeferler]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[MevcutSeferler]
(
@KalkisSehirID int,
@VarisSehirID int,
@Tarih datetime
)
as
begin 
Select CONVERT(nvarchar,DATEPART(hh,Seferler.KalkisZamani))+':'+CONVERT(nvarchar,DATEPART(mi,Seferler.KalkisZamani)) as Saat ,Otobusler.Plaka,Seferler.BiletTutari,Seferler.SeferID,Otobusler.KoltukSayisi , Markalar.MarkaAdi from Seferler inner join Otobusler on Seferler.OtobusID=Otobusler.OtobusID inner Join Markalar on Otobusler.MarkaID=Markalar.MarkaID  where Seferler.KalkisSehirID=@KalkisSehirID and Seferler.VarisSehirID=@VarisSehirID and (DATEPART(D,Seferler.KalkisZamani)=DATEPART(d,@Tarih) and DATEPART(M,Seferler.KalkisZamani)=DATEPART(M,@Tarih)) order by 
Seferler.KalkisZamani
end
GO
/****** Object:  StoredProcedure [dbo].[MusteriDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriDetay]
(
@MusteriID int
)
as
begin
Select * from Musteriler 
where MusteriID = @MusteriID
end
GO
/****** Object:  StoredProcedure [dbo].[MusteriEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriEkle]
(
@Ad varchar(50),
@Soyad varchar(50),
@Email varchar(60),
@Telefon varchar(10),
@Cinsiyet bit,
@DogumTarihi datetime,
@SehirID int,
@Adres varchar(200),
@KartNumarasi char(16),
@KartTeslimDurumu bit,
@MevcutPara money
)
as
begin
Insert Into Musteriler (Ad,Soyad,Email,Telefon,Cinsiyet,DogumTarihi,SehirID,Adres,KartNumarasi,KartTeslimDurumu,MevcutPara) 
values(@Ad,@Soyad,@Email,@Telefon,@Cinsiyet,@DogumTarihi,@SehirID,@Adres,@KartNumarasi,@KartTeslimDurumu,@MevcutPara)
end
GO
/****** Object:  StoredProcedure [dbo].[MusteriGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriGuncelle]
(
@MusteriID int,
@Ad varchar(50),
@Soyad varchar(50),
@Email varchar(60),
@Telefon varchar(10),
@Cinsiyet bit,
@DogumTarihi datetime,
@SehirID int,
@Adres varchar(200),
@KartNumarasi char(16),
@KartTeslimDurumu bit,
@MevcutPara money
)
as
begin
Update Musteriler set
Ad=@Ad,
Soyad=@Soyad,
Email=@Email,
Telefon=@Telefon,
Cinsiyet=@Cinsiyet,
DogumTarihi=@DogumTarihi,
SehirID=@SehirID,
Adres=@Adres,
KartNumarasi=@KartNumarasi,
KartTeslimDurumu=@KartTeslimDurumu,
MevcutPara=@MevcutPara
where MusteriID = @MusteriID
end
GO
/****** Object:  StoredProcedure [dbo].[MusteriListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriListesi]
as
begin
Select * from Musteriler 
end
GO
/****** Object:  StoredProcedure [dbo].[MusteriSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[MusteriSil]
(
@MusteriID int
)
as
begin
Delete from Musteriler 
where MusteriID = @MusteriID
end
GO
/****** Object:  StoredProcedure [dbo].[OtobusDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OtobusDetay]
(
@OtobusID int
)
as
begin
Select * from Otobusler 
where OtobusID = @OtobusID
end
GO
/****** Object:  StoredProcedure [dbo].[OtobusEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OtobusEkle]
(
@Plaka varchar(10),
@KoltukSayisi tinyint,
@MarkaID int,
@AktifMi bit
)
as
begin
Insert Into Otobusler (Plaka,KoltukSayisi,MarkaID,AktifMi) values(@Plaka,@KoltukSayisi,@MarkaID,@AktifMi)
end
GO
/****** Object:  StoredProcedure [dbo].[OtobusGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OtobusGuncelle]
(
@OtobusID int,
@Plaka varchar(10),
@KoltukSayisi tinyint,
@MarkaID int,
@AktifMi bit
)
as
begin
Update Otobusler 
set
Plaka=@Plaka,
KoltukSayisi=@KoltukSayisi,
MarkaID=@MarkaID,
AktifMi=@AktifMi
where OtobusID = @OtobusID
end
GO
/****** Object:  StoredProcedure [dbo].[OtobusListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OtobusListesi]
as
begin
Select * from Otobusler 
end
GO
/****** Object:  StoredProcedure [dbo].[OtobusMasrafDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[OtobusMasrafDetay]
(
@OtobusMasrafID int
)
as
Select * from OtobusMasraflar 
where OtobusMasrafID=@OtobusMasrafID
GO
/****** Object:  StoredProcedure [dbo].[OtobusMasrafEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[OtobusMasrafEkle]
(
@OtobusID int,
@MasrafTipID int,
@Tutar money,
@MasrafYapanPersonelID int,
@SeferID int
)
as
Insert Into OtobusMasraflar (OtobusID,MasrafTipID,Tutar,MasrafYapanPersonelID,SeferID) 
values (@OtobusID,@MasrafTipID,@Tutar,@MasrafYapanPersonelID,@SeferID)
GO
/****** Object:  StoredProcedure [dbo].[OtobusMasrafGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[OtobusMasrafGuncelle]
(
@OtobusMasrafID int,
@OtobusID int,
@MasrafTipID int,
@Tutar money,
@MasrafYapanPersonelID int,
@SeferID int
)
as
Update OtobusMasraflar 
set 
OtobusID=@OtobusID,
MasrafTipID=@MasrafTipID,
Tutar=@Tutar,
MasrafYapanPersonelID=@MasrafYapanPersonelID,
SeferID=@SeferID
where OtobusMasrafID=@OtobusMasrafID
GO
/****** Object:  StoredProcedure [dbo].[OtobusMasrafListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[OtobusMasrafListesi]
as
Select * from OtobusMasraflar 
GO
/****** Object:  StoredProcedure [dbo].[OtobusMasrafSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[OtobusMasrafSil]
(
@OtobusMasrafID int
)
as
Delete from OtobusMasraflar 
where OtobusMasrafID=@OtobusMasrafID
GO
/****** Object:  StoredProcedure [dbo].[OtobusSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[OtobusSil]
(
@OtobusID int
)
as
begin
Delete from Otobusler 
where OtobusID = @OtobusID
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelAra]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelAra]
(@PersonelID int)
as
begin
Select * from PersonelGirisCikis where PersonelID=@PersonelID
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelGirisCikisEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PersonelGirisCikisEkle]
(
@PersonelID int,
@IslemZamani datetime,
@IslemTipi bit
)
as
Insert Into PersonelGirisCikis (PersonelID,IslemZamani,IslemTipi) values (@PersonelID,@IslemZamani,@IslemTipi)
GO
/****** Object:  StoredProcedure [dbo].[PersonelGirisCikisGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelGirisCikisGuncelle]
(
@PersonelIslemID int,
@PersonelID int,
@IslemZamani datetime,
@IslemTipi bit
)
as
begin
Update PersonelGirisCikis 
set PersonelID=@PersonelID, IslemZamani=@IslemZamani, IslemTipi=@IslemTipi
where PersonelIslemID=@PersonelIslemID
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelGirisCikisListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[PersonelGirisCikisListesi]
as
begin
Select * from PersonelGirisCikis
end
GO
/****** Object:  StoredProcedure [dbo].[PersonelGirisCikisSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[PersonelGirisCikisSil]
(
@PersonelIslemID int
)
as
Delete from PersonelGirisCikis where PersonelIslemID=@PersonelIslemID
GO
/****** Object:  StoredProcedure [dbo].[RezervasyonSatisaCevir]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[RezervasyonSatisaCevir]
(
@SeferID int,
@KoltukNo tinyint
)
as
Update Biletler set SatisMiRezervasyonMu=0 
where SeferID=@SeferID and KoltukNo=@KoltukNo
GO
/****** Object:  StoredProcedure [dbo].[SatisIptal]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SatisIptal]
(
@SeferID int,
@KoltukNo tinyint 
)
as
Delete from Biletler where SeferID=@SeferID and KoltukNo=@KoltukNo
GO
/****** Object:  StoredProcedure [dbo].[SeferDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SeferDetay]
(
@SeferID int
)
as
Select * from Seferler
where SeferID=@SeferID
GO
/****** Object:  StoredProcedure [dbo].[SefereGoreKoltukNumaralari]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SefereGoreKoltukNumaralari]
(
@SeferID int 
)
as
begin 
Select SeferID,KoltukNo,YolcuCinsiyet,SatisMiRezervasyonMu from Biletler where SeferID=@SeferID
end
GO
/****** Object:  StoredProcedure [dbo].[SeferEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SeferEkle]
(
@KalkisSehirID int,
@VarisSehirID int,
@OtobusID int,
@SoforID int,
@MuavinId int,
@KalkisZamani datetime,
@VarisZamani datetime,
@TahminiSure tinyint,
@BiletTutari money
)
as
Insert Into Seferler (KalkisSehirID,VarisSehirID,OtobusID,SoforID,MuavinId,KalkisZamani,VarisZamani,TahminiSure,BiletTutari) 
values (@KalkisSehirID,@VarisSehirID,@OtobusID,@SoforID,@MuavinId,@KalkisZamani,@VarisZamani,@TahminiSure,@BiletTutari)
GO
/****** Object:  StoredProcedure [dbo].[SeferGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SeferGuncelle]
(
@SeferID int,
@KalkisSehirID int,
@VarisSehirID int,
@OtobusID int,
@SoforID int,
@MuavinId int,
@KalkisZamani datetime,
@VarisZamani datetime,
@TahminiSure tinyint,
@BiletTutari money
)
as
Update Seferler 
set 
KalkisSehirID=@KalkisSehirID,
VarisSehirID=@VarisSehirID,
OtobusID=@OtobusID,
SoforID=@SoforID,
MuavinId=@MuavinId,
KalkisZamani=@KalkisZamani,
VarisZamani=@VarisZamani,
TahminiSure=@TahminiSure,
BiletTutari=@BiletTutari
where SeferID=@SeferID
GO
/****** Object:  StoredProcedure [dbo].[SeferListeAraGetir]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SeferListeAraGetir]
(@KalkisSehirID int,@VarisSehirID int)
as
begin
Select s.SeferID, s.KalkisSehirID,e.SehirAdi as KalkisSehri,s.VarisSehirID,h.SehirAdi as VarisSehri,o.OtobusID,o.Plaka,c.Ad+''+c.Soyad as SoforAdi,a.Ad+''+a.Soyad as MuavinAdi,
case 
when s.VarisZamani is NULL
then 'Belirtilmedi'
else 
CONVERT(nvarchar(20),s.VarisZamani,104) 
end as VarisZamani,Convert(nvarchar(20),s.KalkisZamani,104) as KalkisZamani,s.BiletTutari,s.TahminiSure
--COUNT(b.SeferID) as SatisiYapilanBiletSayisi
 from Seferler s 
 Inner Join Calisanlar c on c.PersonelID=s.SoforID 
 Inner Join Calisanlar a on a.PersonelID=s.MuavinID 
 Inner join Sehirler e on s.KalkisSehirID=e.SehirID
 Inner join Sehirler h on s.VarisSehirID=h.SehirID
 --Inner Join Biletler b on b.SeferID=s.SeferID
 Inner Join Otobusler o on s.OtobusID=o.OtobusID
  Group By  s.SeferID,s.KalkisSehirID,s.VarisSehirID,c.Ad+''+c.Soyad,a.Ad+''+a.Soyad,h.SehirAdi,e.SehirAdi,s.VarisZamani,s.BiletTutari,s.KalkisZamani,o.OtobusID,o.Plaka,s.TahminiSure 
  having s.KalkisSehirID=@KalkisSehirID  and s.VarisSehirID=@VarisSehirID
  end
GO
/****** Object:  StoredProcedure [dbo].[SeferListeBirlestirDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SeferListeBirlestirDetay]
as
begin
Select s.SeferID, s.KalkisSehirID,e.SehirAdi as KalkisSehri,s.VarisSehirID,h.SehirAdi as VarisSehri,o.OtobusID,o.Plaka,c.Ad+''+c.Soyad as SoforAdi,a.Ad+''+a.Soyad as MuavinAdi,
case 
when s.VarisZamani is NULL
then 'Belirtilmedi'
else 
CONVERT(nvarchar(20),s.VarisZamani,104) 
end as VarisZamani,Convert(nvarchar(20),s.KalkisZamani,104) as KalkisZamani,s.BiletTutari,s.TahminiSure
--COUNT(b.SeferID) as SatisiYapilanBiletSayisi
 from Seferler s 
 Inner Join Calisanlar c on c.PersonelID=s.SoforID 
 Inner Join Calisanlar a on a.PersonelID=s.MuavinID 
 Inner join Sehirler e on s.KalkisSehirID=e.SehirID
 Inner join Sehirler h on s.VarisSehirID=h.SehirID
 --Inner Join Biletler b on b.SeferID=s.SeferID
 Inner Join Otobusler o on s.OtobusID=o.OtobusID
  Group By  s.SeferID,s.KalkisSehirID,s.VarisSehirID,c.Ad+''+c.Soyad,a.Ad+''+a.Soyad,h.SehirAdi,e.SehirAdi,s.VarisZamani,s.BiletTutari,s.KalkisZamani,o.OtobusID,o.Plaka,s.TahminiSure
 end
GO
/****** Object:  StoredProcedure [dbo].[SeferListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SeferListesi]
as
Select * from Seferler
GO
/****** Object:  StoredProcedure [dbo].[SeferSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SeferSil]
(
@SeferID int
)
as
Delete from Seferler
where SeferID=@SeferID
GO
/****** Object:  StoredProcedure [dbo].[SehirBazliSeferRapor]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[SehirBazliSeferRapor]
(	 
@KalkisSehri int , @VarisSehri int
)
As
Select KalkisZamani, 
case
when VarisZamani is NULL
Then 'Belirtilmedi'
else
Convert(nvarchar,VarisZamani, 104)
end As VarisZamani,BiletTutari, dbo.SeferBasinaToplamYolcu(SeferID) As ToplamYolcu
From Seferler Where KalkisSehirID = @KalkisSehri And VarisSehirID = @VarisSehri
GO
/****** Object:  StoredProcedure [dbo].[SehirDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SehirDetay]
(
@SehirID int
)
as
Select * from Sehirler where SehirID=@SehirID
GO
/****** Object:  StoredProcedure [dbo].[SehirEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SehirEkle]
(
@SehirAdi varchar(50)
)
as
Insert Into Sehirler (SehirAdi) values (@SehirAdi)
GO
/****** Object:  StoredProcedure [dbo].[SehirGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SehirGuncelle]
(
@SehirAdi varchar(50),@SehirID int
)
as
Update Sehirler set SehirAdi=@SehirAdi where SehirID=@SehirID
GO
/****** Object:  StoredProcedure [dbo].[SehirListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SehirListesi]
as
Select * from Sehirler 
GO
/****** Object:  StoredProcedure [dbo].[SehirSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SehirSil]
(
@SehirID int
)
as
Delete from Sehirler where SehirID=@SehirID
GO
/****** Object:  StoredProcedure [dbo].[SubeAra]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SubeAra]
(
@SubeAdi nvarchar(50)
)
as
begin
Select Subeler.SubeID,Subeler.SehirID,Subeler.SubeAdi,Sehirler.SehirAdi from Subeler inner join Sehirler on Subeler.SehirID=Sehirler.SehirID Where Subeler.SubeAdi like @SubeAdi+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[SubeDetay]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SubeDetay]
(
@SubeID int
)
as
Select * from Subeler where SubeID=@SubeID
GO
/****** Object:  StoredProcedure [dbo].[SubeEkle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SubeEkle]
(
@SubeAdi varchar(50),
@SehirID int
)
as
begin
Insert Into Subeler(SubeAdi, SehirID) values(@SubeAdi, @SehirID)
end
GO
/****** Object:  StoredProcedure [dbo].[SubeGuncelle]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SubeGuncelle]
(
@SubeID int,
@SehirID int,
@SubeAdi varchar(50)
)
as
Update Subeler 
set SubeAdi=@SubeAdi, SehirID=@SehirID 
where SubeID=@SubeID
GO
/****** Object:  StoredProcedure [dbo].[SubeListesi]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SubeListesi]
as
Select * from Subeler
GO
/****** Object:  StoredProcedure [dbo].[SubeSil]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[SubeSil]
(
@SubeID int
)
as
Delete from Subeler
where SubeID=@SubeID
GO
/****** Object:  StoredProcedure [dbo].[TarihBazliSeferRapor]    Script Date: 30.12.2021 21:16:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create proc [dbo].[TarihBazliSeferRapor] (
@BaslangicTarihi datetime, @BitisTarihi datetime
)
As
Select e.SehirAdi As KalkisSehri, h.SehirAdi as VarisSehri ,
Case
when s.VarisZamani is NULL Then 'Belirtilmedi'
else
Convert(nvarchar,s.VarisZamani, 104)
end As VarisZamani,s.KalkisZamani,s.BiletTutari, Count(b.SeferId) As SatisiYapilanBiletSayisi From Seferler s Inner Join Calisanlar c on c.PersonelId = s.SoforId
Inner Join Calisanlar a on a.PersonelId = s.MuavinId   Inner Join Sehirler e on s.KalkisSehirId = e.SehirId Inner Join Sehirler h on s.VarisSehirId = h.SehirId Inner Join Biletler b on b.SeferId = s.SeferId
Where s.KalkisZamani Between @BaslangicTarihi And
@BitisTarihi Group By s.SeferId ,c.Ad, c.Soyad , h.SehirAdi , e.SehirAdi , s.VarisZamani, s.BiletTutari, s.KalkisZamani
GO
USE [master]
GO
ALTER DATABASE [OtobusOtomasyon] SET  READ_WRITE 
GO
