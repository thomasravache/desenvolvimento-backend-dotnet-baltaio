INSERT INTO
  [Categoria]
  ([Nome])
VALUES
  ('Backend'),
  ('Frontend'),
  ('Mobile');

SELECT *
FROM [Categoria]

INSERT INTO
  [Curso]
  ([Nome], [CategoriaId])
VALUES
  ('Fundamentos de C#', 1),
  ('Fundamentos OOP', 1),
  ('Fundamentos de Angular', 2),
  ('Flutter', 3)