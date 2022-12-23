CREATE OR ALTER VIEW vwContagemCursosPorCategoria
AS
  SELECT TOP 100
    [Categoria].[Id],
    [Categoria].[Nome],
    COUNT([Curso].[CategoriaId]) AS [Cursos]
  FROM
    [Categoria]
    INNER JOIN [Curso] ON [Curso].[CategoriaId] = [Categoria].[Id]
  GROUP BY
    [Categoria].[Id],
    [Categoria].[Nome],
    [Curso].[CategoriaId]
  HAVING
    COUNT([Curso].[CategoriaId]) = 2
GO

-- utilizar VIEW como se fosse uma tabela

SELECT *
FROM vwContagemCursosPorCategoria
WHERE [Cursos] = 2

-- VIEW é uma foto de um select existente
  -- CREATE apenas cria a VIEW
  -- CREATE OR ALTER verifica se já existe, se já existir sobrescreve, se não existir, cria.
  -- NÃO é possível criar VIEWS com ORDER BY