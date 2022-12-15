-- Trazer resultados limitando quantidade de linhas com TOP
SELECT TOP 100
  [Id], [Nome]
FROM
  [Categoria]

-- Usar o DISTINCT para trazer resultados distintos
SELECT DISTINCT TOP 100
  [Id], [Nome]
FROM
  [Categoria]

