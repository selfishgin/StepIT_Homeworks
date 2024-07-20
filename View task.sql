--Teacher Post cedvelleri yaratdiqimiz tapshiriq ucucn ashaqida gosterilen view-lari yaradin:
--16.1. All job titles.
CREATE VIEW AllJobTitles AS
SELECT Name
FROM POSTS;
GO

SELECT * FROM AllJobTitles
GO
--16.2. All the names of teachers.
CREATE VIEW AllTeacherNames AS
SELECT Name
FROM TEACHERS;
GO

SELECT * FROM AllTeacherNames

