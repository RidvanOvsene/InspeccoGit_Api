USE [InspeccoDb]
GO
/****** Object:  Table [dbo].[Companies]    Script Date: 15.06.2022 11:14:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Companies](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](500) NULL,
	[CompanyDescription] [nvarchar](max) NULL,
 CONSTRAINT [PK_Firmalar] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[MenuId] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [nvarchar](500) NULL,
	[MenuUrl] [nvarchar](max) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[MenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationClaims]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_OperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[PermissionId] [int] IDENTITY(1,1) NOT NULL,
	[PermissionName] [nvarchar](250) NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[PersonId] [int] IDENTITY(1,1) NOT NULL,
	[PersonName] [nvarchar](500) NULL,
	[PersonSurname] [nvarchar](500) NULL,
	[Contact] [nvarchar](50) NULL,
	[CompanyId] [int] NULL,
 CONSTRAINT [PK_Kisiler] PRIMARY KEY CLUSTERED 
(
	[PersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[RolId] [int] IDENTITY(1,1) NOT NULL,
	[RolName] [nvarchar](250) NULL,
 CONSTRAINT [PK_Roller] PRIMARY KEY CLUSTERED 
(
	[RolId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RolPermission]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolPermission](
	[RolPermissionId] [int] IDENTITY(1,1) NOT NULL,
	[RolId] [int] NULL,
	[PermissionId] [int] NULL,
	[MenuId] [int] NULL,
 CONSTRAINT [PK_RolPermission] PRIMARY KEY CLUSTERED 
(
	[RolPermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserMenu]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserMenu](
	[UserMenuId] [int] IDENTITY(1,1) NOT NULL,
	[MenuId] [int] NULL,
	[UserId] [int] NULL,
 CONSTRAINT [PK_UserMenu] PRIMARY KEY CLUSTERED 
(
	[UserMenuId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserOperationClaims]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserOperationClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kullanici_ID] [int] NULL,
	[OperationClaimId] [int] NULL,
 CONSTRAINT [PK_UserOperationClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](250) NULL,
	[Password] [nvarchar](250) NULL,
	[RolId] [int] NULL,
	[NameSurname] [nvarchar](500) NULL,
	[CompanyId] [int] NULL,
	[Contact] [nvarchar](500) NULL,
	[Id] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Companies] ON 

INSERT [dbo].[Companies] ([CompanyId], [CompanyName], [CompanyDescription]) VALUES (1, N'Inspecco', N'This is Inspecco')
INSERT [dbo].[Companies] ([CompanyId], [CompanyName], [CompanyDescription]) VALUES (1004, N'Denememe Firması', N'Bu Firma Deneme Amaçlı Kurulmuştur')
SET IDENTITY_INSERT [dbo].[Companies] OFF
GO
SET IDENTITY_INSERT [dbo].[Menu] ON 

INSERT [dbo].[Menu] ([MenuId], [MenuName], [MenuUrl]) VALUES (5, N'Firma Listesi', N'/Company/CompanyList')
INSERT [dbo].[Menu] ([MenuId], [MenuName], [MenuUrl]) VALUES (6, N'Kullanıcı Listesi', N'User/UserList')
INSERT [dbo].[Menu] ([MenuId], [MenuName], [MenuUrl]) VALUES (7, N'Menü Listesi', N'Menu/MenuList')
SET IDENTITY_INSERT [dbo].[Menu] OFF
GO
SET IDENTITY_INSERT [dbo].[OperationClaims] ON 

INSERT [dbo].[OperationClaims] ([Id], [Name]) VALUES (1, N'Create')
SET IDENTITY_INSERT [dbo].[OperationClaims] OFF
GO
SET IDENTITY_INSERT [dbo].[Permissions] ON 

INSERT [dbo].[Permissions] ([PermissionId], [PermissionName]) VALUES (1, N'Create')
INSERT [dbo].[Permissions] ([PermissionId], [PermissionName]) VALUES (2, N'Update')
INSERT [dbo].[Permissions] ([PermissionId], [PermissionName]) VALUES (3, N'Delete')
INSERT [dbo].[Permissions] ([PermissionId], [PermissionName]) VALUES (1005, N'Read')
SET IDENTITY_INSERT [dbo].[Permissions] OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([PersonId], [PersonName], [PersonSurname], [Contact], [CompanyId]) VALUES (1, N'Rıdvan', N'Övsene', N'555-555-55-55', 1)
INSERT [dbo].[Persons] ([PersonId], [PersonName], [PersonSurname], [Contact], [CompanyId]) VALUES (6, N'Deneme Kişisi', N'Deneme', N'555 555 55 55', NULL)
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON 

INSERT [dbo].[Roles] ([RolId], [RolName]) VALUES (1, N'Admin')
INSERT [dbo].[Roles] ([RolId], [RolName]) VALUES (1005, N'Users')
SET IDENTITY_INSERT [dbo].[Roles] OFF
GO
SET IDENTITY_INSERT [dbo].[RolPermission] ON 

INSERT [dbo].[RolPermission] ([RolPermissionId], [RolId], [PermissionId], [MenuId]) VALUES (1, 1, 1, 6)
INSERT [dbo].[RolPermission] ([RolPermissionId], [RolId], [PermissionId], [MenuId]) VALUES (9, 1, 2, 6)
INSERT [dbo].[RolPermission] ([RolPermissionId], [RolId], [PermissionId], [MenuId]) VALUES (11, 1, 3, NULL)
INSERT [dbo].[RolPermission] ([RolPermissionId], [RolId], [PermissionId], [MenuId]) VALUES (13, 1, 1005, NULL)
INSERT [dbo].[RolPermission] ([RolPermissionId], [RolId], [PermissionId], [MenuId]) VALUES (14, 1005, 1005, NULL)
SET IDENTITY_INSERT [dbo].[RolPermission] OFF
GO
SET IDENTITY_INSERT [dbo].[UserMenu] ON 

INSERT [dbo].[UserMenu] ([UserMenuId], [MenuId], [UserId]) VALUES (8, 5, 11)
SET IDENTITY_INSERT [dbo].[UserMenu] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [UserName], [Password], [RolId], [NameSurname], [CompanyId], [Contact], [Id]) VALUES (11, N'Admin', N'123456', 1, N'Admin', NULL, N'(212) 212 21 12', NULL)
INSERT [dbo].[Users] ([UserId], [UserName], [Password], [RolId], [NameSurname], [CompanyId], [Contact], [Id]) VALUES (12, N'123456', N'123456', 1005, N'Users', NULL, N'555 555 55 55', NULL)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
/****** Object:  StoredProcedure [dbo].[GetListPersonDto]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetListPersonDto] 

	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	.Persons.[PersonId]
	,Persons.[PersonName]
	,Persons.[PersonSurname]
	,Persons.[Contact]
	,Companies.[CompanyId]
	,Companies.[CompanyName]
	FROM  Persons
	LEFT JOIN Companies ON Companies.CompanyId=Persons.CompanyId	
	

END
GO
/****** Object:  StoredProcedure [dbo].[GetListRolPermission]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetListRolPermission] 

	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	.RolPermission.[RolPermissionId]
	,Roles.[RolId]
	,Roles.[RolName]
	,Permissions.[PermissionId]
	,Permissions.[PermissionName]
	,Menu.[MenuId]
	,Menu.[MenuName]
	
	FROM  RolPermission
	LEFT JOIN Roles ON Roles.RolId=RolPermission.RolId
	LEFT JOIN Permissions ON Permissions.PermissionId=RolPermission.PermissionId
	LEFT JOIN Menu ON Menu.MenuId=RolPermission.MenuId

END
GO
/****** Object:  StoredProcedure [dbo].[GetListUserMenu]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetListUserMenu] 

	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	.UserMenu.[UserMenuId]
	,Users.[UserId]
	,Users.[UserName]
	,Users.[NameSurname]
	,Menu.[MenuId]
	,Menu.[MenuName]
	,Menu.[MenuUrl]
	FROM  UserMenu
	LEFT JOIN Users ON Users.UserId=UserMenu.UserId	
	LEFT JOIN Menu ON Menu.MenuId=UserMenu.MenuId

END
GO
/****** Object:  StoredProcedure [dbo].[GetListUserRol]    Script Date: 15.06.2022 11:14:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[GetListUserRol] 

	-- Add the parameters for the stored procedure here

AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT 
	.Users.[UserId]
	,Users.[UserName]
	,Users.[NameSurname]
	,Users.[Password]
	,Users.[Contact]
    ,Roles.[RolId]
	,Roles.[RolName]

	
	FROM  Users
	LEFT JOIN Roles ON Roles.RolId=Users.RolId


END
GO
