USE [Cursos]

  SELECT TOP 100
    [Id], [Nome]
  FROM
    [Curso]

UNION

  SELECT TOP 100
    [Id], [Nome]
  FROM
    [Categoria]

  -- UNION = une duas tabelas de acordo com o nome das colunas
  -- UNION ALL = executa como se fosse um select DISTINCT (evita os duplicados)