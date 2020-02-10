CREATE TABLE [dbo].[tblCustomer]
(
	[CustomerID] INT NOT NULL IDENTITY , 
    [BankID] INT NULL, 
    [Name] VARCHAR(50) NULL, 
    [DateCreated] DATE NULL, 
    [Account] BIT NULL, 
    [Balance] MONEY NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([CustomerID]) 
)
