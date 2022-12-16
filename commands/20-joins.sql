USE [Cursos]

SELECT TOP 100
  [c].[Id],
  [c].[Nome],
  [ct].[Nome] AS [Nome Categoria]
FROM
  [Curso] AS [c]
  INNER JOIN [Categoria] AS [ct] ON [ct].Id = [c].[CategoriaId]

-- INNER JOIN = Tudo dos cursos que TAMBÉM esteja na categoria