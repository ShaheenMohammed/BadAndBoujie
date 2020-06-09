create table customer	
	(C_ID		varchar(10) not null,
	Per_ID		varchar(10) not null,
	primary key (C_ID)
	);
GO
alter table customer
add foreign key (Per_ID) references person;