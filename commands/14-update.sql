SELECT
  *
FROM
  [Categoria]

BEGIN TRANSACTION

UPDATE
    [Categoria]
  SET
    [Nome] = 'Backend'
  WHERE
    [Id] = 1

ROLLBACK -- Pra desfazer
-- COMMIT Confirmar ação