create table staff
	(stf_ID		varchar(10) not null,
	Per_ID		varchar(10) not null,
	primary key (stf_ID)
	);
GO
/*add constraints after the tables have been populated */

alter table staff
add foreign key (Per_ID) references person;