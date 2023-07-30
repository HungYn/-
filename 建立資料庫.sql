--通過DLL,數據定義語言來建立數據庫。(有三個,CREATE,ALTER,DROP 語法構成)
--1.第一步切換到系統數據庫master裡面去
use master
GO
--2.第二步開始用CREATE 關鍵字來建立資料庫
--3.在創建數據庫名稱之前需要判斷該名稱的數據庫是否己經存在
IF EXISTS(SELECT * FROM master.dbo.sysdatabases WHERE name='TestData')
	BEGIN
		PRINT N'數據庫己經存在'
	END
ELSE
	BEGIN
		CREATE DATABASE TestData
		ON PRIMARY
		(
			Name='TestData_Data',--主數據庫的邏輯名稱
			FileName='C:\Users\diy\TestData_Data.mdf',----主數據庫的物理名稱
			Size=10MB,---主數據庫的初始值
			MaxSize=6000MB,--主數據庫的最大值
			FileGrowth=2%--主數據庫的增長率
		)
		LOG ON
		(
			Name='TestData_Log',--主數據庫日誌的邏輯名稱
			FileName='C:\Users\diy\TestData_Log.ldf',--主數據庫日誌的物理名稱
			Size=10MB,--主數據庫日誌的初始值
			MaxSize=20MB,--主數據庫日誌的最大值
			FileGrowth=1MB--主數據庫日誌的增長率
		)
	END
GO


--在創建新的學生用戶信息的時候,我們要知道,該學生有哪些信息字段
USE TestData
GO

IF EXISTS(SELECT * FROM sysobjects WHERE name='Admin')
	BEGIN
		DROP TABLE Admin
		PRINT '表刪除成功'
	END
ELSE
	BEGIN
		CREATE TABLE Admin
		(
			Id INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
			LoginId VARCHAR (50) NOT NULL,
			LoginPwd VARCHAR (50) NOT NULL,
		)
	END
	PRINT '表創建成功'
GO

--使用DML 語言進行插入數據
INSERT INTO Admin (LoginId,LoginPwd) VALUES ('admin','123456')

SELECT * FROM Admin ORDER BY LoginId ASC

CREATE TABLE Student
(
	StudentNo INT NOT NULL PRIMARY KEY,
	LoginPwd VARCHAR(50) NOT NULL,
	StudentName VARCHAR(50) NOT NULL,
	Gender BIT NOT NULL DEFAULT(1),
	GradeId SMALLINT NOT NULL,
	Phome VARCHAR(20),
	Address VARCHAR(255) ,
	BornDate DATETIME NOT NULL,
	Email VARCHAR(50),
	IdentityCard  VARCHAR(18)
)
GO

--在創建新的學生用戶信息的時候,我們要知道,該學生有哪些信息字段
USE TestData
GO

CREATE TABLE Grade
(
	GradeId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GradeName VARCHAR(50) NOT NULL,
)
GO

INSERT INTO	Grade (GradeName) VALUES (N'一年級')

Select * from Grade