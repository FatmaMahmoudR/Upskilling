
-----1
create proc countStudents
as
select d.dept_name, count(s.st_id) 
from department d join student s on d.dept_id = s.dept_id
group by d.dept_name

-----2
create proc checkemployees
as
begin
	declare @cnt int,@result nvarchar(100)

	select @cnt = count(e.ssn)
	from employee e join works_for wf on e.ssn = wf.essn
	join project p on wf.pno = p.pnumber
	where wf.pno = 100

	if @cnt >= 3
		select @result = 'the number of employees in the project p1 is 3 or more'
	else if @cnt < 3
		select @result = 'the following employees work for the project p1'

	select e.fname,e.lname,@result
	from employee e join works_for wf on e.ssn = wf.essn
	join project p on wf.pno = p.pnumber
	where wf.pno = 100
end



-----3
alter proc updateEmp 
@old int,@new int,@pnum int
as
begin try 
	update employee 
	set ssn = @new
	where ssn = @old

	update works_for
	set essn = @new
	where essn = @old and pno = @pnum
end try
begin catch
	select 'Not Allowed there are relationship' 
end catch

--exec updateEmp 112233,512463,100

-----4
alter table project
add budget float

update project
set budget = 170000
where pnumber = 100

update project
set budget = 150000
where pnumber = 200

create table audit (
    projectno int,
    username nvarchar(50),
    modifieddate datetime,
    budget_old float,
    budget_new float
)

create trigger t1
on project
after update
as
begin
    declare @projectno int, @username nvarchar(50), @modifieddate datetime, @budget_old float, @budget_new float

    select @username = system_user, @modifieddate = getdate();

    if update(budget)
    begin
        select @projectno = inserted.pnumber, @budget_old = deleted.budget, @budget_new = inserted.budget
        from inserted join deleted on inserted.pnumber = deleted.pnumber;

        insert into audit (projectno, username, modifieddate, budget_old, budget_new)
        values (@projectno, @username, @modifieddate, @budget_old, @budget_new);
    end
end


update project
set budget = 200000
where pnumber = 100;

select * from audit




-----5
alter trigger t2
on departments
instead of insert
as
begin
    select 'can’t insert a new record in that table'
    
end


insert into departments (dname, dnum)
values ('aa', 55)

select * from departments




----6
alter trigger t3
on employee
after insert
as
begin
    declare @month nvarchar(50);
    select @month = datename(month, getdate());
    if @month = 'March'--'April'  
    begin
        select 'can’t insert in this month';
			delete from Employee where SSN =(select SSN from inserted)
    end
end

insert into employee (fname, lname, ssn) values ('Fatma','Mahmoud', 555977)
	


-----7
create table studAudit
(
    server_username nvarchar(50),
    [date] date,
    note nvarchar(100)
)

create trigger t4
on student
after insert
as
begin
    declare @key_value nvarchar(10) = convert(nvarchar(10), (select st_id from inserted));

    insert into studAudit (server_username, date, note)
	--where note will be “[username] Insert New Row with Key=[Key Value] in table [table name]”
    values ( suser_sname(), getdate(), '[' + suser_sname() + '] Insert New Row with Key=[' + @key_value + '] in table [dbo.student]');
end


insert into student (st_id,st_fname, st_lname) values (11111,'Fatma','Mahmoud')

select * from studAudit





-----8
create trigger t5
on student
instead of delete
as
begin
    declare @key_value nvarchar(10) = convert(nvarchar(10), (select st_id from deleted));

    insert into studAudit (server_username, date, note)
    values (suser_sname(), getdate(), 'try to delete Row with Key=[' + @key_value + ']');
end

delete from student where st_id = 11111
select * from studAudit

