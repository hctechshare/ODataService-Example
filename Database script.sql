CREATE TABLE Customer (
	[CustomerID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NULL,
	[LastName] [varchar](50) NULL,
	[Phone] [varchar](50) NULL,
	[Address] [varchar](100) NULL,
	[City] [varchar](50) NULL,
	[State] [varchar](2) NULL,
	[Zip] [varchar](5) NULL,
	CONSTRAINT [PK_Customer] PRIMARY KEY ([CustomerID])
)
GO

CREATE TABLE CSAOrder (
    [OrderNumber] [int] IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[FullSeasonCSA] [bit] NULL,
	[MeatAddOn] [bit] NULL,
	[HardCiderAddOn] [bit] NULL,
	[Fruit] [bit] NULL
	CONSTRAINT [PK_Order] PRIMARY KEY ([OrderNumber]),	
	CONSTRAINT [FK_Order_Customer] FOREIGN KEY ([CustomerID]) REFERENCES [Customer]([CustomerID])
)
GO

CREATE TABLE Feedback (
    [FeedbackID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[Feedback] [text] NULL
    CONSTRAINT [PK_Feedback] PRIMARY KEY ([FeedbackID]),
)
GO