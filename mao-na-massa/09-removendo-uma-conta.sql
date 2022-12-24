CREATE OR ALTER PROCEDURE spDeleteStudent
  (@studentId UNIQUEIDENTIFIER)
AS
BEGIN TRANSACTION

DELETE FROM 
            [StudentCourse]
        WHERE
            [StudentId] = @StudentId

DELETE FROM
            [Student]
        WHERE
            [Id] = @StudentId

COMMIT
GO