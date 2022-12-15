SELECT TOP 100
  *
FROM
  [Curso]
WHERE
  [Nome] LIKE '%Fundamentos%'

  -- Ex: '%Teste' -> Termina com Teste
  -- Ex: 'Teste%' -> Começa com Teste
  -- Ex: '%Teste%' -> Contém Teste