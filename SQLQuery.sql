create database Day8Assignment
use Day8Assignment

create table Products
(PId nvarchar(50) primary key,
PName nvarchar(50) not null,
PPrice int not null,
mfgDate date not null,
expDate date not null)

insert into Products values('P00001','Shampoo',560,'12/08/2022','12/08/2023')
insert into Products values('P00002','Perfume',4500,'12/09/2014','12/08/2016')
insert into Products values('P00003','Powder',350,'01/08/2022','01/08/2023')
insert into Products values('P00004','Lipstic',850,'12/12/2022','12/12/2023')
insert into Products values('P00005','Shampoo',450,'12/10/2022','12/10/2023')
insert into Products values('P00006','Conditioner',865,'12/08/2022','12/08/2023')
insert into Products values('P00007','Moisturizer',250,'12/08/2022','12/08/2023')
insert into Products values('P00008','Sunscreen',1250,'12/08/2022','12/08/2023')
insert into Products values('P00009','Detergent',665,'12/08/2022','12/08/2023')
insert into Products values('P00010','face cream',785,'12/08/2022','12/08/2023')

select * from Products

select * from Products Order by PName Asc

