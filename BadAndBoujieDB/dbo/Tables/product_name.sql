create table product_name
	(P_ID varchar(10) not null,
	P_name	varchar(30) not null
	primary key (P_ID)
	);
GO
alter table product_name
add foreign key (P_ID) references product