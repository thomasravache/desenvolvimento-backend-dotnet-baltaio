USE [Curso]

DROP TABLE [Aluno]

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

-- adicionar primary key se esquecer
ALTER TABLE [Aluno]
  ADD PRIMARY KEY([Id])


-- remover constraint (primary key por exemplo)
ALTER TABLE [Aluno]
  DROP CONSTRAINT [PK_Aluno]