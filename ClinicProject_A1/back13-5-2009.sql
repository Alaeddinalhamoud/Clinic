USE [CLINICDB]
GO
/****** Object:  Table [dbo].[DiseaseTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiseaseTB](
	[DiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[DiseaseName] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_DiseaseTB] PRIMARY KEY CLUSTERED 
(
	[DiseaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClinicData]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ClinicData](
	[DrID] [int] IDENTITY(1,1) NOT NULL,
	[DrName] [nvarchar](50) NOT NULL,
	[Speciaty] [nvarchar](50) NOT NULL,
	[Phone] [varchar](20) NOT NULL,
	[Mobile] [varchar](20) NULL,
	[Fax] [varchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[WebSiteAddress] [nvarchar](50) NULL,
	[Image] [nvarchar](200) NULL,
	[City] [nvarchar](50) NOT NULL,
	[Address] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_ClinicData] PRIMARY KEY CLUSTERED 
(
	[DrID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OperationTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationTypeTB](
	[OperationTypeID] [int] IDENTITY(1,1) NOT NULL,
	[OperationType] [nvarchar](75) NOT NULL,
 CONSTRAINT [PK_OperationTypeTB] PRIMARY KEY CLUSTERED 
(
	[OperationTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Medications]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Medications](
	[MedicationID] [int] IDENTITY(1,1) NOT NULL,
	[MedicationName] [nvarchar](max) NOT NULL,
	[Company] [nvarchar](max) NULL,
	[GroupOfRemedial] [nvarchar](max) NULL,
	[Classification] [nvarchar](max) NULL,
	[Page] [int] NULL,
	[MedicalOfConsultation] [nvarchar](max) NULL,
	[AntiOfMedical_Consultation] [nvarchar](max) NULL,
	[Warning] [nvarchar](max) NULL,
	[OverlapOfMedication] [nvarchar](max) NULL,
	[SideOfEffect] [nvarchar](max) NULL,
 CONSTRAINT [PK_Medications] PRIMARY KEY CLUSTERED 
(
	[MedicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnalysisTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalysisTypeTB](
	[AnalysisTypeID] [int] IDENTITY(1,1) NOT NULL,
	[Analysis] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_AnalysisTypeTB] PRIMARY KEY CLUSTERED 
(
	[AnalysisTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AccidentTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AccidentTB](
	[AccidentID] [int] IDENTITY(1,1) NOT NULL,
	[AccidentName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_AccidentTB] PRIMARY KEY CLUSTERED 
(
	[AccidentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BloodTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BloodTB](
	[BloodID] [int] IDENTITY(1,1) NOT NULL,
	[BloodType] [nvarchar](5) NOT NULL,
 CONSTRAINT [PK_BloodTB] PRIMARY KEY CLUSTERED 
(
	[BloodID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SocialStateTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SocialStateTB](
	[SocialStateID] [int] IDENTITY(1,1) NOT NULL,
	[SocialState] [nvarchar](25) NOT NULL,
 CONSTRAINT [PK_SocialStateTB] PRIMARY KEY CLUSTERED 
(
	[SocialStateID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SexTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SexTB](
	[SexID] [int] IDENTITY(1,1) NOT NULL,
	[Sex] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SexTB] PRIMARY KEY CLUSTERED 
(
	[SexID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RadioTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RadioTypeTB](
	[RadioTypeID] [int] IDENTITY(1,1) NOT NULL,
	[RadioType] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_RadioTypeTB] PRIMARY KEY CLUSTERED 
(
	[RadioTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[VisitTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitTypeTB](
	[VisitTypeID] [int] IDENTITY(1,1) NOT NULL,
	[VisitType] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_VisitTypeTB] PRIMARY KEY CLUSTERED 
(
	[VisitTypeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[TakeBackUpDatabase]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:

CREATE PROCEDURE [dbo].[TakeBackUpDatabase]
@BackupPath nvarchar(255)
As
begin
declare @DBName varchar(50);
	declare @ErrorText nvarchar(255);
	declare @BackupSetID int;

	Select @DBName = DB_Name();	

	Backup Database @DBName To Disk = @BackupPath With NOFORMAT, INIT, Name = @DBName, SKIP, REWIND, NOUNLOAD, STATS = 5;

	Select @ErrorText = N'حدث خطأ أثناء أخذ نسخة احتياطية من قاعدة البيانات ' + @DBName;

	-- check if current backup succeeded
	Select @BackupSetID = position From msdb..backupset
	 Where database_name = @DBName And backup_set_id = (Select Max(backup_set_id) From msdb..backupset Where database_name = @DBName);
	
	if (@BackupSetID Is NULL)
	 begin
		raiserror(@ErrorText, 16, 1)
	 end;

	Restore VERIFYONLY
	 From Disk = @BackupPath 
	 With File = @BackupSetID,  NOUNLOAD,  NOREWIND;
END
GO
/****** Object:  Table [dbo].[StampTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StampTB](
	[StampID] [int] IDENTITY(1,1) NOT NULL,
	[StampName] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_StampTB] PRIMARY KEY CLUSTERED 
(
	[StampID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](50) NOT NULL,
	[SexID] [int] NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[PassWord] [nvarchar](50) NOT NULL,
	[TelHome] [varchar](20) NULL,
	[TelMobil] [varchar](20) NULL,
	[Address] [nvarchar](200) NULL,
	[IsAdmin] [bit] NOT NULL,
	[ImagePath] [nvarchar](200) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UserName] UNIQUE NONCLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[VisitTypeTB_UpDate_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitTypeTB_UpDate_By_ID]
 @VisitTypeID	int 
,@VisitType nvarchar(15)
AS
BEGIN
UPDATE [VisitTypeTB]
   SET [VisitType] = @VisitType
 WHERE VisitTypeID=@VisitTypeID
	
END
GO
/****** Object:  StoredProcedure [dbo].[VisitTypeTB_Insert]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitTypeTB_Insert]
	@VisitType nvarchar(15)
AS
BEGIN
	INSERT INTO [VisitTypeTB]
           ([VisitType])
     VALUES
           (@VisitType)
END
GO
/****** Object:  StoredProcedure [dbo].[VisitTypeTB_Delete_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitTypeTB_Delete_By_ID]
	@VisitTypeID int
AS
BEGIN
	DELETE FROM [VisitTypeTB]
      
where VisitTypeID=@VisitTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[VisitTypeTB_Browes_By_ID_Felid]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitTypeTB_Browes_By_ID_Felid]
	@VisitTypeID int
AS
BEGIN
	SELECT [VisitTypeID]
      ,[VisitType]
  FROM [VisitTypeTB]
where VisitTypeID=@VisitTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[VisitTypeTB_Browes_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitTypeTB_Browes_By_ID]
	@VisitTypeID int
AS
BEGIN
	SELECT [VisitTypeID]
      ,[VisitType]
  FROM [VisitTypeTB]
where VisitTypeID=@VisitTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[VisitTypeTB_Browes_All]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[VisitTypeTB_Browes_All]
	
AS
BEGIN
	SELECT [VisitTypeID]
      ,[VisitType]
  FROM [VisitTypeTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Disease_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_Disease_By_ID]
 @DiseaseID int
,@DiseaseName nvarchar(100)	

AS
BEGIN
if Exists (select DiseaseName from DiseaseTB where DiseaseName=@DiseaseName)
begin
raiserror('هذا المرص موجود مسبقاً',16,1);
return;
end
UPDATE [DiseaseTB]
   SET [DiseaseName] = @DiseaseName
 WHERE DiseaseID=@DiseaseID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Medications_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_Medications_By_ID]
	
@MedicationID int	
,@MedicationName nvarchar(200)
,@Company  nvarchar(70)
,@GroupOfRemedial  nvarchar(100)
,@Classification  nvarchar(10)
,@Page  int 
,@MedicalOfConsultation  nvarchar(200) 
,@AntiOfMedical_Consultation  nvarchar(200) 
,@Warning  nvarchar(200) 
,@OverlapOfMedication  nvarchar(200)
,@SideOfEffect  nvarchar(200)


AS
BEGIN 
if exists (select MedicationName from [Medications] where  MedicationName=@MedicationName)
begin
raiserror('لايمكن إضافة هذا الدواء لأنه موجود مسبقاً', 16, 1);
return ;
end
	UPDATE [CLINICDB].[dbo].[Medications]
   SET [MedicationName] = @MedicationName
      ,[Company] = @Company
      ,[GroupOfRemedial] = @GroupOfRemedial
      ,[Classification] = @Classification
      ,[Page] = @Page
      ,[MedicalOfConsultation] = @MedicalOfConsultation
      ,[AntiOfMedical_Consultation] = @AntiOfMedical_Consultation
      ,[Warning] = @Warning
      ,[OverlapOfMedication] = @OverlapOfMedication
      ,[SideOfEffect] = @SideOfEffect
 


where MedicationID=@MedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Stamp]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_UpDate_Stamp]
@StampID int,
	@StampName nvarchar(200) 
AS
BEGIN
if  exists(select StampName from [StampTB] where StampName =@StampName)
begin
raiserror('هذه العلامة موجودة مسبقا',16,1);
return;
end


 
UPDATE [CLINICDB].[dbo].[StampTB]
   SET [StampName] = @StampName
 WHERE StampID=@StampID 



END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_RadioType]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_RadioType]
@RadioTypeID int
,@RadioType nvarchar(100)
AS
BEGIN
if exists ( select [RadioType] from [RadioTypeTB]where [RadioType]=@RadioType )
begin
raiserror('هذا التصوير موجود مسبقا',16,1);
return;
end;
UPDATE [RadioTypeTB]
   SET [RadioType] = @RadioType
 WHERE RadioTypeID=@RadioTypeID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Accident]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_Accident]
 @AccidentID int ,
	@AccidentName nvarchar(200)
AS
begin

UPDATE [CLINICDB].[dbo].[AccidentTB]
   SET [AccidentName] = @AccidentName
 WHERE AccidentID=@AccidentID






END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_OperationType_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_OperationType_By_ID]

@OperationTypeID int
,@OperationType nvarchar(75)
AS
BEGIN
if exists (select OperationType from [OperationTypeTB] where OperationType=@OperationType)
begin
raiserror('اسم العملية موجود مسبقاً',16,1);
return;
end

UPDATE [OperationTypeTB]
   SET [OperationType] = @OperationType
 WHERE OperationTypeID=@OperationTypeID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Make_Sure_Analysis]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Make_Sure_Analysis]
	@AnalysisTypeID int
AS
BEGIN
	if not Exists(SELECT [AnalysisTypeID]
   
  FROM [AnalysisTypeTB] where [AnalysisTypeID]=@AnalysisTypeID)
begin
return 1;
end

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_AnalysisTypeTB]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_AnalysisTypeTB]
	
@AnalysisTypeID int
,@Analysis nvarchar(100)

AS
BEGIN
if exists(select [Analysis] from [AnalysisTypeTB] where [Analysis]=@Analysis)
begin
raiserror('هذا التحليل موجود مسبقا',16,1);
return;
end

UPDATE [AnalysisTypeTB]
   SET [Analysis] = @Analysis
 WHERE AnalysisTypeID=@AnalysisTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Dr_Info]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Dr_Info] 

@DrID int 
,@DrName nvarchar(50)
,@Speciaty nvarchar(50)
,@Phone varchar(20)
,@Mobile varchar(20)
,@Fax varchar(20)
,@Email nvarchar(50)
,@WebSiteAddress nvarchar(50)

,@City nvarchar(50)
,@Address nvarchar(100)
As
BEGIN
UPDATE [ClinicData]
   SET [DrName] = @DrName
      ,[Speciaty] = @Speciaty
      ,[Phone] = @Phone
,Mobile=@Mobile
      ,[Fax] = @Fax
      ,[Email] = @Email
,WebSiteAddress=@WebSiteAddress
      ,[City] = @City
      ,[Address] = @Address
 WHERE DrID=@DrID 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Dr_Image]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Dr_Image]
@DrID int 
	,@Image nvarchar(200)
AS
BEGIN
	UPDATE [ClinicData]
   SET 
      [Image] = @Image
      
 WHERE DrID=@DrID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Stamp]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Insert_Stamp]
	@StampName nvarchar(200) 
AS
BEGIN
if  exists(select StampName from [StampTB] where StampName =@StampName)
begin
raiserror('هذه العلامة موجودة مسبقا',16,1);
return;
end
INSERT INTO [CLINICDB].[dbo].[StampTB]
           ([StampName])
     VALUES
           (@StampName)


 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_SocialState]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_SocialState]
	@SocialState nvarchar(25)
AS
BEGIN

INSERT INTO [SocialStateTB]
           ([SocialState])
     VALUES
           (@SocialState)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_RadioType]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_RadioType]

@RadioType nvarchar(100)
AS
BEGIN
if exists ( select [RadioType] from [RadioTypeTB]where [RadioType]=@RadioType )
begin
raiserror('هذا التصوير موجود مسبقا',16,1);
return;
end;

INSERT INTO [RadioTypeTB]
           ([RadioType])
     VALUES
           (@RadioType)


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Dr_Info]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Dr_Info] 

@DrName nvarchar(50)
,@Speciaty nvarchar(50)
,@Phone varchar(20)
,@Mobile varchar(20)
,@Fax varchar(20)
,@Email nvarchar(50)
,@WebSiteAddress nvarchar(50)
,@Image nvarchar(200)
,@City nvarchar(50)
,@Address nvarchar(100)
As
BEGIN
	INSERT INTO [ClinicData]
           
     VALUES
           (
           @DrName
           ,@Speciaty
           ,@Phone
,@Mobile
           ,@Fax
           ,@Email
,@WebSiteAddress
           ,@Image
           ,@City
           ,@Address)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Disease]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Disease] 
	@DiseaseName nvarchar(100)
AS
BEGIN
if Exists (select DiseaseName from DiseaseTB where DiseaseName=@DiseaseName)
begin
raiserror('هذا المرص موجود مسبقاً',16,1);
return;
end
	INSERT INTO [DiseaseTB]
           ([DiseaseName])
     VALUES
           (@DiseaseName)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Medications]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Medications]

@MedicationName nvarchar(200)
,@Company  nvarchar(70)
,@GroupOfRemedial  nvarchar(100)
,@Classification  nvarchar(10)
,@Page  int 
,@MedicalOfConsultation  nvarchar(200) 
,@AntiOfMedical_Consultation  nvarchar(200) 
,@Warning  nvarchar(200) 
,@OverlapOfMedication  nvarchar(200)
,@SideOfEffect  nvarchar(200)

AS
BEGIN
if exists (select MedicationName from [Medications] where  MedicationName=@MedicationName)
begin
raiserror('لايمكن إضافة هذا الدواء لأنه موجود مسبقاً', 16, 1);
return ;
end
	INSERT INTO [CLINICDB].[dbo].[Medications]
           ([MedicationName]
           ,[Company]
           ,[GroupOfRemedial]
           ,[Classification]
           ,[Page]
           ,[MedicalOfConsultation]
           ,[AntiOfMedical_Consultation]
           ,[Warning]
           ,[OverlapOfMedication]
           ,[SideOfEffect])
     VALUES
           (@MedicationName
           ,@Company
           ,@GroupOfRemedial
           ,@Classification
           ,@Page
           ,@MedicalOfConsultation
           ,@AntiOfMedical_Consultation
           ,@Warning
           ,@OverlapOfMedication
           ,@SideOfEffect)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_OperationType]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_OperationType]

@OperationType nvarchar(75)
AS
BEGIN
if exists (select OperationType from [OperationTypeTB] where OperationType=@OperationType)
begin
raiserror('اسم العملية موجود مسبقاً',16,1);
return;
end
INSERT INTO [OperationTypeTB]
           ([OperationType])
     VALUES
           (@OperationType)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Stamp]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Delete_Stamp]
@StampID int
	
AS
BEGIN
DELETE FROM [CLINICDB].[dbo].[StampTB]



 WHERE StampID=@StampID 



END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_SocialState]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_SocialState]
	@SocialStateID int
AS
BEGIN

DELETE FROM [SocialStateTB]
      WHERE SocialStateID=@SocialStateID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_RadioType]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_RadioType]
@RadioTypeID int

AS
BEGIN

DELETE FROM [RadioTypeTB]
      
 WHERE RadioTypeID=@RadioTypeID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Accident]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Accident] 
	@AccidentName nvarchar(200)
AS
begin

INSERT INTO [CLINICDB].[dbo].[AccidentTB]
           ([AccidentName])
     VALUES
           (@AccidentName)




END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_AnalysisTypeTB]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_AnalysisTypeTB]
	
@Analysis nvarchar(100)

AS
BEGIN
if exists(select [Analysis] from [AnalysisTypeTB] where [Analysis]=@Analysis)
begin
raiserror('هذا التحليل موجود مسبقا',16,1);
return;
end
INSERT INTO [AnalysisTypeTB]
           ([Analysis])
     VALUES
           (@Analysis)
select SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_AnalysisTypeTB]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_AnalysisTypeTB]
	
@AnalysisTypeID int


AS
BEGIN
DELETE FROM [AnalysisTypeTB]
      WHERE AnalysisTypeID=@AnalysisTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Disease_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Disease_By_ID]
 @DiseaseID int


AS
BEGIN

DELETE FROM [DiseaseTB]
      WHERE DiseaseID=@DiseaseID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Medications_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Medications_By_ID]
	@MedicationID int
AS
BEGIN
	DELETE FROM [Medications]
     
where MedicationID=@MedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_OperationType_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_OperationType_By_ID]

@OperationTypeID int

AS
BEGIN


DELETE FROM [OperationTypeTB]
     
 WHERE OperationTypeID=@OperationTypeID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Accident]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Accident] 
	@AccidentID int  
AS
begin
DELETE FROM [CLINICDB].[dbo].[AccidentTB]
where AccidentID=@AccidentID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Stamp_ID_By_Name]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Browes_Stamp_ID_By_Name]
	@StampName nvarchar(200) 
AS
BEGIN
	SELECT [StampID]
      
  FROM [CLINICDB].[dbo].[StampTB]
where StampName=@StampName 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Stamp_By_Name_DataTale]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Stamp_By_Name_DataTale]
	@StampName nvarchar(200) 
AS
BEGIN
if not exists(select StampName from [StampTB] where StampName =@StampName)
begin
raiserror('لا يوجد علامة بهذا الاسم',16,1);
return;
end
	SELECT [StampID]
      ,[StampName]
  FROM [CLINICDB].[dbo].[StampTB]
where StampName=@StampName 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Stamp_By_ID_DataTale]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Stamp_By_ID_DataTale]
	@StampID int 
AS
BEGIN
	SELECT [StampID]
      ,[StampName]
  FROM [CLINICDB].[dbo].[StampTB]
where StampID=@StampID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_SocialState_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_SocialState_By_ID] 
	@SocialStateID int
AS
BEGIN

SELECT [SocialStateID]
      ,[SocialState]
  FROM [SocialStateTB]
 where SocialStateID=@SocialStateID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_SocialState]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_SocialState]
	
AS
BEGIN
	SELECT [SocialStateID]
          ,[SocialState]
  FROM [SocialStateTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Sex_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Sex_By_ID] 
	@SexID int
AS
BEGIN
	SELECT [SexID]
      ,[Sex]
  FROM [SexTB]
where SexID=@SexID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Sex]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Sex]

AS
BEGIN
	SELECT [SexID]
           ,[Sex]
  FROM [SexTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioType_By_RadioTypeID_List]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioType_By_RadioTypeID_List] 
	@RadioTypeID int
AS
BEGIN
	SELECT [RadioTypeID]
      ,[RadioType]
  FROM [RadioTypeTB]
where RadioTypeID=@RadioTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioType_By_Name_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioType_By_Name_Felid]
@RadioType nvarchar(100)
AS
BEGIN
if not Exists(select RadioType from [RadioTypeTB] where RadioType=@RadioType)
begin 
raiserror ('اسم التصوير غير موجود',16,1);
return;
end
SELECT [RadioTypeID]
      ,[RadioType]
  FROM [RadioTypeTB]
where RadioType=@RadioType


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioType_By_Name]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioType_By_Name]
@RadioType nvarchar(100)
AS
BEGIN

SELECT [RadioTypeID]
      ,[RadioType]
  FROM [RadioTypeTB]
where RadioType=@RadioType


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioType_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioType_By_ID_Felid]
@RadioTypeID int
AS
BEGIN
SELECT [RadioTypeID]
      ,[RadioType]
  FROM [RadioTypeTB]
where RadioTypeID=@RadioTypeID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioType_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioType_All]

AS
BEGIN
SELECT [RadioTypeID]
      ,[RadioType]
  FROM [RadioTypeTB]


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_OperationType_By_Name]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Browes_OperationType_By_Name]
	@OperationType nvarchar(75)
AS
BEGIN
if not exists (select OperationType from [OperationTypeTB] where OperationType=@OperationType)
begin
raiserror('اسم العمليةغير  موجود ',16,1);
return;
end
SELECT [OperationTypeID]
      ,[OperationType]
  FROM [OperationTypeTB]
where OperationType=@OperationType
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_OperationType_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_OperationType_By_ID_Felid]

@OperationTypeID int
AS
BEGIN
SELECT [OperationTypeID]
      ,[OperationType]
  FROM [OperationTypeTB]
where OperationTypeID=@OperationTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_OperationType_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_OperationType_By_ID]

@OperationTypeID int
AS
BEGIN
SELECT [OperationTypeID]
      ,[OperationType]
  FROM [OperationTypeTB]
where OperationTypeID=@OperationTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_OperationType_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_OperationType_All]


AS
BEGIN
SELECT [OperationTypeID]
      ,[OperationType]
  FROM [OperationTypeTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_StampAll]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_StampAll]
	
AS
BEGIN
	SELECT [StampID]
      ,[StampName]
  FROM [CLINICDB].[dbo].[StampTB]


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Pharmacy_By_SideEffect]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Pharmacy_By_SideEffect]
	@SideEffect nvarchar(Max) 
AS
BEGIN
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where [SideOfEffect] like @SideEffect+'%' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Pharmacy_By_OverlapOfMedication]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Pharmacy_By_OverlapOfMedication]
	@OverlapOfMedication nvarchar(Max) 
AS
BEGIN
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where OverlapOfMedication like @OverlapOfMedication+'%' 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Pharmacy_By_Medication_Name]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Pharmacy_By_Medication_Name]
	@MedicationName nvarchar(Max) 
AS
BEGIN
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where [MedicationName] like '%'+@MedicationName 


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Pharmacy_By_MedicalOfConsultation]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Pharmacy_By_MedicalOfConsultation]
	@MedicalOfConsultation nvarchar(Max) 
AS
BEGIN
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where MedicalOfConsultation like @MedicalOfConsultation+ '%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Pharmacy_By_Company_Name]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Pharmacy_By_Company_Name]
	@CompanyName nvarchar(Max) 
AS
BEGIN
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where [Company] like @CompanyName+'%'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browse_Stamp_ByID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browse_Stamp_ByID]
	@StampID int 
AS
BEGIN
	SELECT [StampID]
      ,[StampName]
  FROM [CLINICDB].[dbo].[StampTB]
where StampID=@StampID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browse_Dr_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browse_Dr_Felid] 

As
BEGIN
	SELECT [DrID]
      ,[DrName]
      ,[Speciaty]
      ,[Phone]
      ,[Mobile]
      ,[Fax]
      ,[Email]
      ,[WebSiteAddress]
      ,[Image]
      ,[City]
      ,[Address]
  FROM [ClinicData]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Medications_By_Name]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Medications_By_Name]
	@MedicationName nvarchar(200)
AS
BEGIN
if not exists(select [MedicationName] from [Medications] where [MedicationName]=@MedicationName)
begin
raiserror('لا يوجد دواء بهذا الاسم',16,1);
return;
end 
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where MedicationName=@MedicationName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Medications_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Medications_By_ID_Felid]
	@MedicationID int
AS
BEGIN
if not exists(select MedicationID from [Medications] where MedicationID=@MedicationID)
begin
raiserror('لا يوجد دواء بهذا الرقم',16,1);
return;
end 
SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,AntiOfMedical_Consultation
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]
where MedicationID=@MedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Medications_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Medications_By_ID]
	@MedicationID int
AS
BEGIN
if not exists(select MedicationID from [Medications] where MedicationID=@MedicationID)
begin
raiserror('لا يوجد دواء بهذا الرقم',16,1);
return;
end 

SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]




where MedicationID=@MedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Medications_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Medications_All]
	
AS
BEGIN
	SELECT [MedicationID]
      ,[MedicationName]
      ,[Company]
      ,[GroupOfRemedial]
      ,[Classification]
      ,[Page]
      ,[MedicalOfConsultation]
      ,[AntiOfMedical_Consultation]
      ,[Warning]
      ,[OverlapOfMedication]
      ,[SideOfEffect]
  FROM [CLINICDB].[dbo].[Medications]



END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Disease_By_Name]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Disease_By_Name] 
	@DiseaseName nvarchar(100)
AS
BEGIN
if not exists(select [DiseaseName] from [DiseaseTB] where [DiseaseName]=@DiseaseName)
begin
raiserror('لا يوجد مرض بهذا الاسم',16,1);
return;
end
	SELECT [DiseaseID]
          ,[DiseaseName]
  FROM [DiseaseTB]
where DiseaseName=@DiseaseName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Disease_By_ID_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Disease_By_ID_Felid] 
	@DiseaseID int
AS
BEGIN
	SELECT [DiseaseID]
          ,[DiseaseName]
  FROM [DiseaseTB]
where DiseaseID=@DiseaseID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Disease_By_ID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Disease_By_ID]
@DiseaseID int	
AS
BEGIN
if not exists(select [DiseaseID] from [DiseaseTB] where [DiseaseID]=@DiseaseID)
begin
raiserror('لا يوجد مرض بهذا الرقم',16,1);
return;
end
		SELECT [DiseaseID]
          ,[DiseaseName]
  FROM [DiseaseTB]
where DiseaseID=@DiseaseID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Disease_All]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Disease_All] 
	
AS
BEGIN
	SELECT [DiseaseID]
      ,[DiseaseName]
  FROM [DiseaseTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Blood_By_ID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Blood_By_ID]
	@BloodID int 
AS
BEGIN
	SELECT [BloodID]
      ,[BloodType]
  FROM [BloodTB]
where BloodID=@BloodID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Blood]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Blood] 
	
AS
BEGIN
	SELECT [BloodID]
          ,[BloodType]
  FROM [BloodTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisTypeTB_By_Name_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisTypeTB_By_Name_Felid]
	
@Analysis nvarchar(100)

AS
BEGIN
if not exists(select [Analysis] from [AnalysisTypeTB] where [Analysis]=@Analysis)
begin
raiserror('هذا التحليل غير موجو ',16,1);
return;
end

SELECT [AnalysisTypeID]
      ,[Analysis]
  FROM [AnalysisTypeTB]
	where Analysis=@Analysis
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisTypeTB_By_Name]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisTypeTB_By_Name]
	
@Analysis nvarchar(100)

AS
BEGIN

SELECT [AnalysisTypeID]
      ,[Analysis]
  FROM [AnalysisTypeTB]
	where Analysis=@Analysis
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisTypeTB_By_ID_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisTypeTB_By_ID_Felid]
	@AnalysisTypeID int
AS
BEGIN
SELECT [AnalysisTypeID]
      ,[Analysis]
  FROM [AnalysisTypeTB]
	where AnalysisTypeID=@AnalysisTypeID	

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisTypeTB_All]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisTypeTB_All]
	


AS
BEGIN

SELECT [AnalysisTypeID]
      ,[Analysis]
  FROM [AnalysisTypeTB]
	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisType_By_ID_List]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisType_By_ID_List] 
@AnalysisTypeID int 
AS
BEGIN
	SELECT [AnalysisTypeID]
      ,[Analysis]
  FROM [AnalysisTypeTB]
where AnalysisTypeID=@AnalysisTypeID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Accident_ByName_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Accident_ByName_Felid] 
	@AccidentName nvarchar(200)
AS
BEGIN
	SELECT [AccidentID]
      ,[AccidentName]
  FROM [CLINICDB].[dbo].[AccidentTB]
where AccidentName=@AccidentName


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Accident_ByID_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Accident_ByID_Felid] 
	@AccidentID int
AS
BEGIN
	SELECT [AccidentID]
      ,[AccidentName]
  FROM [CLINICDB].[dbo].[AccidentTB]
where AccidentID=@AccidentID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AccidentAll]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Batch submitted through debugger: SQLQuery2.sql|0|0|C:\Users\Administrator\AppData\Local\Temp\~vs978E.sql

CREATE PROCEDURE [dbo].[SP_Browes_AccidentAll] 
	
AS
BEGIN
	SELECT [AccidentID]
      ,[AccidentName]
  FROM [CLINICDB].[dbo].[AccidentTB]



END
GO
/****** Object:  Table [dbo].[AppointmentTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AppointmentTB](
	[AppointmentID] [int] IDENTITY(1,1) NOT NULL,
	[PatientName] [nvarchar](50) NOT NULL,
	[Date] [smalldatetime] NOT NULL,
	[Time] [varchar](50) NOT NULL,
	[VisitTypeID] [int] NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_AppointmentTB] PRIMARY KEY CLUSTERED 
(
	[AppointmentID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  StoredProcedure [dbo].[MakeSureToAddAnalysis]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[MakeSureToAddAnalysis] 
@Analysis nvarchar(100)
AS
BEGIN
declare @x bit

if not Exists(SELECT [Analysis] FROM [AnalysisTypeTB] where [Analysis]=@Analysis)
begin
select @x=1
return;
end
select @x=0


END
GO
/****** Object:  Table [dbo].[PatientTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientTB](
	[PatientID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[DataOfRegister] [smalldatetime] NOT NULL,
	[DataOFBirth] [smalldatetime] NOT NULL,
	[SexID] [int] NOT NULL,
	[BloodID] [int] NOT NULL,
	[SocialStateID] [int] NULL,
	[ChidNo] [int] NOT NULL,
	[Job] [nvarchar](50) NULL,
	[AddressHome] [nvarchar](100) NULL,
	[AddressWork] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Tel] [varchar](20) NULL,
	[Mobile] [varchar](20) NULL,
	[TelWork] [varchar](20) NULL,
	[Smoke] [bit] NULL,
	[Win] [bit] NULL,
	[Sensitive] [nvarchar](100) NULL,
	[Note] [nvarchar](200) NULL,
	[ImagePath] [nvarchar](200) NULL,
 CONSTRAINT [PK_PatientsTB] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient_LastMedication]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_LastMedication](
	[PatientID] [int] NOT NULL,
	[MedicationID] [int] NOT NULL,
	[LastMedicationID] [int] IDENTITY(1,1) NOT NULL,
	[DateOfMedication] [smalldatetime] NOT NULL,
 CONSTRAINT [PK_Patient_LastMedication] PRIMARY KEY CLUSTERED 
(
	[LastMedicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_LastDisease]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_LastDisease](
	[PatientID] [int] NOT NULL,
	[DiseaseID] [int] NOT NULL,
	[LastDiseaseID] [int] IDENTITY(1,1) NOT NULL,
	[FamilyDisease] [bit] NULL,
	[DateOfDisease] [smalldatetime] NULL,
 CONSTRAINT [PK_Patient_LastDisease] PRIMARY KEY CLUSTERED 
(
	[PatientID] ASC,
	[LastDiseaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OperationTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OperationTB](
	[OperationID] [int] IDENTITY(1,1) NOT NULL,
	[DateOfOperation] [smalldatetime] NOT NULL,
	[PatientID] [int] NOT NULL,
	[OperationTypeID] [int] NOT NULL,
	[Note] [nvarchar](200) NULL,
 CONSTRAINT [PK_OperationTB] PRIMARY KEY CLUSTERED 
(
	[OperationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PermissionTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PermissionTB](
	[UserID] [int] NOT NULL,
	[PatientMenu] [bit] NOT NULL,
	[CHB_FilePatient] [bit] NOT NULL,
	[CHB_OperationOfPatient] [bit] NOT NULL,
	[CHB_lastDisease] [bit] NOT NULL,
	[CHB_LastMedication] [bit] NOT NULL,
	[CHB_Visit] [bit] NOT NULL,
	[AnalysisMeun] [bit] NOT NULL,
	[CHB_Analysis] [bit] NOT NULL,
	[CHB_Radio] [bit] NOT NULL,
	[InvoiceMeun] [bit] NOT NULL,
	[CHB_Invoice] [bit] NOT NULL,
	[ToolsMeun] [bit] NOT NULL,
	[CHB_CameraWatiching] [bit] NOT NULL,
	[CHB_BrowesImage] [bit] NOT NULL,
	[CHB_ControlPanel] [bit] NOT NULL,
	[CHB_AdminControlPanal] [bit] NOT NULL,
	[CHB_UserContolPanel] [bit] NOT NULL,
	[CHB_BackUp] [bit] NOT NULL,
	[AppointmentMeun] [bit] NOT NULL,
	[CHB_Appointment] [bit] NOT NULL,
	[PrescriptionMeun] [bit] NOT NULL,
	[CHB_Prescription] [bit] NOT NULL,
 CONSTRAINT [PK_PermissionTB] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Appointment_By_ID_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Browes_Appointment_By_ID_Felid]

@AppointmentID int
	
AS
BEGIN
SELECT [AppointmentID]
      ,[PatientName]
      ,[Date]
      ,[Time]
      ,[VisitTypeID]
      ,[Note]
  FROM [AppointmentTB]
   where AppointmentID=@AppointmentID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Appointment_All_By_Date]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Browes_Appointment_All_By_Date]

@Date smalldatetime
	
AS
BEGIN
	SELECT [AppointmentID]
      ,[PatientName]
      ,[Date]
      ,[Time]
      ,[VisitTypeID]
      ,[Note]
 
  FROM [AppointmentTB]
   where Date=@Date

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Datials_Appointement]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_Datials_Appointement]
	@Data smalldatetime
AS
BEGIN

SELECT [AppointmentID]
      ,[PatientName]
      ,[Date]
      ,[Time]
      ,VisitTypeTB.[VisitTypeID]
,VisitType
      ,[Note]
  FROM [AppointmentTB]
join VisitTypeTB on 
[AppointmentTB].[VisitTypeID]=VisitTypeTB.[VisitTypeID]
where Date=@Data

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Datails_Patient_Report_From_To_Date]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.

CREATE PROCEDURE [dbo].[SP_Brows_Datails_Patient_Report_From_To_Date]
	@From_Date smalldatetime
   ,@TO_Date smalldatetime
AS
BEGIN
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,Sex
      ,BloodType
      ,SocialState
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
      ,[ImagePath]
  FROM [PatientTB]
join SexTB on
[PatientTB].[SexID]=SexTB.[SexID]
join BloodTB on
[PatientTB].[BloodID]=BloodTB.[BloodID]
join SocialStateTB on
[PatientTB].[SocialStateID]=SocialStateTB.[SocialStateID]

where DataOfRegister between @From_Date and @TO_Date 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Datails_Patient_Report]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_Datails_Patient_Report]
	@PatientID int
   ,@ImagePateint image
AS
BEGIN
	SELECT 
      [DrName]
      ,[Speciaty]
      ,[Phone]
      ,[ClinicData].[Mobile]
      ,[Fax]
      ,[ClinicData].[Email]
      ,[WebSiteAddress]
      ,[Image]
      ,[City]
      ,[Address]





,[PatientID]
      ,[FirstName]
      ,[LastName]
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,Sex
      ,BloodType
      ,SocialState
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[PatientTB].[Email]
      ,[Tel]
      ,[PatientTB].[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
      ,imagep=@ImagePateint
  FROM [ClinicData],[PatientTB]
join SexTB on
[PatientTB].[SexID]=SexTB.[SexID]
join BloodTB on
[PatientTB].[BloodID]=BloodTB.[BloodID]
join SocialStateTB on
[PatientTB].[SocialStateID]=SocialStateTB.[SocialStateID]


where  PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_Name_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_Name_By_ID]
	@PatientID int
AS
BEGIN
	SELECT [FirstName]
     
  FROM [PatientTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_List_By_LastName]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_List_By_LastName] 
@LastName nvarchar(50)
	
AS
BEGIN
if not exists(select [LastName] from [PatientTB] where [LastName]=@LastName)
begin
raiserror('لا يوجد مريض له هذا الاسم',16,1);
return;
end 
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
,ImagePath
  FROM [PatientTB]
where [LastName]=@LastName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_List_By_FirstName]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_List_By_FirstName] 
@FirstName nvarchar(50)
	AS
BEGIN

if not exists(select [FirstName] from [PatientTB] where [FirstName]=@FirstName)
begin
raiserror('لا يوجد مريض له هذا الاسم',16,1);
return;
end 

	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
,ImagePath
  FROM [PatientTB]
where [FirstName]=@FirstName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_FullName_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_FullName_By_ID_Felid]
	@PatientID int
AS
BEGIN

		SELECT [PatientID]
           ,FirstName=FirstName+' '+LastName 
     
  FROM [PatientTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_FullName_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_FullName_By_ID]
	@PatientID int
AS
BEGIN

	SELECT [PatientID]
           ,FirstName=FirstName+' '+LastName 
     
  FROM [PatientTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_FullName]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_FullName]
	
AS
BEGIN
	SELECT [PatientID]
           ,FirstName=FirstName+' '+LastName 
     
  FROM [PatientTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_By_PatientID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_By_PatientID_Felid]
	@PatientID int
AS
BEGIN
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
      
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
,ImagePath
  FROM [PatientTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_By_PatientID]
@PatientID int
	
AS
BEGIN
if not Exists (select [PatientID] from [PatientTB] where [PatientID]=@PatientID)
begin
raiserror('رقم المريض الذي تبحث عنه غير موجود',16,1);
return;
end
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
     
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
,ImagePath
  FROM [PatientTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_By_LastName]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_By_LastName]
@LastName nvarchar(50)
	
AS
BEGIN
if not Exists (select [LastName] from [PatientTB] where [LastName]=@LastName)
begin
raiserror('هذا الاسم غير موجو ',16,1);
return;
end
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
     
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
,ImagePath
  FROM [PatientTB]
where LastName=@LastName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_By_FirstName]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_By_FirstName]
@FirstName nvarchar(50)
	
AS
BEGIN
if not Exists (select [FirstName] from [PatientTB] where [FirstName]=@FirstName)
begin
raiserror('هذا الاسم غير موجو ',16,1);
return;
end
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
     
      ,[DataOfRegister]
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
,ImagePath
  FROM [PatientTB]
where FirstName=@FirstName
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_All]

	
AS
BEGIN
	SELECT [PatientID]
      ,[FirstName]
      ,[LastName]
      
	  ,[DataOfRegister]	
      ,[DataOFBirth]
      ,[SexID]
      ,[BloodID]
      ,[SocialStateID]
      ,[ChidNo]
      ,[Job]
      ,[AddressHome]
      ,[AddressWork]
      ,[Email]
      ,[Tel]
      ,[Mobile]
      ,[TelWork]
      ,[Smoke]
      ,[Win]
      ,[Sensitive]
      ,[Note]
      ,[ImagePath]
  FROM [PatientTB]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browse_UserInfo_For_Login]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browse_UserInfo_For_Login] 
@UserName nvarchar(50)
,@PassWord nvarchar(50)
AS
BEGIN
	SELECT [UserID]
      ,[FullName]
      ,[UserName]
      ,[PassWord]
      
  FROM [Users]
where UserName=@UserName and [PassWord]=@PassWord
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_User_Detalis]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_User_Detalis]
	
AS
BEGIN
	SELECT [UserID]
      ,[FullName]
      ,[Users].[SexID]
,Sex
      ,[UserName]
      ,[PassWord]
      ,[TelHome]
      ,[TelMobil]
      ,[Address]
      ,[IsAdmin]
,ImagePath
  FROM [Users]
join SexTB on
[Users].[SexID]=SexTB.[SexID]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_User_All_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_User_All_Felid]
	@UserID int
AS
BEGIN
	SELECT [UserID]
      ,[FullName]
      ,[SexID]
      ,[UserName]
      ,[PassWord]
      ,[TelHome]
      ,[TelMobil]
      ,[Address]
      ,[IsAdmin]
,ImagePath
  FROM [Users]
where [UserID]=@UserID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_User]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_User]
	@UserID int
AS
BEGIN
DELETE FROM [Users]     
where [UserID]=@UserID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Get_Total_Name_Patient]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Get_Total_Name_Patient]
@FirstName nvarchar(50)
,@LastName nvarchar(50)
AS
BEGIN
	SELECT [PatientID]
        ,[FirstName]
      ,[LastName]
  FROM [PatientTB]
where ([FirstName]=@FirstName and [LastName]=@LastName)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Patient_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Patient_By_PatientID] 
	@PatientID int
AS

BEGIN
DELETE FROM [PatientTB]
     WHERE PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Appointment_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Delete_Appointment_By_ID]

@AppointmentID int
	
AS
BEGIN
	DELETE  FROM [AppointmentTB]
   where AppointmentID=@AppointmentID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Patient]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Patient]
	@FirstName nvarchar(50)
   ,@LastName nvarchar(50)
    
   ,@DataOfRegister smalldatetime
   ,@DataOFBirth smalldatetime
   ,@SexID int
   ,@BloodID int 
   ,@SocialStateID int 
   ,@ChidNo int 
   ,@Job nvarchar(50)
   ,@AddressHome nvarchar(100)
   ,@AddressWork nvarchar(100)
   ,@Email nvarchar(100)
   ,@Tel varchar(20)
   ,@Mobile varchar(20)
   ,@TelWork varchar(20)
   ,@Smoke bit
   ,@Win bit
   ,@Sensitive nvarchar(100)
   ,@Note nvarchar(200)
,@ImagePath nvarchar(200)
AS
BEGIN

	INSERT INTO [PatientTB]
           ([FirstName]
           ,[LastName]
          
           ,[DataOfRegister]
           ,[DataOFBirth]
           ,[SexID]
           ,[BloodID]
           ,[SocialStateID]
           ,[ChidNo]
           ,[Job]
           ,[AddressHome]
           ,[AddressWork]
           ,[Email]
           ,[Tel]
           ,[Mobile]
           ,[TelWork]
           ,[Smoke]
           ,[Win]
           ,[Sensitive]
           ,[Note]
,ImagePath)
     VALUES
           (@FirstName
           ,@LastName
          
		   ,@DataOfRegister
           ,@DataOFBirth
           ,@SexID
           ,@BloodID
           ,@SocialStateID
           ,@ChidNo
           ,@Job
           ,@AddressHome
           ,@AddressWork
           ,@Email
           ,@Tel
           ,@Mobile
           ,@TelWork
           ,@Smoke
           ,@Win
           ,@Sensitive
           ,@Note
,@ImagePath)
select SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Appointment]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Insert_Appointment]


@PatientName nvarchar (50)
,@Date smalldatetime
,@Time  varchar(5)

,@VisitTypeID int

,@Note nvarchar(100)

	
AS
BEGIN

if exists(select PatientName from AppointmentTB where (PatientName=@PatientName) )
begin
raiserror(' هذا الاسم محجوز',16,1);
return;
end
if exists(select [Time] from AppointmentTB where ([Time]=@Time) )
begin
raiserror(' هذا الموعد محجوز مسبقا',16,1);
return;
end
INSERT INTO [CLINICDB].[dbo].[AppointmentTB]
           ([PatientName]
           ,[Date]
           ,[Time]
           ,[VisitTypeID]
           ,[Note])
    
     VALUES
           
( @PatientName
      , @Date
      ,@Time
      , @VisitTypeID
      ,@Note)
 
   

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_User]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_User] 

@FullName  nvarchar(50)
,@SexID int
,@UserName nvarchar(50)
,@PassWord  nvarchar(50)
,@TelHome varchar(20)
,@TelMobil varchar(20)
,@Address nvarchar(200)
,@IsAdmin bit 
,@ImagePath nvarchar(200)

AS
BEGIN
if exists (select UserName from [Users] where  UserName=@UserName)
begin
raiserror('لايمكن إضافة هذا الاسم لأنه موجود مسبقاً', 16, 1);
return ;
end

INSERT INTO [Users]
           ([FullName]
           ,[SexID]
           ,[UserName]
           ,[PassWord]
           ,[TelHome]
           ,[TelMobil]
           ,[Address]
           ,[IsAdmin]
,ImagePath)
     VALUES
           (@FullName
           ,@SexID
           ,@UserName
           ,@PassWord
           ,@TelHome
           ,@TelMobil
           ,@Address
           ,@IsAdmin
,@ImagePath)



END
GO
/****** Object:  StoredProcedure [dbo].[SP_Updata_Appointment_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE  [dbo].[SP_Updata_Appointment_By_ID]

@AppointmentID int

,@PatientName nvarchar (50)
,@Date smalldatetime

,@Time varchar(5)
,@VisitTypeID int
,@Note nvarchar(100)
	
AS
BEGIN
if exists(select PatientName from AppointmentTB where (PatientName=@PatientName) )
begin
raiserror(' هذا الاسم محجوز',16,1);
return;
end
if exists(select [Time] from AppointmentTB where ([Time]=@Time) )
begin
raiserror(' هذا الموعد محجوز مسبقا',16,1);
return;
end
	UPDATE [AppointmentTB]
   SET 
      [PatientName] = @PatientName
,[Date] = @Date
,[Time] = @Time

      ,[VisitTypeID] =@VisitTypeID
      ,[Note] = @Note
      
 
   where AppointmentID=@AppointmentID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Patient_By_PatientID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Patient_By_PatientID] 
	@PatientID int
   ,@FirstName nvarchar(50)
   ,@LastName nvarchar(50)
    
 ,@DataOfRegister smalldatetime
   ,@DataOFBirth smalldatetime
   ,@SexID int
   ,@BloodID int 
   ,@SocialStateID int 
   ,@ChidNo int 
   ,@Job nvarchar(50)
   ,@AddressHome nvarchar(100)
   ,@AddressWork nvarchar(100)
   ,@Email nvarchar(100)
   ,@Tel varchar(20)
   ,@Mobile varchar(20)
   ,@TelWork varchar(20)
   ,@Smoke bit
   ,@Win bit
   ,@Sensitive nvarchar(100)
   ,@Note nvarchar(200)

AS

BEGIN
UPDATE [PatientTB]
   SET [FirstName] = @FirstName
      ,[LastName] = @LastName
      
   ,[DataOfRegister]=@DataOfRegister
      ,[DataOFBirth] = @DataOFBirth
      ,[SexID] = @SexID
      ,[BloodID] = @BloodID
      ,[SocialStateID] = @SocialStateID
      ,[ChidNo] = @ChidNo
      ,[Job] = @Job
      ,[AddressHome] = @AddressHome
      ,[AddressWork] = @AddressWork
      ,[Email] = @Email
      ,[Tel] = @Tel
      ,[Mobile] = @Mobile
      ,[TelWork] = @TelWork
      ,[Smoke] = @Smoke
      ,[Win] = @Win
      ,[Sensitive] = @Sensitive
      ,[Note] =@Note

 WHERE PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Patient_Image_Path_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Patient_Image_Path_By_ID]

@PatientID int	
,@ImagePath nvarchar(200)

AS
BEGIN
	
UPDATE [PatientTB]
   SET 
      [ImagePath] = @ImagePath
 WHERE PatientID=@PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_User_Image]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_User_Image] 
@UserID int
,@ImagePath nvarchar(200) 
AS
BEGIN
UPDATE [Users]
   SET ImagePath=@ImagePath
 WHERE UserID=@UserID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_User]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_User] 
@UserID int
,@FullName  nvarchar(50)
,@SexID int

,@PassWord  nvarchar(50)
,@TelHome varchar(20)
,@TelMobil varchar(20)
,@Address nvarchar(200)
,@IsAdmin bit

AS
BEGIN


UPDATE [Users]
   SET [FullName] = @FullName
      ,[SexID] = @SexID
    
      ,[PassWord] = @PassWord
      ,[TelHome] = @TelHome
      ,[TelMobil] = @TelMobil
      ,[Address] = @Address
      ,[IsAdmin] = @IsAdmin

 WHERE UserID=@UserID


END
GO
/****** Object:  Table [dbo].[VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[VisitTB](
	[VisitID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NOT NULL,
	[DataOfVisit] [smalldatetime] NOT NULL,
	[VisitTypeID] [int] NOT NULL,
	[Weight] [float] NOT NULL,
	[BloodPressure] [float] NOT NULL,
	[PulseHeart] [int] NOT NULL,
	[Temperature] [float] NOT NULL,
	[PhysicalExamination] [nvarchar](200) NOT NULL,
	[Note] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_VisitTB_1] PRIMARY KEY CLUSTERED 
(
	[VisitID] ASC,
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit_Stamp]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit_Stamp](
	[StampID] [int] NOT NULL,
	[VisitID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
 CONSTRAINT [PK_Visit_Stamp] PRIMARY KEY CLUSTERED 
(
	[StampID] ASC,
	[VisitID] ASC,
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit_Disease]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit_Disease](
	[VisitID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[DiseaseID] [int] NOT NULL,
 CONSTRAINT [PK_Visit_Disease] PRIMARY KEY CLUSTERED 
(
	[VisitID] ASC,
	[PatientID] ASC,
	[DiseaseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visit_Accident]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visit_Accident](
	[AccidentID] [int] NOT NULL,
	[VisitID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
 CONSTRAINT [PK_Visit_Accident] PRIMARY KEY CLUSTERED 
(
	[AccidentID] ASC,
	[VisitID] ASC,
	[PatientID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_Update_Permission]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Update_Permission]

@UserID int	
,@PatientMenu bit
,@CHB_FilePatient bit
,@CHB_OperationOfPatient bit
,@CHB_lastDisease bit
,@CHB_LastMedication bit
,@CHB_Visit bit
,@AnalysisMeun bit
,@CHB_Analysis bit
,@CHB_Radio bit
,@InvoiceMeun bit
,@CHB_Invoice bit
,@ToolsMeun bit
 ,@CHB_CameraWatiching bit
 ,@CHB_BrowesImage bit
,@CHB_ControlPanel bit
,@CHB_AdminControlPanal bit
,@CHB_UserContolPanel bit
,@CHB_BackUp bit
,@AppointmentMeun bit
,@CHB_Appointment bit
,@PrescriptionMeun bit
,@CHB_Prescription bit


AS
BEGIN

UPDATE [PermissionTB]
   SET [UserID] = @UserID
      ,[PatientMenu] = @PatientMenu
      ,[CHB_FilePatient] = @CHB_FilePatient
      ,[CHB_OperationOfPatient] = @CHB_OperationOfPatient
      ,[CHB_lastDisease] = @CHB_lastDisease
      ,[CHB_LastMedication] = @CHB_LastMedication
      ,[CHB_Visit] = @CHB_Visit
      ,[AnalysisMeun] = @AnalysisMeun
      ,[CHB_Analysis] = @CHB_Analysis
      ,[CHB_Radio] = @CHB_Radio
      ,[InvoiceMeun] = @InvoiceMeun
      ,[CHB_Invoice] = @CHB_Invoice
      ,[ToolsMeun] = @ToolsMeun
      ,CHB_CameraWatiching=@CHB_CameraWatiching
      ,CHB_BrowesImage=@CHB_BrowesImage
      ,[CHB_ControlPanel] = @CHB_ControlPanel
      ,[CHB_AdminControlPanal] = @CHB_AdminControlPanal
      ,[CHB_UserContolPanel] = @CHB_UserContolPanel
      ,[CHB_BackUp] = @CHB_BackUp
      ,[AppointmentMeun] = @AppointmentMeun
      ,[CHB_Appointment] = @CHB_Appointment
      ,[PrescriptionMeun] = @PrescriptionMeun
      ,[CHB_Prescription] = @CHB_Prescription
 WHERE UserID=@UserID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_VisitTB]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_VisitTB]
	
@PatientID int
,@DataOfVisit smalldatetime
,@VisitTypeID int
,@Weight float
,@BloodPressure float
,@PulseHeart int
,@Temperature float
,@PhysicalExamination nvarchar(200)

,@Note nvarchar(200)
AS
BEGIN
INSERT INTO [VisitTB]
           ([PatientID]
           ,[DataOfVisit]
           ,[VisitTypeID]
           ,[Weight]
           ,[BloodPressure]
           ,[PulseHeart]
           ,[Temperature]
           ,[PhysicalExamination]
			
			,Note
)
     VALUES
           (@PatientID
           ,@DataOfVisit
           ,@VisitTypeID
           ,@Weight
           ,@BloodPressure
           ,@PulseHeart
           ,@Temperature
           ,@PhysicalExamination

			,@Note)

select SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Patient_LastMedication_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Patient_LastMedication_By_ID]
@PatientID  int
 ,@MedicationID  int
,@LastMedicationID  int
,@DateOfMedication smalldatetime
AS
BEGIN
if exists(select [MedicationID] from [Patient_LastMedication] where ([MedicationID]=@MedicationID ))
begin
raiserror('لا يمكن اضافة الدواء اكثر من مرة لنفس المريض ',16,1);
return;
end
UPDATE [Patient_LastMedication]
   SET [PatientID] = @PatientID 
      ,[MedicationID] = @MedicationID 
      ,[DateOfMedication] = @DateOfMedication 

where LastMedicationID=@LastMedicationID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Patient_LastDisease]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Patient_LastDisease]
@LastDiseaseID int
,@PatientID int
,@DiseaseID  int
,@FamilyDisease bit
,@DateOfDisease smalldatetime
AS
BEGIN
if exists(select [DiseaseID] from [Patient_LastDisease] where ([DiseaseID]=@DiseaseID))
begin
raiserror('لا يمكن اضافة المرض اكثر من مرة لنفس المريض ',16,1);
return;
end
UPDATE [Patient_LastDisease]
   SET [PatientID] = @PatientID
      ,[DiseaseID] = @DiseaseID
      ,[FamilyDisease]=@FamilyDisease
      ,[DateOfDisease]=@DateOfDisease
 WHERE LastDiseaseID=@LastDiseaseID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Operation_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Operation_By_ID]
@OperationID int
,@DateOfOperation smalldatetime
,@PatientID int
,@OperationTypeID int
,@Note nvarchar(200)
AS
BEGIN
if exists(select [OperationTypeID] from [OperationTB] where ([OperationTypeID]=@OperationTypeID ))
begin
raiserror('لا يمكن اضافة هذه العملية اكثر من مرة لنفس المريض ',16,1);
return;
end
UPDATE [OperationTB]
   SET [DateOfOperation] = @DateOfOperation
      ,[PatientID] = @PatientID
      ,[OperationTypeID] = @OperationTypeID
      ,[Note]=@Note
 WHERE OperationID =@OperationID 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_VisitTB_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_VisitTB_By_ID]
@VisitID int	
,@PatientID int
,@DataOfVisit smalldatetime
,@VisitTypeID int
,@Weight float
,@BloodPressure float
,@PulseHeart int
,@Temperature float
,@PhysicalExamination nvarchar(200)

,@Note nvarchar(200)
AS
BEGIN
UPDATE [VisitTB]
   SET [PatientID] =@PatientID
      ,[DataOfVisit] = @DataOfVisit
      ,[VisitTypeID] = @VisitTypeID
      ,[Weight] = @Weight
      ,[BloodPressure] =@BloodPressure
      ,[PulseHeart] = @PulseHeart
      ,[Temperature] = @Temperature
      ,[PhysicalExamination] = @PhysicalExamination

,Note=@Note
 WHERE VisitID=@VisitID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Permission]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Permission]
@UserID int	
,@PatientMenu bit
,@CHB_FilePatient bit
,@CHB_OperationOfPatient bit
,@CHB_lastDisease bit
,@CHB_LastMedication bit
,@CHB_Visit bit
,@AnalysisMeun bit
,@CHB_Analysis bit
,@CHB_Radio bit
,@InvoiceMeun bit
,@CHB_Invoice bit
,@ToolsMeun bit
,@CHB_CameraWatiching bit
,@CHB_BrowesImage bit
,@CHB_ControlPanel bit
,@CHB_AdminControlPanal bit
,@CHB_UserContolPanel bit
,@CHB_BackUp bit
,@AppointmentMeun bit
,@CHB_Appointment bit
,@PrescriptionMeun bit
,@CHB_Prescription bit

AS
BEGIN

if exists(select UserID from PermissionTB where UserID=@UserID)
begin
raiserror ('تمت اضافة السماحيات مسبقاً يمكنك التعديل',16,1);
return;
end

INSERT INTO [PermissionTB]
           
     VALUES
           (@UserID
           ,@PatientMenu
           ,@CHB_FilePatient
           ,@CHB_OperationOfPatient
           ,@CHB_lastDisease
           ,@CHB_LastMedication
           ,@CHB_Visit
           ,@AnalysisMeun
           ,@CHB_Analysis
           ,@CHB_Radio
           ,@InvoiceMeun
           ,@CHB_Invoice
           ,@ToolsMeun
           ,@CHB_CameraWatiching
           ,@CHB_BrowesImage
           ,@CHB_ControlPanel
           ,@CHB_AdminControlPanal
           ,@CHB_UserContolPanel
           ,@CHB_BackUp
           ,@AppointmentMeun
           ,@CHB_Appointment
           ,@PrescriptionMeun
           ,@CHB_Prescription)




   
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Patient_LastMedication]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Patient_LastMedication]
@PatientID  int
 ,@MedicationID  int

,@DateOfMedication smalldatetime
AS
BEGIN
if exists(select [MedicationID] from [Patient_LastMedication] where ([MedicationID]=@MedicationID ))
begin
raiserror('لا يمكن اضافة الدواء اكثر من مرة لنفس المريض ',16,1);
return;
end
INSERT INTO [Patient_LastMedication]
           ([PatientID]
           ,[MedicationID]
           ,[DateOfMedication])
     VALUES
           (@PatientID
           ,@MedicationID
           ,@DateOfMedication)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Patient_LastDisease]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Patient_LastDisease]

@PatientID int
,@DiseaseID  int
,@FamilyDisease bit
,@DateOfDisease smalldatetime
AS
BEGIN
if exists(select [DiseaseID] from [Patient_LastDisease] where ([DiseaseID]=@DiseaseID))
begin
raiserror('لا يمكن اضافة المرض اكثر من مرة لنفس المريض ',16,1);
return;
end

	INSERT INTO [Patient_LastDisease]
           ([PatientID]
           ,[DiseaseID]
           ,[FamilyDisease]
           ,[DateOfDisease])
     VALUES
           (@PatientID
           ,@DiseaseID
           ,@FamilyDisease 
           ,@DateOfDisease )
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Operation]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Operation]
@DateOfOperation smalldatetime
,@PatientID int
,@OperationTypeID int
,@Note nvarchar(200)
AS
BEGIN
if exists(select [OperationTypeID] from [OperationTB] where ([OperationTypeID]=@OperationTypeID ))
begin
raiserror('لا يمكن اضافة هذه العملية اكثر من مرة لنفس المريض ',16,1);
return;
end
INSERT INTO [OperationTB]
           ([DateOfOperation]
           ,[PatientID]
           ,[OperationTypeID]
           ,[Note])
           
     VALUES
           (@DateOfOperation
           ,@PatientID
           ,@OperationTypeID
           ,@Note)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Permission]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Permission]
@UserID int	


AS
BEGIN

DELETE FROM [PermissionTB]
    
 WHERE UserID=@UserID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Patient_LastMedication_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Patient_LastMedication_By_ID]

@LastMedicationID  int
AS
BEGIN
DELETE FROM [Patient_LastMedication]
     
where LastMedicationID=@LastMedicationID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Patient_LastDisease]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Patient_LastDisease]
@LastDiseaseID int

AS
BEGIN
DELETE FROM [Patient_LastDisease]
     
 WHERE LastDiseaseID=@LastDiseaseID


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_VisitTB_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_VisitTB_By_ID]
@VisitID int	

AS
BEGIN
DELETE FROM [VisitTB]
     
 WHERE VisitID=@VisitID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Visit_Detiles_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Visit_Detiles_PatientID]

@PatientID int
AS
BEGIN

SELECT [VisitID]
      ,[VisitTB].[PatientID]
,FirstName=FirstName+' '+LastName 
      ,[DataOfVisit]

      ,[VisitTB].[VisitTypeID]
,VisitType
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]
   
      ,[VisitTB].[Note]
  FROM [VisitTB]
join PatientTB on
[VisitTB].[PatientID]=PatientTB.[PatientID]
join VisitTypeTB on 
[VisitTB].[VisitTypeID]=VisitTypeTB.[VisitTypeID]

where [VisitTB].[PatientID]=@PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Visit_Date_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Visit_Date_By_PatientID]
	 @PatientID int
AS
BEGIN
if not exists(select VisitID from VisitTB where PatientID=@PatientID)
begin
raiserror ('لا يوجد لهذا المريض زيارة',16,1);
return;
end
SELECT [VisitID]
     
      ,[DataOfVisit]
     
  FROM  [VisitTB]
where PatientID=@PatientID



END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Visit_Date_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Visit_Date_All] 
	
AS
BEGIN
	SELECT [VisitID]
      ,[DataOfVisit] 
  FROM  [VisitTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Operation_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Operation_By_ID]
@OperationID int

AS
BEGIN
DELETE FROM [OperationTB]
     

 WHERE OperationID =@OperationID 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Operation_All_By_PatientID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Operation_All_By_PatientID_Felid]
@PatientID int
AS
BEGIN
SELECT [OperationID]
      ,[DateOfOperation]
      ,[PatientID]
      ,[OperationTypeID]
      ,[Note]
  FROM [OperationTB]	
  where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Operation_All_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Operation_All_By_PatientID] 
@PatientID int
AS
BEGIN
SELECT [OperationID]
      ,[DateOfOperation]
      ,[PatientID]
      ,[OperationTypeID]
      ,[Note]
  FROM [OperationTB]	
  where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Operation_All_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Operation_All_By_ID_Felid]
@OperationID int
AS
BEGIN
SELECT [OperationID]
      ,[DateOfOperation]
      ,[PatientID]
      ,[OperationTypeID]
      ,[Note]
  FROM[OperationTB]	
  where OperationID=@OperationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Operation_All_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Operation_All_By_ID]
@OperationID int
AS
BEGIN
SELECT [OperationID]
      ,[DateOfOperation]
      ,[PatientID]
      ,[OperationTypeID]
      ,[Note]
  FROM [OperationTB]	
  where OperationID=@OperationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Operation_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Operation_All]

AS
BEGIN
SELECT [OperationID]
      ,[DateOfOperation]
      ,[PatientID]
      ,[OperationTypeID]
  FROM [OperationTB]	

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Permission_ByUserID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Permission_ByUserID_Felid]
@UserID int	
AS
BEGIN
SELECT [UserID]
      ,[PatientMenu]
      ,[CHB_FilePatient]
      ,[CHB_OperationOfPatient]
      ,[CHB_lastDisease]
      ,[CHB_LastMedication]
      ,[CHB_Visit]
      ,[AnalysisMeun]
      ,[CHB_Analysis]
      ,[CHB_Radio]
      ,[InvoiceMeun]
      ,[CHB_Invoice]
      ,[ToolsMeun]
      ,CHB_CameraWatiching
      ,CHB_BrowesImage
      ,[CHB_ControlPanel]
      ,[CHB_AdminControlPanal]
      ,[CHB_UserContolPanel]
      ,[CHB_BackUp]
      ,[AppointmentMeun]
      ,[CHB_Appointment]
      ,[PrescriptionMeun]
      ,[CHB_Prescription]
 
  FROM [PermissionTB]
where UserID=@UserID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_LastMedication_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_LastMedication_By_ID_Felid]

@PatientID  int
AS
BEGIN
SELECT [PatientID]
      ,[MedicationID]
      ,[LastMedicationID]
      ,[DateOfMedication]
  FROM [Patient_LastMedication]
where PatientID =@PatientID 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_LastMedication_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_LastMedication_All]


AS
BEGIN
SELECT [PatientID]
      ,[MedicationID]
      ,[LastMedicationID]
      ,[DateOfMedication]
  FROM [Patient_LastMedication]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_LastDisease_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_LastDisease_By_ID_Felid]

@PatientID int

AS
BEGIN
	SELECT [PatientID]
      ,[DiseaseID]
      ,[LastDiseaseID]
      ,[FamilyDisease]
      ,[DateOfDisease]
  FROM [Patient_LastDisease]
where PatientID=@PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Patient_LastDisease_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Patient_LastDisease_All]



AS
BEGIN
	SELECT [PatientID]
      ,[DiseaseID]
      ,[LastDiseaseID]
      ,[FamilyDisease]
      ,[DateOfDisease]
  FROM [Patient_LastDisease]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_All_Dtailse_Opreation_By_PatientID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_All_Dtailse_Opreation_By_PatientID]
	@PatientID int
AS
BEGIN
	SELECT [OperationID]
      ,[DateOfOperation]
      ,FirstName=FirstName+' '+LastName
      ,[OperationType]
      ,OperationTB.PatientID
      ,OperationTB.[OperationTypeID]
  FROM [OperationTB]
join PatientTB on
[OperationTB].PatientID=PatientTB.PatientID
join OperationTypeTB on
[OperationTB].[OperationTypeID]=OperationTypeTB.[OperationTypeID]
where OperationTB.PatientID=@PatientID 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_All_Dtailse_Opreation]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_All_Dtailse_Opreation] 
	
AS
BEGIN
	SELECT [OperationID]
      ,[DateOfOperation]
      ,FirstName=FirstName+' '+LastName
      ,[OperationType]
      ,OperationTB.PatientID
      ,OperationTB.[OperationTypeID]
  FROM [OperationTB]
join PatientTB on
[OperationTB].PatientID=PatientTB.PatientID
join OperationTypeTB on
[OperationTB].[OperationTypeID]=OperationTypeTB.[OperationTypeID]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_VisitTB_By_PatientID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_VisitTB_By_PatientID_Felid]
	
@PatientID int

AS
BEGIN
	SELECT [VisitID]
      ,[PatientID]
      ,[DataOfVisit]
      ,[VisitTypeID]
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]
    
      ,Note	

  FROM [VisitTB]

where PatientID=@PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_VisitTB_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_VisitTB_By_PatientID]
	
@PatientID int

AS
BEGIN
	SELECT [VisitID]
      ,[PatientID]
      ,[DataOfVisit]
      ,[VisitTypeID]
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]
  
      ,Note	

  FROM [VisitTB]

where PatientID=@PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_VisitTB_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_VisitTB_By_ID_Felid]

@VisitID int

AS
BEGIN
	
SELECT [VisitID]
      ,[PatientID]
      ,[DataOfVisit]
      ,[VisitTypeID]
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]

      ,Note	
  FROM [VisitTB]
where VisitID=@VisitID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_VisitTB_By_ID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_VisitTB_By_ID]

@VisitID int

AS
BEGIN
	
SELECT [VisitID]
      ,[PatientID]
      ,[DataOfVisit]
      ,[VisitTypeID]
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]

      ,Note	
  FROM [VisitTB]
where VisitID=@VisitID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_VisitTB_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_VisitTB_All]


AS
BEGIN
	
SELECT [VisitID]
      ,[PatientID]
      ,[DataOfVisit]
      ,[VisitTypeID]
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]
   
      ,Note		
  FROM [VisitTB]


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_VisitTB_Ditalse]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_VisitTB_Ditalse]

AS
BEGIN

SELECT [VisitID]
      ,[VisitTB].[PatientID]
,FirstName=FirstName+' '+LastName 
      ,[DataOfVisit]

      ,[VisitTB].[VisitTypeID]
,VisitType
      ,[Weight]
      ,[BloodPressure]
      ,[PulseHeart]
      ,[Temperature]
      ,[PhysicalExamination]

      ,[VisitTB].[Note]
  FROM [VisitTB]
join PatientTB on
[VisitTB].[PatientID]=PatientTB.[PatientID]
join VisitTypeTB on 
[VisitTB].[VisitTypeID]=VisitTypeTB.[VisitTypeID]
END
GO
/****** Object:  Table [dbo].[RadioTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RadioTB](
	[RadioID] [int] IDENTITY(1,1) NOT NULL,
	[RadioTypeID] [int] NOT NULL,
	[RadioSubject] [nvarchar](100) NULL,
	[RadioResult] [nvarchar](100) NULL,
	[VisitID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[ImagePath] [nvarchar](200) NULL,
 CONSTRAINT [PK_RadioTB] PRIMARY KEY CLUSTERED 
(
	[RadioID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PrescriptionTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PrescriptionTB](
	[PrescriptionID] [int] IDENTITY(1,1) NOT NULL,
	[DateOfPrescription] [smalldatetime] NOT NULL,
	[PatientID] [int] NOT NULL,
	[VisitID] [int] NOT NULL,
 CONSTRAINT [PK_PrescriptionTB_1] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_LastMedication_Report]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_LastMedication_Report]
	@LastMedicationID int
AS
BEGIN
	

SELECT [Patient_LastMedication].[PatientID]
       ,FirstName=FirstName+' '+LastName 
      ,[Patient_LastMedication].MedicationID
      ,MedicationName
      ,[LastMedicationID]
      ,[DateOfMedication]
  FROM [Patient_LastMedication]
join PatientTB on
[Patient_LastMedication].[PatientID]=PatientTB.[PatientID]
join Medications on
[Patient_LastMedication].MedicationID=Medications.MedicationID
where LastMedicationID=@LastMedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_LastMedication_details]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_LastMedication_details]
	
AS
BEGIN
	

SELECT [Patient_LastMedication].[PatientID]
       ,FirstName=FirstName+' '+LastName 
      ,[Patient_LastMedication].MedicationID
      ,MedicationName
      ,[LastMedicationID]
      ,[DateOfMedication]
  FROM [Patient_LastMedication]
join PatientTB on
[Patient_LastMedication].[PatientID]=PatientTB.[PatientID]
join Medications on
[Patient_LastMedication].MedicationID=Medications.MedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_LastDisease_details_Report]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_LastDisease_details_Report]
	@LastDiseaseID int
AS
BEGIN
	SELECT [Patient_LastDisease].[PatientID]
      ,FirstName=FirstName+' '+LastName 
      ,[Patient_LastDisease].[DiseaseID]
      ,DiseaseName
      ,[LastDiseaseID]
      ,[FamilyDisease]
      ,[DateOfDisease]
  FROM [Patient_LastDisease]
join PatientTB on
[Patient_LastDisease].[PatientID]=PatientTB.[PatientID]
join DiseaseTB on 

[Patient_LastDisease].[DiseaseID]=DiseaseTB.[DiseaseID]
where LastDiseaseID=@LastDiseaseID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_LastDisease_details_IsTrue]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_LastDisease_details_IsTrue]

AS
BEGIN
	SELECT [Patient_LastDisease].[PatientID]
      ,FirstName=FirstName+' '+LastName 
      ,[Patient_LastDisease].[DiseaseID]
      ,DiseaseName
      ,[LastDiseaseID]
      ,[FamilyDisease]
      ,[DateOfDisease]
  FROM [Patient_LastDisease]
join PatientTB on
[Patient_LastDisease].[PatientID]=PatientTB.[PatientID]
join DiseaseTB on 

[Patient_LastDisease].[DiseaseID]=DiseaseTB.[DiseaseID]
where [FamilyDisease]='true'
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_LastDisease_details]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_LastDisease_details] 
	
AS
BEGIN
	SELECT [Patient_LastDisease].[PatientID]
      ,FirstName=FirstName+' '+LastName 
      ,[Patient_LastDisease].[DiseaseID]
      ,DiseaseName
      ,[LastDiseaseID]
      ,[FamilyDisease]
      ,[DateOfDisease]
  FROM [Patient_LastDisease]
join PatientTB on
[Patient_LastDisease].[PatientID]=PatientTB.[PatientID]
join DiseaseTB on 

[Patient_LastDisease].[DiseaseID]=DiseaseTB.[DiseaseID]
END
GO
/****** Object:  Table [dbo].[InvoiceTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceTB](
	[InVoiceID] [int] IDENTITY(1,1) NOT NULL,
	[VisitID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
	[PaidMoney] [int] NULL,
	[Reminder] [int] NULL,
	[Discount] [int] NULL,
	[Total] [int] NULL,
	[DateInvoice] [smalldatetime] NULL,
 CONSTRAINT [PK_InvoiceTB] PRIMARY KEY CLUSTERED 
(
	[InVoiceID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AnalysisTB]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AnalysisTB](
	[AnalysisID] [int] IDENTITY(1,1) NOT NULL,
	[AnalysisTypeID] [int] NOT NULL,
	[AnalysisSubject] [nvarchar](100) NULL,
	[AnalysisResult] [nvarchar](100) NULL,
	[VisitID] [int] NOT NULL,
	[PatientID] [int] NOT NULL,
 CONSTRAINT [PK_Analysis] PRIMARY KEY CLUSTERED 
(
	[AnalysisID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Browes_Perscreption_All_List_By_PatientID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Browes_Perscreption_All_List_By_PatientID] 
	@PatientID int
AS
BEGIN
SELECT [PrescriptionID]
      ,[DateOfPrescription]
      ,[PatientID]
      ,[VisitID]
  FROM [PrescriptionTB]
where PatientID=@PatientID

	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_InVoiceID_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_InVoiceID_By_PatientID]
	 @PatientID int
AS
BEGIN
	
SELECT [InVoiceID]
      ,[VisitID]
      ,[PatientID]
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
  FROM [InvoiceTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Invoice_ReprtByPatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Invoice_ReprtByPatientID]
	@PatientID int
AS
BEGIN
select [DrName]
      ,[Speciaty]
      ,[Phone]
      ,[Fax]
    
      ,[City]
      ,[Address]
,WebSiteAddress
,[InVoiceID]
      ,VisitTB.[VisitID]
,DataOfVisit      
,[InvoiceTB].[PatientID]
,FirstName=FirstName+' '+LastName
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
   FROM [ClinicData],[InvoiceTB]
join VisitTB on
[InvoiceTB].[VisitID]=VisitTB.[VisitID]
join PatientTB on
[InvoiceTB].[PatientID]=PatientTB.[PatientID]
where [InvoiceTB].[PatientID]=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Invoice_ReportMonth]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Invoice_ReportMonth] 
@FromDate smalldatetime	
,@TODate smalldatetime	
AS
BEGIN

	SELECT [InVoiceID]
      
      ,[Total]
      ,[DateInvoice]
	
  FROM [InvoiceTB]

where [DateInvoice] between @FromDate and @TODate
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Invoic_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Invoic_By_ID_Felid]
	@InVoiceID int
AS
BEGIN
	SELECT [InVoiceID]
      ,[VisitID]
      ,[PatientID]
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
  FROM [InvoiceTB]
where InVoiceID=@InVoiceID    
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Invioce_By_PatientID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Invioce_By_PatientID_Felid] 
@PatientID int	
AS
BEGIN
	SELECT [InVoiceID]
      ,[VisitID]
      ,[PatientID]
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
  FROM [InvoiceTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Invioce_All]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Invioce_All]
	
AS
BEGIN
	SELECT [InVoiceID]
      ,[VisitID]
   
   ,PatientTB.PatientID
,FirstName=FirstName+' '+LastName
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
  FROM [InvoiceTB]
join PatientTB on
[InvoiceTB].PatientID=PatientTB.PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisTB_Report_By_PatientID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisTB_Report_By_PatientID]
@PatientID int
AS
BEGIN
SELECT 

     [DrName]
      ,[Speciaty]
      ,[Phone]
    
      ,[Fax]
     
      ,[WebSiteAddress]
  
      ,[City]
      ,[Address]

 

       ,[AnalysisID]
      ,AnalysisTB.[AnalysisTypeID]
      ,Analysis
      ,[AnalysisSubject]
      ,[AnalysisResult]
      ,AnalysisTB.[VisitID]
      ,DataOfVisit
      ,AnalysisTB.[PatientID]
      ,FirstName=FirstName+' '+LastName
  FROM [ClinicData],[AnalysisTB]
join AnalysisTypeTB on
AnalysisTB.[AnalysisTypeID]=AnalysisTypeTB.AnalysisTypeID
join VisitTB on 
AnalysisTB.[VisitID]=VisitTB.[VisitID]
join PatientTB on
AnalysisTB.[PatientID]=PatientTB.[PatientID]
where AnalysisTB.[PatientID]=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_AnalysisTB_details]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_AnalysisTB_details]
AS
BEGIN
SELECT [AnalysisID]
      ,AnalysisTB.[AnalysisTypeID]
      ,Analysis
      ,[AnalysisSubject]
      ,[AnalysisResult]
      ,AnalysisTB.[VisitID]
      ,DataOfVisit
      ,AnalysisTB.[PatientID]
      ,FirstName=FirstName+' '+LastName
  FROM [AnalysisTB]
join AnalysisTypeTB on
AnalysisTB.[AnalysisTypeID]=AnalysisTypeTB.AnalysisTypeID
join VisitTB on 
AnalysisTB.[VisitID]=VisitTB.[VisitID]
join PatientTB on
AnalysisTB.[PatientID]=PatientTB.[PatientID]

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Analysis_By_PatientID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Analysis_By_PatientID]
	@PatientID int
AS
BEGIN
	SELECT [AnalysisID]
      ,[AnalysisTypeID]
      ,[AnalysisSubject]
      ,[AnalysisResult]
      ,[VisitID]
      ,[PatientID]
  FROM [AnalysisTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Analysis_By_AnalysisID_Felid]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Analysis_By_AnalysisID_Felid]
	@AnalysisID int
AS
BEGIN
	SELECT [AnalysisID]
      ,[AnalysisTypeID]
      ,[AnalysisSubject]
      ,[AnalysisResult]
      ,[VisitID]
      ,[PatientID]
  FROM [AnalysisTB]
where AnalysisID=@AnalysisID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Analysis_By_AnalysisID]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Analysis_By_AnalysisID]
	@AnalysisID int
AS
BEGIN
	SELECT [AnalysisID]
      ,[AnalysisTypeID]
      ,[AnalysisSubject]
      ,[AnalysisResult]
      ,[VisitID]
      ,[PatientID]
  FROM [AnalysisTB]
where AnalysisID=@AnalysisID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Analysis_All]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Analysis_All]
	
AS
BEGIN
	SELECT [AnalysisID]
      ,[AnalysisTypeID]
      ,[AnalysisSubject]
      ,[AnalysisResult]
      ,[VisitID]
      ,[PatientID]
  FROM [AnalysisTB]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Accident_Visit_ByPatient_Visit]    Script Date: 05/14/2009 01:57:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Accident_Visit_ByPatient_Visit]

@VisitID int,@PatientID int

	
AS
BEGIN
SELECT [AccidentID]
      ,[VisitID]
      ,[PatientID]
  FROM [CLINICDB].[dbo].[Visit_Accident]
where VisitID=@VisitID and PatientID=@PatientID 


END
GO
/****** Object:  Table [dbo].[Prescription_Medication]    Script Date: 05/14/2009 01:57:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Prescription_Medication](
	[PrescriptionID] [int] NOT NULL,
	[MedicationID] [int] NOT NULL,
	[Dose] [int] NOT NULL,
	[MedicalCount] [int] NOT NULL,
	[Cleander_Of_Dose] [nvarchar](100) NOT NULL,
	[Type_Of_Medication] [nvarchar](50) NOT NULL,
	[Time_Of_Dose] [nvarchar](50) NOT NULL,
	[Note] [nvarchar](100) NULL,
 CONSTRAINT [PK_Prescription_Medication] PRIMARY KEY CLUSTERED 
(
	[PrescriptionID] ASC,
	[MedicationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Invoice_Detials_By_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_Invoice_Detials_By_PatientID]
	@PatientID int 
AS
BEGIN
	SELECT [InVoiceID]
      ,VisitTB.[VisitID]
,DataOfVisit      
,[InvoiceTB].[PatientID]
,FirstName=FirstName+' '+LastName
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
  FROM [InvoiceTB]
join VisitTB on
[InvoiceTB].[VisitID]=VisitTB.[VisitID]
join PatientTB on
[InvoiceTB].[PatientID]=PatientTB.[PatientID]
where [InvoiceTB].[PatientID]=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Invoice_Datials]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_Invoice_Datials]
	
AS
BEGIN
	SELECT [InVoiceID]
      ,VisitTB.[VisitID]
,DataOfVisit      
,[InvoiceTB].[PatientID]
,FirstName=FirstName+' '+LastName
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
  FROM [InvoiceTB]
join VisitTB on
[InvoiceTB].[VisitID]=VisitTB.[VisitID]
join PatientTB on
[InvoiceTB].[PatientID]=PatientTB.[PatientID]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Invoic_By_Invoice_Report]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_Invoic_By_Invoice_Report] 
	@InVoiceID int 
AS
BEGIN
	SELECT
 [DrID]
      ,[DrName]
      ,[Speciaty]
      ,[Phone]
      ,[Fax]
      ,[ClinicData].[Email]
      ,[Image]
      ,[City]
      ,[Address]
,[InVoiceID]
      ,VisitTB.[VisitID]
,DataOfVisit      
,[InvoiceTB].[PatientID]
,FirstName=FirstName+' '+LastName
      ,[PaidMoney]
      ,[Reminder]
      ,[Discount]
      ,[Total]
,DateInvoice
   FROM [ClinicData],[InvoiceTB]
join VisitTB on
[InvoiceTB].[VisitID]=VisitTB.[VisitID]
join PatientTB on
[InvoiceTB].[PatientID]=PatientTB.[PatientID]
where [InVoiceID]=@InVoiceID
  
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Disise_Visit_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.

CREATE PROCEDURE [dbo].[SP_Brows_Disise_Visit_Felid]
	@DiseaseID int
AS
BEGIN
	SELECT [VisitID]
      ,[PatientID]
      ,[DiseaseID]
  FROM [Visit_Disease]
where DiseaseID=@DiseaseID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Brows_Diasase_Patient_AndVisit]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Brows_Diasase_Patient_AndVisit]
	@PatientID int
,@VisitID int  
AS
BEGIN
	SELECT 
      [Visit_Disease].[DiseaseID]
,DiseaseName
  FROM [Visit_Disease]
join DiseaseTB on
[Visit_Disease].[DiseaseID]=DiseaseTB.[DiseaseID]
where [Visit_Disease].PatientID=@PatientID and [Visit_Disease].VisitID=@VisitID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Visit_Stamp_ByVisitID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Visit_Stamp_ByVisitID] 
	@VisitID int
AS
BEGIN
	SELECT [StampID]
      ,[VisitID]
      ,[PatientID]
  FROM [CLINICDB].[dbo].[Visit_Stamp]

where VisitID=@VisitID 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Stamp_Visit_ByPatient_Visit]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Stamp_Visit_ByPatient_Visit]
	@VisitID int
	,@PatientID int
AS
BEGIN
	SELECT [StampID]
    
  FROM [CLINICDB].[dbo].[Visit_Stamp]
where VisitID=@VisitID and PatientID=@PatientID  


END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Prescription_Datials_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Prescription_Datials_PatientID] 
@PatientID int
AS
BEGIN
	SELECT [PrescriptionID]
      ,[DateOfPrescription]
      ,[PrescriptionTB].[PatientID]
,FirstName=FirstName+' '+LastName 
      ,[PrescriptionTB].[VisitID]
,DataOfVisit
  FROM [PrescriptionTB]
join PatientTB on
[PrescriptionTB].[PatientID]=PatientTB.[PatientID]
join VisitTB on
[PrescriptionTB].[VisitID]=VisitTB.[VisitID]
where [PrescriptionTB].[PatientID]=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Prescription_Datials]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Prescription_Datials] 

AS
BEGIN
	SELECT [PrescriptionID]
      ,[DateOfPrescription]
      ,[PrescriptionTB].[PatientID]
,FirstName=FirstName+' '+LastName 
      ,[PrescriptionTB].[VisitID]
,DataOfVisit
  FROM [PrescriptionTB]
join PatientTB on
[PrescriptionTB].[PatientID]=PatientTB.[PatientID]
join VisitTB on
[PrescriptionTB].[VisitID]=VisitTB.[VisitID]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Prescription_By_Patient]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Prescription_By_Patient]
	@PatientID int
AS
BEGIN
	SELECT [PrescriptionID]
      ,[DateOfPrescription]
      ,[PatientID]
      ,[VisitID]
  FROM [PrescriptionTB]
where PatientID=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Prescription_By_ID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Prescription_By_ID_Felid]
	

	@PrescriptionID int
AS
BEGIN
	SELECT [PrescriptionID]
      ,[DateOfPrescription]
      ,[PatientID]
      ,[VisitID]
  FROM [PrescriptionTB]
where PrescriptionID=@PrescriptionID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioTB_By_RadioID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioTB_By_RadioID_Felid]
	@RadioID int 
AS
BEGIN
SELECT [RadioID]
      ,[RadioTypeID]
      ,[RadioSubject]
      ,[RadioResult]
      ,[VisitID]
      ,[PatientID]
      ,[ImagePath]
  FROM [RadioTB]
where RadioID=@RadioID	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_RadioTB_All]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_RadioTB_All]
	
AS
BEGIN
SELECT [RadioID]
      ,[RadioTypeID]
      ,[RadioSubject]
      ,[RadioResult]
      ,[VisitID]
      ,[PatientID]
      ,[ImagePath]
  FROM [RadioTB]	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Radio_Report_PatientID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Radio_Report_PatientID] 
@PatientID int
AS
BEGIN
SELECT 
      [DrName]
      ,[Speciaty]
      ,[Phone]
   
      ,[Fax]
     
      ,[WebSiteAddress]
     
      ,[City]
      ,[Address]


, [RadioID]
      ,[RadioTB].[RadioTypeID]
,RadioType
      ,[RadioSubject]
      ,[RadioResult]
      ,[RadioTB].[VisitID]
,DataOfVisit
      ,[RadioTB].[PatientID]
 ,FirstName=FirstName+' '+LastName 
      
  FROM [ClinicData],[RadioTB]
join RadioTypeTB on
[RadioTB].[RadioTypeID]=RadioTypeTB.[RadioTypeID]
join VisitTB on
[RadioTB].[VisitID]=VisitTB.[VisitID]
join PatientTB on
[RadioTB].[PatientID]=PatientTB.[PatientID]
where [RadioTB].[PatientID]=@PatientID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Radio_Dateils]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Radio_Dateils] 

AS
BEGIN
SELECT [RadioID]
      ,[RadioTB].[RadioTypeID]
,RadioType
      ,[RadioSubject]
      ,[RadioResult]
      ,[RadioTB].[VisitID]
,DataOfVisit
      ,[RadioTB].[PatientID]
 ,FirstName=FirstName+' '+LastName 
    ,[RadioTB].ImagePath  
  FROM [RadioTB]
join RadioTypeTB on
[RadioTB].[RadioTypeID]=RadioTypeTB.[RadioTypeID]
join VisitTB on
[RadioTB].[VisitID]=VisitTB.[VisitID]
join PatientTB on
[RadioTB].[PatientID]=PatientTB.[PatientID]
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Invoice]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Invoice] 
@InVoiceID int

AS
BEGIN
	DELETE FROM [InvoiceTB]
     
 WHERE InVoiceID=@InVoiceID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Diasase_Patient_AndVisit]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Diasase_Patient_AndVisit]

@DiseaseID int
AS
BEGIN
	DELETE FROM [Visit_Disease]
      
 WHERE [DiseaseID] = @DiseaseID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Analysis]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Analysis]
@AnalysisID int 

AS
BEGIN
	DELETE FROM [CLINICDB].[dbo].[AnalysisTB]
      
 WHERE AnalysisID=@AnalysisID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Visit_AccidentByVisitID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Visit_AccidentByVisitID]
@VisitID int
	
AS
BEGIN
SELECT [AccidentID]
      ,[VisitID]
      ,[PatientID]
  FROM [CLINICDB].[dbo].[Visit_Accident]
where VisitID=@VisitID




END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Analysis]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Analysis]
	@AnalysisTypeID int
,@AnalysisSubject nvarchar(100)
,@AnalysisResult nvarchar(100)
,@VisitID int
,@PatientID int
AS
BEGIN

	INSERT INTO [AnalysisTB]
           ([AnalysisTypeID]
           ,[AnalysisSubject]
           ,[AnalysisResult]
           ,[VisitID]
           ,[PatientID])
     VALUES
           (@AnalysisTypeID
           ,@AnalysisSubject           
           ,@AnalysisResult
           ,@VisitID
           ,@PatientID)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Prescription]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Prescription]
@PrescriptionID int 

AS
BEGIN
DELETE FROM [PrescriptionTB]
     
 WHERE PrescriptionID=@PrescriptionID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Visit_Stamp_ByVisitID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Visit_Stamp_ByVisitID] 
	 
	@StampID int 
AS
BEGIN
	DELETE FROM [CLINICDB].[dbo].[Visit_Stamp]
     





where StampID=@StampID 

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Visit_Accident_ByAccidentID]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Visit_Accident_ByAccidentID]
	@AccidentID int 
AS
BEGIN
	DELETE FROM [CLINICDB].[dbo].[Visit_Accident]
      WHERE AccidentID=@AccidentID 



END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_RadioTB]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_RadioTB]
	@RadioID int 
AS
BEGIN
DELETE FROM [RadioTB]
      
where RadioID=@RadioID	
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Invoice]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Invoice] 

@VisitID int,
@PatientID int,
@PaidMoney	int,
@Reminder int,
@Discount int,
@Total int,
@DateInvoice smalldatetime
AS
BEGIN
	INSERT INTO [InvoiceTB]
           ([VisitID]
           ,[PatientID]
           ,[PaidMoney]
           ,[Reminder]
           ,[Discount]
           ,[Total]
,DateInvoice)
     VALUES
           (@VisitID
           ,@PatientID
           ,@PaidMoney
           ,@Reminder
           ,@Discount
           ,@Total
          ,@DateInvoice)

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Diasase_Patient_AndVisit]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Diasase_Patient_AndVisit]
@VisitID int
,@PatientID int
 
,@DiseaseID int
AS
BEGIN
if exists(select [DiseaseID] from [Visit_Disease] where [DiseaseID]=@DiseaseID and([VisitID]=@VisitID and [PatientID]=@PatientID))
begin
raiserror('المرض موجود مسبقاً',16,1)
return;
end
	INSERT INTO [Visit_Disease]
           ([VisitID]
           ,[PatientID]
           ,[DiseaseID])
     VALUES
           (@VisitID 
           ,@PatientID
           ,@DiseaseID)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Prescription]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Prescription]

@DateOfPrescription smalldatetime
,@PatientID int 
,@VisitID int	

AS
BEGIN
if not exists(select VisitID from VisitTB where PatientID=@PatientID)
begin
raiserror('لا يوجد لهذا المريض زيارة',16,1);
return;
end
	INSERT INTO [PrescriptionTB]
           (
           
[DateOfPrescription]
           ,[PatientID]
           ,[VisitID])
     VALUES
           (@DateOfPrescription
           ,@PatientID
           ,@VisitID)
select SCOPE_IDENTITY();

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_RadioTB]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_RadioTB]
@RadioTypeID int 
,@RadioSubject nvarchar(100)
,@RadioResult nvarchar(100)
,@VisitID int
,@PatientID int
,@ImagePath nvarchar(200)
AS
BEGIN
INSERT INTO [RadioTB]
           ([RadioTypeID]
           ,[RadioSubject]
           ,[RadioResult]
           ,[VisitID]
           ,[PatientID]
           ,[ImagePath])
     VALUES
           (@RadioTypeID 
           ,@RadioSubject
           ,@RadioResult 
           ,@VisitID 
           ,@PatientID
           ,@ImagePath)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_RadioTB]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_RadioTB]
@RadioID int 
,@RadioTypeID int 
,@RadioSubject nvarchar(100)
,@RadioResult nvarchar(100)
,@VisitID int
,@PatientID int

AS
BEGIN
UPDATE [RadioTB]
   SET [RadioTypeID] = @RadioTypeID
      ,[RadioSubject] =@RadioSubject
      ,[RadioResult] = @RadioResult 
      ,[VisitID] = @VisitID
      ,[PatientID] =@PatientID
      
 WHERE RadioID=@RadioID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Prescription]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Prescription]
@PrescriptionID int 
,@DateOfPrescription smalldatetime
,@PatientID int 
,@VisitID int	

AS
BEGIN
UPDATE [PrescriptionTB]
   SET [DateOfPrescription] = @DateOfPrescription
      ,[PatientID] = @PatientID
      ,[VisitID] = @VisitID
 WHERE PrescriptionID=@PrescriptionID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Visit_Stamp]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Visit_Stamp]
	@StampID int 
	,@VisitID int
	,@PatientID int
AS
BEGIN
  if exists (select [StampID] from [Visit_Stamp] where ([StampID]=@StampID and VisitID=@VisitID and [PatientID]=@PatientID))
begin
return ;
end
	INSERT INTO [CLINICDB].[dbo].[Visit_Stamp]
           ([StampID]
           ,[VisitID]
           ,[PatientID])
     VALUES
           (@StampID
           ,@VisitID
           ,@PatientID)



END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Visit_Accident]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Visit_Accident]
@AccidentID int,
@VisitID int,@PatientID int

	
AS
BEGIN

  if exists (select [AccidentID] from [Visit_Accident] where ([AccidentID]=@AccidentID and VisitID=@VisitID and [PatientID]=@PatientID))
begin
return ;
end
INSERT INTO [CLINICDB].[dbo].[Visit_Accident]
           ([AccidentID]
           ,[VisitID]
           ,[PatientID])
     VALUES
           (@AccidentID
           ,@VisitID
           ,@PatientID)



END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpData_Analysis]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpData_Analysis]
@AnalysisID int 
,@AnalysisTypeID int
,@AnalysisSubject nvarchar(100)
,@AnalysisResult nvarchar(100)
,@VisitID int
,@PatientID int
AS
BEGIN
	UPDATE [AnalysisTB]
   SET [AnalysisTypeID] = @AnalysisTypeID
      ,[AnalysisSubject] = @AnalysisSubject
      ,[AnalysisResult] = @AnalysisResult
      ,[VisitID] = @VisitID
      ,[PatientID] = @PatientID
 WHERE AnalysisID=@AnalysisID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Visit_Stamp_ByVisitID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_Visit_Stamp_ByVisitID] 
	 @StampID int
	,@VisitID int ,@PatientID int
AS
BEGIN
 if exists (select [StampID] from [Visit_Stamp] where  [StampID]=@StampID)
begin
return ;
end
	UPDATE [CLINICDB].[dbo].[Visit_Stamp]
   SET [StampID] = @StampID
      


where VisitID=@VisitID and [PatientID] = @PatientID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Invoice]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_Invoice] 
@InVoiceID int,
@VisitID int,
@PatientID int,
@PaidMoney	int,
@Reminder int,
@Discount int,
@Total int,
@DateInvoice smalldatetime
AS
BEGIN
	UPDATE [InvoiceTB]
   SET [VisitID] = @VisitID
      ,[PatientID] = @PatientID
      ,[PaidMoney] = @PaidMoney
      ,[Reminder] = @Reminder
      ,[Discount] = @Discount
      ,[Total] = @Total
,DateInvoice=@DateInvoice
 WHERE InVoiceID=@InVoiceID

END
GO
/****** Object:  StoredProcedure [dbo].[SP_UPdate_Diasase_Patient_AndVisit]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UPdate_Diasase_Patient_AndVisit]
@VisitID int
,@PatientID int 

,@DiseaseID int
AS
BEGIN
if exists(select [DiseaseID] from [Visit_Disease] where [DiseaseID]=@DiseaseID and([VisitID]=@VisitID and [PatientID]=@PatientID))
begin
raiserror('المرض موجود مسبقاً',16,1)
return;
end
	UPDATE [Visit_Disease]
   SET 
      [DiseaseID] = @DiseaseID
 WHERE VisitID=@VisitID and PatientID=@PatientID 
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_RadioTB_Image_By_ID]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_RadioTB_Image_By_ID] 
@RadioID int 	
,@ImagePath nvarchar(200)
AS
BEGIN
	UPDATE [CLINICDB].[dbo].[RadioTB]
   SET 
      [ImagePath] = @ImagePath
 WHERE RadioID=@RadioID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_UpDate_Prescription_Medication]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_UpDate_Prescription_Medication]
@PrescriptionID int 
,@MedicationID int
,@Dose int
,@MedicalCount int
,@Cleander_Of_Dose nvarchar(100)
,@Type_Of_Medication nvarchar(50)
,@Time_Of_Dose nvarchar(50)
,@Note nvarchar(100)
AS
BEGIN
if exists(select MedicationID from Prescription_Medication where (MedicationID=@MedicationID and PrescriptionID=@PrescriptionID) )
begin
raiserror('لا يمكن اضافة هذا الداوء ',16,1);
return;
end
	UPDATE[Prescription_Medication]
   SET [PrescriptionID] = @PrescriptionID
      ,[MedicationID] = @MedicationID
      ,[Dose] = @Dose
      ,[MedicalCount] = @MedicalCount
      ,Cleander_Of_Dose=@Cleander_Of_Dose
      ,Type_Of_Medication=@Type_Of_Medication
      ,Time_Of_Dose=@Time_Of_Dose
      ,[Note] = @Note
 
      
where PrescriptionID=@PrescriptionID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Prescription_Report]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Prescription_Report]
@PrescriptionID int 
,@ImageP Image
AS
BEGIN
	
 SELECT ClinicData.DrName,ClinicData.Speciaty, ClinicData.Phone, ClinicData.Mobile, ClinicData.WebSiteAddress, ClinicData.City, ClinicData.Address,Medications.MedicationName, PatientTB.FirstName, PatientTB.LastName, PatientTB.Sensitive,PrescriptionTB.DateOfPrescription,VisitTB.DataOfVisit, Prescription_Medication.PrescriptionID, Prescription_Medication.MedicationID,Prescription_Medication.Dose,Prescription_Medication.MedicalCount,Prescription_Medication.Cleander_Of_Dose,Prescription_Medication.Type_Of_Medication,Prescription_Medication.Time_Of_Dose,Prescription_Medication.Note,ImagePre=@ImageP
 FROM   ClinicData,(((Prescription_Medication INNER JOIN PrescriptionTB ON Prescription_Medication.PrescriptionID=PrescriptionTB.PrescriptionID) INNER JOIN  Medications ON Prescription_Medication.MedicationID=Medications.MedicationID) INNER JOIN VisitTB ON (PrescriptionTB.VisitID=VisitTB.VisitID) AND (PrescriptionTB.PatientID=VisitTB.PatientID)) INNER JOIN PatientTB ON VisitTB.PatientID=PatientTB.PatientID 
where Prescription_Medication.PrescriptionID=@PrescriptionID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Insert_Prescription_Medication]    Script Date: 05/14/2009 01:57:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Insert_Prescription_Medication]
@PrescriptionID int 
,@MedicationID int
,@Dose int
,@MedicalCount int
,@Cleander_Of_Dose nvarchar(100)
,@Type_Of_Medication nvarchar(50)
,@Time_Of_Dose nvarchar(50)
,@Note nvarchar(100)
AS
BEGIN
if exists(select MedicationID from Prescription_Medication where (MedicationID=@MedicationID and PrescriptionID=@PrescriptionID) )
begin
raiserror('لا يمكن اضافة هذا الداوء ',16,1);
return;
end

INSERT INTO [Prescription_Medication]
          
     VALUES
           (@PrescriptionID
           ,@MedicationID
           ,@Dose
           ,@MedicalCount
	       ,@Cleander_Of_Dose
           ,@Type_Of_Medication
           ,@Time_Of_Dose	
           ,@Note)
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Delete_Prescription_Medication]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Delete_Prescription_Medication]
	@MedicationID int 
AS
BEGIN
	DELETE FROM [Prescription_Medication]
      
where MedicationID=@MedicationID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Prescription_Medication_By_PrescriptionID_List]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Prescription_Medication_By_PrescriptionID_List]
	@PrescriptionID int 
AS
BEGIN
	SELECT [PrescriptionID]
      ,[Prescription_Medication].[MedicationID]
     , [MedicationName]
      ,[Dose]
      ,[MedicalCount]
      ,[Cleander_Of_Dose]
      ,[Type_Of_Medication]
      ,[Time_Of_Dose]
      ,[Note]
  FROM [Prescription_Medication] 
join Medications on
[Prescription_Medication].[MedicationID]=Medications.[MedicationID]
where PrescriptionID=@PrescriptionID
END
GO
/****** Object:  StoredProcedure [dbo].[SP_Browes_Prescription_Medication_By_PrescriptionID_Felid]    Script Date: 05/14/2009 01:57:42 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_Browes_Prescription_Medication_By_PrescriptionID_Felid]
	@MedicationID int 
AS
BEGIN
	SELECT [PrescriptionID]
      ,[Prescription_Medication].[MedicationID]
     , [MedicationName]
      ,[Dose]
      ,[MedicalCount]
      ,[Cleander_Of_Dose]
      ,[Type_Of_Medication]
      ,[Time_Of_Dose]
      ,[Note]
  FROM [Prescription_Medication] 
join Medications on
[Prescription_Medication].[MedicationID]=Medications.[MedicationID]
where [Prescription_Medication].[MedicationID]=@MedicationID
END
GO
/****** Object:  ForeignKey [FK_AnalysisTB_AnalysisTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[AnalysisTB]  WITH CHECK ADD  CONSTRAINT [FK_AnalysisTB_AnalysisTypeTB] FOREIGN KEY([AnalysisTypeID])
REFERENCES [dbo].[AnalysisTypeTB] ([AnalysisTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnalysisTB] CHECK CONSTRAINT [FK_AnalysisTB_AnalysisTypeTB]
GO
/****** Object:  ForeignKey [FK_AnalysisTB_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[AnalysisTB]  WITH CHECK ADD  CONSTRAINT [FK_AnalysisTB_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AnalysisTB] CHECK CONSTRAINT [FK_AnalysisTB_VisitTB]
GO
/****** Object:  ForeignKey [FK_AppointmentTB_VisitTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[AppointmentTB]  WITH CHECK ADD  CONSTRAINT [FK_AppointmentTB_VisitTypeTB] FOREIGN KEY([VisitTypeID])
REFERENCES [dbo].[VisitTypeTB] ([VisitTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AppointmentTB] CHECK CONSTRAINT [FK_AppointmentTB_VisitTypeTB]
GO
/****** Object:  ForeignKey [FK_InvoiceTB_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[InvoiceTB]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceTB_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[InvoiceTB] CHECK CONSTRAINT [FK_InvoiceTB_VisitTB]
GO
/****** Object:  ForeignKey [FK_OperationTB_OperationTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[OperationTB]  WITH CHECK ADD  CONSTRAINT [FK_OperationTB_OperationTypeTB] FOREIGN KEY([OperationTypeID])
REFERENCES [dbo].[OperationTypeTB] ([OperationTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OperationTB] CHECK CONSTRAINT [FK_OperationTB_OperationTypeTB]
GO
/****** Object:  ForeignKey [FK_OperationTB_PatientTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[OperationTB]  WITH CHECK ADD  CONSTRAINT [FK_OperationTB_PatientTB] FOREIGN KEY([PatientID])
REFERENCES [dbo].[PatientTB] ([PatientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[OperationTB] CHECK CONSTRAINT [FK_OperationTB_PatientTB]
GO
/****** Object:  ForeignKey [FK_Patient_LastDisease_DiseaseTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Patient_LastDisease]  WITH CHECK ADD  CONSTRAINT [FK_Patient_LastDisease_DiseaseTB] FOREIGN KEY([DiseaseID])
REFERENCES [dbo].[DiseaseTB] ([DiseaseID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient_LastDisease] CHECK CONSTRAINT [FK_Patient_LastDisease_DiseaseTB]
GO
/****** Object:  ForeignKey [FK_Patient_LastDisease_PatientTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Patient_LastDisease]  WITH CHECK ADD  CONSTRAINT [FK_Patient_LastDisease_PatientTB] FOREIGN KEY([PatientID])
REFERENCES [dbo].[PatientTB] ([PatientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient_LastDisease] CHECK CONSTRAINT [FK_Patient_LastDisease_PatientTB]
GO
/****** Object:  ForeignKey [FK_Patient_Medication_Medications]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Patient_LastMedication]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Medication_Medications] FOREIGN KEY([MedicationID])
REFERENCES [dbo].[Medications] ([MedicationID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient_LastMedication] CHECK CONSTRAINT [FK_Patient_Medication_Medications]
GO
/****** Object:  ForeignKey [FK_Patient_Medication_PatientTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Patient_LastMedication]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Medication_PatientTB] FOREIGN KEY([PatientID])
REFERENCES [dbo].[PatientTB] ([PatientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient_LastMedication] CHECK CONSTRAINT [FK_Patient_Medication_PatientTB]
GO
/****** Object:  ForeignKey [FK_PatientTB_BloodTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[PatientTB]  WITH CHECK ADD  CONSTRAINT [FK_PatientTB_BloodTB] FOREIGN KEY([BloodID])
REFERENCES [dbo].[BloodTB] ([BloodID])
GO
ALTER TABLE [dbo].[PatientTB] CHECK CONSTRAINT [FK_PatientTB_BloodTB]
GO
/****** Object:  ForeignKey [FK_PatientTB_SexTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[PatientTB]  WITH CHECK ADD  CONSTRAINT [FK_PatientTB_SexTB] FOREIGN KEY([SexID])
REFERENCES [dbo].[SexTB] ([SexID])
GO
ALTER TABLE [dbo].[PatientTB] CHECK CONSTRAINT [FK_PatientTB_SexTB]
GO
/****** Object:  ForeignKey [FK_PatientTB_SocialStateTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[PatientTB]  WITH CHECK ADD  CONSTRAINT [FK_PatientTB_SocialStateTB] FOREIGN KEY([SocialStateID])
REFERENCES [dbo].[SocialStateTB] ([SocialStateID])
GO
ALTER TABLE [dbo].[PatientTB] CHECK CONSTRAINT [FK_PatientTB_SocialStateTB]
GO
/****** Object:  ForeignKey [FK_PermissionTB_Users]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[PermissionTB]  WITH CHECK ADD  CONSTRAINT [FK_PermissionTB_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([UserID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PermissionTB] CHECK CONSTRAINT [FK_PermissionTB_Users]
GO
/****** Object:  ForeignKey [FK_Prescription_Medication_Medications]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Prescription_Medication]  WITH CHECK ADD  CONSTRAINT [FK_Prescription_Medication_Medications] FOREIGN KEY([MedicationID])
REFERENCES [dbo].[Medications] ([MedicationID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prescription_Medication] CHECK CONSTRAINT [FK_Prescription_Medication_Medications]
GO
/****** Object:  ForeignKey [FK_Prescription_Medication_PrescriptionTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Prescription_Medication]  WITH CHECK ADD  CONSTRAINT [FK_Prescription_Medication_PrescriptionTB] FOREIGN KEY([PrescriptionID])
REFERENCES [dbo].[PrescriptionTB] ([PrescriptionID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Prescription_Medication] CHECK CONSTRAINT [FK_Prescription_Medication_PrescriptionTB]
GO
/****** Object:  ForeignKey [FK_PrescriptionTB_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[PrescriptionTB]  WITH CHECK ADD  CONSTRAINT [FK_PrescriptionTB_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PrescriptionTB] CHECK CONSTRAINT [FK_PrescriptionTB_VisitTB]
GO
/****** Object:  ForeignKey [FK_RadioTB_RadioTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[RadioTB]  WITH CHECK ADD  CONSTRAINT [FK_RadioTB_RadioTypeTB] FOREIGN KEY([RadioTypeID])
REFERENCES [dbo].[RadioTypeTB] ([RadioTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RadioTB] CHECK CONSTRAINT [FK_RadioTB_RadioTypeTB]
GO
/****** Object:  ForeignKey [FK_RadioTB_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[RadioTB]  WITH CHECK ADD  CONSTRAINT [FK_RadioTB_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RadioTB] CHECK CONSTRAINT [FK_RadioTB_VisitTB]
GO
/****** Object:  ForeignKey [FK_Users_SexTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_SexTB] FOREIGN KEY([SexID])
REFERENCES [dbo].[SexTB] ([SexID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_SexTB]
GO
/****** Object:  ForeignKey [FK_Visit_Accident_AccidentTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Visit_Accident]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Accident_AccidentTB] FOREIGN KEY([AccidentID])
REFERENCES [dbo].[AccidentTB] ([AccidentID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit_Accident] CHECK CONSTRAINT [FK_Visit_Accident_AccidentTB]
GO
/****** Object:  ForeignKey [FK_Visit_Accident_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Visit_Accident]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Accident_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit_Accident] CHECK CONSTRAINT [FK_Visit_Accident_VisitTB]
GO
/****** Object:  ForeignKey [FK_Visit_Disease_DiseaseTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Visit_Disease]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Disease_DiseaseTB] FOREIGN KEY([DiseaseID])
REFERENCES [dbo].[DiseaseTB] ([DiseaseID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit_Disease] CHECK CONSTRAINT [FK_Visit_Disease_DiseaseTB]
GO
/****** Object:  ForeignKey [FK_Visit_Disease_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Visit_Disease]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Disease_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit_Disease] CHECK CONSTRAINT [FK_Visit_Disease_VisitTB]
GO
/****** Object:  ForeignKey [FK_Visit_Stamp_StampTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Visit_Stamp]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Stamp_StampTB] FOREIGN KEY([StampID])
REFERENCES [dbo].[StampTB] ([StampID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit_Stamp] CHECK CONSTRAINT [FK_Visit_Stamp_StampTB]
GO
/****** Object:  ForeignKey [FK_Visit_Stamp_VisitTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[Visit_Stamp]  WITH CHECK ADD  CONSTRAINT [FK_Visit_Stamp_VisitTB] FOREIGN KEY([VisitID], [PatientID])
REFERENCES [dbo].[VisitTB] ([VisitID], [PatientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Visit_Stamp] CHECK CONSTRAINT [FK_Visit_Stamp_VisitTB]
GO
/****** Object:  ForeignKey [FK_VisitTB_PatientTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[VisitTB]  WITH CHECK ADD  CONSTRAINT [FK_VisitTB_PatientTB] FOREIGN KEY([PatientID])
REFERENCES [dbo].[PatientTB] ([PatientID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VisitTB] CHECK CONSTRAINT [FK_VisitTB_PatientTB]
GO
/****** Object:  ForeignKey [FK_VisitTB_VisitTypeTB]    Script Date: 05/14/2009 01:57:46 ******/
ALTER TABLE [dbo].[VisitTB]  WITH CHECK ADD  CONSTRAINT [FK_VisitTB_VisitTypeTB] FOREIGN KEY([VisitTypeID])
REFERENCES [dbo].[VisitTypeTB] ([VisitTypeID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[VisitTB] CHECK CONSTRAINT [FK_VisitTB_VisitTypeTB]
GO
