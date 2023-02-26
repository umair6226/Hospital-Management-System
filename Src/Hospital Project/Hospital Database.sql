create database Hospital
use Hospital

CREATE TABLE tbl_Users(
	UserID int primary key IDENTITY(1,1)  ,
	First_Name nvarchar(max) ,
	Last_Name nvarchar(max) ,
	Contact nvarchar(max) ,
	Email nvarchar(max) ,
	UserName nvarchar(max),
	Password nvarchar(max),
	Gender nvarchar(max),
	Acount_Type nvarchar(max),
	Acount_Status nvarchar(max) ,
	IsAdmin bit
	)

create table tbl_Patient(
PatientID int primary key identity(1,1),
Image image,
First_Name nvarchar(max),
Last_Name nvarchar(max),
CNIC nvarchar(max),
Chronic_Diseases nvarchar(max),
Blood_Group nvarchar(max),
Email nvarchar(max),
Age int,
Contact nvarchar(max),
Gender nvarchar(max),
Address nvarchar(max),
City nvarchar(max),
Country nvarchar(max),
More_Details nvarchar(max),
IsDeleted bit
) 

create table tbl_Doctor(
DoctorID int primary key identity(1,1),
Image image,
First_Name nvarchar(max),
Last_Name nvarchar(max),
CNIC nvarchar(max),
Qualification nvarchar(max),
Specialization nvarchar(max),
Contact nvarchar(max),
Email nvarchar(max),
Gender nvarchar(max),
Address nvarchar(max),
City nvarchar(max),
Country nvarchar(max),
IsDeleted bit
) 

create table tbl_Staff(
ID int primary key identity(1,1),
Image image,
Name nvarchar(max),
CNIC nvarchar(max),
Contact nvarchar(max),
Qualification nvarchar(max),
Email nvarchar(max),
Post nvarchar(max),
Gender nvarchar(max),
Address nvarchar(max),
Status nvarchar(max),
IsDeleted bit
)

create table tbl_Appointments(
AppointmentID int primary key identity(1,1),
PatientID int,
DoctorID int,
Patient_Name nvarchar(max),
Appointment_With nvarchar(max),
Gender nvarchar(max),
Date date,
Time_Schedule nvarchar(max),
Checkup_For nvarchar(max),
Status nvarchar(max)
)

create table tbl_Pharmacy(
ProductID int primary key identity(1,1),
Name nvarchar(max),
Category nvarchar(max),
Quantity int,
Price Money,
Avalaiblity nvarchar(max),
Expiry_Date date)

create table tbl_Precautions(
PrecautionID int primary key identity(1,1),
PatientID int,
Disease nvarchar(max),
Drug_Name nvarchar(max),
Dose nvarchar(max),
Duration nvarchar(max),
Advice nvarchar(max),
More_Advice nvarchar(max)
)

Create table tblPatientAddmission(
AdmissionID int primary key identity(1,1),
PatientID int,
Admit_In nvarchar(max),
First_Treatment nvarchar(max),
Admission_Date datetime,
Discharge_Date datetime
)

create table tbl_Bill(
BillingID int primary key identity,
Date datetime,
PatientID int,
[Patient Name] nvarchar(max),
[Addmission Date] datetime,
[Room Charges] money,
[Lab Test Charges] money,
[Doctor Fees] money,
[Treatment Charges] money,
[Medicine Charges] money,
[Other Charges] money,
[Total Amount] money
)

GO;

alter procedure SP_Users
@Type int,
@UserID int=null,
@FirstName nvarchar(max)=null ,
@LastName nvarchar(max)=null ,
@Contact nvarchar(max)=null ,
@Email nvarchar(max)=null ,
@UserName nvarchar(max)=null,
@Password nvarchar(max)=null,
@Gender nvarchar(max)=null,
@AcountType nvarchar(max)=null,
@AcountStatus nvarchar(max)=null ,
@IsAdmin bit=null
AS
BEGIN
if(@Type=1)
Begin
insert into tbl_Users values(@FirstName,@LastName,@Contact,@Email,@UserName,@Password,@Gender,@AcountType,@AcountStatus,@IsAdmin)
End
if(@Type=2)
Begin
update tbl_Users set First_Name=@FirstName,Last_Name=@LastName,Contact=@Contact,Email=@Email,UserName=@UserName,Password=@Password,
Gender=@Gender where UserID=@UserID
End
if(@Type=3)
Begin
Select*from tbl_Users
End
if(@Type=4)
begin
select*from tbl_Users where UserName=@UserName and Password=@Password
end
if(@Type=5)
begin
select*from tbl_Users where UserName=@UserName 
end
if(@Type=6)
begin
update tbl_Users set Password=@Password where UserID=@UserID and UserName=@UserName
end
END
go;

alter procedure SP_DashBoard
@Type int
AS
BEGIN
if(@Type=1)
Begin
select count(*) as Total_No from tbl_Patient where IsDeleted=0
End
if(@Type=2)
Begin
select count(*) as Total_No from tbl_Doctor where IsDeleted=0
End
if(@Type=3)
Begin
select count(*) as Total_No from tbl_Staff where IsDeleted=0
End
if(@Type=4)
Begin
select count(*) as Total_No from tblPatientAddmission where Discharge_Date is null
End
if(@Type=5)
Begin
select top 5 Image,First_Name+' '+Last_Name as Name,Address+','+City+','+Country as Address from tbl_Patient  where IsDeleted=0 order by PatientID desc
End
if(@Type=6)
Begin
select Date, count(AppointmentID) as Total_No from tbl_Appointments group by Date
End
END
go

ALTER procedure SP_Patient
@PatientID int=null  ,
@Image image=null ,
@FirstName nvarchar(max)=null ,
@LastName nvarchar(max)=null ,
@CNIC nvarchar(max)=null ,
@ChronicDiseases nvarchar(max)=null,
@BloodGroup nvarchar(max)=null ,
@Email nvarchar(max)=null ,
@Age int=null ,
@Contact nvarchar(max)=null ,
@Gender nvarchar(max)=null ,
@Address nvarchar(max)=null ,
@City nvarchar(max)=null ,
@Country nvarchar(max)=null ,
@MoreDetails nvarchar(max)=null,
@IsDeleted bit=null,
@Type int
AS
BEGIN
if(@Type=1)
Begin
insert into tbl_Patient values(@Image,@FirstName,@LastName,@CNIC,@ChronicDiseases,@BloodGroup,@Email,@Age,@Contact,@Gender,@Address,@City,@Country,@MoreDetails,@IsDeleted)
End
if(@Type=2)
Begin
update tbl_Patient set Image=@Image,First_Name=@FirstName,Last_Name=@LastName,CNIC=@CNIC,Chronic_Diseases=@ChronicDiseases,Blood_Group=@BloodGroup,
Email=@Email,Age=@Age,Contact=@Contact,Gender=@Gender,Address=@Address,City=@City,Country=@Country,More_Details=@MoreDetails where PatientID=@PatientID
End
if(@Type=3)
Begin
update tbl_Patient set IsDeleted=@IsDeleted where PatientID=@PatientID
End
if(@Type=4)
Begin
select PatientID,Image,First_Name+' '+Last_Name as Name,CNIC,Age,Contact,Gender from tbl_Patient where IsDeleted=0
End
if(@Type=5 )
Begin
select  PatientID,Image,First_Name+' '+Last_Name as Name,CNIC,Age,Contact,Gender from tbl_Patient where IsDeleted=0 and First_Name+' '+Last_Name like '%'+@FirstName+'%'
End
if(@Type=6)
Begin
select* from tbl_Patient where PatientID=@PatientID 
End
if(@Type=7)
Begin
select P.PatientID,First_Name+' '+Last_Name as [Patient Name],Age,Gender,Blood_Group,Admit_In,First_Treatment,Admission_Date,Discharge_Date from tbl_Patient P inner join tblPatientAddmission AD on P.PatientID=AD.PatientID
End
if(@Type=8)
Begin
select P.PatientID,First_Name+' '+Last_Name as [Patient Name],Age,Gender,Blood_Group,Admit_In,First_Treatment,Admission_Date,Discharge_Date from tbl_Patient P inner join tblPatientAddmission AD on P.PatientID=AD.PatientID where First_Name+' '+Last_Name like '%'+@FirstName+'%'
End
if(@Type=9)
Begin
select AP.PatientID,Patient_Name,Appointment_With as Doctor,Date as [Last Visited],Blood_Group,Age,P.Gender from tbl_Appointments AP inner join tbl_Patient P on AP.PatientID=P.PatientID   where Status!='Admitted' and Status!='Discharged' and Status='Completed'
End
if(@Type=10)
Begin
select AP.PatientID,Patient_Name,Appointment_With as Doctor,Date as [Last Visited],Blood_Group,Age,P.Gender from tbl_Appointments AP inner join tbl_Patient P on AP.PatientID=P.PatientID   where Status!='Admitted' and Status!='Discharged' and Status='Completed' and First_Name+' '+Last_Name like '%'+@FirstName+'%'
End
END
go

alter procedure SP_Doctor
@DoctorID int=null  ,
@Image image=null ,
@FirstName nvarchar(max)=null ,
@LastName nvarchar(max)=null ,
@CNIC nvarchar(max)=null ,
@Qualification nvarchar(max)=null ,
@Specialization nvarchar(max)=null ,
@Email nvarchar(max)=null ,
@Contact nvarchar(max)=null ,
@Gender nvarchar(max)=null ,
@Address nvarchar(max)=null ,
@City nvarchar(max)=null ,
@Country nvarchar(max)=null ,
@IsDeleted bit=null,
@DoctorFees money=null,
@Type int
AS
BEGIN
if(@Type=1)
Begin
insert into tbl_Doctor values(@Image,@FirstName,@LastName,@CNIC,@Qualification,@Specialization,@Contact,@Email,@Gender,@Address,@City,@Country,@IsDeleted,@DoctorFees)
End
if(@Type=2)
Begin
update tbl_Doctor set Image=@Image,First_Name=@FirstName,Last_Name=@LastName,CNIC=@CNIC,Qualification=@Qualification,Specialization=@Specialization,
Email=@Email,Contact=@Contact,Gender=@Gender,Address=@Address,City=@City,Country=@Country,Doctor_Fees=@DoctorFees where DoctorID=@DoctorID
End
if(@Type=3)
Begin
Update tbl_Doctor set IsDeleted=@IsDeleted where DoctorID=@DoctorID
End
if(@Type=4)
Begin
select * from tbl_Doctor where IsDeleted=0
End
if(@Type=5 )
Begin
select * from tbl_Doctor where IsDeleted=0 and First_Name+' '+Last_Name like '%'+@FirstName+'%'
End
END

GO

alter procedure SP_Staff
@StaffID int=null  ,
@Image image=null ,
@Name nvarchar(max)=null ,
@CNIC nvarchar(max)=null ,
@Qualification nvarchar(max)=null ,
@Email nvarchar(max)=null ,
@Post nvarchar(max)=null ,
@Contact nvarchar(max)=null ,
@Gender nvarchar(max)=null ,
@Address nvarchar(max)=null ,
@Status nvarchar(max)=null ,
@IsDeleted bit=null,
@Type int
AS
BEGIN
if(@Type=1)
Begin
insert into tbl_Staff values(@Image,@Name,@CNIC,@Contact,@Qualification,@Email,@Post,@Gender,@Address,@Status,@IsDeleted)
End
if(@Type=2)
Begin
update tbl_Staff set Image=@Image,Name=@Name,CNIC=@CNIC,Qualification=@Qualification,
Email=@Email,Contact=@Contact,Gender=@Gender,Address=@Address,Post=@Post,Status=@Status where ID=@StaffID
End
if(@Type=3)
Begin
Update tbl_Staff set IsDeleted=@IsDeleted where ID=@StaffID
End
if(@Type=4)
Begin
select * from tbl_Staff where IsDeleted=0
End
if(@Type=5 )
Begin
select * from tbl_Staff where IsDeleted=0 and Name like '%'+@Name+'%'
End
END

GO

alter proc SP_ForComboBox
@Type int
AS
BEGIN
if(@Type=1)
Begin
select PatientID, First_Name+' '+ Last_Name as Name from tbl_Patient where IsDeleted=0
End
if(@Type=2)
Begin
select DoctorID, First_Name+' '+ Last_Name +' ('+Specialization+')' as Name from tbl_Doctor where IsDeleted=0
End
if(@Type=3)
Begin
select *from tbl_Appointments where Status='Pending'
End
if(@Type=4)
Begin
select Name+' ('+Category+')' as Name,*from tbl_Pharmacy where Category='Tablet' or Category='Syrup' or Category='Capsule' or Category='Cream Tube' or Category='Injection' or Category='Pack'  and  Avalaiblity='Avalaible' 
End
END
GO;

alter proc SP_Appointments
@Type int,
@AppointmentsID int=null,
@PatientID int=null,
@DoctorID int=null,
@PatientName nvarchar(max)=null,
@DoctorName nvarchar(max)=null,
@Gender nvarchar(max)=null,
@Date date=null,
@Time nvarchar(max)=null,
@CheckupFor nvarchar(max)=null,
@Status nvarchar(max)=null
AS
BEGIN
if(@Type=1)
Begin
insert into tbl_Appointments values(@PatientID,@DoctorID,@PatientName,@DoctorName,@Gender,@Date,@Time,@CheckupFor,@Status)
End
if(@Type=2)
Begin
delete from tbl_Appointments where AppointmentID=@AppointmentsID
End
if(@Type=4)
Begin
Select*from tbl_Appointments where Status='Pending' or Status='Admitted' or Status='In Progress'
End
if(@Type=3)
Begin
Select*from tbl_Appointments where Patient_Name like '%'+@PatientName+'%' and Status!='Completed'-- Status='Pending' or Status='Admitted' or Status='In Progress'  
End
if(@Type=5)
Begin
Select*from tbl_Appointments where Patient_Name=@PatientName
End
if(@Type=6)
Begin
Select*from tbl_Appointments 
End
END
GO;

alter proc SP_Parmacy
@Type int,
@ProductID int=null,
@Name nvarchar(max)=null,
@Category nvarchar(max)=null,
@Quantity int=null,
@Price money=null,
@ExpiryDate date=null,
@Avalaiblity nvarchar(max)=null
AS
BEGIN
if(@Type=1)
Begin
insert into tbl_Pharmacy values(@Name,@Category,@Quantity,@Price,@Avalaiblity,@ExpiryDate)
End
if(@Type=2)
Begin
update tbl_Pharmacy set Name=@Name,Category=@Category,Quantity=@Quantity,Price=@Price,Avalaiblity=@Avalaiblity,Expiry_Date=@ExpiryDate where ProductID=@ProductID
End
if(@Type=4)
Begin
select*from tbl_Pharmacy where DATEDIFF(DAY,GETDATE(),Expiry_Date)>0
End
if(@Type=5)
Begin
select*from tbl_Pharmacy where Name like '%'+@Name+'%' and DATEDIFF(DAY,GETDATE(),Expiry_Date)>0
End
if(@Type=6)
Begin
select*from tbl_Pharmacy where Category like '%'+@Category+'%' and DATEDIFF(DAY,GETDATE(),Expiry_Date)>0
End
if(@Type=7)
Begin
select*from tbl_Pharmacy where DATEDIFF(DAY,GETDATE(),Expiry_Date)<=0
End
END
Go;

alter proc SP_Avalaibility
@Quantity int=null,
@Type int
As
BEGIN
if(@Type=1)
Begin
if(@Quantity=0)
Begin
update tbl_Pharmacy set Avalaiblity='Not Avalaible' where Quantity=0
End
if(@Quantity>0)
Begin
update tbl_Pharmacy set Avalaiblity='Avalaible' where Quantity>0
End
End

END

GO;

alter proc SP_Precautions
@Type int,
@PrecautionID int=null,
@PatientID int=null,
@Disease nvarchar(max)=null,
@DrugName nvarchar(max)=null,
@Dose nvarchar(max)=null,
@Duration nvarchar(max)=null,
@Advice nvarchar(max)=null,
@MoreAdvice nvarchar(max)=null
As
BEGIN
if(@Type=1)
Begin
insert into tbl_Precautions values(@PatientID,@Disease,@DrugName,@Dose,@Duration,@Advice,@MoreAdvice)
update tbl_Appointments set Status='In Progress' where PatientID=@PatientID
End
if(@Type=4)
Begin
select*from tbl_Precautions where PatientID=@PatientID
End
END 
GO;

alter proc SP_Admission
@Type int,
@AdmissionID int=null,
@PatientID int=null,
@DoctorID int=null,
@AdmitIn nvarchar(max)=null,
@FirstTreatment nvarchar(max)=null,
@AdmissionDate datetime=null,
@DischargeDate datetime=null
AS
BEGIN
if(@Type=1)
Begin
insert into tblPatientAddmission values(@PatientID,@AdmitIn,@FirstTreatment,@AdmissionDate,@DischargeDate,@DoctorID)
update tbl_Appointments set Status='Admitted' where PatientID=@PatientID
End
END
GO;

alter proc SP_Billing
@Type int,
@BillingID int=null,
@Date date=null,
@PatientID int=null,
@PatientName nvarchar(Max)=null,
@AdmissionDate datetime=null,
@RoomCharges money=null,
@LabCharges money=null,
@DoctorFees money=null,
@TreatmentCharges money=null,
@MedicineCharges money=null,
@OtherCharges money=null,
@TotalAmount money=null
AS
BEGIN
if(@Type=1)
Begin
Insert into tbl_Bill values(@Date,@PatientID,@PatientName,@AdmissionDate,@RoomCharges,@LabCharges,@DoctorFees,@TreatmentCharges,@MedicineCharges,@OtherCharges,@TotalAmount)
update tblPatientAddmission set Discharge_Date=@Date where PatientID=@PatientID
update tbl_Appointments set Status='Completed' where PatientID=@PatientID
End
if(@Type=2)
Begin
select A.PatientID,A.DoctorID,Patient_Name,Appointment_With,A.Gender,Doctor_Fees,P.Contact from tbl_Appointments A inner join tbl_Doctor D on A.DoctorID=D.DoctorID inner join tbl_Patient P on A.PatientID=P.PatientID where A.Status='In Progress' and A.PatientID=@PatientID 
End
if(@Type=3)
Begin
select AP.PatientID,AP.DoctorID,Patient_Name,Admission_Date,AP.Gender,Doctor_Fees,P.Contact from  tbl_Appointments AP inner join tblPatientAddmission AD on AP.PatientID=AD.PatientID inner join tbl_Patient P on AP.PatientID=P.PatientID
inner join tbl_Doctor D on AP.DoctorID=D.DoctorID where AP.Status='Admitted' and AP.PatientID=@PatientID 
End
END
GO;

select count(*) as Total_No from tbl_Appointments where Date=GETDATE()

select*from tbl_Appointments
select*from tblPatientAddmission
select*from tbl_Users

insert into tbl_Users values('Muhammad Umair','Gul','03481198600','umairgul6226@gmail.com','u1','a1','Male','Admin','Active',1)
