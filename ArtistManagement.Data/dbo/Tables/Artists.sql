CREATE TABLE [dbo].[Artists] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [City]        NVARCHAR (50)  NOT NULL,
    [Country]     NVARCHAR (50)  NOT NULL,
    [CreatedDate] DATETIME2 (7)  NOT NULL,
    [Provence]    NVARCHAR (50)  NOT NULL,
    [UserName]    NVARCHAR (50)  NOT NULL,
    [WebSite]     NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Artists] PRIMARY KEY CLUSTERED ([Id] ASC)
);

