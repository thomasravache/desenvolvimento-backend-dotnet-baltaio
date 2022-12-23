CREATE TABLE [Author]
(
  [Id] UNIQUEIDENTIFIER NOT NULL,
  [Name] NVARCHAR(80) NOT NULL,
  [Title] NVARCHAR(80) NOT NULL,
  [Image] NVARCHAR(1024) NOT NULL,
  [Bio] NVARCHAR(2000) NOT NULL,
  [Url] NVARCHAR(450) NULL,
  [Email] NVARCHAR(160) NOT NULL,
  [Type] TINYINT NOT NULL,
  -- de 0 a 255

  CONSTRAINT [PK_Author] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Career]
(
  [Id] UNIQUEIDENTIFIER NOT NULL,
  [Title] NVARCHAR(160) NOT NULL,
  [Summary] NVARCHAR(2000) NOT NULL,
  [Url] NVARCHAR(1024) NOT NULL,
  [DurationInMinutes] INT NOT NULL,
  [Active] BIT NOT NULL,
  [Featured] BIT NOT NULL,
  [Tags] NVARCHAR(160) NOT NULL,

  CONSTRAINT [PK_Career] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Category]
(
  [Id] UNIQUEIDENTIFIER NOT NULL,
  [Title] NVARCHAR(160) NOT NULL,
  [Url] NVARCHAR(1024) NOT NULL,
  [Summary] NVARCHAR(2000) NOT NULL,
  [Order] INT NOT NULL,
  [Description] TEXT NOT NULL,
  [Featured] BIT NOT NULL,

  CONSTRAINT [PK_Category] PRIMARY KEY ([Id])
)
GO

CREATE TABLE [Course]
(
  [Id] UNIQUEIDENTIFIER NOT NULL,
  [Tag] NVARCHAR(20) NOT NULL,
  [Title] NVARCHAR(160) NOT NULL,
  [Summary] NVARCHAR(2000) NOT NULL,
  [Url] NVARCHAR(1024) NOT NULL,
  [Level] TINYINT NOT NULL,
  [DurationInMinutes] INT NOT NULL,
  [CreateDate] DATETIME NOT NULL,
  [LastUpdateDate] DATETIME NOT NULL,
  [Active] BIT NOT NULL,
  [Free] BIT NOT NULL,
  [Featured] BIT NOT NULL,
  [AuthorId] UNIQUEIDENTIFIER NOT NULL,
  [CategoryId] UNIQUEIDENTIFIER NOT NULL,
  [Tags] NVARCHAR(160) NOT NULL,

  CONSTRAINT [PK_Course] PRIMARY KEY ([Id]),
  CONSTRAINT [FK_Course_Author_AuthorId] FOREIGN KEY ([AuthorId]) REFERENCES [Author] ([Id]) ON DELETE NO ACTION,
  CONSTRAINT [FK_Course_Category_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Category] ([Id]) ON DELETE NO ACTION
)
GO

-- ON DELETE NO ACTION
  -- Quando deletar um curso não deletar também os autores ou categorias vinculadas
-- ON DELETE CASCADE
  -- Quando deletar um curso deleta as referências também