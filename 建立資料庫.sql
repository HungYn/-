--�q�LDLL,�ƾکw�q�y���ӫإ߼ƾڮw�C(���T��,CREATE,ALTER,DROP �y�k�c��)
--1.�Ĥ@�B������t�μƾڮwmaster�̭��h
use master
GO
--2.�ĤG�B�}�l��CREATE ����r�ӫإ߸�Ʈw
--3.�b�Ыؼƾڮw�W�٤��e�ݭn�P�_�ӦW�٪��ƾڮw�O�_�v�g�s�b
IF EXISTS(SELECT * FROM master.dbo.sysdatabases WHERE name='TestData')
	BEGIN
		PRINT N'�ƾڮw�v�g�s�b'
	END
ELSE
	BEGIN
		CREATE DATABASE TestData
		ON PRIMARY
		(
			Name='TestData_Data',--�D�ƾڮw���޿�W��
			FileName='C:\Users\diy\TestData_Data.mdf',----�D�ƾڮw�����z�W��
			Size=10MB,---�D�ƾڮw����l��
			MaxSize=6000MB,--�D�ƾڮw���̤j��
			FileGrowth=2%--�D�ƾڮw���W���v
		)
		LOG ON
		(
			Name='TestData_Log',--�D�ƾڮw��x���޿�W��
			FileName='C:\Users\diy\TestData_Log.ldf',--�D�ƾڮw��x�����z�W��
			Size=10MB,--�D�ƾڮw��x����l��
			MaxSize=20MB,--�D�ƾڮw��x���̤j��
			FileGrowth=1MB--�D�ƾڮw��x���W���v
		)
	END
GO


--�b�Ыطs���ǥͥΤ�H�����ɭ�,�ڭ̭n���D,�Ӿǥͦ����ǫH���r�q
USE TestData
GO

IF EXISTS(SELECT * FROM sysobjects WHERE name='Admin')
	BEGIN
		DROP TABLE Admin
		PRINT '��R�����\'
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
	PRINT '��Ыئ��\'
GO

--�ϥ�DML �y���i�洡�J�ƾ�
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

--�b�Ыطs���ǥͥΤ�H�����ɭ�,�ڭ̭n���D,�Ӿǥͦ����ǫH���r�q
USE TestData
GO

CREATE TABLE Grade
(
	GradeId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	GradeName VARCHAR(50) NOT NULL,
)
GO

INSERT INTO	Grade (GradeName) VALUES (N'�@�~��')

Select * from Grade