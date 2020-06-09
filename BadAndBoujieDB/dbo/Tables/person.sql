/*	Table creation
	Note that the tables have to be created in exactly this order*/

	create table person
	(Per_ID		varchar(10) not null,
	Per_firstname	varchar(30),
	Per_lastname		varchar(30),
	Per_phone	varchar(11),
	Per_addr varchar (50),
	Per_usrn 	varchar(20) not null,
	Per_PW	varchar(30) not null,
	Per_type		varchar(10) not null,
	primary key (Per_ID)
	);