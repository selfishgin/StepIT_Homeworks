/*
-- 1.
CREATE DATABASE Teachers;
GO

USE Teachers;
GO

*/



CREATE TABLE POSTS (
    Id INT PRIMARY KEY,
    Name NVARCHAR(20)
);
GO

CREATE TABLE TEACHERS (
    Id INT PRIMARY KEY,
    Name NVARCHAR(15),
    Code CHAR(10),
    IdPost INT FOREIGN KEY REFERENCES POSTS(Id),
    Tel CHAR(7),
    Salary INT,
    Rise NUMERIC(6,2),
    HireDate DATETIME
);
GO


-- 2.
DROP TABLE POSTS;
GO


-- 3.
ALTER TABLE TEACHERS
DROP COLUMN IdPost;
GO


-- 4.
ALTER TABLE TEACHERS
ADD CONSTRAINT CHK_HireDate CHECK (HireDate >= '1990-01-01');
GO


-- 5.
ALTER TABLE TEACHERS
ADD CONSTRAINT UQ_Code UNIQUE (Code);
GO


-- 6.
ALTER TABLE TEACHERS
ALTER COLUMN Salary NUMERIC(6,2);
GO


-- 7.
ALTER TABLE TEACHERS
ADD CONSTRAINT CHK_Salary CHECK (Salary >= 1000 AND Salary <= 5000);
GO


-- 8.
EXEC sp_rename 'TEACHERS.Tel', 'Phone', 'COLUMN';
GO


-- 9.
ALTER TABLE TEACHERS
ALTER COLUMN Phone CHAR(11);
GO


-- 10.
CREATE TABLE POSTS (
    Id INT PRIMARY KEY,
    Name NVARCHAR(20)
);
GO


-- 11.
ALTER TABLE POSTS
ADD CONSTRAINT CHK_PostsName CHECK (Name IN (N'Professor', N'Docent', N'Teacher', N'Assistant'));
GO


-- 12.
ALTER TABLE TEACHERS
ADD CONSTRAINT CHK_TeachersName CHECK (Name NOT LIKE '%[0-9]%');
GO


-- 13.
ALTER TABLE TEACHERS
ADD IdPost INT;
GO


-- 14.
ALTER TABLE TEACHERS
ADD CONSTRAINT FK_IdPost FOREIGN KEY (IdPost) REFERENCES POSTS(Id);
GO


-- 15.
INSERT INTO POSTS (Id, Name)   
VALUES 
(1, N'Professor'), 
(2, N'Docent'), 
(3, N'Teacher'), 
(4, N'Assistant');
GO

INSERT INTO TEACHERS (Id, Name, Code, IdPost, Phone, Salary, Rise, HireDate)   
VALUES 
(1, N'Sidorov', '0123456789', 1, NULL, 1070.00, 470.00, '1992-09-01'),   
(2, N'Ramishevsky', '4567890123', 2, '4567890', 1110.00, 370.00, '1998-09-09'),   
(3, N'Horenko', '1234567890', 3, NULL, 2000.00, 230.00, '2001-10-10'),   
(4, N'Vibrovsky', '2345678901', 4, NULL, 4000.00, 170.00, '2003-09-01'),   
(5, N'Voropaev', NULL, 4, NULL, 1500.00, 150.00, '2002-09-02'),   
(6, N'Kuzintsev', '5678901234', 3, '4567890', 3000.00, 270.00, '1991-01-01');
GO
