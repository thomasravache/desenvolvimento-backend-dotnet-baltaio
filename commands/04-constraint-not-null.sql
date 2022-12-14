USE [Curso]

DROP TABLE [Aluno]

CREATE TABLE [Aluno]
(
  [Id] INT NOT NULL,
  [Nome] NVARCHAR(80) NOT NULL,
  [Nascimento] DATETIME DEFAULT(GETDATE()),
  [Active] BIT NOT NULL DEFAULT(0),
)
GO

-- converter valor null pra not null quando já tem registro
ALTER TABLE [Aluno]
  ALTER COLUMN [Active] BIT NOT NULL