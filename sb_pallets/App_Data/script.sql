CREATE TABLE [ashwin].[Customer_Detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [varchar](100) NOT NULL,
	[address] [text] NOT NULL,
 CONSTRAINT [PK_Customer_Detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [ashwin].[Item_Detail]    Script Date: 2015-08-29 11:29:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ashwin].[Item_Detail](
	[item_id] [int] IDENTITY(1,1) NOT NULL,
	[item_description] [text] NOT NULL,
 CONSTRAINT [PK_Item_Detail] PRIMARY KEY CLUSTERED 
(
	[item_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [ashwin].[Pallets_Description]    Script Date: 2015-08-29 11:29:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [ashwin].[Pallets_Description](
	[pallets_id] [varchar](100) NOT NULL,
	[description] [text] NOT NULL,
	[image] [varchar](500) NOT NULL,
	[comments] [text] NOT NULL,
	[long] [int] NOT NULL,
	[wide] [int] NOT NULL,
	[type] [varchar](50) NOT NULL,
	[top_deck] [varchar](50) NOT NULL,
	[stringer] [varchar](50) NOT NULL,
	[bottom_deck] [varchar](50) NOT NULL,
	[top_cut_quantity] [int] NOT NULL,
	[stringer_cut_quantity] [int] NOT NULL,
	[bottome_cut_quantity] [int] NOT NULL,
	[fastner_id] [varchar](50) NOT NULL,
	[fastner_lenght] [decimal](5, 2) NOT NULL,
	[total_nail_each] [int] NOT NULL,
	[lumber_id] [varchar](50) NOT NULL,
	[top_wood_quantity] [int] NOT NULL,
	[stringer_wood_quantity] [int] NOT NULL,
	[bottom_wood_quantity] [int] NOT NULL,
	[ht] [varchar](50) NULL,
	[stamp] [varchar](50) NULL,
	[color] [varchar](50) NULL,
	[tight] [varchar](50) NULL,
	[wing] [varchar](50) NULL,
 CONSTRAINT [PK_Pallets_Description] PRIMARY KEY CLUSTERED 
(
	[pallets_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [ashwin].[Production_Order]    Script Date: 2015-08-29 11:29:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [ashwin].[Production_Order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_id] [int] NOT NULL,
	[order_quantity] [int] NOT NULL,
	[production_quantity] [int] NOT NULL,
	[ship_quantity] [int] NOT NULL,
	[balance_quantity] [int] NOT NULL,
	[start_date] [date] NOT NULL,
	[due_date] [date] NOT NULL,
	[start_time] [time](7) NOT NULL,
	[end_time] [time](7) NOT NULL,
	[total_hours] [int] NOT NULL,
	[order_notes] [text] NOT NULL,
	[pallets_id] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Production_Order] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [ashwin].[Purchased_Order]    Script Date: 2015-08-29 11:29:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [ashwin].[Purchased_Order](
	[purchase_id] [int] IDENTITY(1,1) NOT NULL,
	[vendor_id] [int] NOT NULL,
	[item_id] [int] NOT NULL,
	[order_date] [date] NOT NULL,
	[request_date] [date] NOT NULL,
	[order_by_name] [varchar](100) NOT NULL,
	[confirm_by_name] [varchar](100) NOT NULL,
	[terms_days] [int] NOT NULL,
	[ship_via] [bit] NOT NULL,
	[order_number] [int] NOT NULL,
	[item_quantity] [int] NOT NULL,
	[unit_price] [decimal](10, 2) NOT NULL,
	[price_fbm] [decimal](10, 2) NOT NULL,
	[amount] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Purchased_Order] PRIMARY KEY CLUSTERED 
(
	[purchase_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [ashwin].[Vendor_Detail]    Script Date: 2015-08-29 11:29:40 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [ashwin].[Vendor_Detail](
	[vendor_id] [int] IDENTITY(1,1) NOT NULL,
	[vendor_address] [text] NOT NULL,
 CONSTRAINT [PK_Vendor_Detail] PRIMARY KEY CLUSTERED 
(
	[vendor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
ALTER TABLE [ashwin].[Production_Order]  WITH CHECK ADD  CONSTRAINT [FK_Production_Order_Customer_Detail] FOREIGN KEY([customer_id])
REFERENCES [ashwin].[Customer_Detail] ([id])
GO
ALTER TABLE [ashwin].[Production_Order] CHECK CONSTRAINT [FK_Production_Order_Customer_Detail]
GO
ALTER TABLE [ashwin].[Production_Order]  WITH CHECK ADD  CONSTRAINT [FK_Production_Order_Pallets_Description] FOREIGN KEY([pallets_id])
REFERENCES [ashwin].[Pallets_Description] ([pallets_id])
GO
ALTER TABLE [ashwin].[Production_Order] CHECK CONSTRAINT [FK_Production_Order_Pallets_Description]
GO
ALTER TABLE [ashwin].[Purchased_Order]  WITH CHECK ADD  CONSTRAINT [FK_Purchased_Order_Item_Detail] FOREIGN KEY([item_id])
REFERENCES [ashwin].[Item_Detail] ([item_id])
GO
ALTER TABLE [ashwin].[Purchased_Order] CHECK CONSTRAINT [FK_Purchased_Order_Item_Detail]
GO
ALTER TABLE [ashwin].[Purchased_Order]  WITH CHECK ADD  CONSTRAINT [FK_Purchased_Order_Vendor_Detail] FOREIGN KEY([vendor_id])
REFERENCES [ashwin].[Vendor_Detail] ([vendor_id])
GO
ALTER TABLE [ashwin].[Purchased_Order] CHECK CONSTRAINT [FK_Purchased_Order_Vendor_Detail]
GO
USE [master]
GO
ALTER DATABASE [sb_pallets] SET  READ_WRITE 
GO
