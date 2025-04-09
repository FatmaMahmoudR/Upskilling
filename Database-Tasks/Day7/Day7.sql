--1
create view vstudent_course 
as
	select s.st_fname + ' ' + s.st_lname as fullname, c.crs_name
	from student s join  stud_course sc 
	on s.st_id = sc.st_id
	join course c on sc.crs_id = c.crs_id
	where sc.grade > 50;

select * from vstudent_course


--2
create view vmanager_topic
with 
encryption
as
	select distinct i.Ins_Name, t.Top_Name
	from department d
	join instructor i on d.Dept_Manager = i.Ins_Id
	join ins_course ic on i.ins_id = ic.ins_id
	join course c on ic.crs_id = c.crs_id
	join topic t on c.top_id = t.top_id ;

select * from vmanager_topic


--3
create view instructor_dept
as
	select distinct i.Ins_Name,d.Dept_Name
	from Department d join Instructor i on d.Dept_Id = i.Dept_Id
	where d.Dept_Name in ('SD','Java')



select * from instructor_dept


--4
create view V1
as
	select * from Student s where s.St_Address in ('Alex', 'Cairo')
	with check option 


	
select * from V1

Update V1 set st_address='tanta'
Where st_address='alex';


--5
create clustered index Imanager_hiredate
on department(manager_hiredate)
--Error because there is a clustered index on this table because of the PK and we can not create multiple clusterd index on a table


--6
create unique index iStudent_age on student(st_age);
-- Error because there are dublicates key 


--7

declare c1 cursor
for 
select d.dept_name, i.ins_name
from department d join instructor i on d.dept_manager = i.ins_id

declare @dept varchar(20), @manager varchar(20)

open c1
fetch c1 into @dept, @manager

while @@fetch_status = 0
begin
    print 'dept: ' + @dept + ', manager: ' + @manager
    fetch c1 into @dept, @manager
end

close c1
deallocate c1



--8
declare c1 cursor
for select distinct ins_name from instructor where ins_name is not null

declare @name varchar(20), @all_names varchar(1000) = ''
open c1
fetch c1 into @name

while @@fetch_status = 0
begin
    set @all_names = concat(@all_names, ',', @name)
    fetch c1 into @name
end

select @all_names

close c1
deallocate c1



--9
--vmanagertopic view is encrypted



USE Company_SD


--10
create view vProject_Emp 
as
	select  p.pname as projectname, count(w.essn) as employeecount
	from Project p left join Works_for w ON p.Pnumber = w.Pno
	group by p.Pname;

select * from vProject_Emp


--11

create schema Company


exec sp_rename 'dbo.Departments', 'Departments', 'OBJECT';
alter schema Company transfer dbo.Departments;



create schema HumanResource

exec sp_rename 'dbo.Employee', 'Employee', 'OBJECT';
alter schema HumanResource transfer dbo.Employee;


--12

declare c2 cursor for 
select ssn, salary from HumanResource.employee

declare @ssn int, @salary int

open c2;
fetch next from c2 into @ssn, @salary

while @@fetch_status = 0
begin
    if @salary < 3000
        update HumanResource.employee set salary = salary * 1.1 where ssn = @ssn
    else
        update HumanResource.employee set salary = salary * 1.2 where ssn = @ssn

    fetch next from c2 into @ssn, @salary
end

close c2
deallocate c2;
