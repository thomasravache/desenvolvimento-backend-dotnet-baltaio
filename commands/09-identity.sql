USE [Curso]

CREATE INDEX [IX_Aluno_Email] ON [Aluno]([Email])
-- criar indice pro e-mail da tabela aluno
DROP INDEX [IX_Aluno_Email] ON [Aluno]
-- remover indice pro e-mail da tabela aluno

CREATE TABLE [Aluno]
(
  [Id] INT NOT NULL,
  [Nome] NVARCHAR(80) NOT NULL,
  [Email] NVARCHAR(180) NOT NULL UNIQUE,
  [Nascimento] DATETIME DEFAULT(GETDATE()),
  [Active] BIT NOT NULL DEFAULT(0),

  CONSTRAINT [PK_Aluno] PRIMARY KEY([Id]),
  CONSTRAINT [UQ_Aluno_Email] UNIQUE([Email])
)
GO

-- IDENTITY(1, 1) incrementa o id de um em um
DROP TABLE [Curso]
CREATE TABLE [Curso]
(
  [Id] INT NOT NULL IDENTITY(1, 1),
  [Nome] NVARCHAR(80) NOT NULL,
  [CategoriaId] INT NOT NULL,

  CONSTRAINT [PK_Curso] PRIMARY KEY([Id]),
  CONSTRAINT [FK_Curso_Categoria] FOREIGN KEY([CategoriaId])
    REFERENCES [Categoria]([Id])
)
GO

CREATE TABLE [Categoria]
(
  [Id] INT NOT NULL,
  [Nome] NVARCHAR(80) NOT NULL,

  CONSTRAINT [PK_Categoria] PRIMARY KEY([Id])
)
GO

CREATE TABLE [ProgressoCurso]
(
  [AlunoId] INT NOT NULL,
  [CursoId] INT NOT NULL,
  [Progresso] INT NOT NULL,
  [UltimaAtualizacao] DATETIME NOT NULL DEFAULT(GETDATE()),

  CONSTRAINT [PK_ProgressoCurso] PRIMARY KEY([AlunoId], [CursoId])
)
GO