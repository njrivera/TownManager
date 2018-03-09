CREATE TABLE [dbo].[Dood] (
    [Id]         INT           IDENTITY (1, 1) NOT NULL,
    [First Name] NVARCHAR (50) NOT NULL,
    [Last Name]  NVARCHAR (50) NOT NULL,
    [Age]        INT           NOT NULL,
    [Gender]     INT           NOT NULL,
    [Spouse] NVARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

