use master
create database HR
go

use HR
go

use master
drop database HR
go


create table Employee_MSSV(
	IdEmployee varchar(50),
	Name nvarchar(50),
	DateBirth date,
	Gender bit,
	PlaceBirth nvarchar(50),
	IdDepartment nvarchar(50)
)
go
create table Department_MSSV (
	IdDepartment varchar(50),
	Name nvarchar(50)
)
go

insert into Department_MSSV values('IT', N'Công Nghệ Thông Tin')
insert into Department_MSSV values('KT', N'Kế toán')
insert into Department_MSSV values('KSNB', N'Kiểm soát nội bộ')

go

insert into Employee_MSSV values('53418', N'Trần Tiến ', '11/10/2001', 1, N'Hà Nội', 'IT')
insert into Employee_MSSV values('53416', N'Nguyễn Cường', '07/21/1996', 0, N'Đắk Lắk', 'KT')
insert into Employee_MSSV values('53417', N'Nguyễn Hào ', '12/25/1996', 1, N'TP.Hồ Chí Minh', 'KSNB')



go

go
create proc spReadEmployee_MSSV
as
begin
select * from Employee_MSSV
end

go

create proc spInsertEmployee_MSSV
@IdEmployee nvarchar(50),
@Name nvarchar(50),
@DateBirth date,
@Gender bit,
@PlaceBirth nvarchar(50),
@IdDepartment nvarchar(50)
as
begin
    insert Employee_MSSV(IdEmployee, Name, DateBirth, Gender, PlaceBirth, IdDepartment) values(@IdEmployee, @Name, @DateBirth, @Gender, @PlaceBirth, @IdDepartment)
end

go

create proc spUpdateEmployee_MSSV
@IdEmployee nvarchar(50),
@Name nvarchar(50),
@DateBirth date,
@Gender bit,
@PlaceBirth nvarchar(50),
@IdDepartment nvarchar(50)
as
begin
    update Employee_MSSV
    set
        Name = @Name,
        DateBirth =@DateBirth,
        Gender =@Gender,
		PlaceBirth=@PlaceBirth,
		IdDepartment=@IdDepartment
    where IdEmployee = @IdEmployee
end

go

create proc spDeleteEmployee_MSSV
@IdEmployee nvarchar(50)
as
begin
    delete Employee_MSSV where IdEmployee = @IdEmployee
end

go

