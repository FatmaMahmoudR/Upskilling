--1
select count(st_age)
from Student

--2
select distinct(Ins_Name)
from Instructor

--3
select s.St_Id as 'Student ID',ISNULL(s.St_Fname, '') + ' ' + ISNULL(s.St_Lname, '')  as 'Student Full Name',
ISNULL(d.Dept_Name, 'No Record') as 'Department Name'
from Student s,Department d where s.Dept_Id = d.Dept_Id

--4
select i.Ins_Name,d.Dept_Name
from Instructor i left join Department d on i.Dept_Id = d.Dept_Id

--5
select s.St_Fname+' '+s.St_Lname as 'Student FullName', c.Crs_Name
from Student s join Stud_Course sc on s.St_Id = sc.St_Id
join Course c on sc.Crs_Id = c.Crs_Id
where sc.Grade is not null

--6
select count (c.Crs_Id),t.Top_Name
from Course c, Topic t where c.Top_Id = t.Top_Id
group by t.Top_Name

--7 
select MIN(salary),MAX(salary)
from Instructor 

--8
select * from Instructor where Salary<(
select AVG(salary) from Instructor)

--9
select d.Dept_Name
from Department d, Instructor i where d.Dept_Id = i.Dept_Id 
and i.Salary = (select MIN(salary) from Instructor)

--10
select top(2) salary
from Instructor 
order by Salary desc

--11
select i.Ins_Name, Coalesce(CAST(salary as nvarchar),'instructor bonus')
from Instructor i

--12
select AVG(salary) from Instructor

--13 
select y.St_Fname, x.*
from student x, Student y
where y.St_super = x.St_Id

--14
select *
from (select * , Row_number() over(Partition by dept_id order by salary desc) as RN
      from Instructor where salary is not null
) as newtable
where RN<=2 


--15
select *
from (select * , Row_number() over(Partition by dept_id order by newid() desc) as RN
      from Student
) as newtable
where RN=1 

