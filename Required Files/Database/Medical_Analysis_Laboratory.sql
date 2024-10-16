USE [master]
GO
CREATE DATABASE [Medical_Analysis_Laboratory]
USE [Medical_Analysis_Laboratory]

GO
CREATE TABLE [dbo].[Patient_Visit_Tests_TB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[patient_visit_id] [int] NULL,
	[test_id] [int] NULL,
	[user_id] [int] NULL,
	[test_val] [float] NULL,
	[test_diagnosis] [text] NULL,
	[dateAdd] [date] NULL,
 CONSTRAINT [PK_Patient_Visit_Tests_TB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patient_Visits_TB]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient_Visits_TB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[patient_id] [int] NULL,
	[user_id] [int] NULL,
	[tests_number] [int] NULL,
	[note] [text] NULL,
	[dateAdd] [date] NULL,
 CONSTRAINT [PK_Patient_Visits_TB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients_TB]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients_TB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idUser] [int] NULL,
	[name] [nvarchar](50) NULL,
	[age] [nvarchar](10) NULL,
	[phone] [nvarchar](30) NULL,
	[gender] [nvarchar](5) NULL,
	[address] [nvarchar](200) NULL,
	[testCount] [int] NULL,
	[note] [nvarchar](200) NULL,
	[dateAdd] [date] NULL,
 CONSTRAINT [PK_Patients_TB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tests_TB]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tests_TB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idParent] [int] NULL,
	[idUser] [int] NULL,
	[name] [nvarchar](50) NULL,
	[isCategory] [bit] NULL,
	[rangeBegin] [float] NULL,
	[rangeEnd] [float] NULL,
	[diagnosisValueLessThanBegin] [text] NULL,
	[diagnosisValueBetweenRange] [text] NULL,
	[diagnosisValueBiggerThanEnd] [text] NULL,
	[note] [text] NULL,
	[dateAdd] [date] NULL,
 CONSTRAINT [PK_Tests_TB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users_TB]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users_TB](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NULL,
	[age] [nchar](10) NULL,
	[phone] [nvarchar](30) NULL,
	[address] [nvarchar](200) NULL,
	[userName] [nvarchar](50) NULL,
	[password] [nvarchar](50) NULL,
	[typeUser] [nchar](15) NULL,
	[dateAdd] [date] NULL,
 CONSTRAINT [PK_Users_TB] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Patient_Visit_Tests_TB]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Visit_Tests_TB_Patient_Visits_TB] FOREIGN KEY([patient_visit_id])
REFERENCES [dbo].[Patient_Visits_TB] ([id])
GO
ALTER TABLE [dbo].[Patient_Visit_Tests_TB] CHECK CONSTRAINT [FK_Patient_Visit_Tests_TB_Patient_Visits_TB]
GO
ALTER TABLE [dbo].[Patient_Visit_Tests_TB]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Visit_Tests_TB_Tests_TB] FOREIGN KEY([test_id])
REFERENCES [dbo].[Tests_TB] ([id])
GO
ALTER TABLE [dbo].[Patient_Visit_Tests_TB] CHECK CONSTRAINT [FK_Patient_Visit_Tests_TB_Tests_TB]
GO
ALTER TABLE [dbo].[Patient_Visit_Tests_TB]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Visit_Tests_TB_Users_TB] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users_TB] ([id])
GO
ALTER TABLE [dbo].[Patient_Visit_Tests_TB] CHECK CONSTRAINT [FK_Patient_Visit_Tests_TB_Users_TB]
GO
ALTER TABLE [dbo].[Patient_Visits_TB]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Visits_TB_Patients_TB] FOREIGN KEY([patient_id])
REFERENCES [dbo].[Patients_TB] ([id])
GO
ALTER TABLE [dbo].[Patient_Visits_TB] CHECK CONSTRAINT [FK_Patient_Visits_TB_Patients_TB]
GO
ALTER TABLE [dbo].[Patient_Visits_TB]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Visits_TB_Users_TB] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users_TB] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient_Visits_TB] CHECK CONSTRAINT [FK_Patient_Visits_TB_Users_TB]
GO
ALTER TABLE [dbo].[Patients_TB]  WITH CHECK ADD  CONSTRAINT [FK_Patients_TB_Users_TB] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users_TB] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patients_TB] CHECK CONSTRAINT [FK_Patients_TB_Users_TB]
GO
ALTER TABLE [dbo].[Tests_TB]  WITH CHECK ADD  CONSTRAINT [FK_Tests_TB_Tests_TB] FOREIGN KEY([idParent])
REFERENCES [dbo].[Tests_TB] ([id])
GO
ALTER TABLE [dbo].[Tests_TB] CHECK CONSTRAINT [FK_Tests_TB_Tests_TB]
GO
ALTER TABLE [dbo].[Tests_TB]  WITH CHECK ADD  CONSTRAINT [FK_Tests_TB_Users_TB] FOREIGN KEY([idUser])
REFERENCES [dbo].[Users_TB] ([id])
GO
ALTER TABLE [dbo].[Tests_TB] CHECK CONSTRAINT [FK_Tests_TB_Users_TB]
GO
/****** Object:  StoredProcedure [dbo].[deletePatient]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[deletePatient]
    @id INT
AS
BEGIN
    DELETE FROM Patients_TB
    WHERE id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[deleteTest]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteTest]
@id int
as
begin
delete from Tests_TB 
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[deleteTestParentWithChild]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteTestParentWithChild]
    @id INT
AS
BEGIN

    DELETE FROM Tests_TB 
    WHERE idParent = @id;


    DELETE FROM Tests_TB 
    WHERE id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[deleteTestParentWithoutChild]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteTestParentWithoutChild]
    @id INT
AS
BEGIN
    DECLARE @parentId INT;


    SELECT @parentId = idParent FROM Tests_TB WHERE id = @id;

 
    UPDATE Tests_TB 
    SET idParent = 
        CASE 
            WHEN @parentId IS NOT NULL THEN @parentId
            ELSE NULL
        END
    WHERE idParent = @id;


    --DELETE FROM Tests_TB 
    --WHERE id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[deleteUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[deleteUser]
@id int
as
begin
delete from Users_TB
where id =@id
end
GO
/****** Object:  StoredProcedure [dbo].[deleteVisit]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[deleteVisit]

@idVisit int
as
begin
-------Delete Child ---------
delete from Patient_Visit_Tests_TB
where patient_visit_id=@idVisit
-------Delete Visit ----------
delete from Patient_Visits_TB 
where id =@idVisit
end
GO
/****** Object:  StoredProcedure [dbo].[getDataCheckUserName]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataCheckUserName]
@userName nvarchar(50)
as
begin
select userName from Users_TB
where userName=@userName
end
GO
/****** Object:  StoredProcedure [dbo].[getDataIdCurrentVisit]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataIdCurrentVisit]
as
begin
select top 1 V.id from Patient_Visits_TB V
order by V.id desc
end
GO
/****** Object:  StoredProcedure [dbo].[getDataIdUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataIdUser]
@userName nvarchar(50)
as
begin
select id from Users_TB
where userName=@userName
end
GO
/****** Object:  StoredProcedure [dbo].[getDataIsCanDeletePatient]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDataIsCanDeletePatient]
    @id INT
AS
BEGIN
select COUNT(id) 
    FROM Patient_Visits_TB 
    WHERE patient_id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[getDataIsCanDeleteUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDataIsCanDeleteUser]
    @id INT
AS
BEGIN
    DECLARE @patientCount INT;
    DECLARE @testCount INT;
    DECLARE @visitCount INT;


    SELECT @patientCount = COUNT(id) 
    FROM Patients_TB
    WHERE idUser = @id;

    SELECT @testCount = COUNT(id) 
    FROM Tests_TB
    WHERE idUser = @id;

	SELECT @visitCount = COUNT(id) 
    FROM Patient_Visits_TB
    WHERE user_id = @id;

  IF (@patientCount = 0 AND @testCount = 0 and @visitCount=0)
    BEGIN
        SELECT CAST(1 AS BIT) AS result;  -- True
    END
    ELSE
    BEGIN
        SELECT CAST(0 AS BIT) AS result;  -- False
    END
END
GO
/****** Object:  StoredProcedure [dbo].[getDataNameUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataNameUser]
@userName nvarchar(50)
as
begin
select name from Users_TB
where userName=@userName
end
GO
/****** Object:  StoredProcedure [dbo].[getDataPatients]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDataPatients]
AS
BEGIN
    SELECT
        P.id AS 'المعرف',
        P.name AS 'الاسم',
        P.age AS 'العمر',
        P.gender AS 'الجنس',
        P.address AS 'العنوان',
        P.phone AS 'رقم الهاتف',
        U.name AS 'مدخل البيانات',
        P.note AS 'ملاحظات',
        P.dateAdd AS 'تاريخ الإضافة'
    FROM 
        Patients_TB P
    INNER JOIN 
        Users_TB U ON U.id = P.idUser
		order by P.id desc
END
GO
/****** Object:  StoredProcedure [dbo].[getDataPatientsByUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDataPatientsByUser]
    @idUser INT
AS
BEGIN
    SELECT
        P.id AS 'المعرف',
        P.name AS 'الاسم',
        P.age AS 'العمر',
        P.gender AS 'الجنس',
        P.address AS 'العنوان',
        P.phone AS 'رقم الهاتف',
        U.name AS 'مدخل البيانات',
        P.note AS 'ملاحظات',
        P.dateAdd AS 'تاريخ الإضافة'
    FROM 
        Patients_TB P
    INNER JOIN 
        Users_TB U ON U.id = P.idUser
    WHERE 
        P.idUser = @idUser
	order by P.id desc
END
GO
/****** Object:  StoredProcedure [dbo].[getDataPatientsToVisits]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[getDataPatientsToVisits]
AS
BEGIN
    SELECT
        P.id AS 'المعرف',
        P.name AS 'الاسم'
    FROM 
        Patients_TB P
END
GO
/****** Object:  StoredProcedure [dbo].[getDataPatientTestsByVisit]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[getDataPatientTestsByVisit]
@idVisit int
as
begin
SELECT 
  PVT.id AS 'المعرف',
  --PV.id AS 'رقم الزيارة',
  -- P.name AS 'اسم المريض',
  T.name AS 'اسم التحليل',
  CASE 
    WHEN PVT.test_val < T.rangeBegin THEN '0' 
    WHEN PVT.test_val > T.rangeEnd THEN '0'   
    ELSE '1'                                  
  END AS 'ضمن النظاق',
  
  round (PVT.test_val,2) AS 'القيمة',
  CONCAT(ROUND(T.rangeBegin, 2), ' ~ ', ROUND(T.rangeEnd, 2)) AS 'المــجــال',
  PVT.test_diagnosis AS 'النتيجة',
  U.name AS 'اسم المخبري',
  PVT.dateAdd AS 'تاريخ الاضافة'
FROM Patient_Visit_Tests_TB PVT
INNER JOIN Patient_Visits_TB PV
  ON PV.id = PVT.patient_visit_id
INNER JOIN Patients_TB P
  ON P.id = PV.patient_id
INNER JOIN Tests_TB T
  ON T.id = PVT.test_id
INNER JOIN Users_TB U
  ON U.id = PVT.user_id

  where PVT.patient_visit_id=@idVisit
      order by PVT.id desc
end
GO
/****** Object:  StoredProcedure [dbo].[getDataTest]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataTest]
as
begin
select 
T.id'المعرف',
T.idParent'رقم الأب',
P.name 'اسم الاب',
T.name'الاسم',
T.isCategory'هل هو صنف',
round(T.rangeBegin,2)'بداية المجال',
round(T.rangeEnd,2)'نهاية المجال',
T.diagnosisValueLessThanBegin'الشتخيص أصغر',
T.diagnosisValueBetweenRange'التشخيص طبيعي',
T.diagnosisValueBiggerThanEnd'التشخيص أكبر',
U.name 'اسم المخبري',
--T.diagnosisValueLessThanBegin'التشــخــيــص للــقـــيــــم ”أصغر مـن البـدايـة“',
--T.diagnosisValueBetweenRange'التشـخـيـص للــقـيـم ”ضمن المجال (الطبيعية)“',
--T.diagnosisValueBiggerThanEnd'التشــخــيــص للــقـــيــــم ”أكـبـر مـن النهاية“',
T.note'ملاحظات',
T.dateAdd'تاريخ الاضافة'


from Tests_TB  T
left outer join Tests_TB P
on T.idParent=P.id
inner join Users_TB U
on T.idUser=U.id
end
GO
/****** Object:  StoredProcedure [dbo].[getDataTestToVisit]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataTestToVisit]
as
begin
select 
T.id'المعرف',
T.name'الاسم',
round(T.rangeBegin,2)'بداية المجال',
round(T.rangeEnd,2)'نهاية المجال',
T.diagnosisValueLessThanBegin'الشتخيص أصغر',
T.diagnosisValueBetweenRange'التشخيص طبيعي',
T.diagnosisValueBiggerThanEnd'التشخيص أكبر'
from Tests_TB  T
where T.isCategory=0
end
GO
/****** Object:  StoredProcedure [dbo].[getDataTypeUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataTypeUser]
@userName nvarchar(50)
as
begin
select typeUser from Users_TB
where userName=@userName
end
GO
/****** Object:  StoredProcedure [dbo].[getDataUsers]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataUsers]
as
BEGIN
    SELECT   U.id AS 'المعرف',
             U.Name AS 'الاسم',
			 U.age 'العمر',
			 U.phone 'رقم الهاتف',
             U.Address AS 'العنوان',
			 userName as 'اسم الحساب',
			 Password as 'كلمة السر',
			 typeUser as 'نوع الحساب',
			 U.dateAdd as 'تاريخ الإضافة'
    FROM     Users_TB U
    ORDER BY U.id DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsersAdmins]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataUsersAdmins]
as
BEGIN
    SELECT   U.id AS 'المعرف',
             U.Name AS 'الاسم',
			 U.age 'العمر',
			 U.phone 'رقم الهاتف',
             U.Address AS 'العنوان',
			 userName as 'اسم الحساب',
			 Password as 'كلمة السر',
			 typeUser as 'نوع الحساب',
			 U.dateAdd as 'تاريخ الإضافة'
    FROM     Users_TB U
	where U.typeUser='مسؤول'
    ORDER BY U.id DESC;
END
GO
/****** Object:  StoredProcedure [dbo].[getDataUsersDataEntryists]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDataUsersDataEntryists]
as
BEGIN
    SELECT   U.id AS 'المعرف',
             U.Name AS 'الاسم',
			 U.age 'العمر',
			 U.phone 'رقم الهاتف',
             U.Address AS 'العنوان',
			 userName as 'اسم الحساب',
			 Password as 'كلمة السر',
			 typeUser as 'نوع الحساب',
			 U.dateAdd as 'تاريخ الإضافة'
    FROM     Users_TB U
	where U.typeUser='مدخل بيانات'
    ORDER BY U.id DESC;
END


GO
/****** Object:  StoredProcedure [dbo].[getDataUsersLaboratory]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataUsersLaboratory]
as
BEGIN
    SELECT   U.id AS 'المعرف',
             U.Name AS 'الاسم',
			 U.age 'العمر',
			 U.phone 'رقم الهاتف',
             U.Address AS 'العنوان',
			 userName as 'اسم الحساب',
			 Password as 'كلمة السر',
			 typeUser as 'نوع الحساب',
			 U.dateAdd as 'تاريخ الإضافة'
    FROM     Users_TB U
	where U.typeUser='مخبري'
    ORDER BY U.id DESC;
END

GO
/****** Object:  StoredProcedure [dbo].[getDataVisitByUser]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataVisitByUser]
@idUser int
as
begin
select 
PV.id 'المعرف',
PV.patient_id 'معرف المريض',
PV.user_id 'معرف المستخدم',
P.name'اسم المريض',
P.age 'عمر المريض',
P.gender 'جنس المريض',
U.name'اسم المخبري',
PV.tests_number 'عدد التحاليل',
PV.note 'ملاحظات',
PV.dateAdd 'تاريخ الاضافة'
from Patient_Visits_TB PV
inner join Patients_TB P
on P.id=PV.patient_id
inner join Users_TB U
on U.id=PV.user_id
where  PV.user_id=@idUser
order by PV.id desc
end
GO
/****** Object:  StoredProcedure [dbo].[getDataVisits]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[getDataVisits]
as
begin
select 
PV.id 'المعرف',
PV.patient_id 'معرف المريض',
PV.user_id 'معرف المستخدم',
P.name'اسم المريض',
P.age 'عمر المريض',
P.gender 'جنس المريض',
U.name'اسم المخبري',
PV.tests_number 'عدد التحاليل',
PV.note 'ملاحظات',
PV.dateAdd 'تاريخ الاضافة'
from Patient_Visits_TB PV
inner join Patients_TB P
on P.id=PV.patient_id
inner join Users_TB U
on U.id=PV.user_id
order by PV.id desc
end
GO
/****** Object:  StoredProcedure [dbo].[insertPatients]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[insertPatients]
    @idUser INT,
    @name NVARCHAR(50),
    @age NVARCHAR(10),
    @gender NVARCHAR(5),
    @address NVARCHAR(200),
    @phone NVARCHAR(30),
    @note NVARCHAR(200),
    @dateAdd DATE
AS
BEGIN
    INSERT INTO Patients_TB (idUser, name, age, gender, address, phone, note, dateAdd)
    VALUES (@idUser, @name, @age, @gender, @address, @phone, @note, @dateAdd);
END
GO
/****** Object:  StoredProcedure [dbo].[insertTest]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertTest]
@idParent int,
@idUser int,
@name nvarchar(50),
@isCategory bit,
@rangeBegin float,
@rangeEnd float,
@diagnosisValueLessThanBegin text,
@diagnosisValueBetweenRange text,
@diagnosisValueBiggerThanEnd text,
@note text,
@dateAdd date
as
begin
insert into Tests_TB
				(idParent,idUser,name,isCategory,rangeBegin,rangeEnd,diagnosisValueLessThanBegin
				,diagnosisValueBetweenRange,diagnosisValueBiggerThanEnd,note,dateAdd)
	values		
				(@idParent,@idUser,@name,@isCategory,@rangeBegin,@rangeEnd,@diagnosisValueLessThanBegin
				,@diagnosisValueBetweenRange,@diagnosisValueBiggerThanEnd,@note,@dateAdd)
end
GO
/****** Object:  StoredProcedure [dbo].[insertTestToVisit]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertTestToVisit]
@patient_visit_id int,
@test_id int,
@user_id int,
@test_val float,
@test_diagnosis text,
@dateAdd date
as
begin
insert into Patient_Visit_Tests_TB 
			(patient_visit_id,test_id,user_id,test_val ,test_diagnosis,dateAdd)
	values  (@patient_visit_id,@test_id,@user_id,@test_val ,@test_diagnosis,@dateAdd)
end
GO
/****** Object:  StoredProcedure [dbo].[insertUsers]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertUsers]
@name NVARCHAR (40),
@age nchar(10) ,
@phone NVARCHAR (40) ,
@address NVARCHAR (150) ,
@userName NVARCHAR (40),
@password NVARCHAR (40),
@typeUser NVARCHAR (40),
@dateAdd date
AS
BEGIN
    INSERT  INTO Users_TB(name,age, phone, Address,userName,Password,typeUser,dateAdd)
    VALUES       (@name,@age, @phone, @address,@userName,@password,@typeUser,@dateAdd);
END
GO
/****** Object:  StoredProcedure [dbo].[insertVisit]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertVisit]
@user_id int,
@patient_id int,
@tests_number int,
@note text,
@dateAdd date
as

begin
insert into Patient_Visits_TB
					(user_id,patient_id,tests_number,note,dateAdd)
values				(@user_id,@patient_id,@tests_number,@note,@dateAdd)
end
GO
/****** Object:  StoredProcedure [dbo].[searchDataUsers]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[searchDataUsers]
  @textSearch NVARCHAR(200),
  @typeSearch NVARCHAR(30)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        U.id AS 'المعرف',
        U.Name AS 'الاسم',
        U.age AS 'العمر',
        U.phone AS 'رقم الهاتف',
        U.Address AS 'العنوان',
        U.userName AS 'اسم الحساب',
        U.Password AS 'كلمة السر',
        U.typeUser AS 'نوع الحساب',
        U.dateAdd AS 'تاريخ الإضافة'
    FROM
        Users_TB U
    WHERE
        (@typeSearch = 'all' OR U.typeUser = @typeSearch)
        AND (
            U.id LIKE '%' + @textSearch + '%'
            OR U.Name LIKE '%' + @textSearch + '%'
            OR U.age LIKE '%' + @textSearch + '%'
            OR U.phone LIKE '%' + @textSearch + '%'
            OR U.Address LIKE '%' + @textSearch + '%'
            OR U.userName LIKE '%' + @textSearch + '%'
            OR U.Password LIKE '%' + @textSearch + '%'
            OR U.typeUser LIKE '%' + @textSearch + '%'
            OR CONVERT(NVARCHAR, U.dateAdd, 103) LIKE '%' + @textSearch + '%'
        );
END
GO
/****** Object:  StoredProcedure [dbo].[updatePatients]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updatePatients]
    @id INT,
    @name NVARCHAR(50),
    @age NVARCHAR(10),
    @phone NVARCHAR(30),
    @gender NVARCHAR(5),
    @address NVARCHAR(200),
    @note NVARCHAR(200)
AS
BEGIN
    UPDATE Patients_TB
    SET 
        name = @name,
        age = @age,
        phone = @phone,
        gender = @gender,
        address = @address,
        note = @note
    WHERE id = @id;
END
GO
/****** Object:  StoredProcedure [dbo].[updateTest]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[updateTest]
@id int,
@nameTest nvarchar(50),
@note text
as
begin
update Tests_TB 
set
name=@nameTest,
note=@note
where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[updateUsers]    Script Date: 10/10/2024 9:24:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[updateUsers]
    @id INT,
    @name NVARCHAR(40),
    @age NVARCHAR(10),
    @phone NVARCHAR(40),
    @address NVARCHAR(200),
    @userName NVARCHAR(40),
    @password NVARCHAR(40),
    @typeUser NVARCHAR(40)
AS
BEGIN
    BEGIN TRY
        UPDATE Users_TB 
        SET 
            name = @name,
            age = @age,
            phone = @phone,
            address = @address,
            userName = @userName,
            password = @password,
            typeUser = @typeUser
        WHERE id = @id;
    END TRY
    BEGIN CATCH
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END
GO
USE [master]
GO
ALTER DATABASE [Medical_Analysis_Laboratory] SET  READ_WRITE 
GO
