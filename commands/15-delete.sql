USE [Cursos]

SELECT
  *
FROM
  [Categoria]

BEGIN TRANSACTION
-- só deletar a categoria não funciona porque
-- as categorias referenciam cursos, tendo que primeiro
-- remover as dependencias antes de deletar
DELETE FROM
  [Curso]
WHERE
  [CategoriaId] = 3

DELETE FROM
  [Categoria]
WHERE
  [Id] = 3

ROLLBACK -- Pra desfazer
-- COMMIT Confirmar ação