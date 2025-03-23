--1
Create function ExtractMonth (@date DATE)
returns nvarchar(50)
as
begin
	return DATENAME(MONTH,@date)
end

select dbo.ExtractMonth(GETDATE())



--2
create function allvalues (@start int, @end int)
returns @t table (numbers int)
as
begin
	while @start < @end-1
	begin
		set @start += 1
		insert into @t (numbers) select @start
	end
	return
end

select * from dbo.allvalues(1, 10)


--3
create function DeptandStudName (@studentID int)
returns table
as
return
(
	select d.Dept_Name,s.St_Fname + ' ' + s.St_Lname as 'Student Name'
	from Department d join Student s on d.Dept_Id = s.Dept_Id
	where s.St_Id = @studentID
)

select * from dbo.DeptandStudName(10)

--4
create function nameChecker (@studentID int)
returns nvarchar(max)
as
begin
	declare @Fname nvarchar(50)
	declare @Lname nvarchar(50)
	declare @msg nvarchar(500)

	select @Fname = s.St_Fname,@Lname = s.St_Lname from Student s where s.St_Id = @studentID

	set @msg =
	case
		when @Fname is null and @Lname is null then 'First name & last name are null'
		when @Fname is null and @Lname is not null then 'first name is null'
		when @Fname is not null and @Lname is null then 'last name is null'
		when @Fname is not null and @Lname is not null then 'First name & last name are not null'
	end
	return @msg
end

select dbo.nameChecker(14) 



--5
create function getDataByManagerId (@id int)
Returns table
as
return (
    select d.Dept_Name, Dept_Manager, d.Manager_hiredate
    from Department d join Instructor i on i.Ins_Id = d.Dept_Manager
    where Dept_Manager = @id
);

select * from getDataByManagerId(1);




--6
create function nameType (@name nvarchar(50))
returns @t table (studentName nvarchar(50))
as
begin
	if @name = 'first name'
		begin
			insert into @t select isnull(s.St_Fname, 'Empty') from Student s
		end
	else if @name = 'last name'
		begin
			insert into @t select isnull(s.St_Lname, 'Empty') from Student s
		end
	else if @name = 'full name'
 		begin
			insert into @t select isnull(s.St_Fname + ' ' + s.St_Lname, 'Empty') from Student s
		end
	return
end

select * from dbo.nameType('first name')



--7
select s.St_Id, substring(s.St_Fname,1, len(s.St_Fname)-1)
from Student s



--8
delete from Stud_Course
where St_Id in (
    select s.St_Id from Student s
     where Dept_Id = (select d.Dept_Id from Department d where d.Dept_Name = 'SD')
);


--9
create table dailyTransactions (
    user_id int primary key,
    transaction_amount int
);

create table lastTransactions (
    user_id int primary key,
    transaction_amount int
);

merge into lastTransactions as target
using dailyTransactions as source
on target.user_id = source.user_id
when matched then
    update set target.transaction_amount = target.transaction_amount + source.transaction_amount
when not matched then
    insert (user_id, transaction_amount)
    values (source.user_id, source.transaction_amount);
