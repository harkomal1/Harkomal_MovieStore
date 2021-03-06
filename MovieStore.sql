USE [master]
GO
/****** Object:  Database [MovieStore]    Script Date: 08/05/2021 12:26:34 AM ******/
CREATE DATABASE [MovieStore]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MovieStore', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MovieStore.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MovieStore_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\MovieStore_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [MovieStore] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MovieStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [MovieStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [MovieStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [MovieStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [MovieStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [MovieStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [MovieStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [MovieStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [MovieStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [MovieStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [MovieStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [MovieStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [MovieStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [MovieStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [MovieStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [MovieStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [MovieStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [MovieStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [MovieStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [MovieStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [MovieStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [MovieStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [MovieStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [MovieStore] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [MovieStore] SET  MULTI_USER 
GO
ALTER DATABASE [MovieStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [MovieStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [MovieStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [MovieStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [MovieStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [MovieStore] SET QUERY_STORE = OFF
GO
USE [MovieStore]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[CustID] [int] IDENTITY(101,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Address] [varchar](max) NULL,
	[Phone] [bigint] NULL,
PRIMARY KEY CLUSTERED 
(
	[CustID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1001,1) NOT NULL,
	[Title] [varchar](500) NULL,
	[Year] [varchar](25) NULL,
	[RentalCost] [int] NULL,
	[Genre] [varchar](50) NULL,
	[Rating] [int] NULL,
	[Flag] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RentedMovies]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RentedMovies](
	[RentId] [int] IDENTITY(1,1) NOT NULL,
	[MovieID] [int] NULL,
	[CustID] [int] NULL,
	[RentedDate] [date] NULL,
	[ReturnDate] [date] NULL,
	[TotalRent] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[RentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customer] ON 

INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (101, N'Harkomal', N'463 Chapel Street', 9108226)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (102, N'Dalpreet', N'572 Warren Avenue', 3149663)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (103, N'Marjorie', N'982 North Street', 2750610)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (104, N'Marie', N'484 Clark Street', 3543001)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (105, N'Nadine', N'917 Route 64', 3928371)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (106, N'Jimmie', N'875 Meadow Lane', 8911141)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (107, N'Alejandro', N'710 10th Street', 2132249)
INSERT [dbo].[Customer] ([CustID], [Name], [Address], [Phone]) VALUES (108, N'Christy', N'940 3rd Street', 8413562)
SET IDENTITY_INSERT [dbo].[Customer] OFF
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1001, N'Life of Pi', N'2012', 2, N'Adventure, Drama, Fantasy', 6, N'Rented')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1002, N'Character', N'1997', 2, N'Crime, Drama, Mystery', 7, N'Rented')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1003, N'Gladiator', N'2015', 5, N'Action, Adventure, Drama', 8, N'Available')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1004, N'Race', N'2014', 5, N'Action', 5, N'Rented')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1005, N'Deadpool', N'2013', 2, N'Action', 6, N'Rented')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1006, N'Anatomy of a Murder', N'1959', 2, N'Crime, Drama, Mystery', 4, N'Available')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1007, N'The Deer Hunter', N'1978', 2, N'Drama, War', 6, N'Available')
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [RentalCost], [Genre], [Rating], [Flag]) VALUES (1008, N'Girl Next Door', N'2010', 2, N'Comedy, Drama', 8, N'Available')
SET IDENTITY_INSERT [dbo].[Movies] OFF
SET IDENTITY_INSERT [dbo].[RentedMovies] ON 

INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (1, 1001, 101, CAST(N'2021-05-04' AS Date), CAST(N'2021-05-06' AS Date), 4)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (5, 1002, 105, CAST(N'2021-05-04' AS Date), CAST(N'2021-05-06' AS Date), 4)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (6, 1002, 106, CAST(N'2021-05-04' AS Date), CAST(N'2021-05-06' AS Date), 4)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (7, 1002, 108, CAST(N'2021-05-04' AS Date), CAST(N'2021-05-06' AS Date), 4)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (8, 1004, 108, CAST(N'2021-04-26' AS Date), CAST(N'2021-05-06' AS Date), 50)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (9, 1005, 108, CAST(N'2021-04-26' AS Date), CAST(N'2021-05-06' AS Date), 20)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (10, 1005, 108, CAST(N'2021-04-26' AS Date), CAST(N'2021-05-06' AS Date), 20)
INSERT [dbo].[RentedMovies] ([RentId], [MovieID], [CustID], [RentedDate], [ReturnDate], [TotalRent]) VALUES (11, 1005, 105, CAST(N'2021-04-26' AS Date), CAST(N'2021-05-06' AS Date), 20)
SET IDENTITY_INSERT [dbo].[RentedMovies] OFF
/****** Object:  Index [UQ__Customer__5C7E359E967858FE]    Script Date: 08/05/2021 12:26:35 AM ******/
ALTER TABLE [dbo].[Customer] ADD UNIQUE NONCLUSTERED 
(
	[Phone] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD FOREIGN KEY([CustID])
REFERENCES [dbo].[Customer] ([CustID])
GO
ALTER TABLE [dbo].[RentedMovies]  WITH CHECK ADD FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
/****** Object:  StoredProcedure [dbo].[prcCustWhoBorrowMostMovies]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
	CREATE proc [dbo].[prcCustWhoBorrowMostMovies]
	as
	SELECT 
    rm.CustID,
	name as CustomerName,
    COUNT(*) occurrences
FROM RentedMovies rm join customer cc on cc.custid = rm.custid
GROUP BY
    rm.CustID, name
  
HAVING 
    COUNT(*) >1;
GO
/****** Object:  StoredProcedure [dbo].[prcDelCust]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[prcDelCust](@custId int)
  as
  delete customer where custId=@custId
GO
/****** Object:  StoredProcedure [dbo].[prcMostPopularMovies]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[prcMostPopularMovies]
 as
SELECT 
    rm.MovieID,title, COUNT(*) occurrences
FROM RentedMovies rm join movies m on m.movieid = rm.movieid
GROUP BY
    rm.MovieID, title
  
HAVING 
    COUNT(*) >1;
GO
/****** Object:  StoredProcedure [dbo].[prcRentMovie]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[prcRentMovie](@MovieID int,@CustID int,@RentDate date, @ReturnDate date,@TotalRent int)
  as
  insert into RentedMovies(MovieID,CustID,RentedDate,ReturnDate,TotalRent) values(@MovieID,@CustID,@RentDate,@ReturnDate,@TotalRent)
GO
/****** Object:  StoredProcedure [dbo].[prcReturnMovie]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[prcReturnMovie](@MovieID int,@Flag varchar(50))
  as
  delete from RentedMovies where MovieID=@MovieID;
  update Movies set Flag=@Flag where MovieID=@MovieID;
GO
/****** Object:  StoredProcedure [dbo].[prcUpdateMovieFlag]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  create proc [dbo].[prcUpdateMovieFlag](@flag varchar(100),@movieID int)
  as
  update movies 
  set flag=@flag
  where MovieID=@movieID
GO
/****** Object:  StoredProcedure [dbo].[ShowRentedData]    Script Date: 08/05/2021 12:26:35 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
  CREATE proc [dbo].[ShowRentedData]
  as
  select RentId, name as CustomerName, Address, Title as MovieTitle,RentalCost,RentedDate,ReturnDate,TotalRent from RentedMovies rm join Customer c on c.CustID = rm.CustID join Movies m on m.MovieID= rm.MovieID
  order by RentedDate desc
GO
USE [master]
GO
ALTER DATABASE [MovieStore] SET  READ_WRITE 
GO
