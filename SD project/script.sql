USE [Invoice]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 12/05/2017 22:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoice](
	[Invoice_Id] [int] IDENTITY(1,1) NOT NULL,
	[Date] [date] NULL,
	[Salesman] [varchar](50) NOT NULL,
	[CustomerName] [varchar](50) NOT NULL,
	[Contact] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Invoice__0DE605740AD2A005] PRIMARY KEY CLUSTERED 
(
	[Invoice_Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Admin_Info]    Script Date: 12/05/2017 22:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Admin_Info](
	[Name] [varchar](50) NULL,
	[Password] [varchar](50) NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Invoice_Item]    Script Date: 12/05/2017 22:40:45 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Invoice_Item](
	[Invoice_Id] [int] NOT NULL,
	[Description] [varchar](50) NOT NULL,
	[Quantity] [int] NOT NULL,
	[Unit_Price] [int] NOT NULL,
	[Line_Total] [int] NOT NULL,
 CONSTRAINT [Invoice_Item_Pk] PRIMARY KEY CLUSTERED 
(
	[Invoice_Id] ASC,
	[Description] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Default [DF_Invoice_Date]    Script Date: 12/05/2017 22:40:45 ******/
ALTER TABLE [dbo].[Invoice] ADD  CONSTRAINT [DF_Invoice_Date]  DEFAULT (getdate()) FOR [Date]
GO
/****** Object:  ForeignKey [FK__Invoice_I__Invoi__117F9D94]    Script Date: 12/05/2017 22:40:45 ******/
ALTER TABLE [dbo].[Invoice_Item]  WITH CHECK ADD  CONSTRAINT [FK__Invoice_I__Invoi__117F9D94] FOREIGN KEY([Invoice_Id])
REFERENCES [dbo].[Invoice] ([Invoice_Id])
GO
ALTER TABLE [dbo].[Invoice_Item] CHECK CONSTRAINT [FK__Invoice_I__Invoi__117F9D94]
GO
