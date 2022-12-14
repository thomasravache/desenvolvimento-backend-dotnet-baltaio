USE [Curso]

DROP TABLE [Aluno]


-- não permite que 2 ids sejam iguais
CREATE TABLE [Aluno]
(
  [Id] INT NOT NULL UNIQUE,
  [Nome] NVARCHAR(80) NOT NULL,
  [Email] NVARCHAR(180) NOT NULL UNIQUE,
  [Nascimento] DATETIME DEFAULT(GETDATE()),
  [Active] BIT NOT NULL DEFAULT(0),
)
GO

-- converter valor null pra not null quando já tem registro
ALTER TABLE [Aluno]
  ALTER COLUMN [Active] BIT NOT NULL