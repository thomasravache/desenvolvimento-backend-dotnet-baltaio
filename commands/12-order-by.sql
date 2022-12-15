USE [Cursos]

SELECT TOP 100
  [Id], [Nome], [CategoriaId]
FROM
  [Curso]
-- WHERE
--   [Id] = 1
ORDER BY
  [Nome], [CategoriaId] -- ASC é o padrao se quiser descendente usar DESC