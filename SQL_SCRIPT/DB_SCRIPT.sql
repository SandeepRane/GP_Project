CREATE DATABASE [DB_GP]
GO
CREATE TABLE [dbo].[FreightHead](
	[FreightHeadID] [int] IDENTITY(1,1) NOT NULL,
	[FHNumber] [varchar](20) NOT NULL,
	[RequestDate] [datetime] NOT NULL,
	[RequestedByUser] [int] NOT NULL,
	[Company] [int] NULL,
	[FreightType] [varchar](100) NULL,
	[IncoTerm] [varchar](100) NULL,
	[Customer] [varchar](100) NULL,
	[PickUpLocation] [varchar](100) NULL,
	[LoadingPort] [varchar](100) NULL,
	[DischargePort] [varchar](100) NULL,
	[PlaceOfDelivery] [varchar](100) NULL,
	[Commodity] [varchar](100) NULL,
	[FreightCargoType] [varchar](100) NULL,
	[TraderName] [varchar](100) NULL,
	[Deparment] [varchar](100) NULL,
	[Priority] [varchar](50) NULL,
	[FreightHeadStatusID] [int] NOT NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
	[LastUpdatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK__FreightH__A03BCB4C67475671] PRIMARY KEY CLUSTERED 
(
	[FreightHeadID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreightHeadServices]    Script Date: 13-02-2020 17:29:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreightHeadServices](
	[FreightHeadServicesID] [int] IDENTITY(1,1) NOT NULL,
	[FreightHeadID] [int] NOT NULL,
	[FreightContainerType] [varchar](100) NOT NULL,
	[NumberOfContainers] [int] NOT NULL,
	[FreightPackingType] [varchar](100) NOT NULL,
	[NetWeight] [float] NOT NULL,
	[GrossWeight] [float] NOT NULL,
	[FreeTimePeriod] [varchar](100) NOT NULL,
	[BLClauses] [varchar](100) NOT NULL,
	[ShippingCertificate] [varchar](100) NOT NULL,
	[Remarks] [varchar](100) NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
	[LastUpdatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK__FreightH__E64664D8B48A4BAE] PRIMARY KEY CLUSTERED 
(
	[FreightHeadServicesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FreightHeadShipmentRate]    Script Date: 13-02-2020 17:29:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FreightHeadShipmentRate](
	[FreightHeadShipmentRateID] [int] IDENTITY(1,1) NOT NULL,
	[FreightHeadID] [int] NOT NULL,
	[FreightHeadShipmentTypeID] [int] NOT NULL,
	[FreightContainerType] [varchar](100) NOT NULL,
	[FreightPackingType] [varchar](100) NOT NULL,
	[RateOfferedToTraders] [float] NOT NULL,
	[RateOfferedByShippingLine] [float] NULL,
	[TotalAmoutToTraders] [float] NOT NULL,
	[TotalAmountOfShippingLine] [float] NULL,
	[LastUpdatedBy] [varchar](50) NOT NULL,
	[LastUpdatedOn] [datetime] NOT NULL,
 CONSTRAINT [PK__FreightH__DE94E7E80F9623C9] PRIMARY KEY CLUSTERED 
(
	[FreightHeadShipmentRateID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[FreightHeadServices]  WITH CHECK ADD  CONSTRAINT [FK_FreightHeadServices_FreightHead] FOREIGN KEY([FreightHeadID])
REFERENCES [dbo].[FreightHead] ([FreightHeadID])
GO
ALTER TABLE [dbo].[FreightHeadServices] CHECK CONSTRAINT [FK_FreightHeadServices_FreightHead]
GO
ALTER TABLE [dbo].[FreightHeadShipmentRate]  WITH CHECK ADD  CONSTRAINT [FK_FreightHeadShipmentRate_FreightHead] FOREIGN KEY([FreightHeadID])
REFERENCES [dbo].[FreightHead] ([FreightHeadID])
GO
ALTER TABLE [dbo].[FreightHeadShipmentRate] CHECK CONSTRAINT [FK_FreightHeadShipmentRate_FreightHead]
GO

CREATE TRIGGER [dbo].[tg_project_master]
 ON [dbo].[FreightHead]
 AFTER INSERT
 AS
 BEGIN

  SET NOCOUNT ON;
 
       DECLARE @CustomerId VARCHAR(200)
 
       SELECT @CustomerId = INSERTED.FreightHeadID       
       FROM INSERTED

	   UPDATE FreightHead
		SET FHNumber = 'FHN00'+@CustomerId

		Where FreightHeadID = @CustomerId
       --INSERT INTO FreightHead(FHNumber)
       --VALUES('FHN00'+@CustomerId)

		-- TRUNCATE TABLE FreightHead

		-- DROP TABLE FreightHead
		-- DROP TABLE[dbo].[FreightHeadServices]
		-- DROP TABLE [dbo].[FreightHeadShipmentRate]
END;
GO

ALTER TABLE [dbo].[FreightHead] ENABLE TRIGGER [tg_project_master]
GO


