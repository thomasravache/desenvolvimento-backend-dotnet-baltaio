USE [Cursos]

SELECT TOP 100
  [Id], [Nome], [CategoriaId]
FROM
  [Curso]
WHERE
  [Id] = 1 AND
  [CategoriaId] = 1

-- comparadores: <, <=, >=, =, IS, IS NOT
-- operadores: AND, OR
