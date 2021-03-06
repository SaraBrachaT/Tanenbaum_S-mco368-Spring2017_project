USE [master]
GO
/****** Object:  Database [DBModel.Context]    Script Date: 6/13/2017 3:28:10 PM ******/
CREATE DATABASE [DBModel.Context]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DBModel.Context', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\DBModel.Context.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DBModel.Context_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLEXPRESS\MSSQL\DATA\DBModel.Context_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [DBModel.Context] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DBModel.Context].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DBModel.Context] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DBModel.Context] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DBModel.Context] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DBModel.Context] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DBModel.Context] SET ARITHABORT OFF 
GO
ALTER DATABASE [DBModel.Context] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DBModel.Context] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DBModel.Context] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DBModel.Context] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DBModel.Context] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DBModel.Context] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DBModel.Context] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DBModel.Context] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DBModel.Context] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DBModel.Context] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DBModel.Context] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DBModel.Context] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DBModel.Context] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DBModel.Context] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DBModel.Context] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DBModel.Context] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [DBModel.Context] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DBModel.Context] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DBModel.Context] SET  MULTI_USER 
GO
ALTER DATABASE [DBModel.Context] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DBModel.Context] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DBModel.Context] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DBModel.Context] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DBModel.Context] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DBModel.Context] SET QUERY_STORE = OFF
GO
USE [DBModel.Context]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [DBModel.Context]
GO
/****** Object:  Table [dbo].[__MigrationHistory]    Script Date: 6/13/2017 3:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__MigrationHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ContextKey] [nvarchar](300) NOT NULL,
	[Model] [varbinary](max) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK_dbo.__MigrationHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC,
	[ContextKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Items]    Script Date: 6/13/2017 3:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[ItemId] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](max) NULL,
	[Price] [float] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Items] PRIMARY KEY CLUSTERED 
(
	[ItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Purchases]    Script Date: 6/13/2017 3:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Purchases](
	[PurchaseId] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseDate] [date] NOT NULL,
	[Item_ItemId] [int] NULL,
	[User_UserId] [int] NULL,
	[PurchaseQuantity] [int] NULL,
 CONSTRAINT [PK_dbo.Purchases] PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Users]    Script Date: 6/13/2017 3:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Balance] [float] NOT NULL,
 CONSTRAINT [PK_dbo.Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Purchases_dbo.Items_Item_ItemId] FOREIGN KEY([Item_ItemId])
REFERENCES [dbo].[Items] ([ItemId])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_dbo.Purchases_dbo.Items_Item_ItemId]
GO
ALTER TABLE [dbo].[Purchases]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Purchases_dbo.Users_User_UserId] FOREIGN KEY([User_UserId])
REFERENCES [dbo].[Users] ([UserId])
GO
ALTER TABLE [dbo].[Purchases] CHECK CONSTRAINT [FK_dbo.Purchases_dbo.Users_User_UserId]
GO
/****** Object:  Trigger [dbo].[AddPurchase]    Script Date: 6/13/2017 3:28:10 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
/*
What should the trigger do?
Check if CUSTOMER has good enough balance
Check if ITEM in stock
If yes,
Change BALANCE
Change STOCK
Record PURCHASE
*/

CREATE TRIGGER [dbo].[AddPurchase] on [dbo].[Purchases]
   instead of INSERT
AS 
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for trigger here
	declare @limit float = -100;
	declare @UserID int;
	declare @ItemID int;
	declare @PurchaseID int;
	declare @balance float;
	declare @price float;
	declare @qty int;
	declare @date date;
	declare @purchaseQty int;

begin
	select @UserID = User_UserId from inserted;
	select @ItemID = Item_ItemId from inserted;
	select @PurchaseID = PurchaseId from inserted;
	select @price = Price from Items where ItemId = @ItemID;
	select @balance = Balance from Users where UserId = @UserID;
	select @date = purchaseDate from inserted;
	select @purchaseQty = PurchaseQuantity from inserted;
	
	if @balance -  (@price * @purchaseQty)< @limit
	begin
		RAISERROR('Insufficient Balance', 11,1)
		return
		end

	select @qty = Quantity from Items where ItemId = @ItemID;
	if @qty < 1
	begin
		RAISERROR('Insufficient Items', 11,1)
		return
		end
		
	
	insert into Purchases(PurchaseDate, Item_ItemId, User_UserId, PurchaseQuantity)
	values (@date , @ItemID, @UserID, @purchaseQty)

	update Users
	set Balance = Balance - (@price * @purchaseQty)
	where UserId = @UserID
	
	update Items
	set Quantity = Quantity - 1
	where ItemId = @ItemID 

end
END

GO
ALTER TABLE [dbo].[Purchases] ENABLE TRIGGER [AddPurchase]
GO
USE [master]
GO
ALTER DATABASE [DBModel.Context] SET  READ_WRITE 
GO
