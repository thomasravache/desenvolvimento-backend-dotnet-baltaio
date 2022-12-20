USE [Cursos]

SELECT TOP 100
  [c].[Id],
  [c].[Nome],
  [ct].[Nome] AS [Nome Categoria]
FROM
  [Curso] AS [c]
  LEFT JOIN [Categoria] AS [ct] ON [ct].Id = [c].[CategoriaId]

-- LEFT JOIN = Pega todos os itens da PRIMEIRA tabela
  -- No caso, trás tudo de cursos, e se em alguma linha a categoria não existir, vai trazer as colunas relacionadas a categoria como NULO

-- RIGHT JOIN = Mesma coisa, porém aplicado a SEGUNDA TABELA
  -- No caso, trás tudo de categorias, e se alguma linha de cursos não existir correlação, vai trazer as colunas relacionadas aos cursos como NULO

-- FULL OUTER JOIN ou apenas FULL JOIN = Executa tanto do LEFT como do RIGHT, irá trazer todos os cursos e todas as categorias
  -- No caso, se tiver algum curso sem categoria ele será listado e vice-versa

