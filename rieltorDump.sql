USE [master]
GO
/****** Object:  Database [rieltorskoe_agenstvo]    Script Date: 28.06.2023 9:54:16 ******/
CREATE DATABASE [rieltorskoe_agenstvo]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'rieltorskoe_agenstvo', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\rieltorskoe_agenstvo.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'rieltorskoe_agenstvo_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\rieltorskoe_agenstvo_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [rieltorskoe_agenstvo].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ARITHABORT OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET  ENABLE_BROKER 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET RECOVERY FULL 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET  MULTI_USER 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET DB_CHAINING OFF 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'rieltorskoe_agenstvo', N'ON'
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET QUERY_STORE = ON
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [rieltorskoe_agenstvo]
GO
/****** Object:  Table [dbo].[owners]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[owners](
	[owner_ID] [int] IDENTITY(1000,1) NOT NULL,
	[owner_name] [varchar](100) NOT NULL,
	[owner_phone_number] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[owner_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[property_types]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[property_types](
	[property_type_ID] [int] IDENTITY(0,1) NOT NULL,
	[property_type_name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[property_type_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[states]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[states](
	[state_ID] [int] IDENTITY(100,1) NOT NULL,
	[state_name] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[state_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[properties]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[properties](
	[property_ID] [int] IDENTITY(20000,1) NOT NULL,
	[property_type] [int] NOT NULL,
	[property_address] [varchar](200) NOT NULL,
	[property_rooms_quantity] [int] NOT NULL,
	[property_owner] [int] NOT NULL,
	[property_rent_price] [float] NOT NULL,
	[property_state] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[property_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[property_view]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[property_view]
AS
SELECT property_ID, property_type_name, property_address, property_rooms_quantity, 
	property_owner, owner_name, property_rent_price, state_name
FROM properties, property_types, owners, states
WHERE property_type = property_type_ID AND
	property_owner = owner_ID AND
	property_state = state_ID
GO
/****** Object:  Table [dbo].[customers]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[customers](
	[customer_ID] [int] IDENTITY(5000,1) NOT NULL,
	[customer_name] [varchar](100) NOT NULL,
	[customer_phone_number] [varchar](20) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rented_properties]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rented_properties](
	[rented_property_contract_ID] [int] IDENTITY(40000,1) NOT NULL,
	[rented_property] [int] NOT NULL,
	[rented_property_customer] [int] NOT NULL,
	[rented_property_owner] [int] NOT NULL,
	[rented_property_price] [float] NOT NULL,
	[rented_property_first_date] [date] NOT NULL,
	[rented_property_last_date] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[rented_property_contract_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[rented_properties_view]    Script Date: 28.06.2023 9:54:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[rented_properties_view]
AS
SELECT rented_property_contract_ID, rented_property, customer_name,
	owner_name, rented_property_price, rented_property_first_date, rented_property_last_date
FROM rented_properties, customers, owners
WHERE rented_property_customer = customer_ID AND
	rented_property_owner = owner_ID
GO
SET IDENTITY_INSERT [dbo].[customers] ON 

INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5000, N'Сорокин Серафим Арсеньевич', N'+7 (248) 397-27-59')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5001, N'Титова Настасья Егоровна', N'+7 (219) 400-36-41')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5002, N'Щербакова Исидора Георгьевна', N'+7 (449) 886-80-88')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5003, N'Субботина Филиппа Никифоровна', N'+7 (963) 670-51-67')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5004, N'Рожкова Фекла Венедиктовна', N'+7 (922) 806-52-18')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5005, N'Филатов Филипп Никанорович', N'+7 (745) 778-48-63')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5006, N'Зайцев Леонид Прохорович', N'+7 (150) 194-15-94')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5007, N'Константинов Макар Никифорович', N'+7 (843) 867-93-44')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5008, N'Титова Агрипина Ефремовна', N'+7 (220) 984-53-70')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5009, N'Журавлев Лаврентий Елизарович', N'+7 (322) 485-60-28')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5010, N'Виноградов Антон Яковлевич', N'+7 (343) 584-65-22')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5011, N'Матвеев Даниил Германович', N'+7 (355) 275-10-72')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5012, N'Комаров Ефим Федотович', N'+7 (191) 441-16-95')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5013, N'Шилов Прокл Викторович', N'+7 (614) 764-52-39')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5015, N'Мясникова Устинья Константиновна', N'+7 (930) 220-89-82')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5016, N'Зимина Зинаида Данииловна', N'+7 (730) 111-33-13')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5017, N'Потапов Филипп Наумович', N'+7 (598) 612-34-37')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5019, N'Виноградов Василий Вениаминович', N'+7 (163) 449-32-69')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5020, N'Сазонов Юлиан Юринович', N'+7 (877) 342-60-27')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5021, N'Кошелев Степан Герасимович', N'+7 (660) 250-42-36')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5022, N'Прокопьев Станислав Романович', N'+7 (919) 025-08-71')
INSERT [dbo].[customers] ([customer_ID], [customer_name], [customer_phone_number]) VALUES (5023, N'Григорьева Шура Тимофеевна', N'+7 (912) 390-85-98')
SET IDENTITY_INSERT [dbo].[customers] OFF
GO
SET IDENTITY_INSERT [dbo].[owners] ON 

INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1000, N'Мамонтова Мария Павловна', N'+7 (811) 622-64-38')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1001, N'Маслов Афанасий Себастьянович', N'+7 (471) 385-78-48')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1002, N'Голубев Всеволод Давидович', N'+7 (158) 192-69-96')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1003, N'Федосеева Светлана Кузьминовна', N'+7 (726) 209-25-84')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1004, N'Панфилов Ефим Даниилович', N'+7 (570) 474-34-29')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1005, N'Соколов Аким Яковлевич', N'+7 (114) 192-82-52')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1006, N'Фокин Феликс Аркадинович', N'+7 (967) 387-14-91')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1007, N'Артемьев Климент Климентович', N'+7 (771) 414-34-19')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1008, N'Сазонова Юлия Ильишна', N'+7 (878) 206-58-29')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1009, N'Тихонова Феодора Афанасьевна', N'+7 (479) 319-30-62')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1010, N'Бобылева Аглая Себастьяновна', N'+7 (911) 895-97-73')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1011, N'Ковалева Анфиса Прохор', N'+7 (208) 344-65-24')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1012, N'Наумов Виталий Степанович', N'+7 (611) 722-36-30')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1013, N'Зыкова Татьяна Викторовна', N'+7 (853) 525-36-69')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1014, N'Колобов Савва Юрьевич', N'+7 (960) 318-60-78')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1015, N'Молчанов Ефим Ефимович', N'+7 (763) 345-80-95')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1016, N'Ермакова Агнесса Геннадьевна', N'+7 (624) 767-25-33')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1017, N'Ефимова Феодора Ираклиевна', N'+7 (427) 795-45-50')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1019, N'Белозеров Филипп Порфирьевич', N'+7 (919) 829-49-87')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1020, N'Соколова Матрона Максимовна', N'+7 (114) 252-89-48')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1021, N'Турова Юстина Якововна', N'+7 (997) 973-30-40')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1022, N'Белов Фадей Васильевич', N'+7 (189) 609-29-56')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1023, N'Евдокимов Юрий Трофимович', N'+7 (681) 643-33-93')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1024, N'Королев Василий Александрович', N'+7 (266) 599-70-44')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1025, N'Григорьева Кира Вениаминовна', N'+7 (279) 619-17-41')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1026, N'Белоусов Валентин Ростиславович', N'+7 (341) 956-10-52')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1027, N'Константинов Прохор Тимофеевич', N'+7 (841) 170-71-85')
INSERT [dbo].[owners] ([owner_ID], [owner_name], [owner_phone_number]) VALUES (1028, N'Фомина Елена Юрьевна', N'+7 (939) 710-18-75')
SET IDENTITY_INSERT [dbo].[owners] OFF
GO
SET IDENTITY_INSERT [dbo].[properties] ON 

INSERT [dbo].[properties] ([property_ID], [property_type], [property_address], [property_rooms_quantity], [property_owner], [property_rent_price], [property_state]) VALUES (20000, 0, N'Россия, г. Москва, Радужная ул., 22, корп. 6, кв. 157', 3, 1014, 45990, 100)
INSERT [dbo].[properties] ([property_ID], [property_type], [property_address], [property_rooms_quantity], [property_owner], [property_rent_price], [property_state]) VALUES (20001, 1, N'Россия, г. Москва, Майская ул., 43, корп. 3, кв. 130', 6, 1004, 99990, 100)
INSERT [dbo].[properties] ([property_ID], [property_type], [property_address], [property_rooms_quantity], [property_owner], [property_rent_price], [property_state]) VALUES (20002, 2, N'Россия, г. Москва, Дзержинского ул., 98, корп. 7, кв. 181', 1, 1017, 13990, 100)
INSERT [dbo].[properties] ([property_ID], [property_type], [property_address], [property_rooms_quantity], [property_owner], [property_rent_price], [property_state]) VALUES (20003, 0, N'Россия, г. Москва, Совхозная ул., 90, корп. 3, кв. 93', 3, 1009, 13990, 100)
INSERT [dbo].[properties] ([property_ID], [property_type], [property_address], [property_rooms_quantity], [property_owner], [property_rent_price], [property_state]) VALUES (20004, 0, N'Россия, г. Москва, Первомайская ул., 34, корп. 8, кв. 119', 2, 1009, 78990, 100)
INSERT [dbo].[properties] ([property_ID], [property_type], [property_address], [property_rooms_quantity], [property_owner], [property_rent_price], [property_state]) VALUES (20005, 0, N'Россия, г. Москва, Интернациональная ул., 42, корп. 6, кв. 76', 3, 1000, 57990, 100)
SET IDENTITY_INSERT [dbo].[properties] OFF
GO
SET IDENTITY_INSERT [dbo].[property_types] ON 

INSERT [dbo].[property_types] ([property_type_ID], [property_type_name]) VALUES (0, N'Многоквартирный дом')
INSERT [dbo].[property_types] ([property_type_ID], [property_type_name]) VALUES (1, N'Частный жилой дом')
INSERT [dbo].[property_types] ([property_type_ID], [property_type_name]) VALUES (2, N'Офисное помещение')
INSERT [dbo].[property_types] ([property_type_ID], [property_type_name]) VALUES (3, N'Дачный участок')
SET IDENTITY_INSERT [dbo].[property_types] OFF
GO
SET IDENTITY_INSERT [dbo].[states] ON 

INSERT [dbo].[states] ([state_ID], [state_name]) VALUES (100, N'Доступно')
INSERT [dbo].[states] ([state_ID], [state_name]) VALUES (101, N'Арендовано')
SET IDENTITY_INSERT [dbo].[states] OFF
GO
ALTER TABLE [dbo].[properties]  WITH CHECK ADD FOREIGN KEY([property_type])
REFERENCES [dbo].[property_types] ([property_type_ID])
GO
ALTER TABLE [dbo].[properties]  WITH CHECK ADD FOREIGN KEY([property_owner])
REFERENCES [dbo].[owners] ([owner_ID])
GO
ALTER TABLE [dbo].[properties]  WITH CHECK ADD FOREIGN KEY([property_state])
REFERENCES [dbo].[states] ([state_ID])
GO
ALTER TABLE [dbo].[rented_properties]  WITH CHECK ADD FOREIGN KEY([rented_property])
REFERENCES [dbo].[properties] ([property_ID])
GO
ALTER TABLE [dbo].[rented_properties]  WITH CHECK ADD FOREIGN KEY([rented_property_customer])
REFERENCES [dbo].[customers] ([customer_ID])
GO
ALTER TABLE [dbo].[rented_properties]  WITH CHECK ADD FOREIGN KEY([rented_property_owner])
REFERENCES [dbo].[owners] ([owner_ID])
GO
USE [master]
GO
ALTER DATABASE [rieltorskoe_agenstvo] SET  READ_WRITE 
GO
