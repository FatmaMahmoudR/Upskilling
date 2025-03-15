--1
select dep.Dependent_name
from Employee e, Dependent dep
where e.SSN = dep.ESSN and dep.Sex='F' and e.Sex ='F'
union
select dep.Dependent_name
from Employee e, Dependent dep
where e.SSN = dep.ESSN and dep.Sex='M' and e.Sex ='M'

--2
select p.Pname, sum(w.Hours)
from Project p inner join Works_for w
on p.Pnumber = w.Pno
group by p.Pname

--3 
select d.* 
from Departments d join Employee e
on e.Dno = d.Dnum
where e.SSN = (select min(e.ssn)
from Employee e) 

--4
select d.Dname, min(e.salary), max(e.salary), avg(e.salary)
from Employee e join Departments d
on e.Dno = d.Dnum
group by e.Dno, d.Dname

--5
select distinct(b.Fname+' '+b.Lname) as 'full name'
from Employee a join Employee b
ON b.SSN = a.SuperSSN 
where b.SSN not in ( select dep.ESSN from Dependent dep)

--6.
select Dnum,Dname,count(ssn)
from departments join Employee on dnum = dno
group by Dnum,Dname
having avg(salary)< (select avg(salary) from employee)

--7
select e.Fname +' '+e.Lname as 'full name', p.Pname
from Employee e join Works_for w on e.ssn = w.ESSn
join Project p on w.pno=p.Pnumber
order by e.dno, e.Fname,e.Lname

--8
select max(salary) from Employee
union
select max(salary) from Employee newe
where newe.salary in 
(
select salary from Employee
except 
select max(salary) from employee
)


--9
select Fname+' '+Lname as fullname
from Employee
intersect
select Dependent_name
from Dependent

--10
select e.Fname+' '+e.Lname as fullname,e.ssn
from Employee e
where exists(
SELECT * FROM Dependent d WHERE d.ESSN = e.SSN
)

--11
insert into Departments values ('DEPT IT',100,112233,'1-11-2006')

--12
begin try 
begin transaction 
update Departments set MGRSSN = 968574 where Dnum =100
update Departments set MGRSSN = 102672 where Dnum =20
update Employee set Superssn = 102672 where ssn =102660
commit transaction 
end try
begin catch 
rollback
end catch

--13
delete from Dependent where essn = 223344
update Departments set MGRSSN = null where MGRSSN = 223344
update Employee set Superssn= null where Superssn = 223344
delete from Works_for where essn=223344
delete from Employee where ssn=223344

--14
update Employee set Salary += (Salary*0.3)
where ssn in(
select e.ssn 
from Employee e, Works_for w, Project p
where e.ssn = w.essn and w.Pno =p.Pnumber and p.Pname = 'Al Rabwah'
)
