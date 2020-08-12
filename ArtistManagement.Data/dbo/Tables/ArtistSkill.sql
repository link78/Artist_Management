CREATE TABLE [dbo].[ArtistSkill] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [ArtistId]   INT            NOT NULL,
    [Details]    NVARCHAR (255) NULL,
    [SkillLevel] INT            NOT NULL,
    [Styles]     NVARCHAR (255) NULL,
    [TalentName] NVARCHAR (50)  NOT NULL,
    CONSTRAINT [PK_ArtistSkill] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ArtistSkill_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [dbo].[Artists] ([Id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_ArtistSkill_ArtistId]
    ON [dbo].[ArtistSkill]([ArtistId] ASC);

