--Stored Procedure
--1. Parametr kimi gonderilen ededin faktorialin hesablayan "Factorial" SP yaradin (5! = 1*2*3*4*5 = 120)
--(0! = 1) (nezere alin ki, menfi ededin faktoriali olmur).

CREATE PROCEDURE Factorial
    @Number INT,            
    @Result BIGINT OUTPUT  
AS
BEGIN
    IF @Number < 0
    BEGIN
        SET @Result = NULL
        RAISERROR('Factorial of a negative number does not exist.', 16, 1)
        RETURN
    END

    SET @Result = 1
    
    WHILE @Number > 0
    BEGIN
        SET @Result = @Result * @Number
        SET @Number = @Number - 1
    END
END
GO

DECLARE @FactorialResult BIGINT

EXEC Factorial @Number = 5, @Result = @FactorialResult OUTPUT

SELECT @FactorialResult AS Output








--2. "LazyStudents" SP yaradin. SP hech vaxt kitabxanadan kitab goturmeyen
-- telebelerin siyahisini gosterir ve output parametr olaraq bele telebelerin sayini qaytarir

CREATE PROCEDURE LazyStudents
AS
BEGIN
    SELECT s.Id, s.FirstName, s.LastName
    FROM Students s
    LEFT JOIN S_Cards b ON s.Id = b.Id
    WHERE b.Id IS NULL;

    SELECT COUNT(*) AS NumberOfLazyStudents
    FROM Students s
    LEFT JOIN S_Cards b ON s.Id = b.Id
    WHERE b.Id IS NULL;
END;

EXEC LazyStudents;






--UDF
--1. Neshriyatlar ve onlarin minimal sehifeye malik kitablarinin
--siyahisini qaytaran funksiya yazin.

CREATE FUNCTION GetPublishersWithMinPageBooks()
RETURNS TABLE
AS
RETURN
(
    WITH MinPagesPerPress AS
    (
        SELECT 
            p.Name,
            MIN(b.Pages) AS MinPages
        FROM 
            Press p
        JOIN 
            Books b ON p.Id = b.Id
        GROUP BY 
            p.Name
    )
    SELECT 
        p.Name AS PressName,
        b.Name AS BookName,
        b.Pages AS BookPage
    FROM 
        MinPagesPerPress m
    JOIN 
        Press p ON p.Name = m.Name
    JOIN 
        Books b ON p.Id = b.Id AND b.Pages = m.MinPages
);


SELECT * FROM dbo.GetPublishersWithMinPageBooks();





--2. Chap etdiyi kitablarin Sehifelerinin ededi ortasi N-den chox olan 
--neshriyatlarin adini qaytaran funksiya yazin. N funksiyaya parametr kimi gonderilmelidir.

CREATE FUNCTION GetPressWithAvgPagesGreaterThan(@N INT)
RETURNS TABLE
AS
RETURN
(
    WITH AvgPagesPerPress AS
    (
        SELECT 
            p.Id,
            p.Name,
            AVG(b.Pages) AS AvgPages
        FROM 
            Press p
        JOIN 
            Books b ON p.Id = b.Id
        GROUP BY 
            p.Id, p.Name
    )
    SELECT 
        Name
    FROM 
        AvgPagesPerPress
    WHERE 
        AvgPages > @N
);


SELECT * FROM dbo.GetPressWithAvgPagesGreaterThan(100);

