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

-- WHERE não funciona depois do GROUP BY, mas tem o HAVING (contendo)
  -- utilizar os ALIAS dentro dele também não dá