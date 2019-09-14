USE daomtthuan_TaskManager;
GO

CREATE TABLE Roll
(
    Id INT IDENTITY(-1, 1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL UNIQUE,
    Level INT NOT NULL
);
GO

CREATE TABLE GroupRoll
(
    Id INT IDENTITY(0, -1) PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL UNIQUE
);
GO

CREATE TABLE Employee
(
    Id INT IDENTITY PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    RollId INT NOT NULL REFERENCES Roll (Id),
    Phone VARCHAR(20),
    Email VARCHAR(100)
);
GO

CREATE TABLE Account
(
    Id INT NOT NULL REFERENCES Employee (Id) PRIMARY KEY,
    Username VARCHAR(100) NOT NULL UNIQUE,
    Password VARCHAR(250) NOT NULL DEFAULT '1962026656160185351301320480154111117132155',
);
GO

CREATE TABLE Task
(
    Id INT IDENTITY PRIMARY KEY,
    ObjectId INT NOT NULL,
    Time DATETIME NOT NULL,
    Location NVARCHAR(250),
    Content NVARCHAR(500),
    Note NVARCHAR(250)
);
GO

---------------------------------------------
CREATE INDEX indexTaskTime
ON Task (Time);
GO

---------------------------------------------
CREATE VIEW viewEmployee
AS(
SELECT e.Id, e.Name, e.RollId, r.Name AS RollName, r.Level AS RollLevel, e.Phone, e.Email
FROM Employee AS e
    JOIN Roll AS r ON r.Id = e.RollId);
GO

CREATE VIEW viewTask
AS(
SELECT t.Id, t.ObjectId, e.Name, r.Id AS RollId, r.Name AS RollName, t.Time, t.Location, t.Content, t.Note
FROM Task AS t
    JOIN Employee AS e ON e.Id = t.ObjectId
    JOIN Roll AS r ON r.Id = e.RollId
UNION
SELECT t.Id, t.ObjectId, g.Name, NULL AS RollId, NULL AS RollName, t.Time, t.Location, t.Content, t.Note
FROM Task AS t
    JOIN GroupRoll AS g ON g.Id = t.ObjectId);
GO

CREATE VIEW viewEmployeeWithAccount
AS(
SELECT e.Id, a.Username, e.Name, e.RollId, e.RollName, e.RollLevel, e.Phone, e.Email
FROM viewEmployee AS e
    LEFT OUTER JOIN Account AS a ON a.Id = e.Id);
GO

----------------------------------------------
CREATE TRIGGER trigDeleteRoll
ON Roll
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @RollId INT = (SELECT Id FROM Deleted);
    IF (SELECT COUNT(Id) FROM Employee WHERE RollId = @RollId) > 0 BEGIN
        UPDATE Employee
        SET RollId = 0
        WHERE RollId = @RollId;
        SELECT 0;
    END;
    ELSE
        SELECT 1;
    DELETE Roll
    WHERE Id = @RollId;
END;
GO

CREATE TRIGGER trigDeleteGroupRoll
ON GroupRoll
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @GroupId INT = (SELECT Id FROM Deleted);
    IF (SELECT COUNT(Id) FROM Task WHERE ObjectId = @GroupId) > 0 BEGIN
        UPDATE Task
        SET ObjectId = 0
        WHERE ObjectId = @GroupId;
        SELECT 0;
    END;
    ELSE
        SELECT 1;
    DELETE GroupRoll
    WHERE Id = @GroupId;
END;
GO

CREATE TRIGGER trigDeleteEmployee
ON Employee
INSTEAD OF DELETE
AS
BEGIN
    DECLARE @Id INT = (SELECT Id FROM Deleted);
    IF (SELECT COUNT(Id) FROM Task WHERE ObjectId = @Id) = 0 BEGIN
        DELETE Account
        WHERE Id = @Id;
        DELETE Employee
        WHERE Id = @Id;
        SELECT 1;
    END;
    ELSE BEGIN
        UPDATE Employee
        SET RollId = -1
        WHERE Id = @Id;
        SELECT 0;
    END;
END;
GO

CREATE TRIGGER trigInsertTask
ON Task
FOR INSERT
AS
BEGIN
    DECLARE @ObjectId INT = (SELECT ObjectId FROM Inserted);
    IF @ObjectId NOT IN (SELECT Id FROM Employee UNION SELECT Id FROM GroupRoll) BEGIN
        ROLLBACK;
    END;
END;
GO

----------------------------------------------
CREATE PROC procRefresh @Id INT
AS BEGIN
    SELECT a.Id, a.Username, e.Name, e.RollId, r.Name AS RollName, r.Level AS RollLevel, e.Phone, e.Email
    FROM Account AS a
        JOIN Employee AS e ON e.Id = a.Id
        JOIN Roll AS r ON r.Id = e.RollId
    WHERE a.Id = @Id;
END;
GO

CREATE PROC procLogin
@Username VARCHAR(100), @Password VARCHAR(250)
AS BEGIN
    SELECT a.Id, a.Username, e.Name, e.RollId, r.Name AS RollName, r.Level AS RollLevel, e.Phone, e.Email
    FROM Account AS a
        JOIN Employee AS e ON e.Id = a.Id
        JOIN Roll AS r ON r.Id = e.RollId
    WHERE a.Username = @Username AND
          a.Password = @Password;
END;
GO

CREATE PROC procInsertAccount
@Id INT, @Username VARCHAR(100)
AS BEGIN
    IF (SELECT COUNT(Id) FROM Account WHERE Username = @Username) = 0 BEGIN
        INSERT Account (Id, Username)
        VALUES (@Id, @Username);
        SELECT 1;
    END;
    ELSE
        SELECT 0;
END;
GO

CREATE PROC procChangePassword
@Id INT, @OldPassword VARCHAR(250), @NewPassword VARCHAR(250)
AS BEGIN
    IF (SELECT Id FROM Account WHERE Id = @Id AND Password = @OldPassword) IS NULL
        SELECT 0;
    ELSE BEGIN
        UPDATE Account
        SET Password = @NewPassword
        WHERE Id = @Id AND
              Password = @OldPassword;
        SELECT 1;
    END;

END;
GO

CREATE PROC procInsertRoll
@Name NVARCHAR(100), @Level INT
AS BEGIN
    IF (SELECT COUNT(Id) FROM Roll WHERE Name = @Name) = 0 BEGIN
        INSERT Roll
        VALUES (@Name, @Level);
        SELECT 1;
    END;
    ELSE
        SELECT 0;
END;
GO

CREATE PROC procUpdateRoll
@Id INT, @Name NVARCHAR(100), @Level INT
AS BEGIN
    IF (SELECT COUNT(Id) FROM Roll WHERE Id != @Id AND Name = @Name) = 0 BEGIN
        UPDATE Roll
        SET Name = @Name, Level = @Level
        WHERE Id = @Id;
        SELECT 1;
    END;
    ELSE
        SELECT 0;
END;
GO

CREATE PROC procInsertGroupRoll @Name NVARCHAR(100)
AS BEGIN
    IF (SELECT COUNT(Id) FROM GroupRoll WHERE Name = @Name) = 0 BEGIN
        INSERT GroupRoll
        VALUES (@Name);
        SELECT 1;
    END;
    ELSE
        SELECT 0;
END;
GO

CREATE PROC procUpdateGroupRoll
@Id INT, @Name NVARCHAR(100)
AS BEGIN
    IF (SELECT COUNT(Id) FROM GroupRoll WHERE Id != @Id AND Name = @Name) = 0 BEGIN
        UPDATE GroupRoll
        SET Name = @Name
        WHERE Id = @Id;
        SELECT 1;
    END;
    ELSE
        SELECT 0;
END;
GO

CREATE PROC procInsertEmployee
@Name NVARCHAR(100), @RollId INT, @Phone VARCHAR(20), @Email VARCHAR(100)
AS BEGIN
    INSERT Employee
    VALUES (@Name, @RollId, NULLIF(@Phone, ''), NULLIF(@Email, ''));
END;
GO

CREATE PROC procUpdateEmployee
@Id INT, @Name NVARCHAR(100), @RollId INT, @Phone VARCHAR(20), @Email VARCHAR(100)
AS BEGIN
    UPDATE Employee
    SET Name = @Name, RollId = @RollId, Phone = NULLIF(@Phone, ''), Email = NULLIF(@Email, '')
    WHERE Id = @Id;
END;
GO

CREATE PROC procInsertTask
@ObjectId INT, @Time DATETIME, @Location NVARCHAR(250), @Content NVARCHAR(500), @Note NVARCHAR(250)
AS BEGIN
    INSERT Task
    VALUES (@ObjectId, @Time, NULLIF(@Location, ''), NULLIF(@Content, ''), NULLIF(@Note, ''));
END;
GO

CREATE PROC procUpdateTask
@Id INT, @ObjectId INT, @Time DATETIME, @Location NVARCHAR(250), @Content NVARCHAR(500), @Note NVARCHAR(250)
AS BEGIN
    UPDATE Task
    SET ObjectId = @ObjectId, Time = @Time, Location = NULLIF(@Location, ''), Content = NULLIF(@Content, ''), Note = NULLIF(@Note, '')
    WHERE Id = @Id;
END;
GO

----------------------------------------------
INSERT Roll
VALUES (N'Nghỉ việc', -1);
INSERT Roll
VALUES (N'Chưa có chức vụ', 0);
GO

INSERT Employee
VALUES (N'Đào Minh Trung Thuận', 0, '0939908568', 'dao.mt.thuan@gmail.com');
INSERT Account
VALUES (1, 'admin', '33354741122871651676713774147412831195');
GO

INSERT GroupRoll
VALUES (N'Nhóm chưa có tên');
GO