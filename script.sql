CREATE DATABASE AjaxSamples
USE [AjaxSamples]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 13/06/2023 21:19:14 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NOT NULL,
	[Country] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [Name], [Country]) VALUES (1, N'John Hammond', N'United States')
INSERT [dbo].[Customers] ([CustomerId], [Name], [Country]) VALUES (2, N'Mudassar Khan', N'India')
INSERT [dbo].[Customers] ([CustomerId], [Name], [Country]) VALUES (3, N'Suzanne Mathews', N'France')
INSERT [dbo].[Customers] ([CustomerId], [Name], [Country]) VALUES (4, N'Robert Schidner', N'Russia')
INSERT [dbo].[Customers] ([CustomerId], [Name], [Country]) VALUES (5, N'Wipa solutions', N'Chorrillos')
SET IDENTITY_INSERT [dbo].[Customers] OFF
