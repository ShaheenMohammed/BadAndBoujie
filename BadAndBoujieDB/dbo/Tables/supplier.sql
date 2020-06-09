create table supplier
	(S_ID varchar(10) not null,
	W_ID varchar(10) not null,
	S_name	varchar(30) not null,
	S_addr varchar(50) not null,
	S_phone	varchar(11) not null,  -- Note that we need to assume that these are all north-american phone numbers with 10 digits and 1 digit country code
	primary key (S_ID),
	);
GO
alter table supplier
add foreign key (W_ID) references warehouse;