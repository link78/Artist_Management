CREATE TABLE [dbo].[Review] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ArtistId]   INT            NOT NULL,
    [Body]       NVARCHAR (MAX) NULL,
    [Rating]     INT            NOT NULL,
    [ReviewName] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_Review] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Review_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [dbo].[Artists] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_Review_ArtistId]
    ON [dbo].[Review]([ArtistId] ASC);

