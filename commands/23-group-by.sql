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

-- GROUP BY = Agrupar informações com base em determinada coluna (ex: [Curso].[CategoriaId])

-- Exs:
  -- Utilizado para contar itens de um pedido
  -- Quantos cursos em uma categoria X