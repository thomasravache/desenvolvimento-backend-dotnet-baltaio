SELECT *
FROM [Student]
SELECT *
FROM [StudentCourse]

SELECT
  [Id],
  [Title]
FROM
  [Course]
WHERE
    [Title] LIKE 'Fundamentos do Git%'

DECLARE @studentId UNIQUEIDENTIFIER = NEWID()

INSERT INTO
    [Student]
  ([Id], [Name], [Email], [Document], [Phone], [Birthdate], [CreateDate])
VALUES
  (@studentId, 'Thomas Ravache', 'thomasravache@gmail.com', '12345678901', '11944484544', '1998-07-27 00:00:00', GETDATE())

INSERT INTO
    [StudentCourse]
  ([CourseId], [StudentId], [Progress], [Favorite], [StartDate], [LastUpdateDate])
VALUES
  ('5f5a33f8-4ff3-7e10-cc6e-3fa000000000', '2d4c3303-b8a2-4e87-83b3-93b613de317e', 50, 0, '2020-01-13 12:35:54', GETDATE())